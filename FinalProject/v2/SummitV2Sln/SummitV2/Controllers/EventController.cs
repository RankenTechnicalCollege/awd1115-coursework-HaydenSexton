using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SummitV2.Data;
using SummitV2.Models;
using System.Security.Claims;

namespace SummitV2.Controllers
{
    public class EventController : Controller
    {
        private Repository<Event> events;
        private Repository<Clan> clans;
        private Repository<ApplicationUser> users;

        public EventController(ApplicationDbContext context)
        {
            events = new Repository<Event>(context);
            clans = new Repository<Clan>(context);
            users = new Repository<ApplicationUser>(context);
        }

        public async Task<IActionResult> Index()
        {
            return View(await events.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var options = new QueryOptions<Event>
            {
                Includes = "Clan,ApplicationUser"
            };

            var ev = await events.GetByIdAsync(id, options);

            if (ev == null)
                return NotFound();

            return View(ev);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddEdit(int clanId, int id = 0)
        {
            if (id == 0)
            {
                var clan = await clans.GetByIdAsync(clanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });

                if (clan == null)
                    return NotFound();

                ViewBag.Clan = clan;
                ViewBag.Operation = "Add";

                var ev = new Event
                {
                    ClanId = clanId,
                    OrganizerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    EventDate = DateTime.UtcNow.AddDays(1)
                };

                return View(ev);
            }
            else
            {
                var options = new QueryOptions<Event> { Includes = "Clan" };
                var ev = await events.GetByIdAsync(id, options);

                if (ev == null)
                    return NotFound();

                ViewBag.Clan = ev.Clan;
                ViewBag.Operation = "Edit";

                return View(ev);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEdit(Event ev)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Clan = await clans.GetByIdAsync(ev.ClanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
                return View(ev);
            }

            if (ev.EventId == 0)
            {
                await events.AddAsync(ev);
                TempData["Message"] = $"Event \"{ev.Title}\" was created.";
            }
            else
            {
                await events.UpdateAsync(ev);
                TempData["Message"] = $"Event \"{ev.Title}\" was updated.";
            }

            return RedirectToAction("Details", "Clan", new { id = ev.ClanId });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var ev = await events.GetByIdAsync(id, new QueryOptions<Event>());

            if (ev == null)
                return NotFound();

            await events.DeleteAsync(id);

            TempData["Message"] = $"Event \"{ev.Title}\" was deleted.";

            return RedirectToAction("Index");
        }
    }
}
