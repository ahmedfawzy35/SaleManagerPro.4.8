using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Roles
{
    public class RoleClaime
    {
        [Key]
        public int IdRoleClaime { get; set; }
        public int IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }

        public int IdClaime { get; set; }
        [ForeignKey("IdClaime")]
        public virtual Claime Claime { get; set; }


    }
}
