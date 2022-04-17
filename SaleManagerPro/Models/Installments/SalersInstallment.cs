using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Installments
{
    public class SalersInstallment
    {
        [Key]
        public int IdSalersInstallment { get; set; }

        public int IdInstallmentPurchase { get; set; }
        [ForeignKey("IdInstallmentPurchase")]
        public virtual InstallmentPurchase InstallmentPurchase { get; set; }
        public int Number { get; set; }
        public DateTime DateToPay { get; set; }

        public double Value { get; set; }
        public string State { get; set; }
        public DateTime DatePaied { get; set; }

    }
}
