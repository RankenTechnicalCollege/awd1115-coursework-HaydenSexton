using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            this._context = context;
            events = new Repository<Event>(context);
            clans = new Repository<Clan>(context);
            users = new Repository<ApplicationUser>(context);
        }

        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            var query = _context.Events.AsQueryable();
            int pageSize = 9;

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c => c.Title.Contains(searchString));
            }

            var pagedEvents = await PaginatedList<Event>.CreateAsync(query, pageNumber ?? 1, pageSize);

            ViewData["searchString"] = searchString;

            return View(pagedEvents);
        }

        public async Task<IActionResult> Details(string id)
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
        public async Task<IActionResult> AddEdit(string clanId, string id = null)
        {
            ViewBag.Operation = string.IsNullOrEmpty(id) ? "Add" : "Edit";
            Event ev;
            Clan clan;

            if (string.IsNullOrEmpty(id))
            {
                clan = await clans.GetByIdAsync(clanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
                if (clan == null) return NotFound();

                ViewBag.Clan = clan;

                ev = new Event
                {
                    EventId = Guid.NewGuid().ToString(),
                    ClanId = clanId,
                    OrganizerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    EventDate = DateTime.UtcNow.AddDays(1)
                };
            }
            else
            {
                ev = await events.GetByIdAsync(id, new QueryOptions<Event> { Includes = "Clan" });
                if (ev == null) return NotFound();

                clan = ev.Clan;
                ViewBag.Clan = clan;
            }

            return View(ev);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit(string clanId, Event ev)
        {
            if (ev != null && string.IsNullOrEmpty(ev.ClanId))
            {
                ev.ClanId = clanId;
            }

            if (!ModelState.IsValid)
            {
                var clan = await clans.GetByIdAsync(clanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
                if (clan == null) return NotFound();
                ViewBag.Clan = clan;
                ViewBag.Operation = string.IsNullOrEmpty(ev.EventId) ? "Add" : "Edit";
                return View(ev);
            }

            if (string.IsNullOrEmpty(ev.EventId))
            {
                ev.EventId = Guid.NewGuid().ToString();
                await events.AddAsync(ev);
                TempData["Message"] = $"Event \"{ev.Title}\" was created.";
            }
            else
            {
                var existingEvent = await events.GetByIdAsync(ev.EventId, new QueryOptions<Event>());
                if (existingEvent == null) return NotFound();

                existingEvent.Title = ev.Title;
                existingEvent.Description = ev.Description;
                existingEvent.EventDate = ev.EventDate;
                existingEvent.ClanId = ev.ClanId;

                await events.UpdateAsync(existingEvent);
                TempData["Message"] = $"Event \"{ev.Title}\" was updated.";
            }

            return RedirectToAction("Details", "Clan", new { id = ev.ClanId });
        }



        [HttpPost]
        [Authorize(Roles = "Admin, ClanOwner")]
        public async Task<IActionResult> Delete(string id)
        {
            var ev = await events.GetByIdAsync(id, new QueryOptions<Event>());

            if (ev == null)
                return NotFound();

            await events.DeleteAsync(id.ToString());

            TempData["Message"] = $"Event \"{ev.Title}\" was deleted.";

            return RedirectToAction("Index");
        }
    }
}
