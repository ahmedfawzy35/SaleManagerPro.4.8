using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
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
        public int IdJob { get; set; }
        [Required]

        public string Name { get; set; }
        public string Details { get; set; }
    }
}
