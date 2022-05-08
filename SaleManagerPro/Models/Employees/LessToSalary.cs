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
    public class LessToSalary: EditPropertieswithuser
    {
        //  الجزاءات الماليه على المرتب والخصومات المستمره لفتره لموظف واحد


        [Key]
        [DisplayName("رقم االخصم")]

        public int IdLessToSalary { get; set; }
        [Required]
        [DisplayName("اسم االخصم")]

        public string Name { get; set; }
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
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ بداية االخصم")]

        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ نهاية الخصم ")]

        public DateTime DateEnd { get; set; }
        [DisplayName("هل الاضافه ثابته")]

        public bool IsFixedSalary { get; set; }


        [DisplayName("هل الاضافه نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الخصم")]

        public decimal Persent { get; set; }

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
    }
}
