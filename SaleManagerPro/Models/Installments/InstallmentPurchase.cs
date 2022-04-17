using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.OrdersAndPurchaces;
using SaleManagerPro.Models.Salers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Installments
{
    public class InstallmentPurchase
    {
        [Key]
        public int IdInstallmentPurchase { get; set; }

        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Saler { get; set; }
        public int IdPurchase { get; set; }
        [ForeignKey("IdPurchase")]
        public virtual Purchase Purchase { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public double InterestRate { get; set; }
        public double AdminstrativeExpenses { get; set; }
        public double LateExpenses { get; set; }
        public int ForgivnessDayes { get; set; }

        public int DayesCycl { get; set; }

        public bool InLawDepartment { get; set; }


        public virtual IEnumerable<CustomersInstallment> CustomersInstallments { get; set; }
    }
}
