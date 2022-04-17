using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Salers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashIns.CashInCash
{
    public class CashInFromSaler : CashFrom
    {
        [Key]
        public int IdCashInFromSaler { get; set; }
        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Saler { get; set; }



    }
}
