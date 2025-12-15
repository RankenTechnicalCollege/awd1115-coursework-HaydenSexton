using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class fixCalls2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76226e72-f30f-4c48-a579-cd638319f7b0",
                column: "ConcurrencyStamp",
                value: "9f1c6a44-6f7e-4a4d-bc9e-5e9d8b0e7f42");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76226e72-f30f-4c48-a579-cd638319f7b0",
                column: "ConcurrencyStamp",
                value: "83f95054-5763-49d8-a694-5ef4cb046324");
        }
    }
}
