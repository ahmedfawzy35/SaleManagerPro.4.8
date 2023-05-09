 
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
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
    public partial class FormRoleAddEdit : Form
    {
        #region getter

        //
        private static FormRoleAddEdit RoleAddEdit;
        static void RoleAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            RoleAddEdit = null;
        }
        public static FormRoleAddEdit GetFormRoleAddEdit
        {
            get
            {
                if (RoleAddEdit == null)
                {
                    RoleAddEdit = new FormRoleAddEdit();
                    RoleAddEdit.FormClosed += new FormClosedEventHandler(RoleAddEdit_formclosed);
                }
                return RoleAddEdit;
            }
        }
        //
        #endregion
        bool isnew = true;
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        public FormRoleAddEdit()
        {
            InitializeComponent();
            if (RoleAddEdit == null) RoleAddEdit = this;

        }
        #region Methods
        private int validations()
        {

            int error = 0;
            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الصلاحيه مطلوب";
                error++;
            }

            if (error > 0)
                 MessageBox.Show($"لديك عدد {error}اخطاء" );

            return error;
        }
        private void Search()
        {
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var     Roles = db.Roles.Where(u => u.Name.Contains(search)).ToList();

            dataGridRoles.DataSource = Roles;

        }
        private void Textchange(TextBox textbox, Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        private bool IsExitsUserName()
        {
            Role role = db.Roles.Where(r=>r.Name  == textName .Text).FirstOrDefault();
            if (role != null)
                return true;
            return false;
        }



       


        private void Add()
        {
            if (!cancreat)
            {
                MessageBox.Show("غير مرخص بالاضافه");
                return;
            }
            if (validations() > 0)
            {
                return;
            }
            if (IsExitsUserName())
            {
                textName.BackColor = Color.DarkOrange;
                labeNamelError.Text = "اسم الصلاحيه موجود بالفعل";

                return;
            }
           
            var role = new Role();
            role.Name = textName .Text;
            role.DateCreated= DateTime.Now; 
            db.Roles.Add(role);
            db.SaveChanges();
             MessageBox.Show("تم انشاء الصلاحيه" );

            cleartext();
        }

        private void Edit()
        {
            if (!canedit)
            {
                MessageBox.Show("غير مرخص بالتعديل");
                cleartext();
                return;
            }
            if (string.IsNullOrEmpty(labelId.Text))
            {
                MessageBox.Show("قم باختيار الصلاحيه المراد تعديلها مجددا");
                return;
            }
            int id = int.Parse(labelId.Text);
            var role = db.Roles.Find(id);
            if (role == null)
            {
                MessageBox.Show("الصلاحيه غير موجوده");
                return;
            }
            if (validations() > 0)
            {
                return;
            }
            if (role.Name != textName .Text)
            {
                if (IsExitsUserName())
                {
                    textName.BackColor = Color.DarkOrange;
                    labeNamelError.Text = "اسم الصلاحيه موجود بالفعل";
                    return;
                }
            }
         


            role.Name = textName .Text;
            role.IsEdit = true;
            role.DateEdit   = DateTime.Now;
            db.Roles.Update(role);

            db.SaveChanges();
             MessageBox.Show("تم تعديل الصلاحيه" );


            cleartext();

        }

        void cleartext()
        {
            textName .Text = "";
            btnSave.Text = "إضافه";
            labelId.Text = "";
            isnew = true;
        }

        #endregion

        #region events
        private void FormUserAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Role));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Role));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Role));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Role));
            if (!canview)
            {
                dataGridRoles.Visible = false;
            }
            Search();
            #endregion


        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Textchange(textName, labeNamelError);
            Search();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isnew)
            {
                Add();
            }
            else
            {
                Edit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridRoles.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridRoles.CurrentRow.Cells[0].Value.ToString());
                //FormRoleClaimManager frm = FormRoleClaimManager.GetFormRoleClaimManager;
                //frm.IdRole = id;
                //frm.RoleName = dataGridRoles.CurrentRow.Cells[1].Value.ToString();
                FormRoleClaimManager.GetFormRoleClaimManager.IdRole = id;
                FormRoleClaimManager.GetFormRoleClaimManager.RoleName = dataGridRoles.CurrentRow.Cells[1].Value.ToString();
                FormRoleClaimManager.GetFormRoleClaimManager.getdata();
                
                Master.MasterForm.GetFormMasterForm.showform("إدارة الاجراءات الصلاحيه", FormRoleClaimManager.GetFormRoleClaimManager);


            }
            else
            {
                MessageBox.Show("قم بإختيار صلاحيه");
            }
        }

        private void تعديلالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridRoles.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridRoles.CurrentRow.Cells[0].Value.ToString());
                var role = db.Roles.Find(id);

                labelId.Text = id.ToString();
                textName .Text = role.Name;
                btnSave.Text = "تعديل";
                isnew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار صلاحيه");
            }
        }

        private void تعديلالصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حذفالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                 MessageBox.Show("غير مصرح بالحذف" );
                return;
            }
            if (!string.IsNullOrEmpty(dataGridRoles.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridRoles.CurrentRow.Cells[0].Value.ToString());
                var role = db.Roles.Find(id);
                if (MessageBox.Show("تأكيد حذف الصلاحيه") ==DialogResult.OK)
                {
                    try
                    {
                        db.Roles.Remove(role);
                        db.SaveChanges();
                        Search();
                    }
                    catch (Exception)
                    {

                         MessageBox.Show("لايمكن حذف الصلاحيه" );
                    }
                }

            }
            else
            {
                MessageBox.Show("قم بإختيار صلاحيه");
            }
        }


        #endregion
    }
}
