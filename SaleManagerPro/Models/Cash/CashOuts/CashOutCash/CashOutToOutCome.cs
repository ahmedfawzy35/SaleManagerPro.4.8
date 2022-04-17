﻿using SaleManagerPro.Assist;
using SaleManagerPro.Models.Customers;
using SaleManagerPro.Models.InComesAndOutComes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Cash.CashOuts.CashOutCash
{
    public class CashOutToOutCome : CashTo
    {
        [Key]
        public int IdCashOutToOutCome { get; set; }
        public int IdOutComeItem { get; set; }
        [ForeignKey("IdOutComeItem")]
        public virtual OutComeItem OutComeItem { get; set; }

       

    }
}
