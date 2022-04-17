using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.Security
{
    public partial class FormUserRoleManager : Form
    {
        public static  UserRoleManager roleManager= new UserRoleManager();
 
        public userroledto userroled = roleManager._userrole(Properties.Settings.Default.id_user_edit_roles);
        AppDbContext db = new AppDbContext();
        List<UserRole> NewUserRoles = new List<UserRole>();
        List<UserRole> startUserRoles = new List<UserRole>();

        public FormUserRoleManager()
        {
            InitializeComponent();
        }

        private void FormUserRoleManager_Load(object sender, EventArgs e)
        {
            dataGridRoles.DataSource = userroled.Roles;
            dataGridRoles.Columns[0].Visible = false;
            lblName.Text = userroled.UserName.ToString();
            lblId.Text = userroled.UserId.ToString();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
              

                startUserRoles = db.UserRoles.Where(x => x.IdUser == userroled.UserId).ToList();
                db.UserRoles.RemoveRange(startUserRoles);

                foreach (DataGridViewRow row in dataGridRoles.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[2].Value))
                    {
                        int idrole = int.Parse(row.Cells[0].Value.ToString());
                        NewUserRoles.Add(new UserRole() { IdRole = idrole, IdUser = userroled.UserId });
                    }
                }
               
                db.UserRoles.AddRange(NewUserRoles);
                db.SaveChanges();
                MessageBox.Show("done");

            }
            catch (Exception ex)
            {

                throw;
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridRoles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
