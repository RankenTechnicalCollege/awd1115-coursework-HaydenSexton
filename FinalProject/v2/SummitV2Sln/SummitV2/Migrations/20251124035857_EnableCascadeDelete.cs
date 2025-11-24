using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class EnableCascadeDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clans_ClanId",
                table: "Events");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clans_ClanId",
                table: "Events",
                column: "ClanId",
                principalTable: "Clans",
                principalColumn: "ClanId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clans_ClanId",
                table: "Events");

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

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2025, 11, 27, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2025, 11, 30, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2025, 11, 26, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2025, 11, 28, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2025, 12, 3, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventDate",
                value: new DateTime(2025, 11, 25, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventDate",
                value: new DateTime(2025, 11, 29, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventDate",
                value: new DateTime(2025, 12, 4, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventDate",
                value: new DateTime(2025, 12, 1, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventDate",
                value: new DateTime(2025, 11, 27, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventDate",
                value: new DateTime(2025, 12, 3, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventDate",
                value: new DateTime(2025, 11, 30, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventDate",
                value: new DateTime(2025, 12, 5, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventDate",
                value: new DateTime(2025, 12, 8, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventDate",
                value: new DateTime(2025, 12, 6, 2, 8, 36, 106, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clans_ClanId",
                table: "Events",
                column: "ClanId",
                principalTable: "Clans",
                principalColumn: "ClanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
