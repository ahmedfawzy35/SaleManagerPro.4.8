using CustomControls.Controls;
using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    public partial class EmployeePromotionAddEdit : Form
    {
        #region getter

        //
        private static EmployeePromotionAddEdit employeePromotionAddEdit;
        static void EmployeePromotionAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            employeePromotionAddEdit = null;
        }
        public static EmployeePromotionAddEdit GetFormEmployeePromotionAddEdit
        {
            get
            {
                if (employeePromotionAddEdit == null)
                {
                    employeePromotionAddEdit = new EmployeePromotionAddEdit();
                    employeePromotionAddEdit.FormClosed += new FormClosedEventHandler(EmployeePromotionAddEdit_formclosed);
                }
                return employeePromotionAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public EmployeePromotionAddEdit()
        {
            InitializeComponent();
            if (employeePromotionAddEdit == null) employeePromotionAddEdit = this;


        }


        #region Methods
        private int validations()
        {

            int error = 0;

            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الموظف مطلوب";
                error++;
            }
            if (string.IsNullOrEmpty(lblidEmployee.Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "اختار الموظف";
                error++;
            }

            if (string.IsNullOrEmpty(textDetails.Texts))
            {
                textDetails.BackColor = Color.Red;
                lableDetailsError.Text = "تفاصيل الترقيه مطلوبه";
                error++;
            }
          
            if (string.IsNullOrEmpty(textAddToSalary.Texts))
            {
                textAddToSalary.BackColor = Color.Red;
                lableAddToSalaryError.Text = "مرتب الموظف  مطلوب";
                error++;
                if (int.Parse(textAddToSalary.Texts) < 1)
                {
                    textAddToSalary.BackColor = Color.Red;
                    lableAddToSalaryError.Text = "هذا الرقم ضغير جدا";
                    error++;
                }
            }
          
           
          
            if (lblIdJob.Text == "0")
            {
                comboJob.BackColor = Color.Red;
                labelJobEroor.Text = "الوظيفه  مطلوب";
                error++;
            }
            if (lblIdJobDegree.Text == "0")
            {
                comboJobDegree.BackColor = Color.Red;
                labelJobDegreeError.Text = "الدرجه الاداريه  مطلوبه";
                error++;
            }
            if (lblbIdFinancialDegree.Text == "0")
            {
                comboFinancialDegree.BackColor = Color.Red;
                labelFinancialDegreeError.Text = "الدرجه الماليه  مطلوبه";
                error++;
            }

            if (error > 0)
                CustomMessageBox.show($"لديك عدد  {error} اخطاء ", CustomMessageBox.enmType.Error);

            return error;
        }
        private void Textchange(CustomControls.Controls.RJTextBox textbox, Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        
      

        public void GetComboBoxDat()
        {
            List<Job> jobs = new List<Job>();
            jobs.Add(new Job { Name = " ", IdJob = 0 });
            jobs.AddRange(db.Jobs.ToList());
            comboJob.DataSource = jobs;
            comboJob.DisplayMember = "Name";
            comboJob.ValueMember = "IdJob";

            List<JobDegree> jobDegree = new List<JobDegree>();
            jobDegree.Add(new JobDegree { Name = " ", IdGobDegree = 0 });
            jobDegree.AddRange(db.JobDegrees.ToList());
            comboJobDegree.DataSource = jobDegree;
            comboJobDegree.DisplayMember = "Name";
            comboJobDegree.ValueMember = "IdGobDegree";

           

            List<FinancialDegree> financialDegree = new List<FinancialDegree>();
            financialDegree.Add(new FinancialDegree { Nmae = " ", IdFinancialDegree = 0 });
            financialDegree.AddRange(db.FinancialDegrees.ToList());
            comboFinancialDegree.DataSource = financialDegree;
            comboFinancialDegree.DisplayMember = "Nmae";
            comboFinancialDegree.ValueMember = "IdFinancialDegree";
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
            

            EmployeePromotion employeePromotionToAdd = new EmployeePromotion();
            employeePromotionToAdd.IdEmployee = int.Parse(lblidEmployee.Text);
            employeePromotionToAdd.AddToSalary = double.Parse(textAddToSalary.Texts);
            //employeePromotionToAdd.job = int.Parse(lblIdJob.Text);
            employeePromotionToAdd.IdGobDegree = int.Parse(lblIdJobDegree.Text);
            employeePromotionToAdd.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employeePromotionToAdd.Date = date.Value.Date;
            employeePromotionToAdd.DateCreated = DateTime.Now;
            employeePromotionToAdd.DateStart = dateStart.Value.Date;
            employeePromotionToAdd.IdUser = Properties.Settings.Default.UserId;

            // تعديل بيانات الموظف

            int idemployee = int.Parse(lblidEmployee.Text);
            var employee = db.Employees.Where(x => x.IdEmployee == idemployee).FirstOrDefault();
            employee.IdJobDegree = int.Parse(lblIdJobDegree.Text);
            employee.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employee.Salary += double.Parse(textAddToSalary.Texts);
            db.Employees.Update(employee);
            db.EmployeePromotions.Add(employeePromotionToAdd);
            db.SaveChanges();

            CustomMessageBox.show("تم اضافة الترقيه", CustomMessageBox.enmType.Success);
            cleartext();
            search();
        }
     
        private void Edit()
        {
            if (!canedit)
            {
                CustomMessageBox.dialog("غير مرخص بالتعديل");
                return;
            }


            if (validations() > 0)
            {
                return;

            }

            int idempprom = int.Parse(labelId.Text);
            EmployeePromotion employeePromotionToEdit = db.EmployeePromotions.Where(x=> x.IdEmployeePromotion == idempprom).FirstOrDefault();

            employeePromotionToEdit.AddToSalary = double.Parse(textAddToSalary.Texts);
            //employeePromotionToEdit.job = int.Parse(lblIdJob.Text);
            employeePromotionToEdit.IdGobDegree = int.Parse(lblIdJobDegree.Text);
            employeePromotionToEdit.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employeePromotionToEdit.Date = date.Value.Date;
            employeePromotionToEdit.DateCreated = DateTime.Now;
            employeePromotionToEdit.DateStart = dateStart.Value.Date;
            employeePromotionToEdit.DateEdit = DateTime.Now;
            employeePromotionToEdit.IdUser = Properties.Settings.Default.UserId;
            employeePromotionToEdit.IsEdit =true;
            employeePromotionToEdit.IdUser = Properties.Settings.Default.UserId;
            // تعديل بيانات الموظف

            int idemployee = int.Parse(lblidEmployee.Text);
            var employee = db.Employees.Where(x => x.IdEmployee == idemployee).FirstOrDefault();
            employee.IdJobDegree = int.Parse(lblIdJobDegree.Text);
            employee.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employee.Salary += double.Parse(textAddToSalary.Texts);
            db.Employees.Update(employee);

            db.EmployeePromotions.Update(employeePromotionToEdit);
            db.SaveChanges();



            CustomMessageBox.show("تم تعديل الترقيه", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void search()
        {
            searchEmployee();
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.EmployeePromotions.Include(x => x.Employee).Where(r => r.Employee.FullName.Contains(search)).Select(em => new EmployeePromotionDto
            {
                IdEmployee = em.IdEmployeePromotion,
                EmployeeName = em.Employee.FullName,
                AddToSalary = em.AddToSalary,
                Date = em.Date,DateCreated = em.DateCreated,DateStart = em.DateStart,
                JobDegreeName = em.JobDegree.Name,IdJobDegree = em.IdGobDegree
                ,FinancialDegreeName = em.FinancialDegree.Nmae , IdFinancialDegree = em.IdFinancialDegree,
                IsEdit = em.IsEdit,DateEdit = em.DateEdit

            }).ToList();
            dataGridEmployees.DataSource = a;
            dataGridEmployees.Columns[1].Visible = false;
            dataGridEmployees.Columns[3].Visible = false;
            dataGridEmployees.Columns[4].Visible = false;
            dataGridEmployees.Columns[6].Visible = false;
            dataGridEmployees.Columns[7].Visible = false;
            dataGridEmployees.Columns[8].Visible = false;
            dataGridEmployees.Columns[9].Visible = false;
            dataGridEmployees.Columns[10].Visible = false;
            dataGridEmployees.Columns[11].Visible = false;

        }
        private void searchEmployee()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.Employees.Where(r => r.FullName.Contains(search)).Select(emp => new
            {
                الرقم = emp.IdEmployee,الاسم =emp.FullName
            }).ToList();
            dataGridEmployee.DataSource = a;
          

        }

        void cleartext()
        {
            textName.Texts = "";
            textName.Enabled = true;
            textDetails.Texts = "";
            textAddToSalary.Texts = "0";
            lblidEmployee.Text = "0";
            lblIdJob.Text = "0";

            lblIdJobDegree.Text = "0";

            lblbIdFinancialDegree.Text = "0";

          

            labelId.Text = "0";

            textAddToSalary.Enabled = true;
            dateStart.Enabled = true;
          
            //comboJob.Enabled = true;
            comboJobDegree.Enabled = true;
            comboFinancialDegree.Enabled = true;
            btnSave.Text = "إضافه";
            IsNew = true;


            GetComboBoxDat();
            search();
        }
        #endregion




        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsNew)
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

        private void textName__TextChanged(object sender, EventArgs e)
        {

            Textchange(textName, labeNamelError);
            search();
        }

        private void textPriceSale__TextChanged(object sender, EventArgs e)
        {
            Textchange(textDetails, lableDetailsError);

        }
        //int editproductunitcount = 0;

        private async void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!canedit)
            {
                CustomMessageBox.show("غير مسموح بالتعديل", CustomMessageBox.enmType.Error);
                return;
            }
            if (!string.IsNullOrEmpty(dataGridEmployees.CurrentRow.Cells[0].Value.ToString()))
            {
                int idep = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                var empporm = db.EmployeePromotions.Include(j=>j.JobDegree).Include(f=>f.FinancialDegree).Include(n =>n.Employee).Where(x => x.IdEmployeePromotion == idep).FirstOrDefault();
                lblidEmployee.Text = empporm.IdEmployee.ToString();
                labelId.Text = empporm.IdEmployeePromotion.ToString();
                textName.Texts = empporm.Employee.FullName;
                textDetails.Texts = empporm.Details;
                textAddToSalary.Texts = empporm.AddToSalary.ToString();
                date.Value = empporm.Date;
                dateStart.Value = empporm.DateStart;
                lblIdJobDegree.Text = empporm.IdGobDegree.ToString();
                lblbIdFinancialDegree.Text = empporm.IdFinancialDegree.ToString();
                textName.Enabled = false;
                GetComboBoxDat();

            }
            else
            {
                MessageBox.Show("قم بإختيار ترقيه");
            }
        }

        private void حذفالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);
                return;
            }
            if (!string.IsNullOrEmpty(dataGridEmployees.CurrentRow.Cells[0].Value.ToString()))
            {
                int idep = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                var empporm = db.EmployeePromotions.Where(x => x.IdEmployeePromotion == idep).FirstOrDefault();
                var emp = db.Employees.Where(x => x.IdEmployee == empporm.IdEmployee).FirstOrDefault();
                if (emp != null)
                {
                    
                }
               

            }
            else
            {
                MessageBox.Show("قم بإختيار ترقيه");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureaddunit2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureaddunit3_Click(object sender, EventArgs e)
        {


        }

        private void btnunit2cancel_Click(object sender, EventArgs e)
        {

        }

        private void btnunit3cancel_Click(object sender, EventArgs e)
        {

        }

        private void btnunit3cancel_Click_1(object sender, EventArgs e)
        {

        }

        private void textunit2count__TextChanged(object sender, EventArgs e)
        {

        }

        private void textunit3count__TextChanged(object sender, EventArgs e)
        {

        }



        private void textPricePurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

     









        private void pictureAddDepartment_Click_1(object sender, EventArgs e)
        {
            //Master.MasterForm.GetFormMasterForm.showform($"اضافة قسم", new FormDepartmentAddEdit());

            SubFormAddNames frm = new SubFormAddNames();
            frm.Text = "اضافة قسم جديد";
            frm.Type = SubFormAddNames.Types.Department.ToString();
            frm.PlaceHolder = "اسم القسم";
            frm.ShowDialog();

        }




    

       

       

        private void comboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJob.Text = comboJob.SelectedValue.ToString();
            labelJobEroor.Text = "";
            comboJob.BackColor = Color.FromArgb(82, 75, 75);
        }

        private void textAddToSalary__TextChanged(object sender, EventArgs e)
        {
            textAddToSalary.BackColor = Color.FromArgb(82, 75, 75);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cleartext();
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployee.CurrentRow.Cells[0].Value.ToString() == null)
            {
                return;
            }
            lblidEmployee.Text = dataGridEmployee.CurrentRow.Cells[0].Value.ToString();
            textName.Texts = dataGridEmployee.CurrentRow.Cells[1].Value.ToString();

        }

        private void comboJobDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJobDegree.Text = comboJobDegree.SelectedValue.ToString();
            labelJobDegreeError.Text = "";
            comboJobDegree.BackColor = Color.FromArgb(82, 75, 75);
        }

        private void comboFinancialDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblbIdFinancialDegree.Text = comboFinancialDegree.SelectedValue.ToString();
            labelFinancialDegreeError.Text = "";
            comboFinancialDegree.BackColor = Color.FromArgb(82, 75, 75);
        }

    
      

     

      


        private void FormProductAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Employee));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Employee));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Employee));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Employee));
            if (!canview)
            {
                dataGridEmployees.Visible = false;
            }

            #endregion
            // combo box load data
            GetComboBoxDat();

        

            cleartext();



            search();

        }

        #endregion
    }
    public class EmployeePromotionDto
    {
        //الترقيات



        public int IdEmployeePromotion { get; set; }
        [DisplayName("تفاصيل الترقيه")]

        public string Details { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ قرار الترقيه")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ تسجيل الترقيه")]

        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("تاريخ تطبيق الترقيه")]

        public DateTime DateStart { get; set; }


        [DataType(DataType.Currency)]
        [DisplayName("الزياده على الاساسي")]

        public double AddToSalary { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [DisplayName("اسم الموظف")]

        public string  EmployeeName { get; set; }
        [DisplayName("رقم الدرجة المالبه")]

        public int IdFinancialDegree { get; set; }
        [DisplayName("اسم الدرجة المالبه")]

        public string FinancialDegreeName { get; set; }
        [DisplayName("رقم الدرجه الاداريه")]

        public int IdJobDegree { get; set; }

        [DisplayName("اسم الدرجة الاداريه")]

        public string JobDegreeName { get; set; }
        
        [DisplayName("تم التعديل")]

        public bool IsEdit { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ التعديل")]

        public DateTime DateEdit { get; set; }

    }
}
