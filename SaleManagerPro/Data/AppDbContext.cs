using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Cash;
using SaleManagerPro.Models.Cash.CashIns.CashInByCheck;
using SaleManagerPro.Models.Cash.CashIns.CashInCash;
using SaleManagerPro.Models.Cash.CashOuts.CashOutByCheck;
using SaleManagerPro.Models.Cash.CashOuts.CashOutCash;
using SaleManagerPro.Models.Cash.CashOuts.RePaidChecks;
using SaleManagerPro.Models.Cash.Checks;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Employees;
using SaleManagerPro.Models.InComesAndOutComes;
using SaleManagerPro.Models.Installments;
using SaleManagerPro.Models.Loaners;
using SaleManagerPro.Models.OrdersAndPurchaces;
using SaleManagerPro.Models.Products;
using SaleManagerPro.Models.Roles;
using SaleManagerPro.Models.Salers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Data
{
    public class AppDbContext:DbContext
    {
        static readonly string con = string.Format(@"Data Source=(localdb)\MSSQLLocalDB;Database=SaleManage4.7.2DB;Trusted_Connection=True");
        #region Models
        #region cash
        #region cashins
        #region cashinbycheck
        public DbSet<CashInFromCusByCheck> CashInFromCusByChecks { get; set; }
        public DbSet<CashInFromCusInstallmentByCheck> CashInFromCusInstallmentByChecks { get; set; }
        public DbSet<CashInFromInComeByCheck> CashInFromInComeByChecks { get; set; }
        public DbSet<CashInFromLoanByCheck> CashInFromLoanByChecks { get; set; }
        public DbSet<CashInFromSalerByCheck> CashInFromSalerByChecks { get; set; }
        public DbSet<CashInFromSalerInstallmentByCheck> CashInFromSalerInstallmentByChecks { get; set; }
        public DbSet<FromCheckToBank> FromCheckToBanks { get; set; }
        public DbSet<FromCheckToCash> FromCheckToCash { get; set; }


        #endregion
        #region cashincash
        public DbSet<CashInFromCus> CashInFromCus { get; set; }
        public DbSet<CashInFromCusInstallment> CashInFromCusInstallments { get; set; }
        public DbSet<CashInFromInCome> CashInFromInComes { get; set; }
        public DbSet<CashInFromLoan> CashInFromLoans { get; set; }
        public DbSet<CashInFromSaler> CashInFromSalers { get; set; }
        public DbSet<CashInFromSalerInstallment> CashInFromSalerInstallments { get; set; }

        #endregion

        #endregion
        #region cashouts
        #region cashoutbycheck
        public DbSet<CashOutToCusByCheck> CashOutToCusByChecks { get; set; }
        public DbSet<CashOutToCusInstallmentByCheck> CashOutToCusInstallmentByChecks { get; set; }
        public DbSet<CashOutToLoansInstallmentByCheck> CashOutToLoansInstallmentByChecks { get; set; }
        public DbSet<CashOutToOutComeByCheck> CashOutToOutComeByChecks { get; set; }
        public DbSet<CashOutToSalerByCheck> CashOutToSalerByChecks { get; set; }
        public DbSet<CashOutToSalerInstallmentByCheck> CashOutToSalerInstallmentByChecks { get; set; }

        #endregion
        #region cashoutcash
        public DbSet<CashOutToCus> CashOutToCuss { get; set; }
        public DbSet<CashOutToCusInstallment> CashOutToCusInstallments { get; set; }
        public DbSet<CashOutToLoansInstallment> CashOutToLoansInstallments { get; set; }
        public DbSet<CashOutToOutCome> CashOutToOutComes { get; set; }
        public DbSet<CashOutToSaler> CashOutToSalers { get; set; }
        public DbSet<CashOutToSalerInstallment> CashOutToSalerInstallments { get; set; }
        public DbSet<FromCashToBank> FromCashToBanks { get; set; }




        #endregion
        #region repaidchecks
        public DbSet<RePaidCheckToCus> RePaidCheckToCuss { get; set; }
        public DbSet<RePaidCheckToCusInstallment> RePaidCheckToCusInstallments { get; set; }
        public DbSet<RePaidCheckToLoansInstallment> RePaidCheckToLoansInstallments { get; set; }
        public DbSet<RePaidCheckToOutCome> RePaidCheckToOutComes { get; set; }
        public DbSet<RePaidCheckToSaler> RePaidCheckToSalers { get; set; }
        public DbSet<RePaidCheckToSalerInstallment> RePaidCheckToSalerInstallments { get; set; }



        #endregion
        #endregion
        #region checks
        public DbSet<ChecksIn> ChecksIns { get; set; }
        public DbSet<ChecksOut> ChecksOuts { get; set; }

        #endregion
        public DbSet<BankAccount> BankAccounts { get; set; }

        #endregion
        #region customer
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBankAccounts> CustomersBankAccounts { get; set; }
        public DbSet<CustomerPhones> CustomersPhones { get; set; }

        #endregion
        #region employee
        public DbSet<AddToSalary> AddToSalaries { get; set; }
        public  DbSet<AddToSalaryForAll> AddToSalaryForAlls { get; set; }
        public  DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<EmployeeDocuments> EmployeeDocuments { get; set; }
        public DbSet<EmployeeDocumentsDetails> EmployeeDocumentsDetails { get; set; }
        public  DbSet<EmployeePromotion> EmployeePromotions { get; set; }
        public  DbSet<EmployeePunishment> EmployeePunishments { get; set; }
        public  DbSet<FinancialDegree> FinancialDegrees { get; set; }
        public  DbSet<Job> Jobs { get; set; }
        public  DbSet<JobDegree> JobDegrees { get; set; }
        public  DbSet<LessToSalary> LessToSalarys { get; set; }
        public  DbSet<LessToSalaryForAll> LessToSalaryForAlls { get; set; }
        public  DbSet<SalaryAdd> SalaryAdds { get; set; }
        public  DbSet<SalaryLess> SalaryLesses { get; set; }
        #endregion
        #region InComesAndOutComes
        public DbSet<InComeItem> InComeItems { get; set; }
        public DbSet<OutComeItem> OutComeItems { get; set; }

        #endregion
        #region Installments
        public DbSet<CustomersInstallment> CustomersInstallments { get; set; }
        public DbSet<InstallmentOrder> InstallmentOrders { get; set; }
        public DbSet<InstallmentPurchase> InstallmentPurchases { get; set; }
        public DbSet<LoansInstallment> LoansInstallments { get; set; }
        public DbSet<SalersInstallment> SalersInstallments { get; set; }

        #endregion
        #region Loaners
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Loaner> Loaners { get; set; }

        #endregion
        #region OrdersAndPurchaces
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBack> OrderBacks { get; set; }
        public DbSet<OrderBackDetails> OrderBackDetails { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseBack> PurchaseBacks { get; set; }
        public DbSet<PurchaseBackDetails> PurchaseBackDetails { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }

        #endregion
        #region Products
        public DbSet<Catogry> Catogrys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductUnits> ProductUnits { get; set; }
        public DbSet<Units> Units { get; set; }

        #endregion
        #region Roles
        public DbSet<Claime> Claimes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleClaime> RoleClaimes { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion
        #region Salers
        public DbSet<Saler> Salers { get; set; }
        public DbSet<SalerBankAccounts> SalerBankAccounts { get; set; }
        public DbSet<SalerPhones> SalerPhones { get; set; }

        #endregion

        public DbSet<Images> Images { get; set; }

        public DbSet<User> Users { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(con);
        }
    }
}
