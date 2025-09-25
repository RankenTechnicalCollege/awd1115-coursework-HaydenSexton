using Microsoft.EntityFrameworkCore;

namespace SummitWeb.Models
{
    public class SummitContext : DbContext
    {
        public SummitContext(DbContextOptions<SummitContext> options) : base(options) { 

        }

        public DbSet<Clan> Clans { get; set; }

        // seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clan>().HasData(
                new Clan { ClanId = 1, Name = "Raiders", Description = "A clan for destiny players who like raiding.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 2, Name = "Crucible Masters", Description = "PvP-focused clan for Guardians who live in the Crucible.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 3, Name = "Gambit Crew", Description = "Clan for those who love Gambit and banking motes.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 4, Name = "Nightfall Heroes", Description = "Dedicated to weekly Nightfalls and high difficulty strikes.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 5, Name = "Trials Legends", Description = "Top-tier Guardians focused on Trials of Osiris.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 6, Name = "Casual Guardians", Description = "A chill group for casual players of all levels.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 7, Name = "Lore Seekers", Description = "Clan for players who love the story and lore of Destiny.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 8, Name = "Exotic Hunters", Description = "Focused on helping members collect exotic gear.", CreatedDate = new DateTime(2025, 1, 1) },
                new Clan { ClanId = 9, Name = "Iron Banner Lords", Description = "Clan specializing in Iron Banner events.", CreatedDate = new DateTime(2025, 1, 1) }
            );
        }
    }
}
