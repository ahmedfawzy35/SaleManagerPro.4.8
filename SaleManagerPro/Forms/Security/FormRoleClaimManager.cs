using SaleManagerPro.Assist;
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
    public partial class FormRoleClaimManager : Form
    {

        #region getter

        //
        private static FormRoleClaimManager RoleClaimManager;

        static void RoleClaimManager_formclosed(object sender, FormClosedEventArgs e)
        {
            RoleClaimManager = null;
        }
        public static FormRoleClaimManager GetFormRoleClaimManager
        {
            get
            {
                if (RoleClaimManager == null)
                {
                    RoleClaimManager = new FormRoleClaimManager();
                    RoleClaimManager.FormClosed += new FormClosedEventHandler(RoleClaimManager_formclosed);
                }
                return RoleClaimManager;
            }
        }
        //
        #endregion
        int x = 10; int y = 40;

        public int IdRole { get; set; }
        private UserRoleManager rolemanager = new UserRoleManager();
        public string RoleName = "";
        public List<Claime> RoleClaimesList = new List<Claime>();
        public List<Claime> AllClaimesList = new List<Claime>();
        public List<RoleClaime> AllRoleClaimesList = new List<RoleClaime>();
        public List<RoleClaime> AllRoleClaimesList_forrole = new List<RoleClaime>();
        public FormRoleClaimManager()
        {
            InitializeComponent();
            if (RoleClaimManager == null) RoleClaimManager = this;

        }

        private void FormRoleClaimManager_Load(object sender, EventArgs e)
        {
          //  IdRole = 1;
            getdata();
            lbl_rolename.Text = RoleName;
            design_form();
          

        }

        public void getdata()
        {
            RoleClaimesList = rolemanager.getroleclaims(IdRole);
            AllClaimesList = rolemanager.GetAllClaimes();
            AllRoleClaimesList = rolemanager.getallroleclaims();
            AllRoleClaimesList_forrole = rolemanager.getallroleclaims_role(IdRole);
        }
        void setlocation(int row , int coulmn)
        {
            if ( coulmn == 1 )
            {
                x = 10;
            }
            else if ( coulmn > 1)
            {
                x = 10+ ((coulmn -1)*260);
            }

            if (row == 1)
            {
                y = 40;
            }
            else if (row > 1)
            {
                y  = 40+((row - 1)*260);
            }

        }
        private void design_form()
        {

             int row = 0,coulmn = 0; 
            for (int i  = 0; i<Assist.Permissions.Models.Count;i++)
            {

                coulmn++;
                if (coulmn == 7) coulmn = 1;
                if (coulmn == 1) row++;

                setlocation(row,coulmn);


                panel1.Controls.Add(new ModelRoleCard() { ModelRoleName = Assist.Permissions.Models[i], Location = new Point(x, y) ,_IdROle = IdRole});

            }
        }
        private void modelRoleCard2_Load(object sender, EventArgs e)
        {

        }
    }
}
