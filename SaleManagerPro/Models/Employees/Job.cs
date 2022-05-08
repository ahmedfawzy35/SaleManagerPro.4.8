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
    public class Job: EditPropertieswithuser
    {
        //الوظائف


        [Key]
        [DisplayName("رقم الوظيفه ")]

        public int IdJob { get; set; }
        [Required]
        [DisplayName("الاسم  ")]

        public string Name { get; set; }
        [DisplayName(" التفاصيل ")]

        public string Details { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }

    }
}
