using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitV2.Models;
using SummitV2.Models.Service;
using System.Text.Json;

namespace SummitV2.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _config;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly BungieService _bungie;

        public AuthController(
            IConfiguration config,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            BungieService bungie)
        {
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            _bungie = bungie;
        }

        public async Task<IActionResult> Test()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-API-Key", _config["Bungie:ApiKey"]);

            var res = await client.GetAsync("https://www.bungie.net/Platform/Destiny2/Manifest/");
            var json = await res.Content.ReadAsStringAsync();

            return Content(json, "application/json");
        }

        // sends to bungie login
        public IActionResult Login()
        {
            var clientId = _config["Bungie:ClientId"];
            var redirect = _config["Bungie:RedirectUri"];

            var url =
                $"https://www.bungie.net/en/OAuth/Authorize?client_id={clientId}&response_type=code&redirect_uri={redirect}";

            return Redirect(url);
        }

        // what to do when bungie redirects back to app
        [HttpGet]
        public async Task<IActionResult> Callback(string code)
        {

            var client = new HttpClient();
            var values = new Dictionary<string, string>
        {
            { "grant_type", "authorization_code" },
            { "code", code },
            { "client_id", _config["Bungie:ClientId"] },
            { "client_secret", _config["Bungie:ClientSecret"] },
            { "redirect_uri", _config["Bungie:RedirectUri"] }
        };

            var content = new FormUrlEncodedContent(values);
            var tokenResponse = await client.PostAsync("https://www.bungie.net/platform/app/oauth/token", content);
            var tokenJson = JsonDocument.Parse(await tokenResponse.Content.ReadAsStringAsync());

            if (!tokenJson.RootElement.TryGetProperty("access_token", out var accessTokenElement))
                return BadRequest("Failed to get access token from Bungie.");

            string accessToken = accessTokenElement.GetString();

            // gets bungo profile
            var profileClient = new HttpClient();
            profileClient.DefaultRequestHeaders.Add("X-API-Key", _config["Bungie:ApiKey"]);
            profileClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var profileResponse = await profileClient.GetAsync("https://www.bungie.net/Platform/User/GetMembershipsForCurrentUser/");
            var profileJson = JsonDocument.Parse(await profileResponse.Content.ReadAsStringAsync());

            var bungieNetUser = profileJson.RootElement
                .GetProperty("Response")
                .GetProperty("bungieNetUser");

            string bungieId = bungieNetUser.GetProperty("membershipId").GetString();
            string bungieDisplayName = bungieNetUser.GetProperty("displayName").GetString();

            // sees if they alrdy exist
            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.BungieId == bungieId);

            // create new user if not found in db
            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = bungieDisplayName,
                    Email = $"{bungieDisplayName}@email.com", // not gonna need nor want the email for this app so not gonna ask user to provide one
                    BungieId = bungieId
                };

                await _userManager.CreateAsync(user);
            }

            // sign in auto
            await _signInManager.SignInAsync(user, isPersistent: true);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
