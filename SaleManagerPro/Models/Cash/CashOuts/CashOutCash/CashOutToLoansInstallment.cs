using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Installments;
using SaleManagerPro.Models.Loaners;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.CashOutCash
{
    public class CashOutToLoansInstallment : CashTo
    {
        [Key]
        public int IdCashOutToLoansInstallment { get; set; }
        public int IdLoansInstallment { get; set; }
        [ForeignKey("IdLoansInstallment")]
        public virtual LoansInstallment LoansInstallment { get; set; }



    }
}
