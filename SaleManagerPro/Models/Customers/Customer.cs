using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Customers
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double StartAccount { get; set; }

        public virtual IEnumerable<CustomerPhones> Phones { get; set; }
        public virtual IEnumerable<CustomerBankAccounts> BankAccounts { get; set; }

    }
}
