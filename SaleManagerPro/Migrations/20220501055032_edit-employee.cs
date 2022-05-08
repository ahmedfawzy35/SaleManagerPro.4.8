using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "SalaryLesses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "SalaryLesses",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "SalaryAdds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "SalaryAdds",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsFixedSalary",
                table: "LessToSalarys",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "LessToSalarys",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "LessToSalarys",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsFixedSalary",
                table: "LessToSalaryForAlls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "LessToSalaryForAlls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "LessToSalaryForAlls",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "FinancialDegreeIdFinancialDegree",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobDegreeIdGobDegree",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobIdJob",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFinancialDegree",
                table: "EmployeePunishments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGobDegree",
                table: "EmployeePunishments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LessFromSalary",
                table: "EmployeePunishments",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AddToSalary",
                table: "EmployeePromotions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdFinancialDegree",
                table: "EmployeePromotions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGobDegree",
                table: "EmployeePromotions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFixedSalary",
                table: "AddToSalaryForAlls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "AddToSalaryForAlls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "AddToSalaryForAlls",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsFixedSalary",
                table: "AddToSalaries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersent",
                table: "AddToSalaries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Persent",
                table: "AddToSalaries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FinancialDegreeIdFinancialDegree",
                table: "Employees",
                column: "FinancialDegreeIdFinancialDegree");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobDegreeIdGobDegree",
                table: "Employees",
                column: "JobDegreeIdGobDegree");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobIdJob",
                table: "Employees",
                column: "JobIdJob");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePunishments_IdFinancialDegree",
                table: "EmployeePunishments",
                column: "IdFinancialDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePunishments_IdGobDegree",
                table: "EmployeePunishments",
                column: "IdGobDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_IdFinancialDegree",
                table: "EmployeePromotions",
                column: "IdFinancialDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_IdGobDegree",
                table: "EmployeePromotions",
                column: "IdGobDegree");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePromotions_FinancialDegrees_IdFinancialDegree",
                table: "EmployeePromotions",
                column: "IdFinancialDegree",
                principalTable: "FinancialDegrees",
                principalColumn: "IdFinancialDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePromotions_JobDegrees_IdGobDegree",
                table: "EmployeePromotions",
                column: "IdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunishments_FinancialDegrees_IdFinancialDegree",
                table: "EmployeePunishments",
                column: "IdFinancialDegree",
                principalTable: "FinancialDegrees",
                principalColumn: "IdFinancialDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunishments_JobDegrees_IdGobDegree",
                table: "EmployeePunishments",
                column: "IdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_FinancialDegrees_FinancialDegreeIdFinancialDegree",
                table: "Employees",
                column: "FinancialDegreeIdFinancialDegree",
                principalTable: "FinancialDegrees",
                principalColumn: "IdFinancialDegree",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobDegrees_JobDegreeIdGobDegree",
                table: "Employees",
                column: "JobDegreeIdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_JobIdJob",
                table: "Employees",
                column: "JobIdJob",
                principalTable: "Jobs",
                principalColumn: "IdJob",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePromotions_FinancialDegrees_IdFinancialDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePromotions_JobDegrees_IdGobDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunishments_FinancialDegrees_IdFinancialDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunishments_JobDegrees_IdGobDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_FinancialDegrees_FinancialDegreeIdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobDegrees_JobDegreeIdGobDegree",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_JobIdJob",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_FinancialDegreeIdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobDegreeIdGobDegree",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobIdJob",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePunishments_IdFinancialDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePunishments_IdGobDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePromotions_IdFinancialDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePromotions_IdGobDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "SalaryLesses");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "SalaryLesses");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "SalaryAdds");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "SalaryAdds");

            migrationBuilder.DropColumn(
                name: "IsFixedSalary",
                table: "LessToSalarys");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "LessToSalarys");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "LessToSalarys");

            migrationBuilder.DropColumn(
                name: "IsFixedSalary",
                table: "LessToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "LessToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "LessToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "FinancialDegreeIdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobDegreeIdGobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobIdJob",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdFinancialDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropColumn(
                name: "IdGobDegree",
                table: "EmployeePunishments");

            migrationBuilder.DropColumn(
                name: "LessFromSalary",
                table: "EmployeePunishments");

            migrationBuilder.DropColumn(
                name: "AddToSalary",
                table: "EmployeePromotions");

            migrationBuilder.DropColumn(
                name: "IdFinancialDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropColumn(
                name: "IdGobDegree",
                table: "EmployeePromotions");

            migrationBuilder.DropColumn(
                name: "IsFixedSalary",
                table: "AddToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "AddToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "AddToSalaryForAlls");

            migrationBuilder.DropColumn(
                name: "IsFixedSalary",
                table: "AddToSalaries");

            migrationBuilder.DropColumn(
                name: "IsPersent",
                table: "AddToSalaries");

            migrationBuilder.DropColumn(
                name: "Persent",
                table: "AddToSalaries");
        }
    }
}
