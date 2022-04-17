using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.Checks
{
    public class ChecksOut
    {
        [Key]
        public string CheckNumber { get; set; }

        public int IdBankAccount { get; set; }
        [ForeignKey("IdBankAccount")]
        public virtual BankAccount BankAccount { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateRelease { get; set; }
        public DateTime DateToPay { get; set; }
        public string State { get; set; }


    }
}
