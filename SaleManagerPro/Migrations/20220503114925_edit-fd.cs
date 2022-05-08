using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "FinancialDegrees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "FinancialDegrees");
        }
    }
}
