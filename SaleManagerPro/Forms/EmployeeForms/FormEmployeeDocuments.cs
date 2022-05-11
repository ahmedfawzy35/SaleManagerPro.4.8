using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Data;
using SaleManagerPro.Models.Employees;
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
    public partial class FormEmployeeDocuments : Form
    {
        public int EmployeeId = 0;
        public List<EmployeeDocuments> AllDoucments = new List<EmployeeDocuments>();
        private readonly AppDbContext db= new AppDbContext();

        public FormEmployeeDocuments()
        {
            InitializeComponent();
        }


        #region events
        private void FormEmployeeDocuments_Load(object sender, EventArgs e)
        {
            CreatButton();
        }

        public void ucButtonActions1_ActionTaskClicked(object sender, DocumentItem.ActionTaskEventArgs e)
        {

            lblDecumentName.Text = e.DecoumentName;

            if (e.DecoumentId>0)
            {
                var d = selectdocument(e.DecoumentId);
                CreatPages(d);
                lblDecumentId.Text = e.DecoumentId.ToString();
                lblPageCount.Text = $"عدد الصفحات :{d.Pages.Count()} ";

            }
            else
            {
                lblPageCount.Text = $"لا يوجد اوراق  ";
            }

        }
        #endregion
        #region methods
        public List< EmployeeDocuments> GetAllDocuments()
        {
            List < EmployeeDocuments >result = new List<EmployeeDocuments>();
            if (EmployeeId != 0)
            {


            result =  db.EmployeeDocuments.Include(x => x.Pages).Where(d => d.IdEmployee == EmployeeId).ToList();
            }
            AllDoucments = result;
            return result;
        }

        public void CreatButton()
        {
            int index = -1;
            foreach (var decoument in GetAllDocuments())
            {
                index++;
                DocumentItem btn = new DocumentItem();
                btn.idDocument = decoument.IdEmployeeDocument;
                btn.nameDocument = decoument.Name;
                btn.Size = new Size(286, 60);
                btn.Location = new Point(0, SetBtnLocation(index));
                panel1.Controls.Add(btn);
            }
        }

        public void CreatPages(EmployeeDocuments doc)
        {
            int index = -1;
            foreach (var page in doc.Pages)
            {
                index++;

                PictureBox picture = new PictureBox();
                picture.Size = new Size(137, 162);
                picture.Location = new Point(0, SetPictureLocation(index));
                Image NewImage;
                using (MemoryStream MS = new MemoryStream(page.Image, 0, page.Image.Length))
                {
                    MS.Write(page.Image, 0, page.Image.Length);
                    NewImage = Image.FromStream(MS, true);
                }
                picture.Image = NewImage;

                panel3.Controls.Add(picture);
            }
        }
        public EmployeeDocuments selectdocument(int id)
        {
          return   AllDoucments.Where(d => d.IdEmployeeDocument == id).FirstOrDefault(); 
        }

        public int SetPictureLocation(int index)
        {
            int x = 0;

            if (index == 0)
            {
                x = 845;

            }else
            {
                x = 845 - ((index) * 137);
            }

            return x;
        }
        public int SetBtnLocation(int index)
        {
            int y = 93;
            if (index == 0)
            {
                 y = 93;
            }
            else
            {
                y = 93 + ((index) * 64);
            }
             
            return y;
        }


        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
   
}
