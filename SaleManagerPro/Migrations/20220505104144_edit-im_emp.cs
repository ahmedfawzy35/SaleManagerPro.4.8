using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class editim_emp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDocumentsDetails_Images_IdImages",
                table: "EmployeeDocumentsDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDocumentsDetails_IdImages",
                table: "EmployeeDocumentsDetails");

            migrationBuilder.DropColumn(
                name: "IdImages",
                table: "EmployeeDocumentsDetails");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "EmployeeDocumentsDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "EmployeeDocumentsDetails");

            migrationBuilder.AddColumn<int>(
                name: "IdImages",
                table: "EmployeeDocumentsDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocumentsDetails_IdImages",
                table: "EmployeeDocumentsDetails",
                column: "IdImages");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDocumentsDetails_Images_IdImages",
                table: "EmployeeDocumentsDetails",
                column: "IdImages",
                principalTable: "Images",
                principalColumn: "IdImages",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
