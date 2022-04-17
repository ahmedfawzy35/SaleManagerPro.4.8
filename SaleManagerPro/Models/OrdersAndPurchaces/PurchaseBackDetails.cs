using SaleManagerPro.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.OrdersAndPurchaces
{
    public class PurchaseBackDetails
    {
        [Key]
        public int IdPurchaseBackDetails { get; set; }
        public int IdPurchaseBack { get; set; }
        [ForeignKey("IdPurchaseBack")]
        public virtual PurchaseBack PurchaseBack  { get; set; }

        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public float Total { get; set; }
        public double Discount { get; set; }
        public double Value { get; set; }


    }
}
