using CustomControls.MessageBox;
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
    public partial class FormJobDegreeAddEdit : Form
    {
        #region getter

        //
        private static FormJobDegreeAddEdit JobDegreeAddEdit;
        static void JobDegreeAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            JobDegreeAddEdit = null;
        }
        public static FormJobDegreeAddEdit GetFormJobDegreeAddEdit
        {
            get
            {
                if (JobDegreeAddEdit == null)
                {
                    JobDegreeAddEdit = new FormJobDegreeAddEdit();
                    JobDegreeAddEdit.FormClosed += new FormClosedEventHandler(JobDegreeAddEdit_formclosed);
                }
                return JobDegreeAddEdit;
            }
        }
        //
        #endregion
        #region faildes
        private AppDbContext db = new AppDbContext();
        public bool IsNew = true;
        bool canview, cancreat, candelete, canedit;
        #endregion

        public FormJobDegreeAddEdit()
        {
            InitializeComponent();
            if (JobDegreeAddEdit == null) JobDegreeAddEdit = this;

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

        private void textName_TextChanged(object sender, EventArgs e)
        {
            search();
            textName.BackColor = Color.FromArgb(82, 75, 75);
            labeNamelError.Text = "";

        }
        private void FormJobAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.JobDegree));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.JobDegree));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.JobDegree));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.JobDegree));
            if (!canview)
            {
                dataGridJobsDegrees.Visible = false;
            }
            #endregion
            search();

            textName.Focus();

        }
        private void تعديل_الدرجه_الوظيفيههToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridJobsDegrees.CurrentRow.Cells[0].Value.ToString()))
            {
                string id = dataGridJobsDegrees.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridJobsDegrees.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridJobsDegrees.CurrentRow.Cells[2].Value.ToString();
                labelId.Text = id;
                textName.Texts = name;
                textDetails.Texts = details;
                btnSave.Text = "تعديل";
                IsNew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }
        }
        private void حذف_الدرجه_الوظيفيههToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);

                return;
            }
            if (!string.IsNullOrEmpty(dataGridJobsDegrees.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridJobsDegrees.CurrentRow.Cells[0].Value.ToString());
                    var jobdegree = db.JobDegrees.Find(id);
                    db.JobDegrees.Remove(jobdegree);
                    db.SaveChanges();
                    search();
                }
                catch (Exception)
                {

                    CustomMessageBox.show("لا يمكن حذف الدرجة الوظيفيه", CustomMessageBox.enmType.Error);

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار درجة ");
            }

        }
        #endregion

        #region methods
        private void Add()
        {
            if (!cancreat)
            {
                CustomMessageBox.show("غير مسموح بالاضافه", CustomMessageBox.enmType.Error);

                return;
            }
            if (isexits(textName.Texts))
            {
                textName.BackColor = Color.Orange;
                CustomMessageBox.show("أسم الدرجة الوظيفيه موجود بالفعل", CustomMessageBox.enmType.Warning);

                labeNamelError.Text = "أسم الدرجة الوظيفيه موجود بالفعل";
                return;
            }
            JobDegree jobdegree = new JobDegree();
            jobdegree.Name = textName.Texts;
            jobdegree.Details = textDetails.Texts;
            jobdegree.IdUser = Properties.Settings.Default.UserId;
            jobdegree.DateCreated = DateTime.Now;
            db.JobDegrees.Add(jobdegree);

            db.SaveChanges();
            CustomMessageBox.show("تم حفظ الدرجة الوظيفيه", CustomMessageBox.enmType.Success);
        }
        private void Edit()
        {
            if (!canedit)
            {
                CustomMessageBox.show("غير مسموح بالتعديل", CustomMessageBox.enmType.Error);

                return;
            }
            int id = int.Parse(labelId.Text);
            JobDegree jobdegreeEdit = db.JobDegrees.Find(id);
            if (jobdegreeEdit == null)
            {
                CustomMessageBox.dialog("لم يتم العثور على الدرجة الوظيفيه");
                CustomMessageBox.show("لم يتم العثور على الدرجة الوظيفيه", CustomMessageBox.enmType.Error);
                return;
            }
            if (textName.Texts != jobdegreeEdit.Name)
            {
                if (isexits(textName.Texts))
                {
                    textName.BackColor = Color.Orange;
                    CustomMessageBox.show("أسم الدرجة الوظيفيه موجود بالفعل", CustomMessageBox.enmType.Warning);

                    labeNamelError.Text = "أسم الدرجة الوظيفيه موجود بالفعل";
                    return;
                }
            }
            jobdegreeEdit.Name = textName.Texts;
            jobdegreeEdit.Details = textDetails.Texts;
            jobdegreeEdit.IdUser = Properties.Settings.Default.UserId;
            jobdegreeEdit.IsEdit = true;
            jobdegreeEdit.DateEdit = DateTime.Now;

            db.JobDegrees.Update(jobdegreeEdit);
            db.SaveChanges();
            CustomMessageBox.show("تم تعديل الدرجة الوظيفيه", CustomMessageBox.enmType.Success);
        }
        private int Validation()
        {
            int errors = 0;
            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الدرجة الوظيفيه مطلوب";
                CustomMessageBox.show("أسم الدرجة الوظيفيه مطلوب", CustomMessageBox.enmType.Error);
                errors++;
            }
            return errors;
        }

        private bool isexits(string name)
        {
            JobDegree jobdegreeEdit = db.JobDegrees.Where(c => c.Name == name).FirstOrDefault();
            if (jobdegreeEdit != null)
                return true;
            return false;
        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;

            var a = db.JobDegrees.Include(x => x.User).Select(ct => new JobDegreeDto
            {
                IdJobDegreeDto = ct.IdGobDegree,
                Name = ct.Name,
                Details = ct.Details,
                IsEdit = ct.IsEdit,
                DateEdit = ct.DateEdit
                  ,
                DateCreated = ct.DateCreated,
                UserName = ct.User.UserName

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridJobsDegrees.DataSource = a;
        }

        void cleartext()
        {
            textDetails.Texts = "";
            textName.Texts = "";
            labelId.Text = "0";
            btnSave.Text = "إضافه";
            IsNew = true;
        }

        #endregion


    }

    public class JobDegreeDto
    {

        [DisplayName("رقم الدرجه الوظيفيه")]
        public int IdJobDegreeDto { get; set; }
        [DisplayName("اسم الدرجه الوظيفيه")]

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
