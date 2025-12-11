using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class recreateClanandEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clans",
                columns: new[] { "ClanId", "CreatedByUserId", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { "1", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 8, 13, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7298), "Veteran Guardians specializing in endgame PVE content.", "Astral Vanguard" },
                    { "10", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 11, 26, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7313), "Lore-obsessed Guardians diving deep into every mystery of the Traveler.", "The Infinite Chorus" },
                    { "2", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 9, 4, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7304), "Competitive PVP players who love Trials and Iron Banner.", "Iron Wolves" },
                    { "3", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 9, 12, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7306), "Late-night Guardians focusing on Gambit, Dungeons, and seasonal grinds.", "Shadow Syndicate" },
                    { "4", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 9, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7307), "New player–friendly clan helping Guardians level up and learn the game.", "Lightbearer Legion" },
                    { "5", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 10, 2, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7308), "Sherpas assisting Guardians with raids, triumphs, and exotic missions.", "The Last City Watch" },
                    { "6", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 10, 7, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7309), "High-end raiding group completing flawless and master raids.", "Vanguard Elite" },
                    { "7", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 10, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7310), "Chaotic Gambit lovers who thrive in the fog of war.", "The Drifter’s Crew" },
                    { "8", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 10, 30, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7311), "Solo-focused players that team up for Nightfalls and seasonal missions.", "Eclipse Wardens" },
                    { "9", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2025, 11, 11, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7312), "Relaxed PVE clan that does raids, dungeons, and chill runs.", "Nova Outriders" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "ClanId", "Description", "EventDate", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { "1", "1", "Full raid run with optional red border farming.", new DateTime(2025, 12, 14, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7412), "4a34051d-2930-45cd-b424-ae708724e5fb", "Deep Stone Crypt Raid" },
                    { "10", "8", "Power grind via Nightfall rotation runs.", new DateTime(2025, 12, 14, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7422), "4a34051d-2930-45cd-b424-ae708724e5fb", "Weekly Nightfall Marathon" },
                    { "11", "9", "Engram farming and seasonal vendor focusing.", new DateTime(2025, 12, 20, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7423), "4a34051d-2930-45cd-b424-ae708724e5fb", "Seasonal Activity Grind" },
                    { "12", "10", "Deep-dive into Witness influence and the Collapse.", new DateTime(2025, 12, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7424), "4a34051d-2930-45cd-b424-ae708724e5fb", "Lore Discussion Night" },
                    { "13", "2", "Warm-up scrims and loadout tuning for Trials weekend.", new DateTime(2025, 12, 22, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7425), "4a34051d-2930-45cd-b424-ae708724e5fb", "Trials Warmup" },
                    { "14", "4", "Teaching new players how to build subclasses efficiently.", new DateTime(2025, 12, 25, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7426), "4a34051d-2930-45cd-b424-ae708724e5fb", "Subclass Build Workshop" },
                    { "15", "8", "Chill playlist grinding for vendor rewards.", new DateTime(2025, 12, 23, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7427), "4a34051d-2930-45cd-b424-ae708724e5fb", "Vanguard Ops Playlist Night" },
                    { "2", "1", "Grandmaster Nightfall — anti-champion mods required.", new DateTime(2025, 12, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7414), "4a34051d-2930-45cd-b424-ae708724e5fb", "GM Nightfall: The Corrupted" },
                    { "3", "2", "Casual PvP night. Stack in fireteams for faster matches.", new DateTime(2025, 12, 13, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7415), "4a34051d-2930-45cd-b424-ae708724e5fb", "Iron Banner Clash Night" },
                    { "4", "3", "3-hour Gambit session. No rage quitting.", new DateTime(2025, 12, 15, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7416), "4a34051d-2930-45cd-b424-ae708724e5fb", "Gambit Prime Marathon" },
                    { "5", "3", "Armor roll farming and Xenophage help.", new DateTime(2025, 12, 20, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7417), "4a34051d-2930-45cd-b424-ae708724e5fb", "Dungeon Farm: Pit of Heresy" },
                    { "6", "4", "Helping new Guardians unlock subclasses and find gear.", new DateTime(2025, 12, 12, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7418), "4a34051d-2930-45cd-b424-ae708724e5fb", "New Light Onboarding Night" },
                    { "7", "5", "Challenge rotation and loot optimization.", new DateTime(2025, 12, 16, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7419), "4a34051d-2930-45cd-b424-ae708724e5fb", "King’s Fall Challenge Mode" },
                    { "8", "6", "Master difficulty raid clearing with coordinated builds.", new DateTime(2025, 12, 21, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7420), "4a34051d-2930-45cd-b424-ae708724e5fb", "Root of Nightmares Master Mode" },
                    { "9", "7", "Complete seasonal Gambit challenges for resets.", new DateTime(2025, 12, 18, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7421), "4a34051d-2930-45cd-b424-ae708724e5fb", "Seasonal Gambit Reset Run" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "9");
        }
    }
}
