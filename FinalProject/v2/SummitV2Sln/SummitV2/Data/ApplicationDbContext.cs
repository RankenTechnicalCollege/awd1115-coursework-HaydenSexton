using Microsoft.AspNetCore.Identity;
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

            // seeding user
            var userId = "4a34051d-2930-45cd-b424-ae708724e5fb";
            var securityStamp = "7c28cc3e-7d17-4f57-b6b2-9d8c1b4e5a6f";
            var concurrencyStamp = "3a5b8d9e-1f2a-4c7d-9e3b-6f8a2c4d5e7f";

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    UserName = "Sparrow",
                    NormalizedUserName = "SPARROW",
                    Email = "sparrow@gmail.com",
                    NormalizedEmail = "SPARROW@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = null,
                    SecurityStamp = securityStamp,
                    ConcurrencyStamp = concurrencyStamp,
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    isClanOwner = true,
                    joinedClanId = null,
                    BungieId = "15225971"
                }
            );

            // Seed basic roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "76226e72-f30f-4c48-a579-cd638319f7b0",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "9f1c6a44-6f7e-4a4d-bc9e-5e9d8b0e7f42"
                }
            );

            // Assign admin role to the user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = userId,
                    RoleId = "76226e72-f30f-4c48-a579-cd638319f7b0"
                }
            );

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
                    ClanId = "1",
                    Name = "Astral Vanguard",
                    Description = "Veteran Guardians specializing in endgame PVE content.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "2",
                    Name = "Iron Wolves",
                    Description = "Competitive PVP players who love Trials and Iron Banner.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "3",
                    Name = "Shadow Syndicate",
                    Description = "Late-night Guardians focusing on Gambit, Dungeons, and seasonal grinds.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "4",
                    Name = "Lightbearer Legion",
                    Description = "New player–friendly clan helping Guardians level up and learn the game.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "5",
                    Name = "The Last City Watch",
                    Description = "Sherpas assisting Guardians with raids, triumphs, and exotic missions.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "6",
                    Name = "Vanguard Elite",
                    Description = "High-end raiding group completing flawless and master raids.",
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "7",
                    Name = "The Drifter's Crew",
                    Description = "Chaotic Gambit lovers who thrive in the fog of war.",
                    CreatedDate = new DateTime(2000, 1, 1), 
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "8",
                    Name = "Eclipse Wardens",
                    Description = "Solo-focused players that team up for Nightfalls and seasonal missions.",
                    CreatedDate = new DateTime(2000, 1, 1), 
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "9",
                    Name = "Nova Outriders",
                    Description = "Relaxed PVE clan that does raids, dungeons, and chill runs.",
                    CreatedDate = new DateTime(2000, 1, 1), 
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                },
                new Clan
                {
                    ClanId = "10",
                    Name = "The Infinite Chorus",
                    Description = "Lore-obsessed Guardians diving deep into every mystery of the Traveler.",
                    CreatedDate = new DateTime(2000, 1, 1), 
                    CreatedByUserId = "4a34051d-2930-45cd-b424-ae708724e5fb"
                }
            );

            // event seeding data
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = "1",
                    ClanId = "1",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Deep Stone Crypt Raid",
                    Description = "Full raid run with optional red border farming.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "2",
                    ClanId = "1",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "GM Nightfall: The Corrupted",
                    Description = "Grandmaster Nightfall — anti-champion mods required.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "3",
                    ClanId = "2",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Iron Banner Clash Night",
                    Description = "Casual PvP night. Stack in fireteams for faster matches.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "4",
                    ClanId = "3",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Gambit Prime Marathon",
                    Description = "3-hour Gambit session. No rage quitting.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "5",
                    ClanId = "3",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Dungeon Farm: Pit of Heresy",
                    Description = "Armor roll farming and Xenophage help.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "6",
                    ClanId = "4",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "New Light Onboarding Night",
                    Description = "Helping new Guardians unlock subclasses and find gear.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "7",
                    ClanId = "5",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "King's Fall Challenge Mode",
                    Description = "Challenge rotation and loot optimization.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "8",
                    ClanId = "6",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Root of Nightmares Master Mode",
                    Description = "Master difficulty raid clearing with coordinated builds.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "9",
                    ClanId = "7",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Seasonal Gambit Reset Run",
                    Description = "Complete seasonal Gambit challenges for resets.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "10",
                    ClanId = "8",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Weekly Nightfall Marathon",
                    Description = "Power grind via Nightfall rotation runs.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "11",
                    ClanId = "9",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Seasonal Activity Grind",
                    Description = "Engram farming and seasonal vendor focusing.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "12",
                    ClanId = "10",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Lore Discussion Night",
                    Description = "Deep-dive into Witness influence and the Collapse.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "13",
                    ClanId = "2",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Trials Warmup",
                    Description = "Warm-up scrims and loadout tuning for Trials weekend.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "14",
                    ClanId = "4",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Subclass Build Workshop",
                    Description = "Teaching new players how to build subclasses efficiently.",
                    EventDate = new DateTime(2000, 1, 1)
                },
                new Event
                {
                    EventId = "15",
                    ClanId = "8",
                    OrganizerId = "4a34051d-2930-45cd-b424-ae708724e5fb",
                    Title = "Vanguard Ops Playlist Night",
                    Description = "Chill playlist grinding for vendor rewards.",
                    EventDate = new DateTime(2000, 1, 1)
                }
            );

        }
    }
}
