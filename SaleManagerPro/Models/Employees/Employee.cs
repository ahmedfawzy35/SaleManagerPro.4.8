using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }

        public Guid Guid { get; set; }
        [Required]
        public string FullName { get; set; }

    }
}
