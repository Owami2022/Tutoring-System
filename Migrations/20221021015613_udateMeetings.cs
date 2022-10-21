using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class udateMeetings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ScheduleMeeting");

            migrationBuilder.AddColumn<string>(
                name: "CreatorID",
                table: "ScheduleMeeting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "ScheduleMeeting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleID",
                table: "ScheduleMeeting",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorID",
                table: "ScheduleMeeting");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "ScheduleMeeting");

            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "ScheduleMeeting");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "ScheduleMeeting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
