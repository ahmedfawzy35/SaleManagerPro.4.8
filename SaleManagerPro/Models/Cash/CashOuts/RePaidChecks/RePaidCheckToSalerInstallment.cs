using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.Installments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.RePaidChecks

{
    public class RePaidCheckToSalerInstallment : RePaidCheck
    {
        [Key]
        public int IdRePaidCheckToSalerInstallment { get; set; }
        public int IdSalersInstallment { get; set; }
        [ForeignKey("IdSalersInstallment")]
        public virtual SalersInstallment SalersInstallment { get; set; }



    }
}
