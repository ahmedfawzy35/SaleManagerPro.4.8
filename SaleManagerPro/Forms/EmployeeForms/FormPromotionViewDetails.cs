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
    public partial class FormPromotionViewDetails : Form
    {
        public EmployeePromotion Promotion { get; set; }
        AppDbContext db= new AppDbContext();
        //public List<PromotionDocuments> documents = new List<PromotionDocuments>();
        int x = 0;int y = 0;int PictureCount = 0;int row = 0 ;int coulmn = 0;
        public FormPromotionViewDetails()
        {
            InitializeComponent();
        }

        #region Methods
      public void SetImages()
        {
            foreach (var item in Promotion.PromotionDocuments)
            {
                PictureBox picture = new PictureBox();
                picture.BringToFront();
                picture.Dock = DockStyle.Right;
                picture.Name = "p" + item.IdPromotionDocuments;
                picture.Click += page_Click;
                Image NewImage;
                using (MemoryStream MS = new MemoryStream(item.Image, 0, item.Image.Length))
                {
                    MS.Write(item.Image, 0, item.Image.Length);

                    NewImage = Image.FromStream(MS, true);
                }
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                picture.Image = NewImage;
                picture.BackColor = Color.Red;
                panel2.Controls.Add(picture);
            }
            Invalidate();
        }
        public void SetValues()
        {
            textIdPromotion.Text =Promotion.IdEmployeePromotion.ToString();
            textEmployeeName.Text = Promotion.Employee.FullName;
            textAddToSalry.Text = Promotion.AddToSalary.ToString();
            textJobDegree.Text = Promotion.JobDegree.Name.ToString();
            textFinancialDegree.Text = Promotion.FinancialDegree.Nmae.ToString();
            textDate.Text = Promotion.Date.ToString("d");
            textDateInsert.Text = Promotion.DateCreated.ToString("d");
            textDateStart.Text = Promotion.DateStart.ToString("d");
            textDetails.Text = Promotion.Details.ToString();
            lblPictureCount.Text = Promotion.PromotionDocuments.Count().ToString();
            Invalidate();
        }
        #endregion

        #region Events
        private void page_Click(object sender, EventArgs e)
        {
            //ResetpictureViewValue();
            PictureBox picture = sender as PictureBox;
            int idpicture = int.Parse(picture.Name.Substring(1, picture.Name.Length - 1));
            pictureView.Image = picture.Image;
            //lbl_imageid.Text = picture.Name.Substring(1, picture.Name.Length - 1);
            //MessageBox.Show(idpicture.ToString());
        }
        Byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        #endregion

        private void اضافةمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Read the files

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(file);
                    //pictureView.Image = picture.Image;

                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Click += page_Click;
                    //picture.BackColor = Color.Red;
                    lblPictureCount.Text = ((int.Parse(PictureCount.ToString()) )+ 1).ToString();
                    picture.BringToFront();
                    picture.Dock = DockStyle.Right;
                    PromotionDocuments pd = new PromotionDocuments
                    {
                        IdEmployeePromotion = Promotion.IdEmployeePromotion,
                        IdUser = Properties.Settings.Default.UserId,
                        PageNumber = int.Parse(PictureCount.ToString()) + 1,
                        Image = ConvertImageToBinary(Image.FromFile(file)),

                    };
                    db.PromotionDocuments.Add(pd);
                    db.SaveChanges();
                    picture.Name = "p" + pd.IdPromotionDocuments;

                    panel2.Controls.Add(picture);

                }
            }
        }
    }
    }

