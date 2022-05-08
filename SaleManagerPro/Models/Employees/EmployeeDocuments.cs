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
    public class EmployeeDocuments : EditPropertieswithuser
    {
        // مستندات الموظف


        [Key]
        [DisplayName("رقم المستند ")]

        public int IdEmployeeDocument { get; set; }
        [Required]
        [DisplayName("اسم المستند")]

        public string Name { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public virtual Employee Employee { get; set; }

        public virtual IEnumerable<EmployeeDocumentsDetails> Pages { get; set; }
    }
}
