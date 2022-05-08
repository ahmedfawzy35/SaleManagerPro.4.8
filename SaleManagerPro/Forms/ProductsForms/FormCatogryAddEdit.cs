using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
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

namespace SaleManagerPro.Forms.ProductsForms
{
    public partial class FormCatogryAddEdit : Form
    {
        #region getter

        //
        private static FormCatogryAddEdit CatogryAddEdit;
        static void CatogryAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            CatogryAddEdit = null;
        }
        public static FormCatogryAddEdit GetFormCatogryAddEdit
        {
            get
            {
                if (CatogryAddEdit == null)
                {
                    CatogryAddEdit = new FormCatogryAddEdit();
                    CatogryAddEdit.FormClosed += new FormClosedEventHandler(CatogryAddEdit_formclosed);
                }
                return CatogryAddEdit;
            }
        }
        //
        #endregion
        #region faildes
        private AppDbContext db = new AppDbContext();
        public bool IsNew = true;
        bool canview, cancreat, candelete, canedit;
        #endregion

        public FormCatogryAddEdit()
        {
            InitializeComponent();
            if (CatogryAddEdit == null) CatogryAddEdit = this;

        }
        #region events
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartext();
            IsNew = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم التصنيف مطلوب";
                CustomMessageBox.show("أسم التصنيف مطلوب", CustomMessageBox.enmType.Error);
                return;
            }

            if (IsNew)
            {
                if (!cancreat)
                {
                    CustomMessageBox.show("غير مسموح بالاضافه", CustomMessageBox.enmType.Error);

                    return;
                }
                if (isexits(textName.Texts))
                {
                    textName.BackColor = Color.Orange;
                    CustomMessageBox.show("أسم التصنيف موجود بالفعل", CustomMessageBox.enmType.Warning);

                    labeNamelError.Text = "أسم التصنيف موجود بالفعل";
                    return;
                }
                Catogry cat = new Catogry();
                cat.Name = textName.Texts;
                cat.Details = textDetails.Texts;
                cat.IdUser = Properties.Settings.Default.UserId;
                cat.DateCreated = DateTime.Now;
                db.Catogrys.Add(cat);

                db.SaveChanges();
                CustomMessageBox.show("تم حفظ التصنيف", CustomMessageBox.enmType.Success);

                //MessageBox.Show("تم حفظ التصنيف");
            }
            else
            {
                if (!canedit)
                {
                    CustomMessageBox.show("غير مسموح بالتعديل", CustomMessageBox.enmType.Error);

                    return;
                }
                int id = int.Parse(labelId.Text);
                Catogry catEdit = db.Catogrys.Find(id);
                if (catEdit == null)
                {
                    //MessageBox.Show("لم يتم العثور على التصنيف");
                    CustomMessageBox.dialog("لم يتم العثور على التصنيف");
                    CustomMessageBox.show("لم يتم العثور على التصنيف", CustomMessageBox.enmType.Error);
                    return;
                }
                if (textName.Texts != catEdit.Name)
                {
                    if (isexits(textName.Texts))
                    {
                        textName.BackColor = Color.Orange;
                        CustomMessageBox.show("أسم التصنيف موجود بالفعل", CustomMessageBox.enmType.Warning);

                        labeNamelError.Text = "أسم التصنيف موجود بالفعل";
                        return;
                    }
                }
                catEdit.Name = textName.Texts;
                catEdit.Details = textDetails.Texts;
                catEdit.IdUser =Properties.Settings.Default.UserId;
                catEdit.IsEdit = true;
                catEdit.DateEdit = DateTime.Now;

                db.Catogrys.Update(catEdit);
                db.SaveChanges();
                CustomMessageBox.show("تم تعديل التصنيف", CustomMessageBox.enmType.Success);
                //MessageBox.Show("تم تعديل التصنيف");
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
        private void FormCatogryAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Catogry));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Catogry));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Catogry));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Catogry));
            if (!canview)
            {
                dataGridCatogrys.Visible = false;
            }
            #endregion
            search();

            btnSave.Focus();

        }
        private void تعديلالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridCatogrys.CurrentRow.Cells[0].Value.ToString()))
            {
                string id = dataGridCatogrys.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridCatogrys.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridCatogrys.CurrentRow.Cells[2].Value.ToString();
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
        #endregion

        #region methods
        private bool isexits(string name)
        {
            Catogry cat = db.Catogrys.Where(c => c.Name == name).FirstOrDefault();
            if (cat != null)
                return true;
            return false;
        }
        private void search( )
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;

            var a = db.Catogrys.Include(x=>x.User).Select(ct => new CatogryDto
            {
                IdCatogry = ct.IdCatogry, Name = ct.Name,Details=ct.Details,IsEdit = ct.IsEdit,DateEdit=ct.DateEdit
                ,DateCreated = ct.DateCreated,UserName = ct.User.UserName

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridCatogrys.DataSource =a;
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

        private void حذفالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);

                return;
            }
            if (!string.IsNullOrEmpty(dataGridCatogrys.CurrentRow.Cells[0].Value.ToString()))
            {
               
                try
                {
                    int id = int.Parse(dataGridCatogrys.CurrentRow.Cells[0].Value.ToString());
                    var cat = db.Catogrys.Find(id);
                    db.Catogrys.Remove(cat);
                    db.SaveChanges();
                    search();
                }
                catch (Exception)
                {

                    CustomMessageBox.show("لا يمكن حذف التصنيف", CustomMessageBox.enmType.Error);

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }

        }
    }

    public class CatogryDto
    {

        [DisplayName("رقم التصنيف")]
        public int IdCatogry { get; set; }
        [DisplayName("اسم التصنيف")]

        public string Name { get; set; }
        [DisplayName("التفاصيل")]

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
