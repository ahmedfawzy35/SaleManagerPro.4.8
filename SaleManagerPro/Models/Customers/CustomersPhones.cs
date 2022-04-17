using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Customers
{
    public class CustomerPhones
    {
        [Key]
        public int IdCustomersPhones { get; set; }
        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer Customer { get; set; }
        public string PhoneNumber { get; set; }
        public bool HaveWhatsApp { get; set; }
    }
}
