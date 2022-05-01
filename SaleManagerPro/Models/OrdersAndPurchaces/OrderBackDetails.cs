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
    public class OrderBackDetails
    {
        [Key]
        public int IdOrderBackDetails { get; set; }
        public int IdOrderBack { get; set; }
        [ForeignKey("IdOrderBack")]
        public virtual OrderBack OrderBack { get; set; }

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
