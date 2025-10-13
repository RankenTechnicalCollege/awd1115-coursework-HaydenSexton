using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitWeb.Models;
using ClanModel = SummitWeb.Areas.Clan.Models.Clan;

namespace SummitWeb.Areas.Clan.Controllers
{
    [Area("Clan")]
    public class ClanController : Controller
    {
        private readonly SummitContext _context;
        public ClanController(SummitContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> List()
        {
            var clans = await _context.Clans.ToListAsync();
            return View(clans);
        }

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
