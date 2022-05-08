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
    public class EmployeeDocumentsDetails : EditPropertieswithuser
    {


        [Key]
        [DisplayName("كود الصفحه ")]

        public int IdEmployeeDocumentsDetails { get; set; }
        
        [DisplayName("ترتيب الصفحه ")]

        public int PageNumber { get; set; }
        [DisplayName(" الصفحه ")]

        public byte[] Image { get; set; }

        [DisplayName("كود المستند")]

        public int IdEmployeeDocument { get; set; }
        [ForeignKey("IdEmployeeDocument")]
        public virtual EmployeeDocuments EmployeeDocuments { get; set; }
    }
}
