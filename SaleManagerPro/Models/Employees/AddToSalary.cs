using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Employees
{
    public class AddToSalary : EditPropertieswithuser
    {
        // الحوافز الشهريه على المرتب
        [Key]
        public int IdAddToSalary { get; set; }
        [Required]
        public string Name { get; set; }

        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Value { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateEnd { get; set; }

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
    }
}
