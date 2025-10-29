using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripLogProject.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accommodations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingsToDo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accommodations", "Destination", "Email", "EndDate", "Phone", "StartDate", "ThingsToDo" },
                values: new object[,]
                {
                    { 1, "The Benson Hotel", "Portland", "staff@thebenson.com", new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "503-555-1234", new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get Voodoo donuts,Walk in the rain,Go to Powell's" },
                    { 2, "Holiday Inn Express", "Boise", "test@test.com", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "504-575-1254", new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visit family" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
