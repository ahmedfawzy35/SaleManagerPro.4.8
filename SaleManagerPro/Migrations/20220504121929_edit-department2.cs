using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editdepartment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Root",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Departments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "Root",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
