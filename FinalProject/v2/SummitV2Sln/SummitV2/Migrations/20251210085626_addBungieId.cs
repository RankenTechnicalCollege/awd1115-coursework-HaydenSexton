using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class addBungieId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "BungieId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 8, 12, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 3, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 11, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 16, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 6, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 16, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 29, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 10, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Clans",
                keyColumn: "ClanId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 25, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2025, 12, 13, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2025, 12, 16, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2025, 12, 12, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2025, 12, 14, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2025, 12, 19, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventDate",
                value: new DateTime(2025, 12, 11, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventDate",
                value: new DateTime(2025, 12, 15, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventDate",
                value: new DateTime(2025, 12, 20, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventDate",
                value: new DateTime(2025, 12, 17, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventDate",
                value: new DateTime(2025, 12, 13, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventDate",
                value: new DateTime(2025, 12, 19, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventDate",
                value: new DateTime(2025, 12, 16, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventDate",
                value: new DateTime(2025, 12, 21, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventDate",
                value: new DateTime(2025, 12, 24, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventDate",
                value: new DateTime(2025, 12, 22, 8, 56, 26, 286, DateTimeKind.Utc).AddTicks(9757));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BungieId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
