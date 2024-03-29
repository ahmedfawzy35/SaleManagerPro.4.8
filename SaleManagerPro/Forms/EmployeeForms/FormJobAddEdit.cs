﻿ 
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models.Employees;
using SaleManagerPro.Models.Products;
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
    public partial class FormJobAddEdit : Form
    {
        #region getter

        //
        private static FormJobAddEdit JobAddEdit;
        static void JobAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            JobAddEdit = null;
        }
        public static FormJobAddEdit GetFormJobAddEdit
        {
            get
            {
                if (JobAddEdit == null)
                {
                    JobAddEdit = new FormJobAddEdit();
                    JobAddEdit.FormClosed += new FormClosedEventHandler(JobAddEdit_formclosed);
                }
                return JobAddEdit;
            }
        }
        //
        #endregion
        #region faildes
        private AppDbContext db = new AppDbContext();
        public bool IsNew = true;
        bool canview, cancreat, candelete, canedit;
        #endregion

        public FormJobAddEdit()
        {
            InitializeComponent();
            if (JobAddEdit == null) JobAddEdit = this;

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
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Job));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Job));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Job));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Job));
            if (!canview)
            {
                dataGridJobs.Visible = false;
            }
            #endregion
            search();

            textName.Focus();

        }
        private void تعديلالوظيفهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridJobs.CurrentRow.Cells[0].Value.ToString()))
            {
                string id = dataGridJobs.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridJobs.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridJobs.CurrentRow.Cells[2].Value.ToString();
                labelId.Text = id;
                textName .Text = name;
                textDetails .Text = details;
                btnSave.Text = "تعديل";
                IsNew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }
        }
        private void حذفالوظيفهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                MessageBox.Show("غير مسموح بالحذف");

                return;
            }
            if (!string.IsNullOrEmpty(dataGridJobs.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridJobs.CurrentRow.Cells[0].Value.ToString());
                    var job = db.Jobs.Find(id);
                    db.Jobs.Remove(job);
                    db.SaveChanges();
                    search();
                }
                catch (Exception)
                {

                    MessageBox.Show("لا يمكن حذف الوظيفه");

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار وظيفه");
            }

        }
        #endregion

        #region methods
        private void Add()
        {
            if (!cancreat)
            {
                MessageBox.Show("غير مسموح بالاضافه");

                return;
            }
            if (isexits(textName .Text))
            {
                textName.BackColor = Color.Orange;
                MessageBox.Show("أسم الوظيفه موجود بالفعل");

                labeNamelError.Text = "أسم الوظيفه موجود بالفعل";
                return;
            }
            Job job = new Job();
            job.Name = textName .Text;
            job.Details = textDetails .Text;
            job.IdUser = Properties.Settings.Default.UserId;
            job.DateCreated = DateTime.Now;
            db.Jobs.Add(job);

            db.SaveChanges();
            MessageBox.Show("تم حفظ الوظيفه");
        }
        private void Edit()
        {
            if (!canedit)
            {
                MessageBox.Show("غير مسموح بالتعديل");

                return;
            }
            int id = int.Parse(labelId.Text);
            Job jobEdit = db.Jobs.Find(id);
            if (jobEdit == null)
            {
               MessageBox.Show("لم يتم العثور على الوظيفه");
                MessageBox.Show("لم يتم العثور على الوظيفه");
                return;
            }
            if (textName .Text != jobEdit.Name)
            {
                if (isexits(textName .Text))
                {
                    textName.BackColor = Color.Orange;
                    MessageBox.Show("أسم الوظيفه موجود بالفعل");

                    labeNamelError.Text = "أسم الوظيفه موجود بالفعل";
                    return;
                }
            }
            jobEdit.Name = textName .Text;
            jobEdit.Details = textDetails .Text;
            jobEdit.IdUser = Properties.Settings.Default.UserId;
            jobEdit.IsEdit = true;
            jobEdit.DateEdit = DateTime.Now;

            db.Jobs.Update(jobEdit);
            db.SaveChanges();
            MessageBox.Show("تم تعديل الوظيفه");
        }
        private int Validation()
        {
            int errors = 0; 
            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الوظيفه مطلوب";
                MessageBox.Show("أسم الوظيفه مطلوب");
               errors++;
            }
            return errors;
        }

        private bool isexits(string name)
        {
            Job job = db.Jobs.Where(c => c.Name == name).FirstOrDefault();
            if (job != null)
                return true;
            return false;
        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var a = db.Jobs.Include(x => x.User).Select(ct => new JobDto
            {
                IdJOB = ct.IdJob,
                Name = ct.Name,
                Details = ct.Details,
                IsEdit = ct.IsEdit,
                DateEdit = ct.DateEdit
                  ,
                DateCreated = ct.DateCreated,
                UserName = ct.User.UserName

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridJobs.DataSource = a;
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

    public class JobDto
    {

        [DisplayName("رقم الوظيفه")]
        public int IdJOB { get; set; }
        [DisplayName("اسم الوظيفه")]

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
