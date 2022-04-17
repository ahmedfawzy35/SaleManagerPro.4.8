using SaleManagerPro.Assist;
using System;
using System.Collections.Generic;
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
        public int IdProduct { get; set; }
        public Guid guid { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public double LastPurchasePrice { get; set; }

        public int LimitInStok { get; set; }
        public int StartStock { get; set; }
        public int IdCatogry { get; set; }
        [ForeignKey("IdCatogry")]
        public virtual Catogry Catogry { get; set; }

        public virtual IEnumerable<ProductUnits> Units { get; set; }

    }
}
