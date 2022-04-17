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

namespace SaleManagerPro.Models.Cash.CashOuts.CashOutByCheck
{
    public class CashOutToSalerByCheck : CashToByCheck
    {
        [Key]
        public int IdCashOutToSalerByCheck { get; set; }
        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Saler { get; set; }



    }
}
