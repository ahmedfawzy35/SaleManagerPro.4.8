using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Assist
{
    public static class Permissions
    {
        public static string PermessionType = "التصريح";


        public static List<string> Models = ModulsName.Modules();
        public static List<string> GenrateModulePermissionsList(string module)
        {
            return new List<string>()
            {
                $"{PermessionType}.بعرض.{module}",
                $"{PermessionType}.بإضافة.{module}",
                $"{PermessionType}.بتعديل.{module}",
                $"{PermessionType}.بحذف.{module}",

            };
        }
        public static List<string> GenrateAllPermissionsList()
        {
            List<string> list = new List<string>();

            foreach (string model in Models)
            {
                list.AddRange(GenrateModulePermissionsList(model));
            }

            return list;

        }
        #region ارجاع وظيفه واحده لكل مديول
        public static string View(string module)
        {
            return  string.Format($"{PermessionType}.بعرض.{module}");
        }
        public static string Creat(string module)
        {
            return  string.Format($"{PermessionType}.بإضافة.{module}");
        }
        public static string Edit(string module)
        {
            return  string.Format($"{PermessionType}.بتعديل.{module}");
        }
        public static string Delete(string module)
        {
            return  string.Format($"{PermessionType}.بحذف.{module}");
        }
        #endregion
        public static class ModulsName

        {

            public static string Product = "المنتجات";
            public static string Catogry = "الاصناف";
            public static string Order = "فواتير البيع";
            //public static string OrderDetail = "OrderDetail";
            public static string Purchase = "فواتير الشراء";
            //public static string PurchaseDetails = "PurchaseDetails";
            public static string Customer = "العملاء";
            public static string Suppliers = "الموردين";
            public static string User = "المستخدمين";
            public static string Role = "الصلاحيات";
            public static string Claime = "الإجراءات";
            public static string Employee = "الموظفين";
            public static string Job = "الوظائف";
            public static string Units = "الوحدات";
            public static string Department = "الاقسام";
            public static string FinancialDegree = "الدرجات الماليه";
            public static string JobDegree = "الدرجات الوظيفيه";
            public static string EmployeeDocuments = "مستندات الموظفين";

            //public static string ProductUnits = "ProductUnits";

            // you will add new module here as static parameter


            public static List<string> Modules()
            {

                return new List<string>
                {
                    Product, Catogry, Order, Purchase, Customer, Suppliers,User,Role,Claime,Employee,Job,Units,JobDegree,FinancialDegree,Department,
                    EmployeeDocuments

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
