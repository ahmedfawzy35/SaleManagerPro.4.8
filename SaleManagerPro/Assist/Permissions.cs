using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Assist
{
    public static class Permissions
    {
        public static string PermessionType = "Permession";


        public static List<string> Models = ModulsName.Modules();
        public static List<string> GenrateModulePermissionsList(string module)
        {
            return new List<string>()
            {
                $"{PermessionType}.{module}.View",
                $"{PermessionType}.{module}.Creat",
                $"{PermessionType}.{module}.Edit",
                $"{PermessionType}.{module}.Delete",

            };
        }
        public static List<string> GenrateAllPermissionsList()
        {
            List<string> list = new List<string>();

            foreach (string permission in Models)
            {
                list.AddRange(GenrateModulePermissionsList(permission));
            }

            return list;

        }
        #region ارجاع وظيفه واحده لكل مديول
        public static string View(string module)
        {
            return  string.Format($"{PermessionType}.{module}.View");
        }
        public static string Creat(string module)
        {
            return  string.Format($"{PermessionType}.{module}.Creat");
        }
        public static string Edit(string module)
        {
            return  string.Format($"{PermessionType}.{module}.Edit");
        }
        public static string Delete(string module)
        {
            return  string.Format($"{PermessionType}.{module}.Delete");
        }
        #endregion
        public static class ModulsName

        {

            public static string Product = "Product";
            public static string Catogry = "Catogry";
            public static string Order = "Order";
            public static string OrderDetail = "OrderDetail";
            public static string Purchase = "Purchase";
            public static string PurchaseDetails = "PurchaseDetails";
            public static string Customer = "Customer";
            public static string Suppliers = "Suppliers";
            public static string User = "User";
            public static string Role = "Role";
            public static string Claime = "Claime";
            public static string Employee = "Employee";
            public static string Job = "Job";
            public static string Units = "Units";
            public static string ProductUnits = "ProductUnits";

            // you will add new module here as static parameter


            public static List<string> Modules()
            {

                return new List<string>
                {
                    Product, Catogry, Order,OrderDetail, Purchase, PurchaseDetails, Customer, Suppliers,User,Role,Claime,Employee,Job,Units,ProductUnits

                };

            }



        }
        public static class Products
        {
            public const string View = "Permession.Product.View";
            public const string Creat = "Permession.Product.Creat";
            public const string Edit = "Permession.Product.Edit";
            public const string Delete = "Permession.Product.Delete";
        }



    }
}
