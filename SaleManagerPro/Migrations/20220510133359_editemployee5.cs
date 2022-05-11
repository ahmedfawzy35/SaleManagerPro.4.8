using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editemployee5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdJob",
                table: "EmployeeTransfer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransfer_IdJob",
                table: "EmployeeTransfer",
                column: "IdJob");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTransfer_Jobs_IdJob",
                table: "EmployeeTransfer",
                column: "IdJob",
                principalTable: "Jobs",
                principalColumn: "IdJob",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTransfer_Jobs_IdJob",
                table: "EmployeeTransfer");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTransfer_IdJob",
                table: "EmployeeTransfer");

            migrationBuilder.DropColumn(
                name: "IdJob",
                table: "EmployeeTransfer");
        }
    }
}
