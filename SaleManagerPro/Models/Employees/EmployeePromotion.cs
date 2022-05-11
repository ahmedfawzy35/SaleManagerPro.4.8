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
    public class EmployeePromotion: EditPropertieswithuser
    {
        //الترقيات


        [Key]
        [DisplayName("رقم الترقيه")]

        public int IdEmployeePromotion { get; set; }
        [DisplayName("تفاصيل الترقيه")]

        public string Details { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تسجيل الترقيه")]

        public DateTime Date { get; set; }

         [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تطبيق الترقيه")]

        public DateTime DateStart { get; set; }


        [Required]

        [DataType(DataType.Currency)]
        [DisplayName("الزياده على الاساسي")]

        public double AddToSalary { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
        [DisplayName("رقم الدرجة المالبه")]

        public int IdFinancialDegree { get; set; }
        [ForeignKey("IdFinancialDegree")]
        public virtual FinancialDegree FinancialDegree { get; set; }
        [DisplayName("رقم الدرجه الاداريه")]

        public int IdGobDegree { get; set; }
        [ForeignKey("IdGobDegree")]
        [DisplayName(" الدرجه الاداريه")]

        public virtual JobDegree JobDegree { get; set; }

    }
}
