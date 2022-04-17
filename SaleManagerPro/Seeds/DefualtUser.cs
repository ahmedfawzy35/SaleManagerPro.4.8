using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Seeds
{
    public static class DefualtUser
    {
       public static readonly AppDbContext db = new AppDbContext();

        //public static User userall = new User();
        //public static Role roleall = new Role();
        //public static UserRole userRoleall  = new UserRole();
        //public static Claime claimeall = new Claime();
        //public static RoleClaime roleclaimeall = new RoleClaime();
        public static async Task AddDefualtUser()
        {
            var _user = db.Users.Where(u => u.UserName == "Admin").FirstOrDefault();
            var user = new User();
            if (_user == null)
            {
                
                user.UserName = "Admin";
                user.Password = "123456";
                user.DateCreated = DateTime.Now;
                user.Enable = true;

                var resulat = await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
            }

        }

        public static async Task AddDefualtRole()
        {
            var _role =  db.Roles.Where(u => u.Name =="Admin" ).FirstOrDefault();
            var role = new Role();
            if (_role == null)
            {
                role.Name = "Admin";


                var resulat = await db.Roles.AddAsync(role);
                await db.SaveChangesAsync();
            }


        }

        public static async Task AddDefualtUserToRole()
        {


            var Urole = new UserRole();
            var role = db.Roles.Where(r => r.Name == "admin").FirstOrDefault();
            var user = db.Users.Where(r => r.UserName == "admin").FirstOrDefault();
            var userrole = new UserRole();
            //if(user!= null && role!= null) 
             var _userrole = db.UserRoles.Where(ur => ur.IdRole == role.IdRole && ur.IdUser == user.IdUser).FirstOrDefault();
            if (_userrole == null)
            {
                if (user != null) userrole.IdUser = user.IdUser;
                if (role != null) userrole.IdRole = role.IdRole;


                var resulat = await db.UserRoles.AddAsync(userrole);
                await db.SaveChangesAsync();

            }




        }


        public static async Task AddDefualtClaims()
            {
            var _allclaimes = db.Claimes.ToList();
            var allPermission = Permissions.GenrateAllPermissionsList();
            List<Claime> allclaims = new List<Claime>();
            List<Claime> addclaims = new List<Claime>();
            foreach (string item in allPermission)
            {
                allclaims.Add(new Claime { Value = item });
            }


            if (_allclaimes.Count < allPermission.Count)
            {
                if (_allclaimes.Count>0)
                {
                   

                    foreach (var item in allclaims)
                    {
                        if (!_allclaimes.Any(x=> x.Value== item.Value))
                        {
                            addclaims.Add(item);
                        }
                    }

                }
                else
                {
                    await db.Claimes.AddRangeAsync(allclaims);

                    await db.SaveChangesAsync();
                }



               



                await db.Claimes.AddRangeAsync(addclaims);

                await db.SaveChangesAsync();

            }


            
            }
        public static async Task  RemoveClimes(List<Claime> claimes)
        {

            foreach (var item in claimes)
            {
                db.Claimes.Remove(item);
            }
               await db.SaveChangesAsync();



          
        }
        public static async Task AddDefualtToRoleClaim()
        {
            var claims =  db.Claimes.ToList();
            var admin = db.Roles.Where(r => r.Name == "admin").FirstOrDefault();
            var _roleclaime = db.RoleClaimes.Where(rc => rc.IdRole == admin.IdRole).ToList();
            if (_roleclaime.Count <claims.Count)
            {

                List<RoleClaime> roleclaime = new List<RoleClaime>();
                if (admin != null)
                {
                    foreach (var claim in claims)
                    {
                        roleclaime.Add(new RoleClaime { IdRole = admin.IdRole, IdClaime = claim.IdClaime });
                    }
                }

                db.RoleClaimes.RemoveRange(_roleclaime);
                db.RoleClaimes.AddRange(roleclaime);
                await db.SaveChangesAsync();

            }


          

        }
    }
}
