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

namespace SaleManagerPro.Models.Cash.CashIns.CashInByCheck

{
    public class CashInFromSalerInstallmentByCheck : CashFromByCheck
    {
        [Key]
        public int IdCashInFromSalerInstallment { get; set; }
        public int IdSalersInstallment { get; set; }
        [ForeignKey("IdSalersInstallment")]
        public virtual SalersInstallment SalersInstallment { get; set; }



    }
}
