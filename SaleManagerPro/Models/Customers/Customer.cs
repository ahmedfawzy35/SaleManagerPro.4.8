using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Customers
{
    public class Customer
    {
        [Key]
        [DisplayName("رقم العميل")]
        public int IdCustomer { get; set; }
        [DisplayName("اسم العميل")]
        public string Name { get; set; }
        [DisplayName(" العنوان")]
        public string Adress { get; set; }
        [DisplayName("الرصيد المبدئي")]
        public double StartAccount { get; set; }
        [DisplayName("اخفاء في الفواتير")]

        public bool  HideInOrders { get; set; }
        public virtual IEnumerable<CustomerPhones> Phones { get; set; }

        #region adds
        public virtual IEnumerable<OrdersAndPurchaces.Order> Orders { get; set; }
        public virtual IEnumerable<Cash.CashOuts.CashOutCash.CashOutToCus> CashOutToCus { get; set; }
        public virtual IEnumerable<Cash.CashOuts.CashOutCash.CashOutToCusInstallment> CashOutToCusInstallment { get; set; }
        public virtual IEnumerable<Cash.CashOuts.CashOutByCheck.CashOutToCusByCheck> CashOutToCusByCheck { get; set; }
        public virtual IEnumerable<Cash.CashOuts.CashOutByCheck.CashOutToCusInstallmentByCheck> CashOutToCusInstallmentByCheck { get; set; }
        #endregion

        #region minas

        public virtual IEnumerable<OrdersAndPurchaces.OrderBack> OrdersBack { get; set; }
        public virtual IEnumerable<Cash.CashIns.CashInCash.CashInFromCus> CashInFromCus { get; set; }
        public virtual IEnumerable<Cash.CashIns.CashInCash.CashInFromSalerInstallment> CashInFromSalerInstallment { get; set; }
        public virtual IEnumerable<Cash.CashIns.CashInByCheck.CashInFromCusByCheck> CashInFromCusByCheck { get; set; }
        public virtual IEnumerable<Cash.CashIns.CashInByCheck.CashInFromCusInstallmentByCheck> CashInFromCusInstallmentByCheck { get; set; }

        #endregion

       

        public virtual IEnumerable<CustomerBankAccounts> BankAccounts { get; set; }

      
    }

  
}
