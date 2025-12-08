using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SummitV2.Data;
using SummitV2.Models;
using SummitV2.Models.ViewModels;
using System.Security.Claims;

namespace SummitV2.Controllers
{
    [Authorize]
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


        public async Task<IActionResult> Details(int id)
        {
            return View(await clans.GetByIdAsync(id,
                new QueryOptions<Clan>() { Includes = "Events,ApplicationUser,UserClans.ApplicationUser" }));

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
        public async Task<IActionResult> Create([Bind("Name, Description")] Clan clan)
        {
            if (ModelState.IsValid)
            {
                clan.CreatedByUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                clan.CreatedDate = DateTime.UtcNow;

                await clans.AddAsync(clan);
                TempData["Message"] = $"Clan '{clan.Name}' was created.";
                return RedirectToAction("Index");
            }

            return View(clan);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await clans.GetByIdAsync(id,
                new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" }));
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Clan clan)
        {
            var eventsToRemove = context.Events.Where(e => e.ClanId == clan.ClanId);
            context.Events.RemoveRange(eventsToRemove);
            await context.SaveChangesAsync();

            await clans.DeleteAsync(clan.ClanId);

            TempData["Message"] = $"Clan '{clan.Name}' was deleted.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
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

        public async Task<IActionResult> Dashboard(int id)
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
    }
}
