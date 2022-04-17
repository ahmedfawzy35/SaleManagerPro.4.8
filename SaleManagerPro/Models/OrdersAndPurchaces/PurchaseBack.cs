using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Salers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.OrdersAndPurchaces
{
    public class PurchaseBack
    {
        [Key]
        public int IdPurchaseBack { get; set; }
        public DateTime Date { get; set; }
        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Customer { get; set; }
        public double Value { get; set; }
        public double Cash { get; set; }
        public double Paki { get; set; }

        public bool IsCash { get; set; }

    }
}
