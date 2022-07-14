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
    public class PromotionDocuments : EditPropertieswithuser
    {


        [Key]
        [DisplayName("كود الصفحه ")]

        public int IdPromotionDocuments { get; set; }
        
        [DisplayName("ترتيب الصفحه ")]

        public int PageNumber { get; set; }
        [DisplayName(" الصفحه ")]

        public byte[] Image { get; set; }

        [DisplayName("رقم الترقيه")]

        public int IdEmployeePromotion { get; set; }
        [ForeignKey("IdEmployeePromotion")]
        public virtual EmployeePromotion employeePromotion { get; set; }
    }
}
