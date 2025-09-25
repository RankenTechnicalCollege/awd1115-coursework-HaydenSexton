using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitWeb.Models;

namespace SummitWeb.Controllers
{
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
        public async Task<IActionResult> Delete(Clan clan)
        {
            _context.Clans.Remove(clan);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }

        [HttpGet]
        // figure out if its editing or adding a clan and then return the clan data t
        public async Task<IActionResult> AddEdit(int id)
        {
            if (id == 0)
            {
                ViewBag.Operation = "Add";
                return View(new Clan());
            }
            ViewBag.Operation = "Edit";
            var clan = await _context.Clans.FindAsync(id);
            return View(clan);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(Clan clan)
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
                return RedirectToAction("List");
            }

            return View(clan);
        }
    }
}
