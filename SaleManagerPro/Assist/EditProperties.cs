using SaleManagerPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Assist
{
    public class EditProperties
    {
        [DisplayName("تم التعديل")]

        public bool IsEdit { get; set; }
        [DisplayName("تاريخ التعديل")]

        public DateTime DateEdit { get; set; }
        [DisplayName("تاريخ الانشاء")]

        public DateTime DateCreated { get; set; }

    }

    public class EditPropertieswithuser
    {
        [DisplayName("تم التعديل")]

        public bool IsEdit { get; set; }
        [DisplayName("تاريخ التعديل")]

        public DateTime DateEdit { get; set; }
        [DisplayName("تاريخ الانشاء")]

        public DateTime DateCreated { get; set; }
        [DisplayName("رقم اخر مستخدم")]

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        [DisplayName("اخر مستخدم")]

        public virtual User User { get; set; }



    }
}
