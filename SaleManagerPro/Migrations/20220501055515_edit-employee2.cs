using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editemployee2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Departments_IdDepartment",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_FinancialDegrees_IdFinancialDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_JobDegrees_IdGobDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Images_IdImages",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Jobs_IdJob",
                table: "EmployeeDetails");

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
                name: "IX_EmployeeDetails_IdDepartment",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_IdFinancialDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_IdGobDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_IdImages",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_IdJob",
                table: "EmployeeDetails");

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
                name: "IdDepartment",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "IdFinancialDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "IdGobDegree",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "IdImages",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "IdJob",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<int>(
                name: "IdDepartment",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFinancialDegree",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGobDegree",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdImages",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdJob",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdDepartment",
                table: "Employees",
                column: "IdDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdFinancialDegree",
                table: "Employees",
                column: "IdFinancialDegree");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdGobDegree",
                table: "Employees",
                column: "IdGobDegree");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdImages",
                table: "Employees",
                column: "IdImages");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdJob",
                table: "Employees",
                column: "IdJob");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_IdDepartment",
                table: "Employees",
                column: "IdDepartment",
                principalTable: "Departments",
                principalColumn: "IdDepartment",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_FinancialDegrees_IdFinancialDegree",
                table: "Employees",
                column: "IdFinancialDegree",
                principalTable: "FinancialDegrees",
                principalColumn: "IdFinancialDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobDegrees_IdGobDegree",
                table: "Employees",
                column: "IdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Images_IdImages",
                table: "Employees",
                column: "IdImages",
                principalTable: "Images",
                principalColumn: "IdImages",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_IdJob",
                table: "Employees",
                column: "IdJob",
                principalTable: "Jobs",
                principalColumn: "IdJob",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_IdDepartment",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_FinancialDegrees_IdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobDegrees_IdGobDegree",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Images_IdImages",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_IdJob",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdDepartment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdGobDegree",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdImages",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdJob",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdDepartment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdFinancialDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdGobDegree",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdImages",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdJob",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "FinancialDegreeIdFinancialDegree",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobDegreeIdGobDegree",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobIdJob",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDepartment",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFinancialDegree",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGobDegree",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdImages",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdJob",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "EmployeeDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
                name: "IX_EmployeeDetails_IdDepartment",
                table: "EmployeeDetails",
                column: "IdDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdFinancialDegree",
                table: "EmployeeDetails",
                column: "IdFinancialDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdGobDegree",
                table: "EmployeeDetails",
                column: "IdGobDegree");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdImages",
                table: "EmployeeDetails",
                column: "IdImages");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdJob",
                table: "EmployeeDetails",
                column: "IdJob");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Departments_IdDepartment",
                table: "EmployeeDetails",
                column: "IdDepartment",
                principalTable: "Departments",
                principalColumn: "IdDepartment",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_FinancialDegrees_IdFinancialDegree",
                table: "EmployeeDetails",
                column: "IdFinancialDegree",
                principalTable: "FinancialDegrees",
                principalColumn: "IdFinancialDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_JobDegrees_IdGobDegree",
                table: "EmployeeDetails",
                column: "IdGobDegree",
                principalTable: "JobDegrees",
                principalColumn: "IdGobDegree",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Images_IdImages",
                table: "EmployeeDetails",
                column: "IdImages",
                principalTable: "Images",
                principalColumn: "IdImages",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Jobs_IdJob",
                table: "EmployeeDetails",
                column: "IdJob",
                principalTable: "Jobs",
                principalColumn: "IdJob",
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
    }
}
