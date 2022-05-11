using SaleManagerPro.Data;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Employees;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Seeds
{
    public static class DefualtDepartment
    {
        public static readonly AppDbContext db = new AppDbContext();
        public static readonly string DepartmentName = "الادارة العامه";
        public static readonly string DepartmentAbout= "القسم الرئيسي يتم انشاءة تلقائيا من قبل النظام لتكون كافة الاقسام تابعه له";
        public static async Task AddDefualtDepartment()
        {
            var user = db.Users.FirstOrDefault();
            var department = db.Departments.Where(u => u.Name == DepartmentName).FirstOrDefault();
            var newdepartment = new Department();
            if (department == null)
            {

                newdepartment.Name =DepartmentName;
                newdepartment.About =DepartmentAbout ;
                newdepartment.Father =0;
                newdepartment.Rate = 0;
                newdepartment.IdUser = user == null? 0 : user.IdUser;
                newdepartment.DateCreated = DateTime.Now;
                

                await db.Departments.AddAsync(newdepartment);
                await db.SaveChangesAsync();
            }

        }

        public static async Task AddDefaultPicture()
        {
            var employeeimage = db.Images.Where(u => u.Name =="DefualtEmployee").FirstOrDefault();
            if (employeeimage == null)
            {
                byte[] imagebyte = ConvertImageToBinary(Properties.Resources.DefualyEmployee);
                Images img = new Images();
                img.Image = imagebyte;
                img.Name = "DefualtEmployee";
                img.Guid = Guid.NewGuid();
                await db.Images.AddAsync(img);
                await db.SaveChangesAsync();

            }
        }

        static  Byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
