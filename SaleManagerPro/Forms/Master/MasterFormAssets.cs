using SaleManagerPro.Forms.ProductsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.Master
{
    public static class CallFomr
    {
        public static Form Products = FormProductAddEdit.GetFormProductAddEdit;
        public static Form Catogrys = FormCatogryAddEdit.GetFormCatogryAddEdit;
        public static Form Units = FormUnitsAddEdit.GetFormUnitsAddEdit;


      public static Form GetFormByName(string name)
        {
            switch (name) {
                case "Product":
                    return Products;

                case "Catogry":
                    return Catogrys;

                default:
                    return Units;
            }
        }


}
}
