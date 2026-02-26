using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Laderoboter.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNoAccessTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Category", "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { "users", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "users.noAccess", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Zugriff verweigert. Nur Administratoren können diese Seite sehen." });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Category", "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { "users", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "users.noAccess", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Access denied. Only administrators can view this page." });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.title", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Aktionsprotokoll" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.title", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Action Log" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.description", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Benutzeraktionen und Systemereignisse" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.description", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "User actions and system events" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.user", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Benutzer" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.user", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "User" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.action", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Aktion" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.action", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Action" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.details", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Details" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.details", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Details" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.timestamp", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Zeitstempel" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.timestamp", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Timestamp" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.noLogs", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Keine Einträge gefunden" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.noLogs", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "No entries found" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.filterByUser", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Nach Benutzer filtern" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.filterByUser", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Filter by user" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.filterByAction", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Nach Aktion filtern" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.filterByAction", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Filter by action" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.allUsers", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Alle Benutzer" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.allUsers", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "All Users" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.allActions", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Alle Aktionen" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "actionLog.allActions", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "All Actions" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "Key", "LanguageId", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { 529, "actionLog", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), null, "actionLog.systemAction", 1, new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "Systemaktion" },
                    { 530, "actionLog", new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), null, "actionLog.systemAction", 2, new DateTime(2026, 2, 25, 15, 23, 19, 629, DateTimeKind.Utc).AddTicks(2703), "System Action" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Category", "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { "actionLog", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.title", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Aktionsprotokoll" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Category", "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { "actionLog", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.title", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Action Log" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.description", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Benutzeraktionen und Systemereignisse" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.description", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "User actions and system events" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.user", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Benutzer" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.user", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "User" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.action", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Aktion" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.action", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Action" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.details", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Details" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.details", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Details" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.timestamp", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Zeitstempel" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.timestamp", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Timestamp" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.noLogs", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Keine Einträge gefunden" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.noLogs", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "No entries found" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.filterByUser", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Nach Benutzer filtern" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.filterByUser", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Filter by user" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.filterByAction", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Nach Aktion filtern" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.filterByAction", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Filter by action" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.allUsers", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Alle Benutzer" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.allUsers", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "All Users" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.allActions", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Alle Aktionen" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.allActions", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "All Actions" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.systemAction", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "Systemaktion" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreatedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "actionLog.systemAction", new DateTime(2026, 2, 25, 15, 10, 17, 73, DateTimeKind.Utc).AddTicks(6428), "System Action" });
        }
    }
}
