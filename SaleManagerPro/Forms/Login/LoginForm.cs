using SaleManagerPro.Data;
using SaleManagerPro.Forms.Master;
using SaleManagerPro.Models;
using SaleManagerPro.Seeds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.Login
{
    public partial class LoginForm : Form
    {
        AppDbContext _context = new AppDbContext();
        public LoginForm()
        {
            InitializeComponent();
        }
        public static async Task AddDefualtUser()
        {
            await Task.Run(async () => {

                await DefualtUser.AddDefualtUser();
                await DefualtUser.AddDefualtRole();
                await DefualtUser.AddDefualtUserToRole();
                await DefualtUser.AddDefualtClaims();
                await DefualtUser.AddDefualtToRoleClaim();

            });


            

        }
        public static async Task AddDefualtDepartment()
        {
            await Task.Run(async () => {


                await DefualtDepartment.AddDefualtDepartment();

            });


            

        }


        public async Task Login(string username, string pass)
        {

            User user_ = new User();
            await Task.Run(() => { user_ = _context.Users.Where(x => x.UserName == username).FirstOrDefault();
            });
            if (user_ == null)
            {

                lbl_error_message.Text = "اسم المستخد غير صحيح";
                lbl_error_message.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
                picture_loading.Hide();
                return;
            }
            else if (user_.Password == pass)
            {

                if (!user_.Enable)
                {
                    lbl_error_message.Text = "هذا الحساب غير مفعل";
                    picture_loading.Hide();
                    return;
                }
                picture_loading.Hide();
                this.Hide();
                MasterForm frm = new MasterForm();
                frm.ShowDialog();
            }
            else
            {
                lbl_error_message.Text = "كلمة المرور غير صحيحه";
                lbl_error_message.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
                picture_loading.Hide();
                return;
            }




        }
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            picture_loading.Focus();
            // start:
            picture_loading.Show();
            picture_loading.Update();
            if (string.IsNullOrEmpty(text_user_name.Texts))
            {
                lbl_error_message.Text = "برجاء ادخال اسم المستخدم اولا";
                lbl_error_message.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
                picture_loading.Hide();
                button1.Enabled = true;

                return;
            }
            if (string.IsNullOrEmpty(text_pass.Texts))
            {
                lbl_error_message.Text = "برجاء ادخال كلمة المرور اولا";
                lbl_error_message.ForeColor = Color.Red;
                System.Media.SystemSounds.Beep.Play();
                picture_loading.Hide();
                button1.Enabled = true;

                return;
            }
            try
            {
                 await Login(text_user_name.Texts, text_pass.Texts);

                button1.Enabled = true;


            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                button1.Enabled = true;

            }
            picture_loading.Hide();

            button1.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                if (text_user_name.Focus()) text_pass.Focus();
                else if(text_pass.Focus()) button1.PerformClick();


            }
        }

        private async void  LoginForm_Load(object sender, EventArgs e)
        {
          await  AddDefualtUser();
           await AddDefualtDepartment();
        }
    }
}
 