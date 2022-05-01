using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Models.Products
{
    public class Product: EditPropertieswithuser
    {
        [Key]
        [DisplayName("رقم المنتج")]

        public int IdProduct { get; set; }
        [DisplayName("كود  المنتج")]

        public Guid guid { get; set; }
        [DisplayName("اسم المنتج")]

        public string Name { get; set; }
        [DisplayName("سعر البيع")]


        public double Price { get; set; }
        [DisplayName("اخر سعر شراء")]

        public double LastPurchasePrice { get; set; }
        [DisplayName("اخفاء في الفواتير")]

        public bool HideInOrders { get; set; }
        [DisplayName("حد المخزون")]

        public int LimitInStok { get; set; }
        [DisplayName("رصيد البدايه")]

        public int StartStock { get; set; }
        public int IdCatogry { get; set; }
        [ForeignKey("IdCatogry")]
        public virtual Catogry Catogry { get; set; }

        public virtual IEnumerable<OrdersAndPurchaces.OrderDetails> Orders { get; set; }
        public virtual IEnumerable<OrdersAndPurchaces.OrderBackDetails> OrdersBak { get; set; }
        public virtual IEnumerable<OrdersAndPurchaces.PurchaseDetails> Purchase { get; set; }
        public virtual IEnumerable<OrdersAndPurchaces.PurchaseBackDetails> PurchaseBack { get; set; }
        public virtual IEnumerable<ProductEquation> ProductEquations { get; set; }
        public virtual IEnumerable<ProductUnits> Units { get; set; }

    }
}
