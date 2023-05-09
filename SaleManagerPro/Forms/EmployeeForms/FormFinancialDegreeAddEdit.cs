 
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    public partial class FormFinancialDegreeAddEdit : Form
    {
        #region getter

        //
        private static FormFinancialDegreeAddEdit FinancialDegreeAddEdit;
        static void FinancialDegreeAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            FinancialDegreeAddEdit = null;
        }
        public static FormFinancialDegreeAddEdit GetFormFinancialDegreeAddEdit
        {
            get
            {
                if (FinancialDegreeAddEdit == null)
                {
                    FinancialDegreeAddEdit = new FormFinancialDegreeAddEdit();
                    FinancialDegreeAddEdit.FormClosed += new FormClosedEventHandler(FinancialDegreeAddEdit_formclosed);
                }
                return FinancialDegreeAddEdit;
            }
        }
        //
        #endregion
        #region faildes
        private AppDbContext db = new AppDbContext();
        public bool IsNew = true;
        bool canview, cancreat, candelete, canedit;
        #endregion

        public FormFinancialDegreeAddEdit()
        {
            InitializeComponent();
            if (FinancialDegreeAddEdit == null) FinancialDegreeAddEdit = this;

        }
        #region events


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cleartext();
            IsNew = true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Validation() > 0)
            {
                return;
            }

            if (IsNew)
            {

                Add();
            }
            else
            {
                Edit();
            }
            cleartext();
            search();
        }

        private void textNameTextChanged(object sender, EventArgs e)
        {
            search();
            textName.BackColor = Color.FromArgb(82, 75, 75);
            labeNamelError.Text = "";

        }
        private void FormJobAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.FinancialDegree));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.FinancialDegree));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.FinancialDegree));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.FinancialDegree));
            if (!canview)
            {
                dataGridFinancialDegeree.Visible = false;
            }
            #endregion
            search();

            textName.Focus();

        }
        private void تعديل_الدرجه_الماليهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString()))
            {
                string id = dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridFinancialDegeree.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridFinancialDegeree.CurrentRow.Cells[2].Value.ToString();
                labelId.Text = id;
                textName .Text = name;
                textDetails .Text = details;
                btnSave.Text = "تعديل";
                IsNew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار الدرجه الماليه");
            }
        }
        private void حذف_الدرجه_الماليهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                 MessageBox.Show("غير مسموح بالحذف" );

                return;
            }
            if (!string.IsNullOrEmpty(dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString());
                    var financialdegree = db.FinancialDegrees.Find(id);
                    db.FinancialDegrees .Remove(financialdegree);
                    db.SaveChanges();
                    search();
                }
                catch (Exception)
                {

                     MessageBox.Show("لا يمكن حذف الدرجه الماليه" );

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار الدرجه الماليه");
            }

        }
        #endregion

        #region methods
        private void Add()
        {
            if (!cancreat)
            {
                 MessageBox.Show("غير مسموح بالاضافه" );

                return;
            }
            if (isexits(textName .Text))
            {
                textName.BackColor = Color.Orange;
                 MessageBox.Show("أسم الدرجه الماليه موجود بالفعل" );

                labeNamelError.Text = "أسم الدرجه الماليه موجود بالفعل";
                return;
            }
            FinancialDegree financialDegree = new FinancialDegree();
            financialDegree.Nmae = textName .Text;
            financialDegree.Details = textDetails .Text;
            financialDegree.IdUser = Properties.Settings.Default.UserId;
            financialDegree.DateCreated = DateTime.Now;
            db.FinancialDegrees.Add(financialDegree);

            db.SaveChanges();
             MessageBox.Show("تم حفظ الدرجه الماليه" );
        }
        private void Edit()
        {
            if (!canedit)
            {
                 MessageBox.Show("غير مسموح بالتعديل" );

                return;
            }
            int id = int.Parse(labelId.Text);
            FinancialDegree financialDegree = db.FinancialDegrees.Find(id);
            if (financialDegree == null)
            {
                MessageBox.Show("لم يتم العثور على الدرجه الماليه");
                 MessageBox.Show("لم يتم العثور على الدرجه الماليه" );
                return;
            }
            if (textName .Text != financialDegree.Nmae)
            {
                if (isexits(textName .Text))
                {
                    textName.BackColor = Color.Orange;
                     MessageBox.Show("أسم الدرجه الماليه موجود بالفعل" );

                    labeNamelError.Text = "أسم الدرجه الماليه موجود بالفعل";
                    return;
                }
            }
            financialDegree.Nmae = textName .Text;
            financialDegree.Details = textDetails .Text;
            financialDegree.IdUser = Properties.Settings.Default.UserId;
            financialDegree.IsEdit = true;
            financialDegree.DateEdit = DateTime.Now;

            db.FinancialDegrees.Update(financialDegree);
            db.SaveChanges();
             MessageBox.Show("تم تعديل الدرجه الماليه" );
        }
        private int Validation()
        {
            int errors = 0;
            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الدرجه الماليه مطلوب";
                 MessageBox.Show("أسم الدرجه الماليه مطلوب" );
                errors++;
            }
            return errors;
        }

        private bool isexits(string name)
        {
            FinancialDegree financialDegree = db.FinancialDegrees.Where(c => c.Nmae == name).FirstOrDefault();
            if (financialDegree != null)
                return true;
            return false;
        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var a = db.FinancialDegrees.Include(x => x.User).Select(ct => new FinancialDegreeDto
            {
                IdFinancialDegree = ct.IdFinancialDegree,
                Name = ct.Nmae,
                Details = ct.Details,
                IsEdit = ct.IsEdit,
                DateEdit = ct.DateEdit
                  ,
                DateCreated = ct.DateCreated,
                UserName = ct.User.UserName

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridFinancialDegeree.DataSource = a;
        }

        void cleartext()
        {
            textDetails .Text = "";
            textName .Text = "";
            labelId.Text = "0";
            btnSave.Text = "إضافه";
            IsNew = true;
        }

        #endregion


    }

    public class FinancialDegreeDto
    {

        [DisplayName("رقم الدرجه الماليه")]
        public int IdFinancialDegree { get; set; }
        [DisplayName("اسم الدرجة الماليه")]

        public string Name { get; set; }
        [DisplayName("الوصف")]

        public string Details { get; set; }
        [DisplayName("تم التعديل")]

        public bool IsEdit { get; set; }
        [DisplayName("تاريخ التعديل")]

        public DateTime DateEdit { get; set; }
        [DisplayName("تاريخ الانشاء")]

        public DateTime DateCreated { get; set; }

        [DisplayName("اسم اخر مستخدم")]

        public string UserName { get; set; }
    }

}
