using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitV2.Data;
using SummitV2.Models;
using SummitV2.Models.ViewModels;
using System.Security.Claims;

namespace SummitV2.Controllers
{
    public class ClanController : Controller
    {
        private Repository<Clan> clans;
        private ApplicationDbContext context;

        public ClanController(ApplicationDbContext context)
        {
            this.context = context;
            clans = new Repository<Clan>(context);
        }

        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            var query = context.Clans.AsQueryable();
            int pageSize = 9;

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c => c.Name.Contains(searchString));
            }

            var pagedClans = await PaginatedList<Clan>.CreateAsync(query, pageNumber ?? 1, pageSize);

            ViewData["searchString"] = searchString;

            return View(pagedClans);
        }


        public async Task<IActionResult> Details(string id)
        {
            var clan = await clans.GetByIdAsync(id,
                new QueryOptions<Clan>()
                {
                    Includes = "Events,ApplicationUser,UserClans.ApplicationUser"
                });

            if (clan == null)
                return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = await context.Users
                .Include(u => u.UserClans)
                 .FirstOrDefaultAsync(u => u.Id == userId);

            bool isMember = await context.UserClans
                .AnyAsync(uc => uc.ApplicationUser.Id == userId
                             && uc.ClanId == id.ToString());



            ViewBag.IsMember = isMember;
            ViewBag.IsClanMod = (currentUser?.UserClans ?? Enumerable.Empty<UserClan>())
                 .Any(uc => uc.ClanId == clan.ClanId && uc.Role == "ClanMod")
                     && currentUser?.joinedClanId == clan.ClanId;
            ViewBag.CanJoin = currentUser != null && string.IsNullOrEmpty(currentUser.joinedClanId);
            ViewBag.IsOwner = currentUser?.joinedClanId == clan.ClanId
                  && currentUser.UserClans.Any(uc => uc.ClanId == clan.ClanId && uc.Role == "ClanOwner");

            return View(clan);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description")] Clan clan)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var currentUser = await context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (currentUser == null)
                return Unauthorized();

            // cant make a clan if your in one
            if (!string.IsNullOrEmpty(currentUser.joinedClanId))
            {
                TempData["Error"] = "You are already a member of a clan and cannot create a new one.";
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                clan.ClanId = Guid.NewGuid().ToString();
                clan.CreatedByUserId = userId;
                clan.CreatedDate = DateTime.UtcNow;

                await clans.AddAsync(clan);

                // makes them clan owner
                var userClan = new UserClan
                {
                    ClanId = clan.ClanId,
                    UserId = userId,
                    Role = "ClanOwner",
                    JoinDate = DateTime.UtcNow
                };

                context.UserClans.Add(userClan);

                // joins user to the clan
                currentUser.joinedClanId = clan.ClanId;

                await context.SaveChangesAsync();

                TempData["Message"] = $"Clan '{clan.Name}' was created and you have joined it.";
                return RedirectToAction("Index");
            }

            return View(clan);
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            return View(await clans.GetByIdAsync(id,
                new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" }));
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var clan = await context.Clans
                .Include(c => c.UserClans)
                    .ThenInclude(uc => uc.ApplicationUser)
                .FirstOrDefaultAsync(c => c.ClanId == id.ToString());

            if (clan == null)
                return NotFound();

            var eventsToRemove = context.Events.Where(e => e.ClanId == clan.ClanId);
            context.Events.RemoveRange(eventsToRemove);

            foreach (var userClan in clan.UserClans.ToList())
            {
                if (userClan.Role == "ClanOwner")
                {
                    var user = userClan.ApplicationUser;
                    user.isClanOwner = false;
                    user.joinedClanId = null; 
                }

                context.UserClans.Remove(userClan);
            }

            await context.SaveChangesAsync();

            await clans.DeleteAsync(clan.ClanId);

            TempData["Message"] = $"Clan '{clan.Name}' was deleted.";
            return RedirectToAction("Index");
        }



        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            return View(await clans.GetByIdAsync(id,
                new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" }));
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Clan clan)
        {
            if (ModelState.IsValid)
            {
                await clans.UpdateAsync(clan);
                TempData["Message"] = $"Clan '{clan.Name}' was updated.";
                return RedirectToAction("Index");
            }
            return View(clan);
        }

        public async Task<IActionResult> Dashboard(string id)
        {
            var clan = await clans.GetByIdAsync(id,
                new QueryOptions<Clan>() { Includes = "Events,UserClans.ApplicationUser" });

            var vm = new ClanDashboardVM
            {
                Clan = clan,
                Events = clan.Events,
                Members = clan.UserClans
            };

            return View(vm);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Join(string clanId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return Unauthorized();

            var clan = await context.Clans
                .FirstOrDefaultAsync(c => c.ClanId == clanId);

            if (clan == null)
                return NotFound();

            // stop double joining incase
            bool alreadyMember = await context.UserClans
                .AnyAsync(uc => uc.UserId == userId && uc.ClanId == clanId);

            if (alreadyMember)
                return RedirectToAction("Details", new { id = clanId });

            user.joinedClanId = clanId;
            user.isClanOwner = false;

            var link = new UserClan
            {
                UserId = userId,
                ClanId = clanId,
                Role = "Member",
                JoinDate = DateTime.UtcNow
            };

            context.UserClans.Add(link);

            await context.SaveChangesAsync();
            return RedirectToAction("Details", new { id = clanId });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Leave(string clanId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return Unauthorized();

            var link = await context.UserClans
                .FirstOrDefaultAsync(uc => uc.UserId == userId && uc.ClanId == clanId);

            if (link == null)
                return RedirectToAction("Details", new { id = clanId });

            context.UserClans.Remove(link);

            if (user.joinedClanId == clanId)
            {
                user.joinedClanId = null;
                user.isClanOwner = false;
            }

            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
