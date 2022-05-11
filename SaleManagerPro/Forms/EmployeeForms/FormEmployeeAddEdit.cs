using CustomControls.Controls;
using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Employees;
using SaleManagerPro.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    public partial class FormEmployeeAddEdit : Form
    {
        #region getter

        //
        private static FormEmployeeAddEdit EmployeeAddEdit;
        static void EmployeeAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            EmployeeAddEdit = null;
        }
        public static FormEmployeeAddEdit GetFormEmployeeAddEdit
        {
            get
            {
                if (EmployeeAddEdit == null)
                {
                    EmployeeAddEdit = new FormEmployeeAddEdit();
                    EmployeeAddEdit.FormClosed += new FormClosedEventHandler(EmployeeAddEdit_formclosed);
                }
                return EmployeeAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public FormEmployeeAddEdit()
        {
            InitializeComponent();
            if (EmployeeAddEdit == null) EmployeeAddEdit = this;


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

            if (string.IsNullOrEmpty(textAdress.Texts))
            {
                textAdress.BackColor = Color.Red;
                lableAdressError.Text = "عنوان الموظف  مطلوب";
                error++;
            }
            if (string.IsNullOrEmpty(textPhone.Texts))
            {
                textPhone.BackColor = Color.Red;
                lablePhoneerror.Text = "هاتف الموظف  مطلوب";
                error++;
            }
          if (string.IsNullOrEmpty(textSalary.Texts))
            {
                textSalary.BackColor = Color.Red;
                lableSalaryError.Text = "مرتب الموظف  مطلوب";
                error++;
            }
           if (lblIdDepartment.Text == "0")
            {
                comboDepartment.BackColor = Color.Red;
                labelDepartmentError.Text = "القسم  مطلوب";
                error++;
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
        private bool IsExitsName()
        {
            Employee employee = db.Employees.Where(c => c.FullName == textName.Texts).FirstOrDefault();
            if (employee != null)
                return true;
            return false;
        }
         private int IsExitsPhonee()
        {
            int employeeyd =0;
            EmployeeDetails employee = db.EmployeeDetails.Where(c => c.Phone == textPhone.Texts).FirstOrDefault();
            if (employee != null)
                employeeyd = employee.IdEmployee ;
            return employeeyd;
        }
         private int IsExitsNationalNumber()
        {
            int employeeyd = 0;

            EmployeeDetails employee = db.EmployeeDetails.Where(c => c.NationalNumber == textNationalNumber.Texts).FirstOrDefault();
            if (employee != null)
                employeeyd = employee.IdEmployee;
            return employeeyd;
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

            List<Department> department = new List<Department>();
            department.Add(new Department { Name = " ", IdDepartment = 0 });
            department.AddRange(db.Departments.ToList());
            comboDepartment.DataSource = department;
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "IdDepartment";

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
            if (IsExitsName())
            {
                CustomMessageBox.show("اسم الموظف موجود بالفعل", CustomMessageBox.enmType.Error);
                return;
            }
            int idnational = IsExitsNationalNumber();
             if (idnational > 0)
            {
                var employeeyd = db.Employees.Where(c => c.IdEmployee == idnational).FirstOrDefault();
                CustomMessageBox.show($"الرقم القومي مسجل مسبقا باسم الموظف {employeeyd.FullName}", CustomMessageBox.enmType.Error);
                return;
            }
             int idphone = IsExitsPhonee();
             if (idphone > 0)
            {
                var employeeyd = db.Employees.Where(c => c.IdEmployee == idphone).FirstOrDefault();
                CustomMessageBox.show($"رقم الهاتف مسجل مسبقا باسم الموظف {employeeyd.FullName}", CustomMessageBox.enmType.Error);
                return;
            }

            Employee employeetoadd = new Employee();
            employeetoadd.Guid = Guid.NewGuid();
            employeetoadd.FullName = textName.Texts;
            employeetoadd.Salary =double.Parse( textSalary.Texts);
            employeetoadd.IdJob =int.Parse(lblIdJob.Text);
            employeetoadd.IdJobDegree = int.Parse(lblIdJobDegree.Text);
            employeetoadd.IdDepartment = int.Parse(lblIdDepartment.Text);
            employeetoadd.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employeetoadd.ISOnWork = true;
            employeetoadd.StartSalary =double.Parse( textSalary.Texts);
            employeetoadd.StartJob = int.Parse(lblIdJob.Text);
            employeetoadd.StartJobDegree = int.Parse(lblIdJobDegree.Text);
            employeetoadd.StartDepartment = int.Parse(lblIdDepartment.Text);
            employeetoadd.StartFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            if (lblDefualtImage.Text == "DefualtImage")
            {
                var img = db.Images.Where(x => x.Name == "DefualtEmployee").FirstOrDefault();
                if (img != null)
                {
                    employeetoadd.IdImages = img.IdImages;
                }else
                {
                    byte[] imagebyte = ConvertImageToBinary(Properties.Resources.DefualyEmployee);
                    Images image = new Images { Guid = Guid.NewGuid(), Name = "DefualyEmployee", Image = imagebyte };
                    db.Images.Add(image);
                    db.SaveChanges();
                    employeetoadd.IdImages = image.IdImages;
                }
            }else
            {
                byte[] imagebyte = ConvertImageToBinary(pictureImage.Image);
                Images image = new Images { Guid = Guid.NewGuid(), Name = employeetoadd.FullName, Image = imagebyte };
                db.Images.Add(image);
                db.SaveChanges();
                employeetoadd.IdImages = image.IdImages;

            }

            db.Employees.Add(employeetoadd);
            db.SaveChanges();

            EmployeeDetails details = new EmployeeDetails();
            details.IdEmployee = employeetoadd.IdEmployee;
            details.Adress = textAdress.Texts;
            details.DateStart = dateStart.Value;
            details.DateOfBirth = dateOfBirth.Value;
            details.DateCreated = DateTime.Now;
            details.Phone = textPhone.Texts;
            details.NationalNumber = textNationalNumber.Texts;
            details.Gender = comboGender.Text;
            details.IsMaried = comboIsMarid.Text;
            details.ScientificDegree = comboScientificDegree.Text;
            details.EducationalQualification = textEducationalQualification.Texts;
            details.DateCreated = DateTime.Now;
            details.IdUser = Properties.Settings.Default.UserId;

            db.EmployeeDetails.Add(details);
            db.SaveChanges();
            CustomMessageBox.show("تم اضافة الموظف", CustomMessageBox.enmType.Success);
            cleartext();
            search();
        }
        Byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void Edit()
        {
            if (!canedit)
            {
                CustomMessageBox.dialog("غير مرخص بالتعديل");
                return;
            }
            var employeetoedit = db.EmployeeDetails.Include(p => p.Employee).Where(x => x.IdEmployee == int.Parse(labelId.Text)).FirstOrDefault();
            var emptoedit = employeetoedit.Employee;
            if (employeetoedit == null)
            {
                CustomMessageBox.dialog("قم بإختيار الموظف مجددا");
                return;
            }

            if (validations() > 0)
            {
                return;

            }
            if (employeetoedit.Employee.FullName != textName.Texts)
            {
                if (IsExitsName())
                {
                    CustomMessageBox.show("اسم الموظف موجود بالفعل", CustomMessageBox.enmType.Error);
                    return;
                }
            }
             if (employeetoedit.NationalNumber != textNationalNumber.Texts)
            {
                if (IsExitsNationalNumber() > 0)
                {
                    CustomMessageBox.show($"الرقم القومي مسجل باسم  {employeetoedit.Employee.FullName}", CustomMessageBox.enmType.Error);
                    return;
                }
            }
             if (employeetoedit.Phone != textPhone.Texts)
            {
                if (IsExitsPhonee() >0)
                {
                    CustomMessageBox.show($"رقم الهاتف مسجل باسم  {employeetoedit.Employee.FullName}", CustomMessageBox.enmType.Error);
                    return;
                }
            }

            employeetoedit.DateOfBirth = dateOfBirth.Value;
            employeetoedit.NationalNumber = textNationalNumber.Texts;
            employeetoedit.Adress =textAdress.Texts;
            employeetoedit.Phone = textPhone.Texts;
            employeetoedit.Gender = comboGender.Text;
            employeetoedit.IsMaried = comboIsMarid.Text;
            employeetoedit.ScientificDegree = comboScientificDegree.Text;
            employeetoedit.EducationalQualification = textEducationalQualification.Texts;
            employeetoedit.IsEdit = true;
            employeetoedit.IdUser = Properties.Settings.Default.UserId;

            emptoedit.FullName = textName.Texts;
            emptoedit.IdJob =int.Parse( lblIdJob.Text);

            if (lblDefualtImage.Text != employeetoedit.Employee.FullName)
            {

                byte[] imagebyte = ConvertImageToBinary(pictureImage.Image);
                Images image = new Images { Guid = Guid.NewGuid(), Name = employeetoedit.Employee.FullName, Image = imagebyte };
                db.Images.Add(image);
                db.SaveChanges();
                emptoedit.IdImages = image.IdImages;
            }
            db.EmployeeDetails.Update(employeetoedit);
            db.Employees.Update(emptoedit);
            db.SaveChanges();



            CustomMessageBox.show("تم تعديل الموظف", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.Employees.Where(r => r.FullName.Contains(search)).ToList();
            dataGridEmployee.DataSource = a;
            dataGridEmployee.Columns[1].Visible = false;
            dataGridEmployee.Columns[3].Visible = false;
            dataGridEmployee.Columns[4].Visible = false;
            dataGridEmployee.Columns[5].Visible = false;
            dataGridEmployee.Columns[6].Visible = false;
            dataGridEmployee.Columns[7].Visible = false;
            dataGridEmployee.Columns[8].Visible = false;
            dataGridEmployee.Columns[9].Visible = false;
            dataGridEmployee.Columns[10].Visible = false;
            dataGridEmployee.Columns[11].Visible = false;
            dataGridEmployee.Columns[12].Visible = false;
            dataGridEmployee.Columns[13].Visible = false;
            dataGridEmployee.Columns[14].Visible = false;
            dataGridEmployee.Columns[15].Visible = false;
             dataGridEmployee.Columns[16].Visible = false;
            dataGridEmployee.Columns[17].Visible = false;
            dataGridEmployee.Columns[18].Visible = false;
            dataGridEmployee.Columns[19].Visible = false;
            dataGridEmployee.Columns[20].Visible = false; 
            dataGridEmployee.Columns[21].Visible = false;
            dataGridEmployee.Columns[22].Visible = false;
             dataGridEmployee.Columns[23].Visible = false;
            dataGridEmployee.Columns[24].Visible = false;
            dataGridEmployee.Columns[25].Visible = false;
            dataGridEmployee.Columns[26].Visible = false;
            dataGridEmployee.Columns[27].Visible = false;

        }

        void cleartext()
        {
            textName.Texts = "";
            textAdress.Texts = "";
            textPhone.Texts = "";
            textSalary.Texts = "";
            textEducationalQualification.Texts = "";
            textNationalNumber.Texts = "";
            lblIdDepartment.Text = "0";
            lblDefualtImage.Text = "DefualtImage";
            pictureImage.Image = Properties.Resources.DefualyEmployee;
            lblIdJob.Text = "0";

            lblIdJobDegree.Text = "0";

            lblbIdFinancialDegree.Text = "0";

            comboGender.Text = "";

            comboIsMarid.Text = "";

            comboScientificDegree.Text = "";

            labelId.Text ="0";

            textSalary.Enabled = true;
            dateStart.Enabled = true;
            comboDepartment.Enabled = true;
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
            Textchange(textAdress, lableAdressError);

        }
        //int editproductunitcount = 0;

        private async void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
                var emp = await db.EmployeeDetails.
                    Include(p => p.Employee).
                    Include(j=> j.Employee.Job).
                    Include(jd => jd.Employee.JobDegree).
                    Include(f=> f.Employee.FinancialDegree).
                    Include(i=> i.Employee.Images).
                    Include(d=>d.Employee.Department).Where(x => x.IdEmployee == id).FirstOrDefaultAsync();




                cleartext();
               


                labelId.Text = emp.IdEmployee.ToString();
                textName.Texts = emp.Employee.FullName;
                textAdress.Texts = emp.Adress;
                textPhone.Texts = emp.Phone;
                textSalary.Texts = emp.Employee.Salary.ToString();
                textNationalNumber.Texts = emp.NationalNumber;
                textEducationalQualification.Texts = emp.EducationalQualification;
                dateStart.Value = emp.DateStart;
                dateOfBirth.Value = emp.DateOfBirth;
                comboDepartment.Text = emp.Employee.Department.Name;
                lblIdDepartment.Text = emp.Employee.IdDepartment.ToString();

                comboJob.Text = emp.Employee.Job.Name;
                lblIdJob.Text = emp.Employee.IdJob.ToString();

                comboJobDegree.Text = emp.Employee.JobDegree.Name;
                lblIdJobDegree.Text = emp.Employee.IdJobDegree.ToString();

                comboFinancialDegree.Text = emp.Employee.FinancialDegree.Nmae;
                lblbIdFinancialDegree.Text = emp.Employee.IdFinancialDegree.ToString();

                comboGender.Text = emp.Gender;

                comboIsMarid.Text = emp.IsMaried;
                comboScientificDegree.Text = emp.ScientificDegree;
                Image NewImage;
                using (MemoryStream MS = new MemoryStream(emp.Employee.Images.Image, 0, emp.Employee.Images.Image.Length))
                {
                    MS.Write(emp.Employee.Images.Image, 0, emp.Employee.Images.Image.Length);
                    NewImage = Image.FromStream(MS, true);
                }
                pictureImage.Image = NewImage;
                lblDefualtImage.Text = emp.Employee.Images.Name;
                btnSave.Text = "تعديل";
                IsNew = false;

                textSalary.Enabled = false;
                dateStart.Enabled = false;
                comboDepartment.Enabled = false;
                //comboJob.Enabled = false;
                comboJobDegree.Enabled = false;
                comboFinancialDegree.Enabled = false;


            }
            else
            {
                MessageBox.Show("قم بإختيارموظف");
            }
        }

        private void حذفالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);

                return;
            }
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
                    var product = db.Products.Find(id);
                    db.Products.Remove(product);
                    db.SaveChanges();
                    search();

                }
                catch (Exception)
                {

                    CustomMessageBox.show("لا يمكن حذف المنتج", CustomMessageBox.enmType.Error);

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureaddunit2_Click(object sender, EventArgs e)
        {
            if (panelunit2.Visible == false)
            {

                panelunit2.Visible = true;
               


            }
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

        private void textPriceSale_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textLimitStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }






        private void عرضمستنداتالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {
                int id =int.Parse( dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
                //string name = dataGridProducts.CurrentRow.Cells[1].Value.ToString();
                Master.MasterForm.GetFormMasterForm.showform($"", new FormEmployeeDocuments { EmployeeId = id});
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

        private void textEducationalQualification__TextChanged(object sender, EventArgs e)
        {

            Textchange(textEducationalQualification, labelEducationalQualificationError);
            search();
        }

        private void textNationalNumber__TextChanged(object sender, EventArgs e)
        {
            Textchange(textNationalNumber, labelNationalNumberError);

        }

        private void pictureAddJob_Click(object sender, EventArgs e)
        {
            //Master.MasterForm.GetFormMasterForm.showform($"اضافة وظيفه", new FormJobAddEdit());
            SubFormAddNames frm = new SubFormAddNames();
            frm.Text = "اضافة وظيفه جديده";
            frm.Type = SubFormAddNames.Types.Job.ToString();
            frm.PlaceHolder = "اسم الوظيفه";
            frm.ShowDialog();
        }

        private void pictureAddJobDegree_Click(object sender, EventArgs e)
        {
            //Master.MasterForm.GetFormMasterForm.showform($"اضافة درجة وظيفيه", new FormJobDegreeAddEdit());
            SubFormAddNames frm = new SubFormAddNames();
            frm.Text = "اضافة درجه وظيفيه جديده";
            frm.Type = SubFormAddNames.Types.JobDegree.ToString();
            frm.PlaceHolder = "اسم الدرجه الوظيفيه";
            frm.ShowDialog();
        }

        private void pictureAddFinancialDegree_Click(object sender, EventArgs e)
        {
            //Master.MasterForm.GetFormMasterForm.showform($"اضافة درجة ماليه", new FormFinancialDegreeAddEdit());
            SubFormAddNames frm = new SubFormAddNames();
            frm.Text = "اضافة درجه ماليه جديده";
            frm.Type = SubFormAddNames.Types.FinancialDegree.ToString();
            frm.PlaceHolder = "اسم الدرجه الماليه";
            frm.ShowDialog();
        }

        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdDepartment.Text = comboDepartment.SelectedValue.ToString();
        }

        private void comboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJob.Text = comboJob.SelectedValue.ToString();

        }

        private void comboJobDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJobDegree.Text = comboJobDegree.SelectedValue.ToString();

        }

        private void comboFinancialDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblbIdFinancialDegree.Text = comboFinancialDegree.SelectedValue.ToString();

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                // Read the files
                pictureImage.Image = Image.FromFile(openFileDialog1.FileName);
                lblDefualtImage.Text = openFileDialog1.FileName;
                //List<EmployeeDocumentsDetails> imgList = new List<EmployeeDocumentsDetails>();
                //int page = 0;
                //foreach (String file in openFileDialog1.FileNames)
                //{

                //    byte[] imagebyte = ConvertImageToBinary(Image.FromFile(file));
                //    images.Add(imagebyte);

                //    imgList.Add(new EmployeeDocumentsDetails
                //    {
                //        IdEmployeeDocument = decumentId,
                //        IdUser = Properties.Settings.Default.UserId,
                //        DateCreated = DateTime.Now,
                //        Image = imagebyte,
                //        PageNumber = page++
                //    });



                //}
            }
        }

        private void textPricePurchase__TextChanged(object sender, EventArgs e)
        {
            Textchange(textPhone, lablePhoneerror);

        }

        private void textLimitStock__TextChanged(object sender, EventArgs e)
        {
            Textchange(textSalary, lableSalaryError);

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
                dataGridEmployee.Visible = false;
            }

            #endregion
            // combo box load data
            GetComboBoxDat();

            comboScientificDegree.DataSource = Enum.GetValues(typeof(ScientificDegree));

            comboGender.DataSource = Enum.GetValues(typeof(Gender));

            comboIsMarid.DataSource = Enum.GetValues(typeof(IsMaried));

            cleartext();
           


            search();

        }

        #endregion
    }

    public class EmployeetyDto
    {

        [DisplayName("رقم الموظف")]
        public int IdEmployee { get; set; }
        [DisplayName("اسم الموظف")]

        public string FullName { get; set; }
        [DisplayName("المرتب الاساسي")]

        public double Salary { get; set; }
        [DisplayName("تاريخ التعيين")]

        public DateTime DateStart { get; set; }
        [DisplayName("الرقم القومي")]

        public string NationalNumber { get; set; }
        [DisplayName("تاريخ الميلاد")]

        public DateTime DateOfBirth { get; set; }
        [DisplayName("العنوان")]

        public string Adress { get; set; }
        [DisplayName("رقم الهاتف")]

        public string Phone { get; set; }
        [DisplayName("النوع ")]

        public string Gender { get; set; }
        [DisplayName("الحاله الاجتماعيه")]

        public string IsMaried { get; set; }

        [DisplayName("الدرجه العلميه")]

        public string ScientificDegree { get; set; }
        [DisplayName("المؤهل الدراسي")]

        public string EducationalQualification { get; set; }
        public EmployeeSalaryProcess SalaryProcess { get; set; }

        [DisplayName("الرصيد الحالي")]
        public double TotalSalary => Salary + SalaryProcess.AddToSalary - SalaryProcess.LessToSalary ;
    }
    public class EmployeeSalaryProcess
    {
        //public double Salary { get; set; }
        public double AddToSalary { get; set; }
        public double LessToSalary { get; set; }


    }
}
