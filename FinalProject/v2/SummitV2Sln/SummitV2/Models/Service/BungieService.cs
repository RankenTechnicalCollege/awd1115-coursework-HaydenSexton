namespace SummitV2.Models.Service
{
    public class BungieService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _http;

        public BungieService(IConfiguration config)
        {
            _config = config;
            _http = new HttpClient();
            _http.DefaultRequestHeaders.Add("X-API-Key", _config["Bungie:ApiKey"]);
        }

        public async Task<string> GetManifestAsync()
        {
            var res = await _http.GetAsync("https://www.bungie.net/Platform/Destiny2/Manifest/");
            return await res.Content.ReadAsStringAsync();
        }
    }
}
