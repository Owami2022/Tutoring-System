using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class AddingMarksTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarksDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OverallMarks = table.Column<int>(type: "int", nullable: false),
                    ObtainedMark = table.Column<int>(type: "int", nullable: false),
                    MarksComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    ModulesModuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarksId);
                    table.ForeignKey(
                        name: "FK_Marks_Modules_ModulesModuleId",
                        column: x => x.ModulesModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_ModulesModuleId",
                table: "Marks",
                column: "ModulesModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");
        }
    }
}
