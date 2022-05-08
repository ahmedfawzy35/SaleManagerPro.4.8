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
    public class SalaryAdd: EditPropertieswithuser
    {
        //  الحوافز الماليه على المرتب  لمره واحده لموظف واحد


        [Key]
        [DisplayName("  رقم الاضافه")]

        public int IdSalaryAdd { get; set; }
        [DisplayName("  تفاصيل الاضافه")]

        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("  قيمة الاضافه")]

        public double Value { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("  تاريخ التسجيل")]

        public DateTime Date { get; set; }
        [DisplayName("هل الاضافه نسبه")]

        public bool IsPersent { get; set; }
        [DisplayName("  نسبه الاضافه")]

        public decimal Persent { get; set; }
        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
    }
}
