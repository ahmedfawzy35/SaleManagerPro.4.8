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
    public class EmployeeDetails : EditPropertieswithuser
    {
        // بيانات الموظفين

        [Key]
        public int IdEmployeeDetails { get; set; }

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public string NationalNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string IsMaried { get; set; }
        public double Salary { get; set; }

        public string ScientificDegree { get; set; }
        public string EducationalQualification { get; set; }

        public int IdDepartment { get; set; }
        [ForeignKey("IdDepartment")]
        public virtual Department Department { get; set; }

        public int IdJob { get; set; }
        [ForeignKey("IdJob")]
        public virtual Job Job { get; set; }

        public int IdGobDegree { get; set; }
        [ForeignKey("IdGobDegree")]
        public virtual JobDegree JobDegree { get; set; }

        public int IdFinancialDegree { get; set; }
        [ForeignKey("IdFinancialDegree")]
        public virtual FinancialDegree FinancialDegree { get; set; }

        public int IdImages { get; set; }
        [ForeignKey("IdImages")]
        public virtual Images Images { get; set; }
        //IdImages

        //public Job Job { get; set; }
        //public JobDegree JobDegree { get; set; }
    }
}
