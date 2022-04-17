using SaleManagerPro.Models.Cash.Checks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.RePaidChecks
{
    public class RePaidCheck
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public bool IsEdit { get; set; }
        public DateTime DateEdit { get; set; }
        public DateTime DateCreated { get; set; }

        public string CheckNumber { get; set; }
        [ForeignKey("CheckNumber")]
        public virtual ChecksIn ChecksIn { get; set; }


        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
    }
}
