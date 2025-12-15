using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SummitV2.Migrations
{
    /// <inheritdoc />
    public partial class fixCalls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isClanOwner = table.Column<bool>(type: "bit", nullable: true),
                    joinedClanId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BungieId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    ClanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.ClanId);
                    table.ForeignKey(
                        name: "FK_Clans_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrganizerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Clans_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clans",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClans",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClans", x => new { x.UserId, x.ClanId });
                    table.ForeignKey(
                        name: "FK_UserClans_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClans_Clans_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clans",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76226e72-f30f-4c48-a579-cd638319f7b0", "83f95054-5763-49d8-a694-5ef4cb046324", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BungieId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isClanOwner", "joinedClanId" },
                values: new object[] { "4a34051d-2930-45cd-b424-ae708724e5fb", 0, "15225971", "3a5b8d9e-1f2a-4c7d-9e3b-6f8a2c4d5e7f", "sparrow@gmail.com", true, true, null, "SPARROW@GMAIL.COM", "SPARROW", null, null, false, "7c28cc3e-7d17-4f57-b6b2-9d8c1b4e5a6f", false, "Sparrow", true, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76226e72-f30f-4c48-a579-cd638319f7b0", "4a34051d-2930-45cd-b424-ae708724e5fb" });

            migrationBuilder.InsertData(
                table: "Clans",
                columns: new[] { "ClanId", "CreatedByUserId", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { "1", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veteran Guardians specializing in endgame PVE content.", "Astral Vanguard" },
                    { "10", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lore-obsessed Guardians diving deep into every mystery of the Traveler.", "The Infinite Chorus" },
                    { "2", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Competitive PVP players who love Trials and Iron Banner.", "Iron Wolves" },
                    { "3", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Late-night Guardians focusing on Gambit, Dungeons, and seasonal grinds.", "Shadow Syndicate" },
                    { "4", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New player–friendly clan helping Guardians level up and learn the game.", "Lightbearer Legion" },
                    { "5", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherpas assisting Guardians with raids, triumphs, and exotic missions.", "The Last City Watch" },
                    { "6", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-end raiding group completing flawless and master raids.", "Vanguard Elite" },
                    { "7", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chaotic Gambit lovers who thrive in the fog of war.", "The Drifter's Crew" },
                    { "8", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solo-focused players that team up for Nightfalls and seasonal missions.", "Eclipse Wardens" },
                    { "9", "4a34051d-2930-45cd-b424-ae708724e5fb", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relaxed PVE clan that does raids, dungeons, and chill runs.", "Nova Outriders" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "ClanId", "Description", "EventDate", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { "1", "1", "Full raid run with optional red border farming.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Deep Stone Crypt Raid" },
                    { "10", "8", "Power grind via Nightfall rotation runs.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Weekly Nightfall Marathon" },
                    { "11", "9", "Engram farming and seasonal vendor focusing.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Seasonal Activity Grind" },
                    { "12", "10", "Deep-dive into Witness influence and the Collapse.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Lore Discussion Night" },
                    { "13", "2", "Warm-up scrims and loadout tuning for Trials weekend.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Trials Warmup" },
                    { "14", "4", "Teaching new players how to build subclasses efficiently.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Subclass Build Workshop" },
                    { "15", "8", "Chill playlist grinding for vendor rewards.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Vanguard Ops Playlist Night" },
                    { "2", "1", "Grandmaster Nightfall — anti-champion mods required.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "GM Nightfall: The Corrupted" },
                    { "3", "2", "Casual PvP night. Stack in fireteams for faster matches.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Iron Banner Clash Night" },
                    { "4", "3", "3-hour Gambit session. No rage quitting.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Gambit Prime Marathon" },
                    { "5", "3", "Armor roll farming and Xenophage help.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Dungeon Farm: Pit of Heresy" },
                    { "6", "4", "Helping new Guardians unlock subclasses and find gear.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "New Light Onboarding Night" },
                    { "7", "5", "Challenge rotation and loot optimization.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "King's Fall Challenge Mode" },
                    { "8", "6", "Master difficulty raid clearing with coordinated builds.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Root of Nightmares Master Mode" },
                    { "9", "7", "Complete seasonal Gambit challenges for resets.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a34051d-2930-45cd-b424-ae708724e5fb", "Seasonal Gambit Reset Run" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clans_CreatedByUserId",
                table: "Clans",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClanId",
                table: "Events",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClans_ClanId",
                table: "UserClans",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserClans");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Clans");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
