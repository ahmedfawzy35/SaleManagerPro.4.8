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
    public class ProductUnits
    {
        [Key]
        [DisplayName("رقم وحدة المنتج")]
        public int IdProductUnits { get; set; }
        [DisplayName("رقم تعريفي لوحدة المستخدم")]
        public Guid Guid { get; set; }
        [DisplayName("رقم المنتج")]
        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        [DisplayName(" المنتج")]
        public virtual Product Product { get; set; }
        [DisplayName("رقم الوحده")]
        public int IdUnit { get; set; }
        [ForeignKey("IdUnit")]
        [DisplayName(" الوحده")]
        public virtual Units Units { get; set; }
        [DisplayName("الترتيب ")]
        public int Rate { get; set; }
        [DisplayName("عدد القطع ")]
        public int Count { get; set; }

        
    }
}
