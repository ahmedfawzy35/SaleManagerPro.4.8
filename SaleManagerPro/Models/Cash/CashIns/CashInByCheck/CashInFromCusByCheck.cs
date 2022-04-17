using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashIns.CashInByCheck
{
    public class CashInFromCusByCheck : CashFromByCheck
    {
        [Key]
        public int IdCashInFromCusByCheck { get; set; }
        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer Customer { get; set; }

      

    }
}
