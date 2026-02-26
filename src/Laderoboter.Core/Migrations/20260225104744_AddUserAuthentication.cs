using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Laderoboter.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAuthentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonalNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    RfidTag = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserActionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    PersonalNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Action = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Details = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IpAddress = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActionLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "Key", "LanguageId", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { 411, "common", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "common.slideToDelete", 1, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Zum Löschen schieben" },
                    { 412, "common", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "common.slideToDelete", 2, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Slide to delete" },
                    { 413, "common", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "common.confirmed", 1, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Bestätigt" },
                    { 414, "common", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "common.confirmed", 2, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Confirmed" },
                    { 415, "translations", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "translations.deleteLanguage", 1, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Sprache löschen" },
                    { 416, "translations", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "translations.deleteLanguage", 2, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Delete Language" },
                    { 417, "translations", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "translations.deleteLanguageConfirm", 1, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Möchten Sie diese Sprache wirklich löschen?" },
                    { 418, "translations", new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), null, "translations.deleteLanguageConfirm", 2, new DateTime(2026, 2, 25, 10, 47, 43, 159, DateTimeKind.Utc).AddTicks(1665), "Do you really want to delete this language?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserActionLogs_Timestamp",
                table: "UserActionLogs",
                column: "Timestamp");

            migrationBuilder.CreateIndex(
                name: "IX_UserActionLogs_UserId",
                table: "UserActionLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonalNumber",
                table: "Users",
                column: "PersonalNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RfidTag",
                table: "Users",
                column: "RfidTag",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActionLogs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 2, 25, 7, 3, 15, 365, DateTimeKind.Utc).AddTicks(9955) });
        }
    }
}
