using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Products
{
    public class Catogry : EditPropertieswithuser
    {
        [Key]
        [DisplayName("{رقم التصنيف")]
        public int IdCatogry { get; set; }
        [DisplayName("{اسم التصنيف")]

        public string Name { get; set; }
        [DisplayName("التفاصيل")]

        public string Details { get; set; }
    }
}
