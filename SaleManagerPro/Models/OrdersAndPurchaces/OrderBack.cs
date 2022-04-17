using SaleManagerPro.Models.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.OrdersAndPurchaces
{
    public class OrderBack
    {
        [Key]
        public int IdOrderBack { get; set; }
        public DateTime Date { get; set; }
        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer Customer { get; set; }
        public double Value { get; set; }
        public double Cash { get; set; }
        public double Paki { get; set; }

        public bool IsCash { get; set; }

    }
}
