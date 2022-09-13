using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class AddTableForCaptureMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMark",
                columns: table => new
                {
                    Teamid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamOne = table.Column<int>(type: "int", nullable: false),
                    TeamTwo = table.Column<int>(type: "int", nullable: false),
                    TeamThree = table.Column<int>(type: "int", nullable: false),
                    TeamFour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMark", x => x.Teamid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMark");
        }
    }
}
