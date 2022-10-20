using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class AddvirtalinMarktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TBHAcademyUserId",
                table: "Marks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marks_TBHAcademyUserId",
                table: "Marks",
                column: "TBHAcademyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_AspNetUsers_TBHAcademyUserId",
                table: "Marks",
                column: "TBHAcademyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_AspNetUsers_TBHAcademyUserId",
                table: "Marks");

            migrationBuilder.DropIndex(
                name: "IX_Marks_TBHAcademyUserId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "TBHAcademyUserId",
                table: "Marks");
        }
    }
}
