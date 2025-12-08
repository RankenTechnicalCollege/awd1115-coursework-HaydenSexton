using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityUserToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 10, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 1, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 9, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 14, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 4, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 14, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 27, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 8, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 23, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2025, 12, 11, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2025, 12, 10, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2025, 12, 12, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventDate",
                value: new DateTime(2025, 12, 9, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventDate",
                value: new DateTime(2025, 12, 13, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventDate",
                value: new DateTime(2025, 12, 18, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventDate",
                value: new DateTime(2025, 12, 15, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventDate",
                value: new DateTime(2025, 12, 11, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventDate",
                value: new DateTime(2025, 12, 19, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventDate",
                value: new DateTime(2025, 12, 22, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 0, 0, 55, 130, DateTimeKind.Utc).AddTicks(8947));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 27, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 18, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 26, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 31, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 15, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 20, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 13, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 25, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 9, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2025, 11, 27, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2025, 11, 30, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2025, 11, 26, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2025, 11, 28, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2025, 12, 3, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventDate",
                value: new DateTime(2025, 11, 25, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventDate",
                value: new DateTime(2025, 11, 29, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventDate",
                value: new DateTime(2025, 12, 4, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventDate",
                value: new DateTime(2025, 12, 1, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventDate",
                value: new DateTime(2025, 11, 27, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventDate",
                value: new DateTime(2025, 12, 3, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventDate",
                value: new DateTime(2025, 11, 30, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventDate",
                value: new DateTime(2025, 12, 5, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventDate",
                value: new DateTime(2025, 12, 8, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventDate",
                value: new DateTime(2025, 12, 6, 3, 58, 57, 383, DateTimeKind.Utc).AddTicks(4819));
        }
    }
}
