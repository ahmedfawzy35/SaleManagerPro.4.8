using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class addemployeedocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                columns: table => new
                {
                    IdEmployeeDocument = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.IdEmployeeDocument);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDocumentsDetails",
                columns: table => new
                {
                    IdEmployeeDocumentsDetails = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    PageNumber = table.Column<int>(nullable: false),
                    IdImages = table.Column<int>(nullable: false),
                    IdEmployeeDocument = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocumentsDetails", x => x.IdEmployeeDocumentsDetails);
                    table.ForeignKey(
                        name: "FK_EmployeeDocumentsDetails_EmployeeDocuments_IdEmployeeDocument",
                        column: x => x.IdEmployeeDocument,
                        principalTable: "EmployeeDocuments",
                        principalColumn: "IdEmployeeDocument",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDocumentsDetails_Images_IdImages",
                        column: x => x.IdImages,
                        principalTable: "Images",
                        principalColumn: "IdImages",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDocumentsDetails_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_IdEmployee",
                table: "EmployeeDocuments",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_IdUser",
                table: "EmployeeDocuments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocumentsDetails_IdEmployeeDocument",
                table: "EmployeeDocumentsDetails",
                column: "IdEmployeeDocument");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocumentsDetails_IdImages",
                table: "EmployeeDocumentsDetails",
                column: "IdImages");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocumentsDetails_IdUser",
                table: "EmployeeDocumentsDetails",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDocumentsDetails");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments");
        }
    }
}
