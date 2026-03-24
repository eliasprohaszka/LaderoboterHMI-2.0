using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laderoboter.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkpieceProgramNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkpieceProgramNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaletteNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgramNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkpieceProgramNumbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkpieceProgramNumbers_PaletteNumber_Position",
                table: "WorkpieceProgramNumbers",
                columns: new[] { "PaletteNumber", "Position" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkpieceProgramNumbers");
        }
    }
}
