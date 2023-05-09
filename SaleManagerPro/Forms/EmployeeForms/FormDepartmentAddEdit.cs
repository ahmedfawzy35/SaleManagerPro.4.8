 
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
    public partial class FormDepartmentAddEdit : Form
    {
        #region getter

        //
        private static FormDepartmentAddEdit DepartmentAddEdit;
        static void DepartmentAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            DepartmentAddEdit = null;
        }
        public static FormDepartmentAddEdit GetFormDepartmentAddEdit
        {
            get
            {
                if (DepartmentAddEdit == null)
                {
                    DepartmentAddEdit = new FormDepartmentAddEdit();
                    DepartmentAddEdit.FormClosed += new FormClosedEventHandler(DepartmentAddEdit_formclosed);
                }
                return DepartmentAddEdit;
            }
        }
        //
        #endregion
        #region faildes
        private AppDbContext db = new AppDbContext();
        public bool IsNew = true;
        bool canview, cancreat, candelete, canedit;
        List<Department> departmentList = new List<Department>();
        #endregion

        public FormDepartmentAddEdit()
        {
            InitializeComponent();
            if (DepartmentAddEdit == null) DepartmentAddEdit = this;

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
        private void TextFatherTextChanged(object sender, EventArgs e)
        {
            search();
            TextFather.BackColor = Color.FromArgb(82, 75, 75);
            labeFatherError.Text = "";
           
        }
        private void FormJobAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Department));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Department));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Department));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Department));
            if (!canview)
            {
                dataGridFinancialDegeree.Visible = false;
            }
            #endregion
            search();

            textName.Focus();
            refrshcombo();

        }
        private void تعديل_الدرجه_الماليهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString()))
            {
                int idfather = int.Parse(dataGridFinancialDegeree.CurrentRow.Cells[2].Value.ToString());
                string id = dataGridFinancialDegeree.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridFinancialDegeree.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridFinancialDegeree.CurrentRow.Cells[4].Value.ToString();
                labelId.Text = id;
                textName .Text = name;
                lblFatherId.Text  = dataGridFinancialDegeree.CurrentRow.Cells[2].Value.ToString();
                TextFather .Text = dataGridFinancialDegeree.CurrentRow.Cells[5].Value == null? " ": dataGridFinancialDegeree.CurrentRow.Cells[5].Value.ToString();
                textDetails .Text = details;
                btnSave.Text = "تعديل";
                IsNew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار القسم");
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
                    var department = db.Departments.Find(id);
                    db.Departments.Remove(department);
                    db.SaveChanges();
                    search();
                }
                catch (Exception)
                {

                     MessageBox.Show("لا يمكن حذف القسم" );

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار القسم");
            }

        }
        private void combodeparments_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFather .Text = combodeparments.Text;
            lblFatherId.Text = combodeparments.SelectedValue.ToString();
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
                 MessageBox.Show("أسم القسم موجود بالفعل" );

                labeNamelError.Text = "أسم القسم موجود بالفعل";
                return;
            }
            int idfather = int.Parse(lblFatherId.Text);
            Department department = new Department();
            department.Name = textName .Text;
            department.About = textDetails .Text;
            department.Father = int.Parse(lblFatherId.Text);
            department.Rate = db.Departments.Where(x => x.IdDepartment == idfather).FirstOrDefault().Rate + 1;
            department.IdUser = Properties.Settings.Default.UserId;
            department.DateCreated = DateTime.Now;
            db.Departments.Add(department);

            db.SaveChanges();
             MessageBox.Show("تم حفظ القسم" );
        }
        private void Edit()
        {
            if (!canedit)
            {
                 MessageBox.Show("غير مسموح بالتعديل" );

                return;
            }
            int id = int.Parse(labelId.Text);
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                MessageBox.Show("لم يتم العثور على القسم");
                 MessageBox.Show("لم يتم العثور على القسم" );
                return;
            }
            if (textName .Text != department.Name)
            {
                if (isexits(textName .Text))
                {
                    textName.BackColor = Color.Orange;
                     MessageBox.Show("أسم القسم موجود بالفعل" );

                    labeNamelError.Text = "أسم القسم موجود بالفعل";
                    return;
                }
            }
            int idfather = int.Parse(lblFatherId.Text);
            department.Name = textName .Text;
            department.About = textDetails .Text;
            //department.Father = int.Parse(lblFatherId.Text);
            //department.Rate = db.Departments.Where(x => x.IdDepartment == idfather).FirstOrDefault().Rate + 1;
            department.IdUser = Properties.Settings.Default.UserId;
            department.DateCreated = DateTime.Now;
            department.IsEdit = true;
            department.DateEdit = DateTime.Now;
            db.Departments.Update(department);
            db.SaveChanges();
             MessageBox.Show("تم تعديل القسم" );
        }
        private int Validation()
        {
            int errors = 0;
            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم القسم مطلوب";
                 MessageBox.Show("أسم القسم مطلوب" );
                errors++;
            }  
            if (string.IsNullOrEmpty(TextFather .Text))
            {
                TextFather.BackColor = Color.Red;
                labeFatherError.Text = "أسم القسم الاب مطلوب";
                 MessageBox.Show("أسم القسم الاب مطلوب" );
                errors++;
            }
            return errors;
        }

        private bool isexits(string name)
        {
            Department financialDegree = db.Departments.Where(c => c.Name == name).FirstOrDefault();
            if (financialDegree != null)
                return true;
            return false;
        }



        private void search()
        {
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var a = db.Departments.Include(x => x.User).Select(ct => new DepartmentDto
            {
                IdDepartment = ct.IdDepartment,
                Name = ct.Name,
                About = ct.About,
                IsEdit = ct.IsEdit,
                DateEdit = ct.DateEdit,
                Father = ct.Father,
                Rate = ct.Rate,
                FatherName = db.Departments.Where(x => x.IdDepartment == ct.Father).FirstOrDefault().Name,
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
            TextFather .Text = "";
            //TextFather.Enabled = false;
            lblFatherId.Text = "0";
            refrshcombo();

        }
        private void refrshcombo()
        {
            departmentList = db.Departments.ToList();
            combodeparments.DataSource = departmentList;
            combodeparments.ValueMember = "IdDepartment";
            combodeparments.DisplayMember = "Name";


        }

        #endregion


    }

    public class DepartmentDto
    {

        [DisplayName("رقم القسم ")]
        public int IdDepartment { get; set; }

        [DisplayName("اسم القسم ")]
        public string Name { get; set; }

        [DisplayName("رتبة القسم ")]
        public int Rate { get; set; }

        [DisplayName("القسم الرئيسي ")]
        public int Father { get; set; }

        [DisplayName("تفاصيل القسم ")]
        public string About { get; set; }

        [DisplayName("القسم الرئيسي ")]
        public string  FatherName { get; set; }
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
