using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Loaners;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashIns.CashInCash
{
    public class CashInFromLoan : CashFrom
    {
        [Key]
        public int IdCashInFromLoan { get; set; }
        public int IdLoan { get; set; }
        [ForeignKey("IdLoan")]
        public virtual Loan Loan { get; set; }



    }
}
