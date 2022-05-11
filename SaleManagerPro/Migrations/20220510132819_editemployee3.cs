using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editemployee3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobDegrees_IdGobDegree",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdGobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdGobDegree",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "ISOnWork",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IdJobDegree",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartDepartment",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartFinancialDegree",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartJob",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartJobDegree",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "StartSalary",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "EmployeePromotions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "EmployeeTransfer",
                columns: table => new
                {
                    IdEmployeeTransfer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTransfer", x => x.IdEmployeeTransfer);
                    table.ForeignKey(
                        name: "FK_EmployeeTransfer_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTransfer_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdJobDegree",
                table: "Employees",
                column: "IdJobDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransfer_IdEmployee",
                table: "EmployeeTransfer",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransfer_IdUser",
                table: "EmployeeTransfer",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobDegrees_IdJobDegree",
                table: "Employees",
                column: "IdJobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobDegrees_IdJobDegree",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeTransfer");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdJobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ISOnWork",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdJobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartDepartment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartFinancialDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartJob",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartJobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartSalary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "EmployeePromotions");

            migrationBuilder.AddColumn<int>(
                name: "IdGobDegree",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdGobDegree",
                table: "Employees",
                column: "IdGobDegree");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobDegrees_IdGobDegree",
                table: "Employees",
                column: "IdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
