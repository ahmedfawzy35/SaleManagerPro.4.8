using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class addpormationdocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PromotionDocuments",
                columns: table => new
                {
                    IdPromotionDocuments = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    PageNumber = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    IdEmployeePromotion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDocuments", x => x.IdPromotionDocuments);
                    table.ForeignKey(
                        name: "FK_PromotionDocuments_EmployeePromotions_IdEmployeePromotion",
                        column: x => x.IdEmployeePromotion,
                        principalTable: "EmployeePromotions",
                        principalColumn: "IdEmployeePromotion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionDocuments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDocuments_IdEmployeePromotion",
                table: "PromotionDocuments",
                column: "IdEmployeePromotion");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDocuments_IdUser",
                table: "PromotionDocuments",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PromotionDocuments");
        }
    }
}
