using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class FAQs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Course_CourseID",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Modules",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Modules_CourseID",
                table: "Modules",
                newName: "IX_Modules_CourseId");

            migrationBuilder.CreateTable(
                name: "fAQs",
                columns: table => new
                {
                    FAQId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fAQs", x => x.FAQId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Course_CourseId",
                table: "Modules",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Course_CourseId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "fAQs");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Modules",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                newName: "IX_Modules_CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Course_CourseID",
                table: "Modules",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
