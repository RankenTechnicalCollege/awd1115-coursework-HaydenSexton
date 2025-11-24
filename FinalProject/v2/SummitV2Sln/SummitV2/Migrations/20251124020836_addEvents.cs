using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class addEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 27, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 18, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 26, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 31, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 15, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 20, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 13, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 25, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 9, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "ClanId", "Description", "EventDate", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Full raid run with optional red border farming.", new DateTime(2025, 11, 27, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9786), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Deep Stone Crypt Raid" },
                    { 2, 1, "Grandmaster Nightfall — anti-champion mods required.", new DateTime(2025, 11, 30, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9789), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "GM Nightfall: The Corrupted" },
                    { 3, 2, "Casual PvP night. Stack in fireteams for faster matches.", new DateTime(2025, 11, 26, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9790), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Iron Banner Clash Night" },
                    { 4, 3, "3-hour Gambit session. No rage quitting.", new DateTime(2025, 11, 28, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9792), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Gambit Prime Marathon" },
                    { 5, 3, "Armor roll farming and Xenophage help.", new DateTime(2025, 12, 3, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9793), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Dungeon Farm: Pit of Heresy" },
                    { 6, 4, "Helping new Guardians unlock subclasses and find gear.", new DateTime(2025, 11, 25, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9794), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "New Light Onboarding Night" },
                    { 7, 5, "Challenge rotation and loot optimization.", new DateTime(2025, 11, 29, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9795), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "King’s Fall Challenge Mode" },
                    { 8, 6, "Master difficulty raid clearing with coordinated builds.", new DateTime(2025, 12, 4, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9796), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Root of Nightmares Master Mode" },
                    { 9, 7, "Complete seasonal Gambit challenges for resets.", new DateTime(2025, 12, 1, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9797), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Seasonal Gambit Reset Run" },
                    { 10, 8, "Power grind via Nightfall rotation runs.", new DateTime(2025, 11, 27, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9798), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Weekly Nightfall Marathon" },
                    { 11, 9, "Engram farming and seasonal vendor focusing.", new DateTime(2025, 12, 3, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9799), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Seasonal Activity Grind" },
                    { 12, 10, "Deep-dive into Witness influence and the Collapse.", new DateTime(2025, 11, 30, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9800), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Lore Discussion Night" },
                    { 13, 2, "Warm-up scrims and loadout tuning for Trials weekend.", new DateTime(2025, 12, 5, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9801), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Trials Warmup" },
                    { 14, 4, "Teaching new players how to build subclasses efficiently.", new DateTime(2025, 12, 8, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9802), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Subclass Build Workshop" },
                    { 15, 8, "Chill playlist grinding for vendor rewards.", new DateTime(2025, 12, 6, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9803), "17f1e219-9a92-4b7a-85b8-e3f3e2f3b450", "Vanguard Ops Playlist Night" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 17, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 25, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 30, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 14, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 19, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 12, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 24, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 8, 23, 34, 49, 439, DateTimeKind.Utc).AddTicks(8506));
        }
    }
}
