using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitWeb.Areas.Clan.Models;
using SummitWeb.Models;
using System.Numerics;
using System.Security.Claims;
using SummitWeb.Areas.Clan.Data.Services;
using ClanModel = SummitWeb.Areas.Clan.Models.Clan;
using SummitContext = SummitWeb.Models.SummitContext;

namespace SummitWeb.Areas.Clan.Controllers
{
    [Area("Clan")]
    public class ClanController : Controller
    {
        private readonly SummitContext _context;
        private readonly IClansService _clansService;
        // add more services here when created

        // service constructor
        public ClanController(SummitContext context, IClansService clansService)
        {
            _clansService = clansService;
            _context = context;
        }

        // new paginated list method
        public async Task<IActionResult> List(int? pageNumber, string searchString)
        {
            var SummitContext = _clansService.GetAll();
            int pageSize = 9;
            if (!string.IsNullOrEmpty(searchString))
            {
                SummitContext = SummitContext.Where(a => a.Name.Contains(searchString));
            }

            return View(await PaginatedList<ClanModel>.CreateAsync(SummitContext, pageNumber ?? 1, pageSize));
        }

        // paginated list method to be implemented later for own created clans
/*        public async Task<IActionResult> MyClans(int? pageNumber)
        {
            var SummitContext = _clansService.GetAll();
            int pageSize = 3;

            return View("Index", await PaginatedList<ClanModel>.CreateAsync(SummitContext.Where(l => l.IdentityUserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).AsNoTracking(), pageNumber ?? 1, pageSize));
        }*/

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var clanToDelete = await _context.Clans.FindAsync(id);
            return View(clanToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ClanModel clan)
        {
            _context.Clans.Remove(clan);
            await _context.SaveChangesAsync();
            return RedirectToAction("List", "Clan", new { area = "Clan" }); // list = action, clan = controller, area = "clan" = area name.
        }

        [HttpGet]
        // figure out if its editing or adding a clan and then return the clan data t
        public async Task<IActionResult> AddEdit(int id)
        {
            if (id == 0)
            {
                ViewBag.Operation = "Add";
                return View(new ClanModel());
            }
            ViewBag.Operation = "Edit";
            var clan = await _context.Clans.FindAsync(id);
            return View(clan);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(ClanModel clan)
        {
            ViewBag.Operation = clan.ClanId == 0 ? "Add" : "Edit";

            if (ModelState.IsValid)
            {
                // add operation
                if (clan.ClanId == 0)
                {
                    clan.CreatedDate = DateTime.UtcNow; // modify later
                    _context.Add(clan);
                }
                // edit operation
                else
                {
                    _context.Update(clan);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("List", "Clan", new { area = "Clan" }); // list = action, clan = controller, area = "clan" = area name.
            }

            return View(clan);
        }
    }
}
