using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.InComesAndOutComes
{
    public class InComeItem
    {
        [Key]
        public int IdInComeItem { get; set; }
        public string Name { get; set; }    
        public string Details { get; set; }  
        

    }
}
