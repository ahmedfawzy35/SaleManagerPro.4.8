using CustomControls.Controls;
using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
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
    public partial class FormEmployeePunishmentAddEdit : Form
    {
        #region getter

        //
        private static FormEmployeePunishmentAddEdit employeePunishmentAddEdit;
        static void employeePunishmentAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            employeePunishmentAddEdit = null;
        }
        public static FormEmployeePunishmentAddEdit GetFormEmployeePunishmentAddEdit
        {
            get
            {
                if (employeePunishmentAddEdit == null)
                {
                    employeePunishmentAddEdit = new FormEmployeePunishmentAddEdit();
                    employeePunishmentAddEdit.FormClosed += new FormClosedEventHandler(employeePunishmentAddEdit_formclosed);
                }
                return employeePunishmentAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public FormEmployeePunishmentAddEdit()
        {
            InitializeComponent();
            if (employeePunishmentAddEdit == null) employeePunishmentAddEdit = this;


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
                lableDetailsError.Text = "تفاصيل الجزاء مطلوبه";
                error++;
            }

            if (string.IsNullOrEmpty(textLessFromSalary.Texts))
            {
                textLessFromSalary.BackColor = Color.Red;
                lableAddToSalaryError.Text = "مرتب الموظف  مطلوب";
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

            int idemp = int.Parse(lblidEmployee.Text);
            if (idemp > 0)
            {

                var emp = db.Employees.Where(x => x.IdEmployee == idemp).FirstOrDefault();
                if (int.Parse(lblIdJobDegree.Text) == emp.IdJobDegree)
                {
                    if (CustomMessageBox.dialog("تأكيد حفظ الجزاء والبقاء على نفس الدرجه الوظيفيه") != DialogResult.OK)
                    {
                        return;
                    }
                }

                if (int.Parse(lblbIdFinancialDegree.Text) == emp.IdFinancialDegree)
                {
                    if (CustomMessageBox.dialog("تأكيد حفظ الجزاء والبقاء على نفس الدرجه الماليه") != DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            EmployeePunishment employeePromotionToAdd = new EmployeePunishment();
            employeePromotionToAdd.IdEmployee = int.Parse(lblidEmployee.Text);
            employeePromotionToAdd.LessFromSalary = double.Parse(textLessFromSalary.Texts);
            employeePromotionToAdd.Details = textDetails.Texts;

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
            employee.Salary -= double.Parse(textLessFromSalary.Texts);
            db.Employees.Update(employee);
            db.EmployeePunishments.Add(employeePromotionToAdd);
            db.SaveChanges();
            AddDocuments(employeePromotionToAdd.IdEmployeePunishment);
            CustomMessageBox.show("تم اضافة الجزاء", CustomMessageBox.enmType.Success);
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
        private Image zoom(Image img, Size size)
        {
            int width = Convert.ToInt32((img.Width) * (size.Width));
            int height = Convert.ToInt32((img.Height) * (size.Height));
            Bitmap srcbtm = new Bitmap(img);
            Bitmap destbtm = new Bitmap(width, height);
            Graphics destGraphic = Graphics.FromImage(destbtm);
            destGraphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            destGraphic.DrawImage(srcbtm, 0, 0, destbtm.Width + 1, destbtm.Height + 1);

            return destbtm;
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
            EmployeePromotion employeePromotionToEdit = db.EmployeePromotions.Where(x => x.IdEmployeePromotion == idempprom).FirstOrDefault();

            employeePromotionToEdit.AddToSalary = double.Parse(textLessFromSalary.Texts);
            //employeePromotionToEdit.job = int.Parse(lblIdJob.Text);
            employeePromotionToEdit.IdGobDegree = int.Parse(lblIdJobDegree.Text);
            employeePromotionToEdit.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employeePromotionToEdit.Date = date.Value.Date;
            employeePromotionToEdit.DateCreated = DateTime.Now;
            employeePromotionToEdit.DateStart = dateStart.Value.Date;
            employeePromotionToEdit.DateEdit = DateTime.Now;
            employeePromotionToEdit.IdUser = Properties.Settings.Default.UserId;
            employeePromotionToEdit.IsEdit = true;
            employeePromotionToEdit.IdUser = Properties.Settings.Default.UserId;
            // تعديل بيانات الموظف

            int idemployee = int.Parse(lblidEmployee.Text);
            var employee = db.Employees.Where(x => x.IdEmployee == idemployee).FirstOrDefault();
            employee.IdJobDegree = int.Parse(lblIdJobDegree.Text);
            employee.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            employee.Salary += double.Parse(textLessFromSalary.Texts);
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
            var a = db.EmployeePunishments.Include(x => x.Employee).Where(r => r.Employee.FullName.Contains(search)).Select(em => new EmployeePunishmentDto
            {
                IdEmployeePromotion = em.IdEmployeePunishment,
                IdEmployee = em.IdEmployee,
                EmployeeName = em.Employee.FullName,
                AddToSalary = em.LessFromSalary,
                Date = em.Date,
                DateCreated = em.DateCreated,
                DateStart = em.DateStart,
                JobDegreeName = em.JobDegree.Name,
                IdJobDegree = em.IdGobDegree
                ,
                FinancialDegreeName = em.FinancialDegree.Nmae,
                IdFinancialDegree = em.IdFinancialDegree,


            }).ToList();
            dataGridEmployees.DataSource = a;
            dataGridEmployees.Columns[1].Visible = false;
            dataGridEmployees.Columns[3].Visible = false;
            dataGridEmployees.Columns[4].Visible = false;
            dataGridEmployees.Columns[6].Visible = false;
            dataGridEmployees.Columns[8].Visible = false;



        }
        private void searchEmployee()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.Employees.Where(r => r.FullName.Contains(search)).Select(emp => new
            {
                الرقم = emp.IdEmployee,
                الاسم = emp.FullName,
                الوظيفيه = emp.JobDegree.Name,
                الماليه =emp.FinancialDegree.Nmae
            }).ToList();
            dataGridEmployee.DataSource = a;
            dataGridEmployee.Columns[2].Visible = false;
            dataGridEmployee.Columns[3].Visible = false;


        }

        void cleartext()
        {
            textName.Texts = "";
            textName.Enabled = true;
            textDetails.Texts = "";
            textLessFromSalary.Texts = "0";
            lblidEmployee.Text = "0";

            lblIdJobDegree.Text = "0";

            lblbIdFinancialDegree.Text = "0";



            labelId.Text = "0";

            textLessFromSalary.Enabled = true;
            dateStart.Enabled = true;

            //comboJob.Enabled = true;
            comboJobDegree.Enabled = true;
            comboFinancialDegree.Enabled = true;
            btnSave.Text = "إضافه";
            IsNew = true;

            x = 3; y = 6; PictureCount = 0; row = 0; coulmn = 0;
            panelImages.Controls.Clear();
            lblPictureCount.Text = "0";
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
                var empporm = db.EmployeePunishments
                    .Include(j => j.JobDegree)
                    .Include(f => f.FinancialDegree)
                    .Include(n => n.Employee)
                    .Where(x => x.IdEmployeePunishment == idep).FirstOrDefault();

                lblidEmployee.Text = empporm.IdEmployee.ToString();
                labelId.Text = empporm.IdEmployeePunishment.ToString();
                textName.Texts = empporm.Employee.FullName;
                textDetails.Texts = empporm.Details;
                textLessFromSalary.Texts = empporm.LessFromSalary.ToString();
                date.Value = empporm.Date;
                dateStart.Value = empporm.DateStart;
                lblIdJobDegree.Text = empporm.IdGobDegree.ToString();
                lblbIdFinancialDegree.Text = empporm.IdFinancialDegree.ToString();
                textName.Enabled = false;
                GetComboBoxDat();

            }
            else
            {
                MessageBox.Show("قم بإختيار جزاء");
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
                var empporm = db.EmployeePunishments.Where(x => x.IdEmployeePunishment == idep).FirstOrDefault();
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

        private void textAddToSalary__TextChanged(object sender, EventArgs e)
        {
            textLessFromSalary.BackColor = Color.FromArgb(82, 75, 75);
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
            comboJobDegree.Text = dataGridEmployee.CurrentRow.Cells[2].Value.ToString();
            comboFinancialDegree.Text = dataGridEmployee.CurrentRow.Cells[3].Value.ToString();

        }
        private void AddDocuments(int idPromtion)
        {
            List<PromotionDocuments> imgList = new List<PromotionDocuments>();
            int page = 0;
            foreach (PictureBox pictureBox in panelImages.Controls.OfType<PictureBox>().ToList())
            {

                byte[] imagebyte = ConvertImageToBinary(pictureBox.Image);
                //images.Add(imagebyte);

                imgList.Add(new PromotionDocuments
                {
                    IdUser = Properties.Settings.Default.UserId,
                    DateCreated = DateTime.Now,
                    Image = imagebyte,
                    PageNumber = page++,
                    IdEmployeePromotion = idPromtion
                    //User = Properties.Settings.Default.UserId
                });



            }


            db.PromotionDocuments.AddRange(imgList);
            db.SaveChanges();
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read the files


                int page = 0;

                foreach (string file in openFileDialog1.FileNames)
                {

                    //byte[] imagebyte = ConvertImageToBinary(Image.FromFile(file));
                    //images.Add(imagebyte);


                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(file);
                    picture.Size = new Size(75, 75);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    coulmn++; PictureCount++;
                    if (coulmn == 5) coulmn = 1;
                    if (coulmn == 1) row++;

                    setlocation(row, coulmn);
                    picture.Location = new Point(x, y);
                    panelImages.Controls.Add(picture);
                    lblPictureCount.Text = PictureCount.ToString();
                }

            }
        }
        int x = 3; int y = 6; int PictureCount = 0; int row = 0, coulmn = 0;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            x = 3; y = 6; PictureCount = 0; row = 0; coulmn = 0;
            panelImages.Controls.Clear();
            lblPictureCount.Text = "0";
        }

        private void عرضالقرارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromotionViewDetails frm = new FormPromotionViewDetails();
            int idpro = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
            frm.Promotion = db.EmployeePromotions
                .Include(d => d.PromotionDocuments)
                .Include(em => em.Employee)
                .Include(j => j.JobDegree)
                .Include(f => f.FinancialDegree)
                .Where(x => x.IdEmployeePromotion == idpro).FirstOrDefault();
            frm.SetImages();
            frm.SetValues();
            Master.MasterForm.GetFormMasterForm.showform("تفاصيل القرار", frm);
        }

        void setlocation(int row, int coulmn)
        {
            if (coulmn == 1)
            {
                x = 3;
            }
            else if (coulmn > 1)
            {
                x = 3 + ((coulmn - 1) * 75);
            }

            if (row == 1)
            {
                y = 6;
            }
            else if (row > 1)
            {
                y = 40 + ((row - 1) * 75);
            }

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
    public class EmployeePunishmentDto
    {
        //الترقيات



        public int IdEmployeePromotion { get; set; }
        [DisplayName("تفاصيل الجزاء")]

        public string Details { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ قرار الجزاء")]

        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("تاريخ تسجيل الجزاء")]

        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("تاريخ تطبيق الجزاء")]

        public DateTime DateStart { get; set; }


        [DataType(DataType.Currency)]
        [DisplayName("الخصم من الاساسي")]

        public double AddToSalary { get; set; }
        [DisplayName("رقم الموظف")]

        public int IdEmployee { get; set; }
        [DisplayName("اسم الموظف")]

        public string EmployeeName { get; set; }
        [DisplayName("رقم الدرجة المالبه")]

        public int IdFinancialDegree { get; set; }
        [DisplayName("اسم الدرجة المالبه")]

        public string FinancialDegreeName { get; set; }
        [DisplayName("رقم الدرجه الاداريه")]

        public int IdJobDegree { get; set; }

        [DisplayName("اسم الدرجة الاداريه")]

        public string JobDegreeName { get; set; }



    }
}