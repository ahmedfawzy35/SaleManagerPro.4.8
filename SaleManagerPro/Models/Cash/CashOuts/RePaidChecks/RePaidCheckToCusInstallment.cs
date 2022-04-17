using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Installments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.RePaidChecks
{
    public class RePaidCheckToCusInstallment : RePaidCheck
    {
        [Key]
        public int IdRePaidCheckToInstallment { get; set; }
        public int IdCustomersInstallment { get; set; }
        [ForeignKey("IdCustomersInstallment")]
        public virtual CustomersInstallment CustomersInstallment { get; set; }


    }
}
