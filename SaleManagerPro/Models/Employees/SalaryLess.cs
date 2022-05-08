using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Employees
{
    public class SalaryLess: EditPropertieswithuser
    {
        //  الجزاءات الماليه على المرتب والخصومات مره واحده


        [Key]
        [DisplayName("رقم االخصم")]

        public int IdSalaryLess { get; set; }
        [DisplayName("تفاصيل االخصم")]

        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("قيمة االخصم")]

        public double Value { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تسجيل االخصم")]

        public DateTime Date { get; set; }
        [DisplayName("هل الخصم نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الخصم")]

        public decimal Persent { get; set; }
        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }

    }
}
