using SaleManagerPro.Data;
using SaleManagerPro.Models.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Assist
{
    public class UserRoleManager
    {
        AppDbContext db = new AppDbContext();


        public List<Role> get_roles(int iduser)
        {
            return (from ur in db.UserRoles
                   join r in db.Roles on ur.IdRole equals r.IdRole
                   where ur.IdUser == iduser    
                   select r).ToList();
        }
        public List<RoleClaime> getallroleclaims()
        {
            return db.RoleClaimes.ToList();
        }
        public List<RoleClaime> getallroleclaims_role(int idrole)
        {
            return db.RoleClaimes.Where(r=>r.IdRole == idrole).ToList();
        }

        public List<Claime> getroleclaims(int idrole)
        {
           return (from rc in db.RoleClaimes
             join c in db.Claimes on rc.IdClaime equals c.IdClaime
             where rc.IdRole == idrole
             select c).ToList();
        }

        public List<Claime> getuserclaims(int iduser)
        {
            List<Claime> claims = new List<Claime>();
            foreach (var role in get_roles(iduser))
            {
                claims.AddRange(getroleclaims(role.IdRole));
            }
            return claims;
        }

        public List<Role> GetAllROles()
        {
            return db.Roles.ToList();
        }
        public List<Claime> GetAllClaimes()
        {
            return db.Claimes.ToList();
        }

        public userroledto _userrole(int iduser)
        {
            List <Role> uroles = get_roles(iduser);
            List<Role> allroles = GetAllROles();
            List<CheckBoxItem> roles = new List<CheckBoxItem>();
            userroledto userrole = new userroledto();
            string name = db.Users.Where(x => x.IdUser == iduser).FirstOrDefault().FullName;
            userrole.UserId = iduser;
            userrole.UserName =name==null ? "اسم المستخدم" :name;
            foreach (var Role in allroles)
            {
                if (uroles.Any(x=> x.IdRole == Role.IdRole))
                {
                    roles.Add(new CheckBoxItem() { Id = Role.IdRole,Value = Role.Name , IsSelected = true });
                }else
                {
                    roles.Add(new CheckBoxItem() { Id = Role.IdRole, Value = Role.Name, IsSelected = false });

                }
            }

            userrole.Roles = roles;

            return userrole;
        }
    }


    public class userroledto
    {
        [DisplayName("{رقم المستخدم")]
        public int UserId { get; set; }
        [DisplayName("{اسم المستخدم")]
        public string UserName { get; set; }
 
        public List<CheckBoxItem> Roles { get; set; }
    }
    public class CheckBoxItem
    {
        [DisplayName("{رقم ")]
        public int Id { get; set; }
        [DisplayName("الاسم")]
        public string Value { get; set; }
        [DisplayName("تم الاختيار")]
        public bool IsSelected { get; set; }
    }
    public class RolesDTO
    {
        public string Name { get; set; }
    }

    public class PemissionManageDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<CheckBoxItem> Permissions { get; set; }

    }
}
