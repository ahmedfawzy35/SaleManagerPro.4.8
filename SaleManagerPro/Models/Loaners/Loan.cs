using SaleManagerPro.Models.Installments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Loaners
{
    public class Loan
    {
        [Key]
        public int IdLoan { get; set; }
        public int IdLoaner { get; set; }
        [ForeignKey("IdLoaner")]
        public virtual Loaner Loaner { get; set; }

        public string BankAccount { get; set; }
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


        public virtual IEnumerable<LoansInstallment> LoansInstallment { get; set; }

    }
}
