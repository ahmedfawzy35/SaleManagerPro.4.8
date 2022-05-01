using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Products
{
    public class ProductEquation : EditPropertieswithuser
    {
        [DisplayName("رقم التسويه")]
        [Key]
        public int IdProductEquation { get; set; }
        [DisplayName("تاريخ التسويه")]

        public DateTime Date { get; set; }
        [DisplayName("نوع التسويه")]

        public string Type { get; set; }
        [DisplayName("عدد المنتجات")]

        public int Count { get; set; }

        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }
    }



}
