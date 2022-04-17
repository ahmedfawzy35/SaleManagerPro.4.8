using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Salers

{
    public class Saler
    {
        [Key]
        public int IdSaler { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double StartAccount { get; set; }

        public virtual IEnumerable<SalerPhones> Phones { get; set; }
        public virtual IEnumerable<SalerBankAccounts> BankAccounts { get; set; }

    }
}
