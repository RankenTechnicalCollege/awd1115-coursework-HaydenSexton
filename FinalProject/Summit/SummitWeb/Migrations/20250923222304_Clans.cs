using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SummitWeb.Migrations
{
    /// <inheritdoc />
    public partial class Clans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    ClanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.ClanId);
                });

            migrationBuilder.InsertData(
                table: "Clans",
                columns: new[] { "ClanId", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 23, 17, 23, 3, 621, DateTimeKind.Local).AddTicks(6892), "A clan for destiny players who like raiding.", "Raiders" },
                    { 2, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(665), "PvP-focused clan for Guardians who live in the Crucible.", "Crucible Masters" },
                    { 3, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(682), "Clan for those who love Gambit and banking motes.", "Gambit Crew" },
                    { 4, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(685), "Dedicated to weekly Nightfalls and high difficulty strikes.", "Nightfall Heroes" },
                    { 5, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(687), "Top-tier Guardians focused on Trials of Osiris.", "Trials Legends" },
                    { 6, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(689), "A chill group for casual players of all levels.", "Casual Guardians" },
                    { 7, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(690), "Clan for players who love the story and lore of Destiny.", "Lore Seekers" },
                    { 8, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(691), "Focused on helping members collect exotic gear.", "Exotic Hunters" },
                    { 9, new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(693), "Clan specializing in Iron Banner events.", "Iron Banner Lords" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clans");
        }
    }
}
