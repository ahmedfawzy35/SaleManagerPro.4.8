using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.OrdersAndPurchaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Installments
{
    public class InstallmentOrder
    {
        [Key]
        public int IdInstallmentOrder { get; set; }

        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer Customer { get; set; }
        public int IdOrder { get; set; }
        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }

        public double ValueStart { get; set; }
        public double ValueEnd { get; set; }
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
