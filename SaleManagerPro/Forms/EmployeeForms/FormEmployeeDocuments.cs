using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
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
        #region Properties
        public int EmployeeId = 0;
        public string EmployeeName = "";
        public List<EmployeeDocuments> AllDoucments = new List<EmployeeDocuments>();
        private readonly AppDbContext db= new AppDbContext();
        PictureBox org = new PictureBox();
        bool canview, cancreat, candelete, canedit;
        #endregion
        public FormEmployeeDocuments()
        {
            InitializeComponent();
            lblEmployeeName.Text += EmployeeName;

        }

        #region methods
        private void ResetpictureViewValue()
        {
            
            lbl_imageid.Text = "0";
            pictureView.Image = null;
            trackBar1.Value = 1;
        }
        public void AddDocument()
        {
            if (!cancreat)
            {
                CustomControls.MessageBox.CustomMessageBox.show("غير مصرح بالاضافه ", CustomControls.MessageBox.CustomMessageBox.enmType.Info);
                return;
            }
            if (string.IsNullOrEmpty(textName.Texts))
            {
                labelNameError.Text = "اسم المستند مطلوب";
                textName.BackColor = Color.Red;
                return;
            }
            var document = new EmployeeDocuments();
            document.Name = textName.Texts;
            document.IdEmployee = EmployeeId;
            document.DateCreated = DateTime.Now;
            document.IdUser = Properties.Settings.Default.UserId;
            db.EmployeeDocuments.Add(document);
            db.SaveChanges();
            CreatButton();
        }
        public List<EmployeeDocuments> GetAllDocuments()
        {
            List<EmployeeDocuments> result = new List<EmployeeDocuments>();
            if (EmployeeId != 0)
            {


                result = db.EmployeeDocuments.Include(x => x.Pages).Where(d => d.IdEmployee == EmployeeId).ToList();
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
                btn.NameDocument = decoument.Name;
                btn.Size = new Size(286, 60);
                btn.ActionTaskClicked += Btn_ActionTaskClicked;
                btn.Location = new Point(0, SetBtnLocation(index));
                panel1.Controls.Add(btn);
            }
        }
        public void CreatPages(EmployeeDocuments doc)
        {
            panel3.Controls.Clear();
            int index = -1;
            foreach (var page in doc.Pages)
            {
                index++;

                PictureBox picture = new PictureBox();
                //picture.Size = new Size(137, 162);
                //picture.Location = new Point(0, SetPictureLocation(index));
                picture.BringToFront();
                picture.Dock = DockStyle.Right;
                picture.Name = "p" + page.IdEmployeeDocumentsDetails;
                picture.Click += page_Click;
                Image NewImage;
                using (MemoryStream MS = new MemoryStream(page.Image, 0, page.Image.Length))
                {
                    MS.Write(page.Image, 0, page.Image.Length);

                    NewImage = Image.FromStream(MS, true);
                }
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                picture.Image = NewImage;
                picture.BackColor = Color.Red;
                panel3.Controls.Add(picture);
            }
        }
        public EmployeeDocuments selectdocument(int id)
        {
            return AllDoucments.Where(d => d.IdEmployeeDocument == id).FirstOrDefault();
        }
        public int SetPictureLocation(int index)
        {
            int x = 0;

            if (index == 0)
            {
                x = 845;

            }
            else
            {
                x = 845 - ((index) * 137);
            }

            return x;
        }
        public int SetBtnLocation(int index)
        {
            int y = 170;
            if (index == 0)
            {
                y = 140;
            }
            else
            {
                y = 140 + ((index) * 64);
            }

            return y;
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
        #endregion
        #region events
        private void FormEmployeeDocuments_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.EmployeeDocuments));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.EmployeeDocuments));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.EmployeeDocuments));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.EmployeeDocuments));
            if (canview)
            {
                CreatButton();
                GetAllDocuments();
            }
            #endregion
            //trackBar1.Minimum = 1;
            //trackBar1.Maximum = 4;
            //trackBar1.SmallChange = 1;
            //trackBar1.LargeChange = 1;
            //trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true; 
            pictureView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.picture_MouseWheel);
            
        }
        private void picture_MouseWheel(object sender, MouseEventArgs e)
        {

            //if (e.Delta > 0)
            //{
            //    factor += .1;
            //}else
            //{   
            //    factor -= .1;
            //}
            ////if (factor <= 0)factor = .1;
            //Image img_ = pictureView.Image;
            //Bitmap srcbtm = new Bitmap(img_);

            //int width = Convert.ToInt32((srcbtm.Width) * factor);
            //int height = Convert.ToInt32((srcbtm.Height) * factor);
            //Bitmap destbtm = new Bitmap(width, height);
            //Graphics destGraphic = Graphics.FromImage(destbtm);

            //destGraphic.DrawImage(srcbtm, 0, 0, destbtm.Width + 1, destbtm.Height + 1);
            //pictureView.Image = destbtm;
           
        }
        private void Btn_ActionTaskClicked(object sender, DocumentItem.ActionTaskEventArgs e)
        {

            lblDecumentName.Text = e.DecoumentName;

            if (e.DecoumentId > 0)
            {
                var d = selectdocument(e.DecoumentId);
                CreatPages(d);
                lblDecumentId.Text = e.DecoumentId.ToString();
                lblPageCount.Text = $"عدد الصفحات :{d.Pages.Count()} ";
                CreatPages(selectdocument(e.DecoumentId));
                ResetpictureViewValue();
            }
            else
            {
                lblPageCount.Text = $"لا يوجد اوراق  ";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeDocuments documents = selectdocument(int.Parse(lblDecumentId.Text));
            if (documents == null)
            {
                return;
            }
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read the files


                List<EmployeeDocumentsDetails> imgList = new List<EmployeeDocumentsDetails>();
                int page = 0;
                foreach (String file in openFileDialog1.FileNames)
                {

                    byte[] imagebyte = ConvertImageToBinary(Image.FromFile(file));
                    //images.Add(imagebyte);

                    imgList.Add(new EmployeeDocumentsDetails
                    {
                        IdEmployeeDocument = int.Parse(lblDecumentId.Text),
                        IdUser = Properties.Settings.Default.UserId,
                        DateCreated = DateTime.Now,
                        Image = imagebyte,
                        PageNumber = page++
                    });



                }


                db.EmployeeDocumentsDetails.AddRange(imgList);
                db.SaveChanges();
                //GetAllDocuments();
                CreatPages(documents);
            }
        }
        private void textName__TextChanged(object sender, EventArgs e)
        {
            labelNameError.Text = "";
            textName.BackColor = Color.FromArgb(82, 75, 75);
        }
        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            AddDocument();
        }
        private void page_Click(object sender, EventArgs e)
        {
            ResetpictureViewValue();
            PictureBox picture = sender as PictureBox ;
            int idpicture =int.Parse(picture.Name.Substring(1,picture.Name.Length-1));
            pictureView.Image = picture.Image;
            lbl_imageid.Text = picture.Name.Substring(1, picture.Name.Length - 1);
            //MessageBox.Show(idpicture.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Master.MasterForm.GetFormMasterForm.showform("test", form2);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void طباعةالصفحةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حفظالصفحهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (lbl_imageid.Text == "0" || string.IsNullOrEmpty(lbl_imageid.Text))
            {
                return;
            }
            org.Image = pictureView.Image;
            if (trackBar1.Value != 0)
            {
                int id_document = int.Parse(lblDecumentId.Text);
                int id_d_details = int.Parse(lbl_imageid.Text);
                EmployeeDocumentsDetails page = selectdocument(id_document).Pages.Where(i => i.IdEmployeeDocumentsDetails == id_d_details).FirstOrDefault();

                Image NewImage;
                using (MemoryStream MS = new MemoryStream(page.Image, 0, page.Image.Length))
                {
                    MS.Write(page.Image, 0, page.Image.Length);

                    NewImage = Image.FromStream(MS, true);
                }
                pictureView.Image = null;
                pictureView.Image = zoom(NewImage, new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        private void btnChangeImage_Click_1(object sender, EventArgs e)
        {
            if (!canedit)
            {
                CustomControls.MessageBox.CustomMessageBox.show("غير مصرح بالتعديل ", CustomControls.MessageBox.CustomMessageBox.enmType.Info);
                return;
            }
            if (lbl_imageid.Text == "0" || string.IsNullOrEmpty(lbl_imageid.Text))
            {
                return;
            }

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                int id_document = int.Parse(lblDecumentId.Text);
                int id_d_details = int.Parse(lbl_imageid.Text);
                EmployeeDocuments documents = selectdocument(id_document);
                EmployeeDocumentsDetails page = documents.Pages.Where(i => i.IdEmployeeDocumentsDetails == id_d_details).FirstOrDefault();

                page.Image = ConvertImageToBinary(Image.FromFile(openFileDialog1.FileName));
                db.EmployeeDocumentsDetails.Update(page);
                db.SaveChanges();
                //GetAllDocuments();
                ResetpictureViewValue();
                CreatPages(documents);
            }

        }
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomControls.MessageBox.CustomMessageBox.show("غير مصرح بالحذف ", CustomControls.MessageBox.CustomMessageBox.enmType.Info);
                return;
            }
            if (lbl_imageid.Text == "0" || string.IsNullOrEmpty(lbl_imageid.Text))
            {
                return;
            }
            if (CustomControls.MessageBox.CustomMessageBox.dialog(" تأكيد حذف الصوره نهائيا ") == DialogResult.OK)
            {

                int id_document = int.Parse(lblDecumentId.Text);
                int id_d_details = int.Parse(lbl_imageid.Text);
                EmployeeDocuments documents = selectdocument(id_document);
                EmployeeDocumentsDetails page = documents.Pages.Where(i => i.IdEmployeeDocumentsDetails == id_d_details).FirstOrDefault();

                db.EmployeeDocumentsDetails.Remove(page);
                db.SaveChanges();
                //GetAllDocuments();
                lblPageCount.Text = $"عدد الصفحات :{documents.Pages.Count()} ";
                ResetpictureViewValue();
                CreatPages(documents);
            }
        }
        #endregion


    }
   
}
