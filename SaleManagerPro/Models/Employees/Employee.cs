using SaleManagerPro.Assist;
using SaleManagerPro.Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models
{
    public class Employee 
    {
        [Key]
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [DisplayName("كود الموظف")]

        public Guid Guid { get; set; }
        [Required]
        [DisplayName("الاسم الكامل")]

        public string FullName { get; set; }

        [DisplayName("المرتب الاساسي")]

        public double Salary { get; set; }
        [DisplayName("القسم")]

        public int IdDepartment { get; set; }
        [ForeignKey("IdDepartment")]
        public virtual Department Department { get; set; }
        [DisplayName("الوظيفه")]

        public int IdJob { get; set; }
        [ForeignKey("IdJob")]
        public virtual Job Job { get; set; }
        [DisplayName("الدرجه الوظيفيه")]

        public int IdJobDegree { get; set; }
        [ForeignKey("IdJobDegree")]
        public virtual JobDegree JobDegree { get; set; }
        [DisplayName("الدرجه الماليه")]

        public int IdFinancialDegree { get; set; }
        [ForeignKey("IdFinancialDegree")]
        public virtual FinancialDegree FinancialDegree { get; set; }
        [DisplayName("صورة الموظف")]

        public int IdImages { get; set; }
        public bool ISOnWork { get; set; }
        public double StartSalary { get; set; }
        public int StartDepartment { get; set; }
        public int StartJob { get; set; }
        public int StartJobDegree { get; set; }
        public int StartFinancialDegree { get; set; }
        [ForeignKey("IdImages")]
        public virtual Images Images { get; set; }
        public virtual IEnumerable<AddToSalary> AddsToSalary { get; set; }
        public virtual IEnumerable<LessToSalary> LessesToSalary { get; set; }
        public virtual IEnumerable<SalaryAdd> SalaryAdds { get; set; }
        public virtual IEnumerable<SalaryLess> SalaryLesses { get; set; }
        public virtual IEnumerable<EmployeePromotion> EmployeePromotions { get; set; }
        public virtual IEnumerable<EmployeePunishment> EmployeePunishments { get; set; }
        public virtual IEnumerable<EmployeeDocuments> EmployeeDocuments { get; set; }
        public virtual IEnumerable<EmployeeTransfer> EmployeeTransfers { get; set; }


    }
}
