 
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Forms.Security;
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
using SaleManagerPro.Models.Customers;
using Microsoft.EntityFrameworkCore.Internal;

namespace SaleManagerPro.Forms.CustomersForms
{
    public partial class FormCustomerAddEdit :Form
    {
        #region getter

        //
        private static FormCustomerAddEdit CustomerAddEdit;
        static void CustomerAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            CustomerAddEdit = null;
        }
        public static FormCustomerAddEdit GetFormCustomerAddEdit
        {
            get
            {
                if (CustomerAddEdit == null)
                {
                    CustomerAddEdit = new FormCustomerAddEdit();
                    CustomerAddEdit.FormClosed += new FormClosedEventHandler(CustomerAddEdit_formclosed);
                }
                return CustomerAddEdit;
            }
        }
        //
        #endregion

        bool isnew = true;
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        DataTable ban_dt = new DataTable();
        public FormCustomerAddEdit()
        {
            InitializeComponent();
            if (CustomerAddEdit == null) CustomerAddEdit = this;

            ban_dt.Columns.Add("كود الحساب",typeof(int));
            ban_dt.Columns.Add("رقم الحساب",typeof(string));
            ban_dt.Columns.Add("اسم البنك",typeof(string));
            ban_dt.Columns.Add("اسم الفرع",typeof(string));

            dataGridView_BankAccounts.DataSource = ban_dt;
            

        }

        #region Methods
        private int validations()
        {

            int error = 0;
            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labelNamelError.Text = "أسم العميل مطلوب";
                error++;
            }

            if (string.IsNullOrEmpty(textAdress .Text))
            {
                textAdress.BackColor = Color.Red;
                labelAdressError.Text = "العنوان  مطلوب";
                error++;
            }
            
            

          
            if (error > 0)
                 MessageBox.Show($"لديك عدد {error}اخطاء" );

            return error;
        }
        private void Search()
        {
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var customers = db.Customers.Where(u => u.Name.Contains(search)).Select(cus => new CustomerDto
            {
                IdCustomer = cus.IdCustomer,
               Name = cus.Name,
               Adress = cus.Adress,
               StartAccount = cus.StartAccount,
               Cusvalues = new cusvalues
               {
                    orders =cus.Orders.Sum(X=>X.Value),
                    OrdersBack = cus.OrdersBack.Sum(X=>X.Value)
                    
                },
            


            }).ToList();

            dataGridUsers.DataSource = customers;
            dataGridUsers.Columns[4].Visible = false;
        }
        private void Textchange(TextBox textbox, Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        private bool IsExitsUserName()
        {
            User user = db.Users.Where(c => c.UserName == textName .Text).FirstOrDefault();
            if (user != null)
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
                labelNamelError.Text = "اسم المستخدم موجود بالفعل";

                return;
            }
        
            var customer = new Customer();
            customer.Name = textName .Text;
            customer.Adress = textAdress .Text;
            customer.HideInOrders = textHideInOrder.Checked;
            customer.StartAccount =string.IsNullOrEmpty(textStartAccount .Text)?0: double.Parse(textStartAccount .Text);
            db.Customers.Add(customer);
            db.SaveChanges();
            var phones = cutomerphones.Values.ToList();
            if (phones.Count>0)
            {
                var cusphones = new List<CustomerPhones>();
                foreach (var phone in phones)
                {
                    cusphones.Add(new CustomerPhones { IdCustomer = customer.IdCustomer, PhoneNumber = phone });
                }
                db.CustomersPhones.AddRange(cusphones);
                db.SaveChanges();
            }
            if (ban_dt.Rows.Count>0)
            {
                List<CustomerBankAccounts> bankAccounts = new List<CustomerBankAccounts>();
                foreach (DataRow item in ban_dt.Rows)
                {
                    if (int.Parse( item[1].ToString()) ==0)
                    {
                        bankAccounts.Add(new CustomerBankAccounts { IdCustomer = customer.IdCustomer, BankAccuntNumber = item[1].ToString(), BankName = item[2].ToString(), BankBranchName = item[3].ToString() });

                    }
                }
                db.CustomersBankAccounts.AddRange(bankAccounts);
                db.SaveChanges();   

            }

             MessageBox.Show("تم انشاء العميل" );

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
                MessageBox.Show("قم باختيار العميل المراد تعديله مجددا");
                return;
            }
            int id = int.Parse(labelId.Text);
            var customer = db.Customers.Include(p=> p.Phones)
                .Include(b => b.BankAccounts).Where(c => c.IdCustomer == id).FirstOrDefault();
            if (customer == null)
            {
                MessageBox.Show("العميل غير موجود");
                return;
            }
            if (validations() > 0)
            {
                return;
            }
            if (customer.Name != textName .Text)
            {
                if (IsExitsUserName())
                {
                    textName.BackColor = Color.DarkOrange;
                    labelNamelError.Text = "اسم العميل موجود بالفعل";
                    return;
                }
            }



            customer.Name = textName .Text;
            customer.Adress = textAdress .Text;
            customer.HideInOrders = textHideInOrder.Checked;
            customer.StartAccount = string.IsNullOrEmpty(textStartAccount .Text) ? 0 : double.Parse(textStartAccount .Text);
            db.Customers.Update(customer);
            db.SaveChanges();

            // تعديل ارقام الهواتف

            List<string> newphones = cutomerphones.Values.ToList();

                db.CustomersPhones.RemoveRange(customer.Phones);
                db.SaveChanges();
            if (newphones.Count> 0)
            {
                var cusphones = new List<CustomerPhones>();
                foreach (var phone in newphones)
                {
                    cusphones.Add(new CustomerPhones { IdCustomer = customer.IdCustomer, PhoneNumber = phone });
                }
                db.CustomersPhones.AddRange(cusphones);
                db.SaveChanges();

            }




            // تعديل ارقام الحسابات
                if (ban_dt.Rows.Count > 0)
            {
                List<CustomerBankAccounts> bankAccounts = new List<CustomerBankAccounts>();
                foreach (DataRow item in ban_dt.Rows)
                {

                        if (item[0].ToString() == "0")
                        {
                            bankAccounts.Add(new CustomerBankAccounts { IdCustomer = customer.IdCustomer, BankAccuntNumber = item[1].ToString(), BankName = item[2].ToString(), BankBranchName = item[3].ToString() });

                        }

                }
                db.CustomersBankAccounts.AddRange(bankAccounts);
                db.SaveChanges();

            }
             MessageBox.Show("تم تعديل العميل" );


            cleartext();

        }

        void cleartext()
        {
            ban_dt.Clear();
            isnew = true;
            textName .Text = "";
     
            textAdress .Text = "";
            textStartAccount .Text = "";
            textHideInOrder.Checked = false;
            cutomerphones.Enabled = true;
            btnSave.Text = "إضافه";
            labelId.Text = "";
            cutomerphones.ValuesClear();

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

            dataGridView_BankAccounts.Columns[0].Width = Convert.ToInt32((dataGridView_BankAccounts.Width * .10));
            dataGridView_BankAccounts.Columns[1].Width = Convert.ToInt32((dataGridView_BankAccounts.Width * .50));
            dataGridView_BankAccounts.Columns[2].Width = Convert.ToInt32((dataGridView_BankAccounts.Width * .20));
            dataGridView_BankAccounts.Columns[3].Width = Convert.ToInt32((dataGridView_BankAccounts.Width * .20));
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Textchange(textName, labelNamelError);
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

        private void تعديلالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridUsers.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                var customer = db.Customers.Include(p=>p.Phones).Include(b=>b.BankAccounts).Where(x=>x.IdCustomer == id).FirstOrDefault();

                labelId.Text = id.ToString();
                textName .Text = customer.Name;
                textAdress .Text = customer.Adress;
                textStartAccount .Text = customer.StartAccount.ToString();
                textHideInOrder.Checked = customer.HideInOrders;
                btnSave.Text = "تعديل";
                isnew = false;
                List<string> list = new List<string>();
                if (customer.Phones.Count() > 0)
                {
                    foreach (var item in customer.Phones)
                    {
                        list.Add(item.PhoneNumber);  
                    }
                    cutomerphones.ValuesClear();
                    cutomerphones.Values = list;
                }

                if (customer.BankAccounts.Count() > 0)
                {
                    foreach(var item in customer.BankAccounts)
                    {
                       DataRow r = ban_dt.NewRow();
                        r[0] = item.Id;
                        r[1] = item.BankAccuntNumber;
                        r[2] = item.BankName;
                        r[3] = item.BankBranchName;
                        ban_dt.Rows.Add(r); 
                    }
                }

            }
            else
            {
                MessageBox.Show("قم بإختيار عميل");
            }
        }

        private void تعديلالصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                 MessageBox.Show("غير مصرح بالحذف" );
                return;
            }
            if (!string.IsNullOrEmpty(dataGridUsers.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                var customer = db.Customers.Find(id);
                if (MessageBox.Show($"تأكيد حذف المستخدم {customer.Name}") == DialogResult.OK)
                {
                    try
                    {
                        db.Customers.Remove(customer);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {

                         MessageBox.Show("لايمكن حذف العميل" );
                    }

                }

;

            }
            else
            {
                MessageBox.Show("قم بإختيار عميل");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
        }
        private void btn_bankcancek_Click(object sender, EventArgs e)
        {
            lbl_idban.Text = "0";
            text_BankAccountNumber .Text = "";
            text_BankName .Text = "";
            text_BankBranchName .Text = "";
            btn_AddBankAccount.Text = "اضافه";
        }
        private void btn_AddBankAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_BankAccountNumber .Text))
            {
                text_BankAccountNumber.BackColor = Color.OrangeRed;
                return;
            }
            if (string.IsNullOrEmpty(text_BankName .Text))
            {
                text_BankName.BackColor = Color.OrangeRed;
                return;
            }
            if (string.IsNullOrEmpty(text_BankBranchName .Text))
            {
                text_BankBranchName.BackColor = Color.OrangeRed;
                return;
            }
            DataRow r = ban_dt.NewRow();
            r[0] = int.Parse(lbl_idban.Text);
            r[1] = text_BankAccountNumber .Text;
            r[2] = text_BankName .Text;
            r[3] = text_BankBranchName .Text;
            ban_dt.Rows.Add(r);

            int id = int.Parse(lbl_idban.Text);
                if (id > 0)
                {


                    CustomerBankAccounts customerBankAccount = db.CustomersBankAccounts.Where(x => x.Id ==id).FirstOrDefault();
                    if (customerBankAccount != null)
                {
                    customerBankAccount.BankAccuntNumber = text_BankAccountNumber .Text;
                    customerBankAccount.BankName = text_BankName .Text;
                    customerBankAccount.BankBranchName = text_BankBranchName .Text;

                    db.CustomersBankAccounts.Update(customerBankAccount);
                    db.SaveChanges();
                     MessageBox.Show("تم تعديل الحساب" );

                }

            }


            lbl_idban.Text = "0";
            text_BankAccountNumber .Text = "";
            text_BankName .Text = "";
            text_BankBranchName .Text = "";
            btn_AddBankAccount.Text = "اضافه";

        }

        private void text_BankAccountNumber_TextChanged(object sender, EventArgs e)
        {
            text_BankAccountNumber.BackColor = Color.FromArgb(82, 75, 75);
        }

        private void text_BankName_TextChanged(object sender, EventArgs e)
        {
            text_BankName.BackColor = Color.FromArgb(82, 75, 75);

        }

        private void text_BankBranchName_TextChanged(object sender, EventArgs e)
        {
            text_BankBranchName.BackColor = Color.FromArgb(82, 75, 75);

        }

        private void dataGridView_BankAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!canedit ) return;
            if (!string.IsNullOrEmpty(dataGridView_BankAccounts.CurrentRow.Cells[0].Value.ToString()))
            {
                lbl_idban.Text = dataGridView_BankAccounts.CurrentRow.Cells[0].Value.ToString();
                text_BankAccountNumber .Text = dataGridView_BankAccounts.CurrentRow.Cells[1].Value.ToString();
                text_BankName .Text = dataGridView_BankAccounts.CurrentRow.Cells[2].Value.ToString();
                text_BankBranchName .Text = dataGridView_BankAccounts.CurrentRow.Cells[3].Value.ToString();
                
                ban_dt.Rows.RemoveAt(dataGridView_BankAccounts.CurrentRow.Index);
                if (int.Parse(lbl_idban.Text) > 0)
                {
                    btn_AddBankAccount.Text = "تعديل";

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار حساب");
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            Textchange(textAdress, labelAdressError);

        }
        private void textRePassword_TextChanged(object sender, EventArgs e)
        {
            Textchange(textStartAccount, labelStartAccountError);

        }

        private void textFullName_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }

    public class CustomerDto
    {

        [DisplayName("رقم العميل")]
        public int IdCustomer { get; set; }
        [DisplayName("اسم العميل")]
        public string Name { get; set; }
        [DisplayName(" العنوان")]
        public string Adress { get; set; }
        [DisplayName("الرصيد المبدئي")]
        public double StartAccount { get; set; }
        public cusvalues Cusvalues { get; set; }

        [DisplayName("الرصيد الحالي")]
        public double AccountBalance => StartAccount + Cusvalues.orders - Cusvalues.OrdersBack;




    }
   public class cusvalues
    {
        public double orders { get; set; }
        public double CashOutToCus { get; set; }
        public double CashOutToCusInstallment { get; set; }
        public double CashOutToCusByCheck { get; set; }
        public double CashOutToCusInstallmentByCheck { get; set; }
        public double OrdersBack { get; set; }
        public double CashInFromCus { get; set; }
        public double CashInFromSalerInstallment { get; set; }
        public double CashInFromCusByCheck { get; set; }
        public double CashInFromCusInstallmentByCheck { get; set; }

    }
}
