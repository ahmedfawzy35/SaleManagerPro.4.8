using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Roles
{
    public class Role: EditProperties
    {
        [Key]
        [DisplayName("{رقم الصلاحيه")]

        public int IdRole { get; set; }
        [DisplayName("{اسم الصلاحيه ")]

        public string Name { get; set; }
    }
}
