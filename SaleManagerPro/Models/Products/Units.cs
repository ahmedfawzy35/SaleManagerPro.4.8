using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Products
{
    public class Units
    {
        [Key]
        [DisplayName("رقم الوحده")]
        public int IdUnit { get; set; }
        [DisplayName("اسم المستخدم")]
        public string Name { get; set; }
        [DisplayName("معلومات الوحده")]
        public string Details { get; set; }
        //public int Root { get; set; }
        //public int Rate { get; set; }
        //public string Count { get; set; }
    }
}
