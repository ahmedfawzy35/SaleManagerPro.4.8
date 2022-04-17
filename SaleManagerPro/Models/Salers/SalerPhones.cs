using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Salers
{
    public class SalerPhones
    {
        [Key]
        public int IdCustomersPhones { get; set; }
        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Saler { get; set; }
        public string PhoneNumber { get; set; }
        public bool HaveWhatsApp { get; set; }
    }
}
