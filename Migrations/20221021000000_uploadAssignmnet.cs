using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class uploadAssignmnet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "SubModel");

            migrationBuilder.CreateTable(
                name: "Upload",
                columns: table => new
                {
                    AssignmnetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AssignmentDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upload", x => x.AssignmnetID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Upload");

            migrationBuilder.AddColumn<int>(
                name: "ModuleID",
                table: "SubModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
