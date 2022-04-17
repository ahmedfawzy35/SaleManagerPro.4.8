using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models
{
    public class User: EditProperties
    {
        [Key]
        [DisplayName("رقم المستخدم")]
        public int IdUser { get; set; }
        [DisplayName("اسم المستخدم")]
        public string UserName { get; set; }
        [DisplayName("الاسم الكامل")]
        public string FullName { get; set; }
        [DisplayName("كلمة المرور")]
        public string Password { get; set; }
        [DisplayName("التفعيل")]
        public bool Enable { get; set; }




    }
}
