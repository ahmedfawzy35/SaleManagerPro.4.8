using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Employees
{
    public class JobDegree : EditPropertieswithuser
    {


        // التصنيف او الدرجة الوظيفيه


        [Key]
        public int IdGobDegree { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
