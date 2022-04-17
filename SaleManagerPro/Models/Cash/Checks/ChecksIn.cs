using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.Checks
{
    public class ChecksIn
    {
        //public int CashIdChecksIn { get; set; }
        [Key]
        public string CheckNumber { get; set; }
        public string CheckBank { get; set; }
        public string CheckAccount { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateToPay { get; set; }
        public string State { get; set; }
        public bool IsRePaid { get; set; }


    }
}
