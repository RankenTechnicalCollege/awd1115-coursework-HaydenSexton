using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SummitV2.Models;

namespace SummitV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Clan> Clans { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<UserClan> UserClans { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Clan>()
             .HasOne(c => c.ApplicationUser)
             .WithMany(u => u.Clans)
             .HasForeignKey(c => c.CreatedByUserId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
              .HasOne(e => e.ApplicationUser)
              .WithMany(u => u.Events)
              .HasForeignKey(e => e.OrganizerId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Clan)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.ClanId)
                .OnDelete(DeleteBehavior.Cascade);




            // UserClan link

            modelBuilder.Entity<UserClan>()
                .HasKey(uc => new { uc.UserId, uc.ClanId });

            modelBuilder.Entity<UserClan>()
                .HasOne(uc => uc.ApplicationUser)
                .WithMany(u => u.UserClans)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserClan>()
                .HasOne(uc => uc.Clan)
                .WithMany(c => c.UserClans)
                .HasForeignKey(u => u.ClanId);


            // UserEvent link

            modelBuilder.Entity<UserEvent>()
                .HasKey(ue => new { ue.UserId, ue.EventId });

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.ApplicationUser)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(ue => ue.UserId);

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.Event)
                .WithMany(c => c.UserEvents)
                .HasForeignKey(ue => ue.EventId);


            // clan seeding data

            modelBuilder.Entity<Clan>().HasData(
                new Clan
                {
                    ClanId = 1,
                    Name = "Astral Vanguard",
                    Description = "Veteran Guardians specializing in endgame PVE content.",
                    CreatedDate = DateTime.UtcNow.AddDays(-120),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 2,
                    Name = "Iron Wolves",
                    Description = "Competitive PVP players who love Trials and Iron Banner.",
                    CreatedDate = DateTime.UtcNow.AddDays(-98),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 3,
                    Name = "Shadow Syndicate",
                    Description = "Late-night Guardians focusing on Gambit, Dungeons, and seasonal grinds.",
                    CreatedDate = DateTime.UtcNow.AddDays(-90),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 4,
                    Name = "Lightbearer Legion",
                    Description = "New player–friendly clan helping Guardians level up and learn the game.",
                    CreatedDate = DateTime.UtcNow.AddDays(-85),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 5,
                    Name = "The Last City Watch",
                    Description = "Sherpas assisting Guardians with raids, triumphs, and exotic missions.",
                    CreatedDate = DateTime.UtcNow.AddDays(-70),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 6,
                    Name = "Vanguard Elite",
                    Description = "High-end raiding group completing flawless and master raids.",
                    CreatedDate = DateTime.UtcNow.AddDays(-65),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 7,
                    Name = "The Drifter’s Crew",
                    Description = "Chaotic Gambit lovers who thrive in the fog of war.",
                    CreatedDate = DateTime.UtcNow.AddDays(-55),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 8,
                    Name = "Eclipse Wardens",
                    Description = "Solo-focused players that team up for Nightfalls and seasonal missions.",
                    CreatedDate = DateTime.UtcNow.AddDays(-42),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 9,
                    Name = "Nova Outriders",
                    Description = "Relaxed PVE clan that does raids, dungeons, and chill runs.",
                    CreatedDate = DateTime.UtcNow.AddDays(-30),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                },
                new Clan
                {
                    ClanId = 10,
                    Name = "The Infinite Chorus",
                    Description = "Lore-obsessed Guardians diving deep into every mystery of the Traveler.",
                    CreatedDate = DateTime.UtcNow.AddDays(-15),
                    CreatedByUserId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450"
                }
            );

            // event seeding data

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    ClanId = 1,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Deep Stone Crypt Raid",
                    Description = "Full raid run with optional red border farming.",
                    EventDate = DateTime.UtcNow.AddDays(3)
                },
                new Event
                {
                    EventId = 2,
                    ClanId = 1,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "GM Nightfall: The Corrupted",
                    Description = "Grandmaster Nightfall — anti-champion mods required.",
                    EventDate = DateTime.UtcNow.AddDays(6)
                },
                new Event
                {
                    EventId = 3,
                    ClanId = 2,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Iron Banner Clash Night",
                    Description = "Casual PvP night. Stack in fireteams for faster matches.",
                    EventDate = DateTime.UtcNow.AddDays(2)
                },
                new Event
                {
                    EventId = 4,
                    ClanId = 3,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Gambit Prime Marathon",
                    Description = "3-hour Gambit session. No rage quitting.",
                    EventDate = DateTime.UtcNow.AddDays(4)
                },
                new Event
                {
                    EventId = 5,
                    ClanId = 3,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Dungeon Farm: Pit of Heresy",
                    Description = "Armor roll farming and Xenophage help.",
                    EventDate = DateTime.UtcNow.AddDays(9)
                },
                new Event
                {
                    EventId = 6,
                    ClanId = 4,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "New Light Onboarding Night",
                    Description = "Helping new Guardians unlock subclasses and find gear.",
                    EventDate = DateTime.UtcNow.AddDays(1)
                },
                new Event
                {
                    EventId = 7,
                    ClanId = 5,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "King’s Fall Challenge Mode",
                    Description = "Challenge rotation and loot optimization.",
                    EventDate = DateTime.UtcNow.AddDays(5)
                },
                new Event
                {
                    EventId = 8,
                    ClanId = 6,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Root of Nightmares Master Mode",
                    Description = "Master difficulty raid clearing with coordinated builds.",
                    EventDate = DateTime.UtcNow.AddDays(10)
                },
                new Event
                {
                    EventId = 9,
                    ClanId = 7,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Seasonal Gambit Reset Run",
                    Description = "Complete seasonal Gambit challenges for resets.",
                    EventDate = DateTime.UtcNow.AddDays(7)
                },
                new Event
                {
                    EventId = 10,
                    ClanId = 8,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Weekly Nightfall Marathon",
                    Description = "Power grind via Nightfall rotation runs.",
                    EventDate = DateTime.UtcNow.AddDays(3)
                },
                new Event
                {
                    EventId = 11,
                    ClanId = 9,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Seasonal Activity Grind",
                    Description = "Engram farming and seasonal vendor focusing.",
                    EventDate = DateTime.UtcNow.AddDays(9)
                },
                new Event
                {
                    EventId = 12,
                    ClanId = 10,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Lore Discussion Night",
                    Description = "Deep-dive into Witness influence and the Collapse.",
                    EventDate = DateTime.UtcNow.AddDays(6)
                },
                new Event
                {
                    EventId = 13,
                    ClanId = 2,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Trials Warmup",
                    Description = "Warm-up scrims and loadout tuning for Trials weekend.",
                    EventDate = DateTime.UtcNow.AddDays(11)
                },
                new Event
                {
                    EventId = 14,
                    ClanId = 4,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Subclass Build Workshop",
                    Description = "Teaching new players how to build subclasses efficiently.",
                    EventDate = DateTime.UtcNow.AddDays(14)
                },
                new Event
                {
                    EventId = 15,
                    ClanId = 8,
                    OrganizerId = "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450",
                    Title = "Vanguard Ops Playlist Night",
                    Description = "Chill playlist grinding for vendor rewards.",
                    EventDate = DateTime.UtcNow.AddDays(12)
                }
            );

        }
    }
}
