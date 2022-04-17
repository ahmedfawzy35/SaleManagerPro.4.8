using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Roles
{
    public class Claime
    {
        [Key]
        public int IdClaime { get; set; }
        public string Value { get; set; }

    }
}
