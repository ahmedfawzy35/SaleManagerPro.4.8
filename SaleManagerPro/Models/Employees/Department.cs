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
    public class Department: EditPropertieswithuser
    {
        // الاقسام

        [Key]
        [DisplayName("رقم القسم ")]

        public int IdDepartment { get; set; }
        [Required]
        [DisplayName("اسم القسم ")]

        public string Name { get; set; }
        [Required]
        [DisplayName("رتبة القسم ")]

        public int Father { get; set; }
        [DisplayName("القسم الرئيسي ")]

        public int Rate { get; set; }
        [DisplayName("تفاصيل القسم ")]

        public string About { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }

    }
}
