using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.InComesAndOutComes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashIns.CashInCash
{
    public class CashInFromInCome : CashFrom
    {
        [Key]
        public int IdCashInFromInCome { get; set; }
        public int IdInComeItem { get; set; }
        [ForeignKey("IdInComeItem")]
        public virtual InComeItem InComeItem { get; set; }

       

    }
}
