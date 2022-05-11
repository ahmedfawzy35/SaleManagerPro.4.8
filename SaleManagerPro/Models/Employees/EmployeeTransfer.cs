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
    public class EmployeeTransfer : EditPropertieswithuser
    {
        //عمليات نق الموظفين بين الاقسام


        [Key]
        [DisplayName("رقم قرار النقل")]

        public int IdEmployeeTransfer { get; set; }
        [DisplayName("تفاصيل القرار")]

        public string Details { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تسجيل القرار")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("تاريخ تطبيق النقل")]

        public DateTime DateStart { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [DisplayName("الوظيفه")]

        public int IdJob { get; set; }
        [ForeignKey("IdJob")]
        public virtual Job Job { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
    }
}
