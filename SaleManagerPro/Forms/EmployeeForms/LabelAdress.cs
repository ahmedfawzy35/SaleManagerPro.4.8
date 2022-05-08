using SaleManagerPro.Data;
using SaleManagerPro.Models;
using SaleManagerPro.Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    public partial class LabelAdress : UserControl
    {
        private readonly AppDbContext db = new AppDbContext();
        private string  decumentName = "";
        private string  pageCount = "";
        private int  decumentId = 0;
        private List<Byte[]> images = new List<Byte[]>();
        private List<EmployeeDocumentsDetails> pageList = new List<EmployeeDocumentsDetails>();
        private EmployeeDocuments decument = new EmployeeDocuments();

        public EmployeeDocuments Decument
        {
            get
            {
                return decument;
            }
            set
            {
                decument = value;

                images.Clear();
                pageList.Clear();
                foreach (var page in value.Pages)
                {
                    images.Add(page.Image);
                    pageList.Add(page);
                };
                Pages = images;
                PageList = pageList;
                Invalidate();
            }
        }
        public List<EmployeeDocumentsDetails> PageList
        {
            get
            {
                return pageList;
            }
            set
            {
                pageList = value;
                
                images.Clear();
                foreach (var page in value)
                {
                    images.Add(page.Image);
                }
                Invalidate();
            }
        }
        [Category("RJ Code Advance")]

        public string DecumentName
        {
            get
            {
                return decumentName;
            }
            set
            {
                decumentName = value;
                lblDecumentName.Text = $"اسم المستند : {decumentName}";
                Invalidate();
            }
        }

        public List<Byte[]> Pages
        {
            get
            {
                return images;
            }
            set
            {
                images = value;
                pageCount = value.Count.ToString();
                lblPageCount.Text = $"عدد الصفحات : {pageCount}";

                Invalidate();
            }
        }


         [Category("RJ Code Advance")]
        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
                lblPageCount.Text = $"عدد الصفحات : {pageCount}";
                Invalidate();
            }
        }

        public int DecumentId
        {
            get
            {
                return decumentId;
            }
            set
            {
                decumentId = value;
                lblDecumentId.Text = decumentId.ToString();

                Invalidate();
            }
        }


        Byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btn_selct_image_Click(object sender, EventArgs e)
        {
            //DialogResult dr = this.openFileDialog2.ShowDialog();
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Read the files


                List<EmployeeDocumentsDetails> imgList = new List<EmployeeDocumentsDetails>();
                int page = 0;
                foreach (String file in openFileDialog2.FileNames)
                {
                  
                    byte[] imagebyte = ConvertImageToBinary(Image.FromFile(file));
                    images.Add(imagebyte);

                    imgList.Add(new EmployeeDocumentsDetails { IdEmployeeDocument = decumentId , IdUser = Properties.Settings.Default.UserId,
                     DateCreated = DateTime.Now , Image = imagebyte,PageNumber = page++ });
                    

 
                }

                Pages = images;
                db.EmployeeDocumentsDetails.AddRange(imgList);
                db.SaveChanges();
                Invalidate();

            }
        }

        private void AddPages()
        {


        }
        public LabelAdress()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //textBox1.Text == "مستند جديد للتجربه "
        }
    }
}
