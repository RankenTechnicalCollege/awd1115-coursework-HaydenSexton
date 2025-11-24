using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class addClans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clans",
                columns: new[] { "ClanId", "CreatedByUserId", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 7, 26, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8492), "Veteran Guardians specializing in endgame PVE content.", "Astral Vanguard" },
                    { 2, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 8, 17, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8498), "Competitive PVP players who love Trials and Iron Banner.", "Iron Wolves" },
                    { 3, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 8, 25, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8499), "Late-night Guardians focusing on Gambit, Dungeons, and seasonal grinds.", "Shadow Syndicate" },
                    { 4, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 8, 30, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8500), "New player–friendly clan helping Guardians level up and learn the game.", "Lightbearer Legion" },
                    { 5, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 9, 14, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8501), "Sherpas assisting Guardians with raids, triumphs, and exotic missions.", "The Last City Watch" },
                    { 6, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 9, 19, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8502), "High-end raiding group completing flawless and master raids.", "Vanguard Elite" },
                    { 7, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 9, 29, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8503), "Chaotic Gambit lovers who thrive in the fog of war.", "The Drifter’s Crew" },
                    { 8, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 10, 12, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8504), "Solo-focused players that team up for Nightfalls and seasonal missions.", "Eclipse Wardens" },
                    { 9, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 10, 24, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8505), "Relaxed PVE clan that does raids, dungeons, and chill runs.", "Nova Outriders" },
                    { 10, "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", new DateTime(2025, 11, 8, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8506), "Lore-obsessed Guardians diving deep into every mystery of the Traveler.", "The Infinite Chorus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10);
        }
    }
}
