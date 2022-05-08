using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("كود تفاصيل الموظف")]

        public int IdEmployeeDetails { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }
        [Required]
        [DisplayName("تاريخ التعيين")]

        public DateTime DateStart { get; set; }
        [DisplayName("الرقم القومي")]

        public string NationalNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ الميلاد")]

        public DateTime DateOfBirth { get; set; }
        [Required]
        [DisplayName("العنوان")]

        public string Adress { get; set; }
        [Required]
        [DisplayName("رقم الهاتف")]

        public string Phone { get; set; }
        [DisplayName("النوع ")]

        public string Gender { get; set; }
        [DisplayName("الحاله الاجتماعيه")]

        public string IsMaried { get; set; }
      
        [DisplayName("الدرجه العلميه")]

        public string ScientificDegree { get; set; }
        [DisplayName("المؤهل الدراسي")]

        public string EducationalQualification { get; set; }


    }
}
