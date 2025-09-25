using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitWeb.Migrations
{
    /// <inheritdoc />
    public partial class ClanStaticTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 621, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 23, 17, 23, 3, 625, DateTimeKind.Local).AddTicks(693));
        }
    }
}
