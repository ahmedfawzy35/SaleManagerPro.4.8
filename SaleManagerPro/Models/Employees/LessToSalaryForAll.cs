using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Employees
{
    public class LessToSalaryForAll: EditPropertieswithuser
    {
        //  الحوافز الماليه على المرتب والخصومات المستمره لفتره لجميع الموظفين

        [Key]
        [DisplayName("رقم االخصم")]

        public int IdLessToSalaryForAll { get; set; }
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
        [DisplayName("تاريخ تسجيل االخصم")]


        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ بداية االخصم")]


        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ نهاية االخصم")]


        public DateTime DateEnd { get; set; }
        [DisplayName("هل الخصم ثابته")]

        public bool IsFixedSalary { get; set; }


        [DisplayName("هل الخصم نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الخصم")]

        public decimal Persent { get; set; }

    }
}
