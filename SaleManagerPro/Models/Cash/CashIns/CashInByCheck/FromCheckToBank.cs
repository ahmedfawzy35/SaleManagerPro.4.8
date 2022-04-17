using SaleManagerPro.Models.Cash.Checks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashIns.CashInByCheck
{
    public class FromCheckToBank
    {
        [Key]
        public int IdFromCheckToBank { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public bool IsEdit { get; set; }
        public DateTime DateEdit { get; set; }
        public DateTime DateCreated { get; set; }

        public string CheckNumber { get; set; }
        [ForeignKey("CheckNumber")]
        public virtual ChecksIn ChecksIn { get; set; }

        public int IdBankAccount { get; set; }
        [ForeignKey("IdBankAccount")]
        public virtual BankAccount BankAccount { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
    }
}
