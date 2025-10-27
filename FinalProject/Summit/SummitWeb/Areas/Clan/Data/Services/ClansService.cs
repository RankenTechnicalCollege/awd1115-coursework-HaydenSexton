using SummitContext = SummitWeb.Models.SummitContext;
using SummitWeb.Areas.Clan.Models;
using Microsoft.EntityFrameworkCore;

namespace SummitWeb.Areas.Clan.Data.Services
{
    public class ClansService : IClansService
    {
        private readonly SummitContext _context;

        public ClansService(SummitContext context)
        {
            _context = context;
        }

        public async Task Add(Models.Clan clan)
        {
            _context.Clans.Add(clan);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Models.Clan> GetAll()
        {
            // implement later when clan relationships are added
            //var applicationDbContext = _context.Clans.Include(l => l.Name);
            //return applicationDbContext;


            return _context.Clans.AsQueryable();
        }

        public async Task<Models.Clan> GetById(int? id)
        {
            var clan = await _context.Clans
                // Add Includes later when I have navigation properties
                .FirstOrDefaultAsync(m => m.ClanId == id);
            return clan;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
