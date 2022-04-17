using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Salers
{
    public class SalerBankAccounts
    {
        [Key]
        public int Id { get; set; }
        public int IdSaler { get; set; }
        [ForeignKey("IdSaler")]
        public virtual Saler Saler { get; set; }
        public string BankName { get; set; }
        public string BankAccuntNumber { get; set; }
    }
}
