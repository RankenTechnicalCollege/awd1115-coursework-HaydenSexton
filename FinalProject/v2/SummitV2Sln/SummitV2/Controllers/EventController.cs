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
        public async Task<IActionResult> Create(string clanId)
        {
            var clan = await clans.GetByIdAsync(clanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
            if (clan == null) return NotFound();

            ViewBag.Clan = clan;

            var ev = new Event
            {
                EventId = Guid.NewGuid().ToString(),
                ClanId = clanId,
                OrganizerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                EventDate = DateTime.UtcNow.AddDays(1)
            };

            return View(ev);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event ev)
        {
            if (!ModelState.IsValid)
            {
                var clan = await clans.GetByIdAsync(ev.ClanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
                if (clan != null) ViewBag.Clan = clan;
                return View(ev);
            }

            ev.EventId = Guid.NewGuid().ToString();
            ev.OrganizerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await events.AddAsync(ev);
            TempData["Message"] = $"Event \"{ev.Title}\" was created.";

            return RedirectToAction("Details", "Clan", new { id = ev.ClanId });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddEdit(string? id = null)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest("Event ID required");

            ViewBag.Operation = "Edit";

            var ev = await events.GetByIdAsync(id, new QueryOptions<Event> { Includes = "Clan" });
            if (ev == null) return NotFound();

            ViewBag.Clan = ev.Clan;

            return View("AddEdit", ev);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit(Event ev)
        {
            if (!ModelState.IsValid)
            {
                var clan = await clans.GetByIdAsync(ev.ClanId, new QueryOptions<Clan> { Includes = "UserClans.ApplicationUser" });
                if (clan != null) ViewBag.Clan = clan;
                ViewBag.Operation = "Edit";
                return View(ev);
            }

            var existingEvent = await events.GetByIdAsync(ev.EventId, new QueryOptions<Event>());
            if (existingEvent == null) return NotFound();

            existingEvent.Title = ev.Title;
            existingEvent.Description = ev.Description;
            existingEvent.EventDate = ev.EventDate;

            await events.UpdateAsync(existingEvent);
            TempData["Message"] = $"Event \"{ev.Title}\" was updated.";

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
