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
    public partial class SubFormAddNames : Form
    {
        public readonly AppDbContext db = new AppDbContext();
        public string PlaceHolder { get; set; }
        public string Type { get; set; }
        public enum Types
        {
            Department,
            Job,
            JobDegree,
            FinancialDegree
        }
        public SubFormAddNames()
        {
            InitializeComponent();
            textName.PlaceholderText = PlaceHolder;
           
        }



         public void AddDepartment()
        {
            if (string.IsNullOrEmpty(TextFather.Texts))
            {
                labeNamelError.Text = "قم باختيار القسم الاب ";
                return;
            }
            if (string.IsNullOrEmpty(textName.Texts))
            {
                labeNamelError.Text = "الاسم مطلوب";
                return;
            }
          
             int idfather = int.Parse(lblFatherId.Text);
            Department department = new Department();
            Department father = db.Departments.Where(x=>x.IdDepartment == idfather).FirstOrDefault();
            department.Name = textName.Texts;
            department.About = textDetails.Texts;
            department.Father = idfather;
            department.Rate = father.Rate+1;
            department.DateCreated = DateTime.Now;
            department.IdUser = Properties.Settings.Default.UserId;

            db.Departments.Add(department);
            db.SaveChanges();
            this.Close();


        }

        public void AddJob()
        {
            if (string.IsNullOrEmpty(textName.Texts))
            {
                labeNamelError.Text = "الاسم مطلوب";
                return;
            }
            Job job = new Job();
            job.Name = textName.Texts;
            job.Details = textDetails.Texts;
            job.DateCreated = DateTime.Now;
            job.IdUser = Properties.Settings.Default.UserId;
            db.Jobs.Add(job);
            db.SaveChanges();
            this.Close();

        }

        public void AddJobDegree()
        {
            if (string.IsNullOrEmpty(textName.Texts))
            {
                labeNamelError.Text = "الاسم مطلوب";
                return;
            }
            JobDegree jobDegree = new JobDegree();
            jobDegree.Name = textName.Texts;
            jobDegree.Details = textDetails.Texts;
            jobDegree.DateCreated = DateTime.Now;
            jobDegree.IdUser = Properties.Settings.Default.UserId;
            db.JobDegrees.Add(jobDegree);
            db.SaveChanges();
            this.Close();

        }

        public void AddFinancialDegree()
        {
            if (string.IsNullOrEmpty(textName.Texts))
            {
                labeNamelError.Text = "الاسم مطلوب";
                return;
            }
            FinancialDegree financialDegree = new FinancialDegree();
            financialDegree.Nmae = textName.Texts;
            financialDegree.Details = textDetails.Texts;
            financialDegree.DateCreated = DateTime.Now;
            financialDegree.IdUser = Properties.Settings.Default.UserId;
            db.FinancialDegrees.Add(financialDegree);
            db.SaveChanges();
            this.Close();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Type == Types.Department.ToString())
            {
                AddDepartment();
            }else if (Type == Types.Job.ToString())
            {
                AddJob();
            }else if (Type == Types.JobDegree.ToString())
            {
                AddJobDegree();
            }else if (Type == Types.FinancialDegree.ToString())
            {
                AddFinancialDegree();
            }
            FormEmployeeAddEdit.GetFormEmployeeAddEdit.GetComboBoxDat();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubFormAddNames_Load(object sender, EventArgs e)
        {
            if (Type == Types.Department.ToString())
            {
                combodeparments.DataSource = db.Departments.ToList();
                combodeparments.DisplayMember = "Name";
                combodeparments.ValueMember = "IdDepartment";
                TextFather.Texts = "";
                lblFatherId.Text = "0";
                label2.Visible = true;
                combodeparments.Visible = true;
                TextFather.Visible = true;
                //lblFatherId.Visible = true;
                labeFatherError.Visible = true;
            }
        }

        private void combodeparments_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFather.Texts = combodeparments.Text.ToString();
            lblFatherId.Text = combodeparments.SelectedValue.ToString();
        }
    }
}
