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
    public class FinancialDegree: EditPropertieswithuser
    {
        //الدرجات الماليه
        [Key]
        [DisplayName("رقم الدرجه الماليه")]

        public int IdFinancialDegree { get; set; }
        [Required]
        [DisplayName("الاسم")]

        public string Nmae { get; set; }
        [DisplayName(" التفاصيل ")]

        public string Details { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }

    }
}
