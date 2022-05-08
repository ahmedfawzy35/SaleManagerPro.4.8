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
    public class AddToSalary : EditPropertieswithuser
    {
        //  الحوافز الشهريه على المرتب لموظف واحد
        [Key]
        [DisplayName("رقم الاضافه")]

        public int IdAddToSalary { get; set; }
        [Required]
        [DisplayName("اسم الاضافه")]

        public string Name { get; set; }
        [DisplayName("تفاصيل الاضافه")]

        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("قيمة الاضافه")]

        public double Value { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تارخ اضافة الاضافه")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ بدأ الاضافه")]

        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ انتهاء الاضافه")]

        public DateTime DateEnd { get; set; }
        [DisplayName("هل الاضافه ثابته")]

        public bool IsFixedSalary { get; set; }


        [DisplayName("هل الاضافه نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الاضافه")]

        public decimal Persent { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        [DisplayName(" الموظف")]

        public virtual Employee Employee { get; set; }
    }
}
