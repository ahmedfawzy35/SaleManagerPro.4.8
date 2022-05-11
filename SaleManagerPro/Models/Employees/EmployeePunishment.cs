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
    public class EmployeePunishment: EditPropertieswithuser
    {
        // الجزاءات والعقوبات 

        [Key]
        [DisplayName("رقم الجزاء")]

        public int IdEmployeePunishment { get; set; }
        [DisplayName("تفاصيل الجزاء")]

        public string Details { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تسجيل الجزاء")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تنفيذ الجزاء")]

        public DateTime DateStart { get; set; }
        
        [Required]

        [DataType(DataType.Currency)]
        [DisplayName("الخصم من الاساسي")]

        public double LessFromSalary { get; set; }
        [Required]
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
        [DisplayName("رقم الدرجه الماله")]

        public int IdFinancialDegree { get; set; }
        [ForeignKey("IdFinancialDegree")]
        public virtual FinancialDegree FinancialDegree { get; set; }
        [DisplayName("رقم الدرجه الاداريه")]

        public int IdGobDegree { get; set; }
        [ForeignKey("IdGobDegree")]
        public virtual JobDegree JobDegree { get; set; }

    }
}
