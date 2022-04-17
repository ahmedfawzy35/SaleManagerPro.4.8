using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
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
        public int IdDepartment { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public int Rate { get; set; }

        public int Root { get; set; }
        public string About { get; set; }
    }
}
