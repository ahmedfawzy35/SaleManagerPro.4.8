using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Loaners
{
    public class Loaner
    {
        [Key]
        public int IdLoaner { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }



    }
}
