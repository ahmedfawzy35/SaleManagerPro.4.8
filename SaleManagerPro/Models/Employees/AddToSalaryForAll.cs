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
    public class AddToSalaryForAll: EditPropertieswithuser
    {
        // الحوافز الشهريه والاضافات لجميع العاملين

        [Key]
        [DisplayName("  رقم الاضافه")]

        public int IdAddToSalaryForAll { get; set; }
        [Required]
        [DisplayName("  اسم الاضافه")]

        public string Name { get; set; }
        [DisplayName("  تفاصيل الاضافه")]


        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("  قيمة الاضافه")]

        public double Value { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("  تاريخ تسجيل الاضافه")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("  تاريخ بداية الاضافه")]

        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("  تاريخ نهاية الاضافه")]

        public DateTime DateEnd { get; set; }
        [DisplayName("هل الاضافه ثابته")]

        public bool IsFixedSalary { get; set; }


        [DisplayName("هل الاضافه نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الاضافه")]

        public decimal Persent { get; set; }

    }
}
