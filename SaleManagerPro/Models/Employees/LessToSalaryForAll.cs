using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Employees
{
    public class LessToSalaryForAll: EditPropertieswithuser
    {
        //  الحوافز الماليه على المرتب والخصومات المستمره لفتره

        [Key]
        public int IdLessToSalaryForAll { get; set; }
        [Required]
        public string Name { get; set; }

        public string Details { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Value { get; set; }
        [DataType(DataType.Date)]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [Required]

        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required]

        public DateTime DateEnd { get; set; }


    }
}
