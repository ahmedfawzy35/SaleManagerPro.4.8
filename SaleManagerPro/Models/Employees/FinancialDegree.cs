using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
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
        public int IdFinancialDegree { get; set; }
        [Required]
        public string Nmae { get; set; }
    }
}
