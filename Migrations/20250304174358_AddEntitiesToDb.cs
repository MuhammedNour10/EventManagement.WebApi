using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagement.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddEntitiesToDb : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    OrganizerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RSVPs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSVPs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70c32e27-8b28-4e66-a299-e4e4843bf37a", "70c32e27-8b28-4e66-a299-e4e4843bf37a", "Admin", "ADMIN" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "b6655fd0-51ca-4557-9874-27bf20be094d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75", 0, "47c1e34b-afce-4133-a758-6d84b6e0bc85", "use1@gmail.com", true, "", true, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAEP31gqpp1jtFauQpvJqsHSsvuRzpfuCXhkooNhrcWEzNBFzqsysIDgbWM6yr5jFyoQ==", null, false, "bdcff4ba-edf4-40a7-8cfd-efadc5644801", false, "use1@gmail.com" },
                    { "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92", 0, "c8fca6c5-5c4e-4f62-b07b-e8ed06f4b43f", "user2@gmail.com", true, "", true, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEBrmTFpdnnmL/HW2wkPU4FbZgf+jxWMjIk6jGfrLskRFh3K0L3sIhlVfGiW1oeZrrw==", null, false, "47a75ef4-e602-41ac-80f6-80058a425d85", false, "user2@gmail.com" },
                    { "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1", 0, "9620240d-c102-4917-8d2e-af059e144f47", "user3@gmail.com", true, "", true, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEFvkI+Qv3ljQ2w+oGYYwC4WskGKlvgYRlQ6cwH8U4ottJusg3qVyKqEE6Lra/yBQ+g==", null, false, "4de3b84c-f8bb-431e-925b-d0b44c7aee7f", false, "user3@gmail.com" },
                    { "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20", 0, "5073ef93-329b-4124-b464-65ce435a249d", "user4@gmail.com", true, "", true, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEHoiy27h7GhKVAslPG2gfxjHZJidai/EGuM7/26cmKKSav+Ej+vy8wGHxP/TW+m3fQ==", null, false, "6ce8b611-6b84-4fce-9772-28b788ee9509", false, "user4@gmail.com" },
                    { "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11", 0, "928997d8-e96a-47be-a366-3ccecd9d7f4f", "user5@gmail.com", true, "", true, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEIVLKK6c+SW70Z0NpM3t2W8nLBYpj44g3kXT8Synbz8DJ+mUJB7QymWCUvAbnzIAsw==", null, false, "3e4e07b9-7bc5-445d-afc6-181c5505a6d7", false, "user5@gmail.com" },
                    { "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31", 0, "c4162d55-22a6-4dac-8acc-c5d8f67522c9", "user6@gmail.com", true, "", true, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEBI0NDkYwMlJ+v/2wFJn/IYivz0muv+N7T8RqUgFr29wQvzcZQpqiXAilSqWwjwvXA==", null, false, "133c302a-840e-4466-81b2-593fe4487164", false, "user6@gmail.com" },
                    { "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213", 0, "a7f8b7d4-ead4-4751-bb74-f190ce6ff000", "admin@gmail.com", true, "", true, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBoWHEobkBAuAeai+nuudmqn+f4dqWv+IP/mlCUTza9GJkdQg3yAbq1xGz/TMMPNpw==", null, false, "cd5503f5-305c-4b6c-acc7-93e935cb3343", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "70c32e27-8b28-4e66-a299-e4e4843bf37a", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
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
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_EventId",
                table: "RSVPs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs",
                column: "UserId");
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
                name: "RSVPs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
