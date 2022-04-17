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
    public class CustomersInstallment
    {
        [Key]
        public int IdCustomersInstallment { get; set; }

        public int IdInstallmentOrder { get; set; }
        [ForeignKey("IdInstallmentOrder")]
        public virtual InstallmentOrder InstallmentOrder { get; set; }
        public int Number { get; set; }
        public DateTime DateToPay { get; set; }

        public double Value { get; set; }
        public string State { get; set; }
        public DateTime DatePaied { get; set; }

    }
}
