using CustomControls.MessageBox;
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
            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الصلاحيه مطلوب";
                error++;
            }

            if (error > 0)
                CustomMessageBox.show($"لديك عدد {error}اخطاء", CustomMessageBox.enmType.Error);

            return error;
        }
        private void Search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;

            var     Roles = db.Roles.Where(u => u.Name.Contains(search)).ToList();

            dataGridRoles.DataSource = Roles;

        }
        private void Textchange(CustomControls.Controls.RJTextBox textbox, Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        private bool IsExitsUserName()
        {
            Role role = db.Roles.Where(r=>r.Name  == textName.Texts).FirstOrDefault();
            if (role != null)
                return true;
            return false;
        }



       


        private void Add()
        {
            if (!cancreat)
            {
                CustomMessageBox.dialog("غير مرخص بالاضافه");
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
            role.Name = textName.Texts;
            role.DateCreated= DateTime.Now; 
            db.Roles.Add(role);
            db.SaveChanges();
            CustomMessageBox.show("تم انشاء الصلاحيه", CustomMessageBox.enmType.Success);

            cleartext();
        }

        private void Edit()
        {
            if (!canedit)
            {
                CustomMessageBox.dialog("غير مرخص بالتعديل");
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
            if (role.Name != textName.Texts)
            {
                if (IsExitsUserName())
                {
                    textName.BackColor = Color.DarkOrange;
                    labeNamelError.Text = "اسم الصلاحيه موجود بالفعل";
                    return;
                }
            }
         


            role.Name = textName.Texts;
            role.IsEdit = true;
            role.DateEdit   = DateTime.Now;
            db.Roles.Update(role);

            db.SaveChanges();
            CustomMessageBox.show("تم تعديل الصلاحيه", CustomMessageBox.enmType.Success);


            cleartext();

        }

        void cleartext()
        {
            textName.Texts = "";
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

        private void textName__TextChanged(object sender, EventArgs e)
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
                textName.Texts = role.Name;
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
                CustomMessageBox.show("غير مصرح بالحذف", CustomMessageBox.enmType.Error);
                return;
            }
            if (!string.IsNullOrEmpty(dataGridRoles.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridRoles.CurrentRow.Cells[0].Value.ToString());
                var role = db.Roles.Find(id);
                if (CustomMessageBox.dialog("تأكيد حذف الصلاحيه") ==DialogResult.OK)
                {
                    try
                    {
                        db.Roles.Remove(role);
                        db.SaveChanges();
                        Search();
                    }
                    catch (Exception)
                    {

                        CustomMessageBox.show("لايمكن حذف الصلاحيه", CustomMessageBox.enmType.Error);
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
