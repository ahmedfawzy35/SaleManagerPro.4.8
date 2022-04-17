using CustomControls.MessageBox;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
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
    public partial class FormUserAddEdit : Form
    {
        #region getter

        //
        private static FormUserAddEdit UserAddEdit;
        static void UserAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            UserAddEdit = null;
        }
        public static FormUserAddEdit GetFormUserAddEdit
        {
            get
            {
                if (UserAddEdit == null)
                {
                    UserAddEdit = new FormUserAddEdit();
                    UserAddEdit.FormClosed += new FormClosedEventHandler(UserAddEdit_formclosed);
                }
                return UserAddEdit;
            }
        }
        //
        #endregion
        bool isnew = true;
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;

    

        public FormUserAddEdit()
        {
            InitializeComponent();
            if (UserAddEdit == null) UserAddEdit = this;

        }

        #region Methods
        private int validations()
        {

            int error = 0;
            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم المستخدم مطلوب";
                error++;
            }

            if (string.IsNullOrEmpty(textPassword.Texts))
            {
                textPassword.BackColor = Color.Red;
                labePasswordError.Text = "كلمة المرو مطلوبه";
                error++;
            }
            if (string.IsNullOrEmpty(textRePassword.Texts))
            {
                textRePassword.BackColor = Color.Red;
                labeRePasswordError.Text = "اعادة كلنة المرور مطلوبه";
                error++;
            }
             if (textRePassword.Texts != textPassword.Texts)
            {
                textRePassword.BackColor = Color.Red;
                labeRePasswordError.Text = "كلمات المرور غير متطابقه";
                error++;
            }

            if (string.IsNullOrEmpty(textFullName.Texts))
            {
                textFullName.BackColor = Color.Red;
                labeFullNameError.Text = "الاسم الكامل مطلوب";
                error++;
            }
            if(error>0)
            CustomMessageBox.show($"لديك عدد {error}اخطاء", CustomMessageBox.enmType.Error);

            return error;
        }
        private void Search()
        {
            string search = string.IsNullOrEmpty(textName.Texts)?" ":textName.Texts;

            var Users =db.Users.Where(u => u.UserName.Contains(search)).ToList();

            dataGridUsers.DataSource = Users;

        }
        private void Textchange(CustomControls.Controls.RJTextBox textbox, Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        private bool IsExitsUserName()
        {
            User user = db.Users.Where(c => c.UserName == textName.Texts).FirstOrDefault();
            if (user != null)
                return true;
            return false;
        }

        

        private bool IsExitsFullName()
        {
            User user = db.Users.Where(c => c.FullName == textFullName.Texts).FirstOrDefault();
            if (user != null)
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
                labeNamelError.Text = "اسم المستخدم موجود بالفعل";

                return;
            }
            if (IsExitsFullName())
            {
                textFullName.BackColor = Color.DarkOrange;
                labeFullNameError.Text = "هذا السم لدية حساب بالفعل";

                return;
            }
            var user = new User();
            user.UserName = textName.Texts;
            user.Password = textPassword.Texts;
            user.FullName = textFullName.Texts;
            user.Enable = textenable.Checked;
            user.DateCreated = DateTime.Now;
            db.Users.Add(user);
            db.SaveChanges();
            CustomMessageBox.show("تم انشاء المستخدم", CustomMessageBox.enmType.Success);

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
                MessageBox.Show("قم باختيار المستخدم المراد تعديله مجددا");
                return;
            }
            int id = int.Parse(labelId.Text);
            var user = db.Users.Find(id);
            if (user== null)
            {
                MessageBox.Show("المستخدم غير موجود");
                return;
            }
            if (validations() > 0)
            {
                return;
            }
            if (user.UserName != textName.Texts)
            {
                if (IsExitsUserName())
                {
                    textName.BackColor = Color.DarkOrange;
                    labeNamelError.Text = "اسم المستخدم موجود بالفعل";
                    return;
                }
            }
            if (user.FullName != textFullName.Texts)
            {
                if (IsExitsFullName())
                {
                    textFullName.BackColor = Color.DarkOrange;
                    labeFullNameError.Text = "هذا السم لدية حساب بالفعل";
                    return;
                }
            }


            user.UserName = textName.Texts; 
            user.Password = textPassword.Texts;
            user.FullName = textFullName.Texts;
            user.Enable = textenable.Checked;
            user.IsEdit = true; 
            user.DateEdit = DateTime.Now;
            db.Users.Update(user);
            db.SaveChanges();
            CustomMessageBox.show("تم تعديل المستخدم", CustomMessageBox.enmType.Success);


            cleartext();
            
        }

        void cleartext()
        {
            textName.Texts = "";
            textFullName.Texts = "";
            textPassword.Texts = "";
            textRePassword.Texts = "";
            textenable.Checked = false;
            btnSave.Text = "إضافه";
            labelId.Text = "";
        }

        #endregion

        #region events
        private void FormUserAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.User));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.User));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.User));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.User));
            if (!canview)
            {
                dataGridUsers.Visible = false;
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
            }else
            {
                Edit();
            }
        }

        private void تعديلالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridUsers.CurrentRow.Cells[0].Value.ToString()))
            {
                int id =int.Parse( dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                var user = db.Users.Find(id);

                labelId.Text = id.ToString();
                textName.Texts = user.UserName;
                textPassword.Texts = user.Password;
                textRePassword.Texts = user.Password;
                textFullName.Texts = user.FullName;
                textenable.Checked = user.Enable;
                btnSave.Text = "تعديل";
                isnew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار مستخدم");
            }
        }

        private void تعديلالصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مصرح بالحذف",CustomMessageBox.enmType.Error);
                return;
            }
            if (!string.IsNullOrEmpty(dataGridUsers.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                var user = db.Users.Find(id);
                if (CustomMessageBox.dialog($"تأكيد حذف المستخدم {user.UserName}") == DialogResult.OK)
                {
                    try
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {

                        CustomMessageBox.show("لايمكن حذف المستخدم", CustomMessageBox.enmType.Error);
                    }
                    
                }
          
;

            }
            else
            {
                MessageBox.Show("قم بإختيار مستخدم");
            }
        }

        private void حذفالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridUsers.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                Properties.Settings.Default.id_user_edit_roles = id;
                Properties.Settings.Default.Save();
                //   var user = db.Users.Find(id);
                FormUserRoleManager frm = new FormUserRoleManager();

                frm.ShowDialog();
                ;

            }
            else
            {
                MessageBox.Show("قم بإختيار مستخدم");
            }
        }

        private void textPassword__TextChanged(object sender, EventArgs e)
        {
            Textchange(textPassword, labePasswordError);

        }
        private void textRePassword__TextChanged(object sender, EventArgs e)
        {
            Textchange(textRePassword, labeRePasswordError);

        }

        private void textFullName__TextChanged(object sender, EventArgs e)
        {
            Textchange(textFullName, labeFullNameError);

        }
        #endregion
    }
}
