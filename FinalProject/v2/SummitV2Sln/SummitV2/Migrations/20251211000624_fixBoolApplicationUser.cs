using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class fixBoolApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isClanOwner",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2025, 8, 13, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2025, 11, 26, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 4, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 17, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 30, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2025, 11, 11, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "10",
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "11",
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "12",
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "13",
                column: "EventDate",
                value: new DateTime(2025, 12, 22, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "14",
                column: "EventDate",
                value: new DateTime(2025, 12, 25, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "15",
                column: "EventDate",
                value: new DateTime(2025, 12, 23, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                column: "EventDate",
                value: new DateTime(2025, 12, 13, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                column: "EventDate",
                value: new DateTime(2025, 12, 15, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                column: "EventDate",
                value: new DateTime(2025, 12, 12, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                column: "EventDate",
                value: new DateTime(2025, 12, 16, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                column: "EventDate",
                value: new DateTime(2025, 12, 21, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "9",
                column: "EventDate",
                value: new DateTime(2025, 12, 18, 0, 6, 23, 630, DateTimeKind.Utc).AddTicks(7365));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isClanOwner",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2025, 8, 13, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2025, 11, 26, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 4, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2025, 10, 30, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2025, 11, 11, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "10",
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "11",
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "12",
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "13",
                column: "EventDate",
                value: new DateTime(2025, 12, 22, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "14",
                column: "EventDate",
                value: new DateTime(2025, 12, 25, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "15",
                column: "EventDate",
                value: new DateTime(2025, 12, 23, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                column: "EventDate",
                value: new DateTime(2025, 12, 13, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                column: "EventDate",
                value: new DateTime(2025, 12, 15, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                column: "EventDate",
                value: new DateTime(2025, 12, 12, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                column: "EventDate",
                value: new DateTime(2025, 12, 16, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                column: "EventDate",
                value: new DateTime(2025, 12, 21, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "9",
                column: "EventDate",
                value: new DateTime(2025, 12, 18, 0, 4, 50, 227, DateTimeKind.Utc).AddTicks(7421));
        }
    }
}
