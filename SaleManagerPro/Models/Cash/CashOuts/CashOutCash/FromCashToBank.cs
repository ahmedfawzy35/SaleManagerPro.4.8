using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.CashOutCash
{
    public class FromCashToBank
    {
        [Key]
        public int IdFromCashToBank { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public bool IsEdit { get; set; }
        public DateTime DateEdit { get; set; }
        public DateTime DateCreated { get; set; }

        public int IdBankAccount { get; set; }
        [ForeignKey("IdBankAccount")]
        public virtual BankAccount BankAccount { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
    }
}
