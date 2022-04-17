using SaleManagerPro.Assist;
using SaleManagerPro.Models.Loaners;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Installments
{
    public class LoansInstallment
    {
        [Key]
        public int IdLoansInstallment { get; set; }

        public int IdLoan { get; set; }
        [ForeignKey("IdLoan")]
        public virtual Loan Loan { get; set; }

        public int Number { get; set; }
        public DateTime DateToPay { get; set; }

        public double Value { get; set; }
        public string State { get; set; }
        public DateTime DatePaied { get; set; }

    }
}
