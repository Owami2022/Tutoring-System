using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementId);
                });

            migrationBuilder.CreateTable(
                name: "Mark_Capture",
                columns: table => new
                {
                    MarkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleID = table.Column<int>(type: "int", nullable: false),
                    Assessment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assessment_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAssessment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overall_Mark = table.Column<int>(type: "int", nullable: false),
                    mark_Obtained = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark_Capture", x => x.MarkID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Mark_Capture");
        }
    }
}
