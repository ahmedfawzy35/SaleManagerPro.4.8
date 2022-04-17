using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleManagerPro.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    IdBankAccount = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(nullable: true),
                    BankBranch = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    StartBalance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.IdBankAccount);
                });

            migrationBuilder.CreateTable(
                name: "ChecksIns",
                columns: table => new
                {
                    CheckNumber = table.Column<string>(nullable: false),
                    CheckBank = table.Column<string>(nullable: true),
                    CheckAccount = table.Column<string>(nullable: true),
                    DateInsert = table.Column<DateTime>(nullable: false),
                    DateToPay = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    IsRePaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecksIns", x => x.CheckNumber);
                });

            migrationBuilder.CreateTable(
                name: "Claimes",
                columns: table => new
                {
                    IdClaime = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claimes", x => x.IdClaime);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    StartAccount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    IdImages = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.IdImages);
                });

            migrationBuilder.CreateTable(
                name: "InComeItems",
                columns: table => new
                {
                    IdInComeItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InComeItems", x => x.IdInComeItem);
                });

            migrationBuilder.CreateTable(
                name: "Loaners",
                columns: table => new
                {
                    IdLoaner = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaners", x => x.IdLoaner);
                });

            migrationBuilder.CreateTable(
                name: "OutComeItems",
                columns: table => new
                {
                    IdOutComeItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutComeItems", x => x.IdOutComeItem);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Salers",
                columns: table => new
                {
                    IdSaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    StartAccount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salers", x => x.IdSaler);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    IdUnit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.IdUnit);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Enable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "ChecksOuts",
                columns: table => new
                {
                    CheckNumber = table.Column<string>(nullable: false),
                    IdBankAccount = table.Column<int>(nullable: false),
                    DateInsert = table.Column<DateTime>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false),
                    DateToPay = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecksOuts", x => x.CheckNumber);
                    table.ForeignKey(
                        name: "FK_ChecksOuts_BankAccounts_IdBankAccount",
                        column: x => x.IdBankAccount,
                        principalTable: "BankAccounts",
                        principalColumn: "IdBankAccount",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustomer = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    BankAccuntNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersBankAccounts_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CustomersPhones",
                columns: table => new
                {
                    IdCustomersPhones = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustomer = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    HaveWhatsApp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersPhones", x => x.IdCustomersPhones);
                    table.ForeignKey(
                        name: "FK_CustomersPhones_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderBacks",
                columns: table => new
                {
                    IdOrderBack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Cash = table.Column<double>(nullable: false),
                    Paki = table.Column<double>(nullable: false),
                    IsCash = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBacks", x => x.IdOrderBack);
                    table.ForeignKey(
                        name: "FK_OrderBacks_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Cash = table.Column<double>(nullable: false),
                    Paki = table.Column<double>(nullable: false),
                    IsCash = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    IdLoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLoaner = table.Column<int>(nullable: false),
                    BankAccount = table.Column<string>(nullable: true),
                    ValueStart = table.Column<double>(nullable: false),
                    ValueEnd = table.Column<double>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    AdminstrativeExpenses = table.Column<double>(nullable: false),
                    LateExpenses = table.Column<double>(nullable: false),
                    ForgivnessDayes = table.Column<int>(nullable: false),
                    DayesCycl = table.Column<int>(nullable: false),
                    InLawDepartment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.IdLoan);
                    table.ForeignKey(
                        name: "FK_Loans_Loaners_IdLoaner",
                        column: x => x.IdLoaner,
                        principalTable: "Loaners",
                        principalColumn: "IdLoaner",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaimes",
                columns: table => new
                {
                    IdRoleClaime = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(nullable: false),
                    IdClaime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaimes", x => x.IdRoleClaime);
                    table.ForeignKey(
                        name: "FK_RoleClaimes_Claimes_IdClaime",
                        column: x => x.IdClaime,
                        principalTable: "Claimes",
                        principalColumn: "IdClaime",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RoleClaimes_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseBacks",
                columns: table => new
                {
                    IdPurchaseBack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Cash = table.Column<double>(nullable: false),
                    Paki = table.Column<double>(nullable: false),
                    IsCash = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseBacks", x => x.IdPurchaseBack);
                    table.ForeignKey(
                        name: "FK_PurchaseBacks_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    IdPurchase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Cash = table.Column<double>(nullable: false),
                    Paki = table.Column<double>(nullable: false),
                    IsCash = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.IdPurchase);
                    table.ForeignKey(
                        name: "FK_Purchases_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalerBankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSaler = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    BankAccuntNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalerBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalerBankAccounts_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalerPhones",
                columns: table => new
                {
                    IdCustomersPhones = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSaler = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    HaveWhatsApp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalerPhones", x => x.IdCustomersPhones);
                    table.ForeignKey(
                        name: "FK_SalerPhones_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AddToSalaries",
                columns: table => new
                {
                    IdAddToSalary = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddToSalaries", x => x.IdAddToSalary);
                    table.ForeignKey(
                        name: "FK_AddToSalaries_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AddToSalaries_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AddToSalaryForAlls",
                columns: table => new
                {
                    IdAddToSalaryForAll = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddToSalaryForAlls", x => x.IdAddToSalaryForAll);
                    table.ForeignKey(
                        name: "FK_AddToSalaryForAlls_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromCus",
                columns: table => new
                {
                    IdCashInFromCus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromCus", x => x.IdCashInFromCus);
                    table.ForeignKey(
                        name: "FK_CashInFromCus_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromCus_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromCusByChecks",
                columns: table => new
                {
                    IdCashInFromCusByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromCusByChecks", x => x.IdCashInFromCusByCheck);
                    table.ForeignKey(
                        name: "FK_CashInFromCusByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromCusByChecks_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromCusByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromInComeByChecks",
                columns: table => new
                {
                    IdCashInFromInCome = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdInComeItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromInComeByChecks", x => x.IdCashInFromInCome);
                    table.ForeignKey(
                        name: "FK_CashInFromInComeByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromInComeByChecks_InComeItems_IdInComeItem",
                        column: x => x.IdInComeItem,
                        principalTable: "InComeItems",
                        principalColumn: "IdInComeItem",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromInComeByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromInComes",
                columns: table => new
                {
                    IdCashInFromInCome = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdInComeItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromInComes", x => x.IdCashInFromInCome);
                    table.ForeignKey(
                        name: "FK_CashInFromInComes_InComeItems_IdInComeItem",
                        column: x => x.IdInComeItem,
                        principalTable: "InComeItems",
                        principalColumn: "IdInComeItem",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromInComes_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromSalerByChecks",
                columns: table => new
                {
                    IdCashInFromSaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromSalerByChecks", x => x.IdCashInFromSaler);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerByChecks_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromSalers",
                columns: table => new
                {
                    IdCashInFromSaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromSalers", x => x.IdCashInFromSaler);
                    table.ForeignKey(
                        name: "FK_CashInFromSalers_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromSalers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToCuss",
                columns: table => new
                {
                    IdCashOutToCus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToCuss", x => x.IdCashOutToCus);
                    table.ForeignKey(
                        name: "FK_CashOutToCuss_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToCuss_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToOutComes",
                columns: table => new
                {
                    IdCashOutToOutCome = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdOutComeItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToOutComes", x => x.IdCashOutToOutCome);
                    table.ForeignKey(
                        name: "FK_CashOutToOutComes_OutComeItems_IdOutComeItem",
                        column: x => x.IdOutComeItem,
                        principalTable: "OutComeItems",
                        principalColumn: "IdOutComeItem",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToOutComes_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToSalers",
                columns: table => new
                {
                    IdCashOutToSaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToSalers", x => x.IdCashOutToSaler);
                    table.ForeignKey(
                        name: "FK_CashOutToSalers_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToSalers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Catogrys",
                columns: table => new
                {
                    IdCatogry = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catogrys", x => x.IdCatogry);
                    table.ForeignKey(
                        name: "FK_Catogrys_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    IdDepartment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Root = table.Column<int>(nullable: false),
                    About = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.IdDepartment);
                    table.ForeignKey(
                        name: "FK_Departments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePromotions",
                columns: table => new
                {
                    IdEmployeePromotion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePromotions", x => x.IdEmployeePromotion);
                    table.ForeignKey(
                        name: "FK_EmployeePromotions_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeePromotions_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePunishments",
                columns: table => new
                {
                    IdEmployeePunishment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePunishments", x => x.IdEmployeePunishment);
                    table.ForeignKey(
                        name: "FK_EmployeePunishments_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeePunishments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FinancialDegrees",
                columns: table => new
                {
                    IdFinancialDegree = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Nmae = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialDegrees", x => x.IdFinancialDegree);
                    table.ForeignKey(
                        name: "FK_FinancialDegrees_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FromCashToBanks",
                columns: table => new
                {
                    IdFromCashToBank = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdBankAccount = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FromCashToBanks", x => x.IdFromCashToBank);
                    table.ForeignKey(
                        name: "FK_FromCashToBanks_BankAccounts_IdBankAccount",
                        column: x => x.IdBankAccount,
                        principalTable: "BankAccounts",
                        principalColumn: "IdBankAccount",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FromCashToBanks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FromCheckToBanks",
                columns: table => new
                {
                    IdFromCheckToBank = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdBankAccount = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FromCheckToBanks", x => x.IdFromCheckToBank);
                    table.ForeignKey(
                        name: "FK_FromCheckToBanks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FromCheckToBanks_BankAccounts_IdBankAccount",
                        column: x => x.IdBankAccount,
                        principalTable: "BankAccounts",
                        principalColumn: "IdBankAccount",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FromCheckToBanks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FromCheckToCash",
                columns: table => new
                {
                    IdFromCheckToCash = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FromCheckToCash", x => x.IdFromCheckToCash);
                    table.ForeignKey(
                        name: "FK_FromCheckToCash_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FromCheckToCash_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "JobDegrees",
                columns: table => new
                {
                    IdGobDegree = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDegrees", x => x.IdGobDegree);
                    table.ForeignKey(
                        name: "FK_JobDegrees_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    IdJob = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.IdJob);
                    table.ForeignKey(
                        name: "FK_Jobs_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LessToSalaryForAlls",
                columns: table => new
                {
                    IdLessToSalaryForAll = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessToSalaryForAlls", x => x.IdLessToSalaryForAll);
                    table.ForeignKey(
                        name: "FK_LessToSalaryForAlls_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LessToSalarys",
                columns: table => new
                {
                    IdLessToSalary = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessToSalarys", x => x.IdLessToSalary);
                    table.ForeignKey(
                        name: "FK_LessToSalarys_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LessToSalarys_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToCuss",
                columns: table => new
                {
                    IdRePaidCheckToCus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToCuss", x => x.IdRePaidCheckToCus);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCuss_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCuss_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCuss_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToOutComes",
                columns: table => new
                {
                    IdRePaidCheckToOutCome = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdOutComeItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToOutComes", x => x.IdRePaidCheckToOutCome);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToOutComes_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToOutComes_OutComeItems_IdOutComeItem",
                        column: x => x.IdOutComeItem,
                        principalTable: "OutComeItems",
                        principalColumn: "IdOutComeItem",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToOutComes_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToSalers",
                columns: table => new
                {
                    IdRePaidCheckToSaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToSalers", x => x.IdRePaidCheckToSaler);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalers_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalers_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalaryAdds",
                columns: table => new
                {
                    IdSalaryAdd = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryAdds", x => x.IdSalaryAdd);
                    table.ForeignKey(
                        name: "FK_SalaryAdds_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalaryAdds_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalaryLesses",
                columns: table => new
                {
                    IdSalaryLess = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryLesses", x => x.IdSalaryLess);
                    table.ForeignKey(
                        name: "FK_SalaryLesses_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalaryLesses_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    IdUserRole = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.IdUserRole);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToCusByChecks",
                columns: table => new
                {
                    IdCashOutToCusByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToCusByChecks", x => x.IdCashOutToCusByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToCusByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToCusByChecks_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToCusByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToOutComeByChecks",
                columns: table => new
                {
                    IdCashOutToOutComeByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdOutComeItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToOutComeByChecks", x => x.IdCashOutToOutComeByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToOutComeByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToOutComeByChecks_OutComeItems_IdOutComeItem",
                        column: x => x.IdOutComeItem,
                        principalTable: "OutComeItems",
                        principalColumn: "IdOutComeItem",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToOutComeByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToSalerByChecks",
                columns: table => new
                {
                    IdCashOutToSalerByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSaler = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToSalerByChecks", x => x.IdCashOutToSalerByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerByChecks_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentOrders",
                columns: table => new
                {
                    IdInstallmentOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustomer = table.Column<int>(nullable: false),
                    IdOrder = table.Column<int>(nullable: false),
                    ValueStart = table.Column<double>(nullable: false),
                    ValueEnd = table.Column<double>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    AdminstrativeExpenses = table.Column<double>(nullable: false),
                    LateExpenses = table.Column<double>(nullable: false),
                    ForgivnessDayes = table.Column<int>(nullable: false),
                    DayesCycl = table.Column<int>(nullable: false),
                    InLawDepartment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentOrders", x => x.IdInstallmentOrder);
                    table.ForeignKey(
                        name: "FK_InstallmentOrders_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InstallmentOrders_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromLoanByChecks",
                columns: table => new
                {
                    IdCashInFromLoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdLoan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromLoanByChecks", x => x.IdCashInFromLoan);
                    table.ForeignKey(
                        name: "FK_CashInFromLoanByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromLoanByChecks_Loans_IdLoan",
                        column: x => x.IdLoan,
                        principalTable: "Loans",
                        principalColumn: "IdLoan",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromLoanByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromLoans",
                columns: table => new
                {
                    IdCashInFromLoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdLoan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromLoans", x => x.IdCashInFromLoan);
                    table.ForeignKey(
                        name: "FK_CashInFromLoans_Loans_IdLoan",
                        column: x => x.IdLoan,
                        principalTable: "Loans",
                        principalColumn: "IdLoan",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromLoans_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LoansInstallments",
                columns: table => new
                {
                    IdLoansInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLoan = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DateToPay = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    DatePaied = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoansInstallments", x => x.IdLoansInstallment);
                    table.ForeignKey(
                        name: "FK_LoansInstallments_Loans_IdLoan",
                        column: x => x.IdLoan,
                        principalTable: "Loans",
                        principalColumn: "IdLoan",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentPurchases",
                columns: table => new
                {
                    IdInstallmentPurchase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSaler = table.Column<int>(nullable: false),
                    IdPurchase = table.Column<int>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    AdminstrativeExpenses = table.Column<double>(nullable: false),
                    LateExpenses = table.Column<double>(nullable: false),
                    ForgivnessDayes = table.Column<int>(nullable: false),
                    DayesCycl = table.Column<int>(nullable: false),
                    InLawDepartment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentPurchases", x => x.IdInstallmentPurchase);
                    table.ForeignKey(
                        name: "FK_InstallmentPurchases_Purchases_IdPurchase",
                        column: x => x.IdPurchase,
                        principalTable: "Purchases",
                        principalColumn: "IdPurchase",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InstallmentPurchases_Salers_IdSaler",
                        column: x => x.IdSaler,
                        principalTable: "Salers",
                        principalColumn: "IdSaler",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    LastPurchasePrice = table.Column<double>(nullable: false),
                    LimitInStok = table.Column<int>(nullable: false),
                    IdCatogry = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Products_Catogrys_IdCatogry",
                        column: x => x.IdCatogry,
                        principalTable: "Catogrys",
                        principalColumn: "IdCatogry",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    IdEmployeeDetails = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    NationalNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    IsMaried = table.Column<string>(nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    ScientificDegree = table.Column<string>(nullable: true),
                    EducationalQualification = table.Column<string>(nullable: true),
                    IdDepartment = table.Column<int>(nullable: false),
                    IdJob = table.Column<int>(nullable: false),
                    IdGobDegree = table.Column<int>(nullable: false),
                    IdFinancialDegree = table.Column<int>(nullable: false),
                    IdImages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.IdEmployeeDetails);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Departments_IdDepartment",
                        column: x => x.IdDepartment,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_FinancialDegrees_IdFinancialDegree",
                        column: x => x.IdFinancialDegree,
                        principalTable: "FinancialDegrees",
                        principalColumn: "IdFinancialDegree",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_JobDegrees_IdGobDegree",
                        column: x => x.IdGobDegree,
                        principalTable: "JobDegrees",
                        principalColumn: "IdGobDegree",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Images_IdImages",
                        column: x => x.IdImages,
                        principalTable: "Images",
                        principalColumn: "IdImages",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Jobs_IdJob",
                        column: x => x.IdJob,
                        principalTable: "Jobs",
                        principalColumn: "IdJob",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToLoansInstallmentByChecks",
                columns: table => new
                {
                    IdCashOutToLoansInstallmentByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdLoansInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToLoansInstallmentByChecks", x => x.IdCashOutToLoansInstallmentByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToLoansInstallmentByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToLoansInstallmentByChecks_LoansInstallments_IdLoansInstallment",
                        column: x => x.IdLoansInstallment,
                        principalTable: "LoansInstallments",
                        principalColumn: "IdLoansInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToLoansInstallmentByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToLoansInstallments",
                columns: table => new
                {
                    IdCashOutToLoansInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdLoansInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToLoansInstallments", x => x.IdCashOutToLoansInstallment);
                    table.ForeignKey(
                        name: "FK_CashOutToLoansInstallments_LoansInstallments_IdLoansInstallment",
                        column: x => x.IdLoansInstallment,
                        principalTable: "LoansInstallments",
                        principalColumn: "IdLoansInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToLoansInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToLoansInstallments",
                columns: table => new
                {
                    IdRePaidCheckToLoansInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdLoansInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToLoansInstallments", x => x.IdRePaidCheckToLoansInstallment);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToLoansInstallments_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToLoansInstallments_LoansInstallments_IdLoansInstallment",
                        column: x => x.IdLoansInstallment,
                        principalTable: "LoansInstallments",
                        principalColumn: "IdLoansInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToLoansInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CustomersInstallments",
                columns: table => new
                {
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInstallmentOrder = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DateToPay = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    DatePaied = table.Column<DateTime>(nullable: false),
                    InstallmentPurchaseIdInstallmentPurchase = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersInstallments", x => x.IdCustomersInstallment);
                    table.ForeignKey(
                        name: "FK_CustomersInstallments_InstallmentOrders_IdInstallmentOrder",
                        column: x => x.IdInstallmentOrder,
                        principalTable: "InstallmentOrders",
                        principalColumn: "IdInstallmentOrder",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomersInstallments_InstallmentPurchases_InstallmentPurchaseIdInstallmentPurchase",
                        column: x => x.InstallmentPurchaseIdInstallmentPurchase,
                        principalTable: "InstallmentPurchases",
                        principalColumn: "IdInstallmentPurchase",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalersInstallments",
                columns: table => new
                {
                    IdSalersInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInstallmentPurchase = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DateToPay = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    DatePaied = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalersInstallments", x => x.IdSalersInstallment);
                    table.ForeignKey(
                        name: "FK_SalersInstallments_InstallmentPurchases_IdInstallmentPurchase",
                        column: x => x.IdInstallmentPurchase,
                        principalTable: "InstallmentPurchases",
                        principalColumn: "IdInstallmentPurchase",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderBackDetails",
                columns: table => new
                {
                    IdOrderDetailsBack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrderBack = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBackDetails", x => x.IdOrderDetailsBack);
                    table.ForeignKey(
                        name: "FK_OrderBackDetails_OrderBacks_IdOrderBack",
                        column: x => x.IdOrderBack,
                        principalTable: "OrderBacks",
                        principalColumn: "IdOrderBack",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderBackDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    IdOrderDetails = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrder = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.IdOrderDetails);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnits",
                columns: table => new
                {
                    IdProductUnits = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(nullable: false),
                    IdUnit = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Count = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnits", x => x.IdProductUnits);
                    table.ForeignKey(
                        name: "FK_ProductUnits_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductUnits_Units_IdUnit",
                        column: x => x.IdUnit,
                        principalTable: "Units",
                        principalColumn: "IdUnit",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseBackDetails",
                columns: table => new
                {
                    IdPurchaseBackDetails = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPurchaseBack = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseBackDetails", x => x.IdPurchaseBackDetails);
                    table.ForeignKey(
                        name: "FK_PurchaseBackDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseBackDetails_PurchaseBacks_IdPurchaseBack",
                        column: x => x.IdPurchaseBack,
                        principalTable: "PurchaseBacks",
                        principalColumn: "IdPurchaseBack",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    IdPurchaseDetails = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPurchase = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.IdPurchaseDetails);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Purchases_IdPurchase",
                        column: x => x.IdPurchase,
                        principalTable: "Purchases",
                        principalColumn: "IdPurchase",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromCusInstallmentByChecks",
                columns: table => new
                {
                    IdCashInFromCusInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromCusInstallmentByChecks", x => x.IdCashInFromCusInstallment);
                    table.ForeignKey(
                        name: "FK_CashInFromCusInstallmentByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromCusInstallmentByChecks_CustomersInstallments_IdCustomersInstallment",
                        column: x => x.IdCustomersInstallment,
                        principalTable: "CustomersInstallments",
                        principalColumn: "IdCustomersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromCusInstallmentByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromCusInstallments",
                columns: table => new
                {
                    IdCashInFromCusInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromCusInstallments", x => x.IdCashInFromCusInstallment);
                    table.ForeignKey(
                        name: "FK_CashInFromCusInstallments_CustomersInstallments_IdCustomersInstallment",
                        column: x => x.IdCustomersInstallment,
                        principalTable: "CustomersInstallments",
                        principalColumn: "IdCustomersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromCusInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToCusInstallmentByChecks",
                columns: table => new
                {
                    IdCashOutToCusInstallmentByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToCusInstallmentByChecks", x => x.IdCashOutToCusInstallmentByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToCusInstallmentByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToCusInstallmentByChecks_CustomersInstallments_IdCustomersInstallment",
                        column: x => x.IdCustomersInstallment,
                        principalTable: "CustomersInstallments",
                        principalColumn: "IdCustomersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToCusInstallmentByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToCusInstallments",
                columns: table => new
                {
                    IdCashOutToCusInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToCusInstallments", x => x.IdCashOutToCusInstallment);
                    table.ForeignKey(
                        name: "FK_CashOutToCusInstallments_CustomersInstallments_IdCustomersInstallment",
                        column: x => x.IdCustomersInstallment,
                        principalTable: "CustomersInstallments",
                        principalColumn: "IdCustomersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToCusInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToCusInstallments",
                columns: table => new
                {
                    IdRePaidCheckToInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdCustomersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToCusInstallments", x => x.IdRePaidCheckToInstallment);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCusInstallments_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCusInstallments_CustomersInstallments_IdCustomersInstallment",
                        column: x => x.IdCustomersInstallment,
                        principalTable: "CustomersInstallments",
                        principalColumn: "IdCustomersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToCusInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromSalerInstallmentByChecks",
                columns: table => new
                {
                    IdCashInFromSalerInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSalersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromSalerInstallmentByChecks", x => x.IdCashInFromSalerInstallment);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerInstallmentByChecks_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerInstallmentByChecks_SalersInstallments_IdSalersInstallment",
                        column: x => x.IdSalersInstallment,
                        principalTable: "SalersInstallments",
                        principalColumn: "IdSalersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerInstallmentByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashInFromSalerInstallments",
                columns: table => new
                {
                    IdCashInFromSalerInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdSalersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInFromSalerInstallments", x => x.IdCashInFromSalerInstallment);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerInstallments_SalersInstallments_IdSalersInstallment",
                        column: x => x.IdSalersInstallment,
                        principalTable: "SalersInstallments",
                        principalColumn: "IdSalersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashInFromSalerInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToSalerInstallmentByChecks",
                columns: table => new
                {
                    IdCashOutToSalerInstallmentByCheck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSalersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToSalerInstallmentByChecks", x => x.IdCashOutToSalerInstallmentByCheck);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerInstallmentByChecks_ChecksOuts_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksOuts",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerInstallmentByChecks_SalersInstallments_IdSalersInstallment",
                        column: x => x.IdSalersInstallment,
                        principalTable: "SalersInstallments",
                        principalColumn: "IdSalersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerInstallmentByChecks_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CashOutToSalerInstallments",
                columns: table => new
                {
                    IdCashOutToSalerInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdSalersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashOutToSalerInstallments", x => x.IdCashOutToSalerInstallment);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerInstallments_SalersInstallments_IdSalersInstallment",
                        column: x => x.IdSalersInstallment,
                        principalTable: "SalersInstallments",
                        principalColumn: "IdSalersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CashOutToSalerInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RePaidCheckToSalerInstallments",
                columns: table => new
                {
                    IdRePaidCheckToSalerInstallment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateEdit = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CheckNumber = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSalersInstallment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePaidCheckToSalerInstallments", x => x.IdRePaidCheckToSalerInstallment);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalerInstallments_ChecksIns_CheckNumber",
                        column: x => x.CheckNumber,
                        principalTable: "ChecksIns",
                        principalColumn: "CheckNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalerInstallments_SalersInstallments_IdSalersInstallment",
                        column: x => x.IdSalersInstallment,
                        principalTable: "SalersInstallments",
                        principalColumn: "IdSalersInstallment",
                       onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RePaidCheckToSalerInstallments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                       onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddToSalaries_IdEmployee",
                table: "AddToSalaries",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_AddToSalaries_IdUser",
                table: "AddToSalaries",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_AddToSalaryForAlls_IdUser",
                table: "AddToSalaryForAlls",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCus_IdCustomer",
                table: "CashInFromCus",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCus_IdUser",
                table: "CashInFromCus",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusByChecks_CheckNumber",
                table: "CashInFromCusByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusByChecks_IdCustomer",
                table: "CashInFromCusByChecks",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusByChecks_IdUser",
                table: "CashInFromCusByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusInstallmentByChecks_CheckNumber",
                table: "CashInFromCusInstallmentByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusInstallmentByChecks_IdCustomersInstallment",
                table: "CashInFromCusInstallmentByChecks",
                column: "IdCustomersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusInstallmentByChecks_IdUser",
                table: "CashInFromCusInstallmentByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusInstallments_IdCustomersInstallment",
                table: "CashInFromCusInstallments",
                column: "IdCustomersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromCusInstallments_IdUser",
                table: "CashInFromCusInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromInComeByChecks_CheckNumber",
                table: "CashInFromInComeByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromInComeByChecks_IdInComeItem",
                table: "CashInFromInComeByChecks",
                column: "IdInComeItem");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromInComeByChecks_IdUser",
                table: "CashInFromInComeByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromInComes_IdInComeItem",
                table: "CashInFromInComes",
                column: "IdInComeItem");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromInComes_IdUser",
                table: "CashInFromInComes",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromLoanByChecks_CheckNumber",
                table: "CashInFromLoanByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromLoanByChecks_IdLoan",
                table: "CashInFromLoanByChecks",
                column: "IdLoan");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromLoanByChecks_IdUser",
                table: "CashInFromLoanByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromLoans_IdLoan",
                table: "CashInFromLoans",
                column: "IdLoan");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromLoans_IdUser",
                table: "CashInFromLoans",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerByChecks_CheckNumber",
                table: "CashInFromSalerByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerByChecks_IdSaler",
                table: "CashInFromSalerByChecks",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerByChecks_IdUser",
                table: "CashInFromSalerByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerInstallmentByChecks_CheckNumber",
                table: "CashInFromSalerInstallmentByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerInstallmentByChecks_IdSalersInstallment",
                table: "CashInFromSalerInstallmentByChecks",
                column: "IdSalersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerInstallmentByChecks_IdUser",
                table: "CashInFromSalerInstallmentByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerInstallments_IdSalersInstallment",
                table: "CashInFromSalerInstallments",
                column: "IdSalersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalerInstallments_IdUser",
                table: "CashInFromSalerInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalers_IdSaler",
                table: "CashInFromSalers",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_CashInFromSalers_IdUser",
                table: "CashInFromSalers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusByChecks_CheckNumber",
                table: "CashOutToCusByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusByChecks_IdCustomer",
                table: "CashOutToCusByChecks",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusByChecks_IdUser",
                table: "CashOutToCusByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusInstallmentByChecks_CheckNumber",
                table: "CashOutToCusInstallmentByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusInstallmentByChecks_IdCustomersInstallment",
                table: "CashOutToCusInstallmentByChecks",
                column: "IdCustomersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusInstallmentByChecks_IdUser",
                table: "CashOutToCusInstallmentByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusInstallments_IdCustomersInstallment",
                table: "CashOutToCusInstallments",
                column: "IdCustomersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCusInstallments_IdUser",
                table: "CashOutToCusInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCuss_IdCustomer",
                table: "CashOutToCuss",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToCuss_IdUser",
                table: "CashOutToCuss",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToLoansInstallmentByChecks_CheckNumber",
                table: "CashOutToLoansInstallmentByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToLoansInstallmentByChecks_IdLoansInstallment",
                table: "CashOutToLoansInstallmentByChecks",
                column: "IdLoansInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToLoansInstallmentByChecks_IdUser",
                table: "CashOutToLoansInstallmentByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToLoansInstallments_IdLoansInstallment",
                table: "CashOutToLoansInstallments",
                column: "IdLoansInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToLoansInstallments_IdUser",
                table: "CashOutToLoansInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToOutComeByChecks_CheckNumber",
                table: "CashOutToOutComeByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToOutComeByChecks_IdOutComeItem",
                table: "CashOutToOutComeByChecks",
                column: "IdOutComeItem");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToOutComeByChecks_IdUser",
                table: "CashOutToOutComeByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToOutComes_IdOutComeItem",
                table: "CashOutToOutComes",
                column: "IdOutComeItem");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToOutComes_IdUser",
                table: "CashOutToOutComes",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerByChecks_CheckNumber",
                table: "CashOutToSalerByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerByChecks_IdSaler",
                table: "CashOutToSalerByChecks",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerByChecks_IdUser",
                table: "CashOutToSalerByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerInstallmentByChecks_CheckNumber",
                table: "CashOutToSalerInstallmentByChecks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerInstallmentByChecks_IdSalersInstallment",
                table: "CashOutToSalerInstallmentByChecks",
                column: "IdSalersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerInstallmentByChecks_IdUser",
                table: "CashOutToSalerInstallmentByChecks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerInstallments_IdSalersInstallment",
                table: "CashOutToSalerInstallments",
                column: "IdSalersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalerInstallments_IdUser",
                table: "CashOutToSalerInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalers_IdSaler",
                table: "CashOutToSalers",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_CashOutToSalers_IdUser",
                table: "CashOutToSalers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Catogrys_IdUser",
                table: "Catogrys",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_ChecksOuts_IdBankAccount",
                table: "ChecksOuts",
                column: "IdBankAccount");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBankAccounts_IdCustomer",
                table: "CustomersBankAccounts",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersInstallments_IdInstallmentOrder",
                table: "CustomersInstallments",
                column: "IdInstallmentOrder");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersInstallments_InstallmentPurchaseIdInstallmentPurchase",
                table: "CustomersInstallments",
                column: "InstallmentPurchaseIdInstallmentPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPhones_IdCustomer",
                table: "CustomersPhones",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_IdUser",
                table: "Departments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdDepartment",
                table: "EmployeeDetails",
                column: "IdDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdEmployee",
                table: "EmployeeDetails",
                column: "IdEmployee");

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_IdUser",
                table: "EmployeeDetails",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_IdEmployee",
                table: "EmployeePromotions",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_IdUser",
                table: "EmployeePromotions",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePunishments_IdEmployee",
                table: "EmployeePunishments",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePunishments_IdUser",
                table: "EmployeePunishments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialDegrees_IdUser",
                table: "FinancialDegrees",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_FromCashToBanks_IdBankAccount",
                table: "FromCashToBanks",
                column: "IdBankAccount");

            migrationBuilder.CreateIndex(
                name: "IX_FromCashToBanks_IdUser",
                table: "FromCashToBanks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_FromCheckToBanks_CheckNumber",
                table: "FromCheckToBanks",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_FromCheckToBanks_IdBankAccount",
                table: "FromCheckToBanks",
                column: "IdBankAccount");

            migrationBuilder.CreateIndex(
                name: "IX_FromCheckToBanks_IdUser",
                table: "FromCheckToBanks",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_FromCheckToCash_CheckNumber",
                table: "FromCheckToCash",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_FromCheckToCash_IdUser",
                table: "FromCheckToCash",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentOrders_IdCustomer",
                table: "InstallmentOrders",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentOrders_IdOrder",
                table: "InstallmentOrders",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentPurchases_IdPurchase",
                table: "InstallmentPurchases",
                column: "IdPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_InstallmentPurchases_IdSaler",
                table: "InstallmentPurchases",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_JobDegrees_IdUser",
                table: "JobDegrees",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_IdUser",
                table: "Jobs",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_LessToSalaryForAlls_IdUser",
                table: "LessToSalaryForAlls",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_LessToSalarys_IdEmployee",
                table: "LessToSalarys",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_LessToSalarys_IdUser",
                table: "LessToSalarys",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_IdLoaner",
                table: "Loans",
                column: "IdLoaner");

            migrationBuilder.CreateIndex(
                name: "IX_LoansInstallments_IdLoan",
                table: "LoansInstallments",
                column: "IdLoan");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBackDetails_IdOrderBack",
                table: "OrderBackDetails",
                column: "IdOrderBack");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBackDetails_IdProduct",
                table: "OrderBackDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBacks_IdCustomer",
                table: "OrderBacks",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdOrder",
                table: "OrderDetails",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdProduct",
                table: "OrderDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdCustomer",
                table: "Orders",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdCatogry",
                table: "Products",
                column: "IdCatogry");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdUser",
                table: "Products",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnits_IdProduct",
                table: "ProductUnits",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnits_IdUnit",
                table: "ProductUnits",
                column: "IdUnit");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBackDetails_IdProduct",
                table: "PurchaseBackDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBackDetails_IdPurchaseBack",
                table: "PurchaseBackDetails",
                column: "IdPurchaseBack");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBacks_IdSaler",
                table: "PurchaseBacks",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_IdProduct",
                table: "PurchaseDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_IdPurchase",
                table: "PurchaseDetails",
                column: "IdPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_IdSaler",
                table: "Purchases",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCusInstallments_CheckNumber",
                table: "RePaidCheckToCusInstallments",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCusInstallments_IdCustomersInstallment",
                table: "RePaidCheckToCusInstallments",
                column: "IdCustomersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCusInstallments_IdUser",
                table: "RePaidCheckToCusInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCuss_CheckNumber",
                table: "RePaidCheckToCuss",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCuss_IdCustomer",
                table: "RePaidCheckToCuss",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToCuss_IdUser",
                table: "RePaidCheckToCuss",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToLoansInstallments_CheckNumber",
                table: "RePaidCheckToLoansInstallments",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToLoansInstallments_IdLoansInstallment",
                table: "RePaidCheckToLoansInstallments",
                column: "IdLoansInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToLoansInstallments_IdUser",
                table: "RePaidCheckToLoansInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToOutComes_CheckNumber",
                table: "RePaidCheckToOutComes",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToOutComes_IdOutComeItem",
                table: "RePaidCheckToOutComes",
                column: "IdOutComeItem");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToOutComes_IdUser",
                table: "RePaidCheckToOutComes",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalerInstallments_CheckNumber",
                table: "RePaidCheckToSalerInstallments",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalerInstallments_IdSalersInstallment",
                table: "RePaidCheckToSalerInstallments",
                column: "IdSalersInstallment");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalerInstallments_IdUser",
                table: "RePaidCheckToSalerInstallments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalers_CheckNumber",
                table: "RePaidCheckToSalers",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalers_IdSaler",
                table: "RePaidCheckToSalers",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_RePaidCheckToSalers_IdUser",
                table: "RePaidCheckToSalers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaimes_IdClaime",
                table: "RoleClaimes",
                column: "IdClaime");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaimes_IdRole",
                table: "RoleClaimes",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryAdds_IdEmployee",
                table: "SalaryAdds",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryAdds_IdUser",
                table: "SalaryAdds",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryLesses_IdEmployee",
                table: "SalaryLesses",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryLesses_IdUser",
                table: "SalaryLesses",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_SalerBankAccounts_IdSaler",
                table: "SalerBankAccounts",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_SalerPhones_IdSaler",
                table: "SalerPhones",
                column: "IdSaler");

            migrationBuilder.CreateIndex(
                name: "IX_SalersInstallments_IdInstallmentPurchase",
                table: "SalersInstallments",
                column: "IdInstallmentPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdRole",
                table: "UserRoles",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdUser",
                table: "UserRoles",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddToSalaries");

            migrationBuilder.DropTable(
                name: "AddToSalaryForAlls");

            migrationBuilder.DropTable(
                name: "CashInFromCus");

            migrationBuilder.DropTable(
                name: "CashInFromCusByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromCusInstallmentByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromCusInstallments");

            migrationBuilder.DropTable(
                name: "CashInFromInComeByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromInComes");

            migrationBuilder.DropTable(
                name: "CashInFromLoanByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromLoans");

            migrationBuilder.DropTable(
                name: "CashInFromSalerByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromSalerInstallmentByChecks");

            migrationBuilder.DropTable(
                name: "CashInFromSalerInstallments");

            migrationBuilder.DropTable(
                name: "CashInFromSalers");

            migrationBuilder.DropTable(
                name: "CashOutToCusByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToCusInstallmentByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToCusInstallments");

            migrationBuilder.DropTable(
                name: "CashOutToCuss");

            migrationBuilder.DropTable(
                name: "CashOutToLoansInstallmentByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToLoansInstallments");

            migrationBuilder.DropTable(
                name: "CashOutToOutComeByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToOutComes");

            migrationBuilder.DropTable(
                name: "CashOutToSalerByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToSalerInstallmentByChecks");

            migrationBuilder.DropTable(
                name: "CashOutToSalerInstallments");

            migrationBuilder.DropTable(
                name: "CashOutToSalers");

            migrationBuilder.DropTable(
                name: "CustomersBankAccounts");

            migrationBuilder.DropTable(
                name: "CustomersPhones");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "EmployeePromotions");

            migrationBuilder.DropTable(
                name: "EmployeePunishments");

            migrationBuilder.DropTable(
                name: "FromCashToBanks");

            migrationBuilder.DropTable(
                name: "FromCheckToBanks");

            migrationBuilder.DropTable(
                name: "FromCheckToCash");

            migrationBuilder.DropTable(
                name: "LessToSalaryForAlls");

            migrationBuilder.DropTable(
                name: "LessToSalarys");

            migrationBuilder.DropTable(
                name: "OrderBackDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "PurchaseBackDetails");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "RePaidCheckToCusInstallments");

            migrationBuilder.DropTable(
                name: "RePaidCheckToCuss");

            migrationBuilder.DropTable(
                name: "RePaidCheckToLoansInstallments");

            migrationBuilder.DropTable(
                name: "RePaidCheckToOutComes");

            migrationBuilder.DropTable(
                name: "RePaidCheckToSalerInstallments");

            migrationBuilder.DropTable(
                name: "RePaidCheckToSalers");

            migrationBuilder.DropTable(
                name: "RoleClaimes");

            migrationBuilder.DropTable(
                name: "SalaryAdds");

            migrationBuilder.DropTable(
                name: "SalaryLesses");

            migrationBuilder.DropTable(
                name: "SalerBankAccounts");

            migrationBuilder.DropTable(
                name: "SalerPhones");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "InComeItems");

            migrationBuilder.DropTable(
                name: "ChecksOuts");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "FinancialDegrees");

            migrationBuilder.DropTable(
                name: "JobDegrees");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "OrderBacks");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "PurchaseBacks");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CustomersInstallments");

            migrationBuilder.DropTable(
                name: "LoansInstallments");

            migrationBuilder.DropTable(
                name: "OutComeItems");

            migrationBuilder.DropTable(
                name: "SalersInstallments");

            migrationBuilder.DropTable(
                name: "ChecksIns");

            migrationBuilder.DropTable(
                name: "Claimes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Catogrys");

            migrationBuilder.DropTable(
                name: "InstallmentOrders");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "InstallmentPurchases");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Loaners");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Salers");
        }
    }
}
