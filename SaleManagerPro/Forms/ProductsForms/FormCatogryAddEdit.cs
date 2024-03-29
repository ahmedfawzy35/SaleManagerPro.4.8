﻿ 
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

            if (string.IsNullOrEmpty(textName .Text))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم التصنيف مطلوب";
                 MessageBox.Show("أسم التصنيف مطلوب" );
                return;
            }

            if (IsNew)
            {
                if (!cancreat)
                {
                     MessageBox.Show("غير مسموح بالاضافه" );

                    return;
                }
                if (isexits(textName .Text))
                {
                    textName.BackColor = Color.Orange;
                     MessageBox.Show("أسم التصنيف موجود بالفعل" );

                    labeNamelError.Text = "أسم التصنيف موجود بالفعل";
                    return;
                }
                Catogry cat = new Catogry();
                cat.Name = textName .Text;
                cat.Details = textDetails .Text;
                cat.IdUser = Properties.Settings.Default.UserId;
                cat.DateCreated = DateTime.Now;
                db.Catogrys.Add(cat);

                db.SaveChanges();
                 MessageBox.Show("تم حفظ التصنيف" );

                //MessageBox.Show("تم حفظ التصنيف");
            }
            else
            {
                if (!canedit)
                {
                     MessageBox.Show("غير مسموح بالتعديل" );

                    return;
                }
                int id = int.Parse(labelId.Text);
                Catogry catEdit = db.Catogrys.Find(id);
                if (catEdit == null)
                {
                    //MessageBox.Show("لم يتم العثور على التصنيف");
                    MessageBox.Show("لم يتم العثور على التصنيف");
                     MessageBox.Show("لم يتم العثور على التصنيف" );
                    return;
                }
                if (textName .Text != catEdit.Name)
                {
                    if (isexits(textName .Text))
                    {
                        textName.BackColor = Color.Orange;
                         MessageBox.Show("أسم التصنيف موجود بالفعل" );

                        labeNamelError.Text = "أسم التصنيف موجود بالفعل";
                        return;
                    }
                }
                catEdit.Name = textName .Text;
                catEdit.Details = textDetails .Text;
                catEdit.IdUser =Properties.Settings.Default.UserId;
                catEdit.IsEdit = true;
                catEdit.DateEdit = DateTime.Now;

                db.Catogrys.Update(catEdit);
                db.SaveChanges();
                 MessageBox.Show("تم تعديل التصنيف" );
                //MessageBox.Show("تم تعديل التصنيف");
            }
            cleartext();
            search();
        }

        private void textNameTextChanged(object sender, EventArgs e)
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
            string search = string.IsNullOrEmpty(textName .Text) ? " " : textName .Text;

            var a = db.Catogrys.Include(x=>x.User).Select(ct => new CatogryDto
            {
                IdCatogry = ct.IdCatogry, Name = ct.Name,Details=ct.Details,IsEdit = ct.IsEdit,DateEdit=ct.DateEdit
                ,DateCreated = ct.DateCreated,UserName = ct.User.UserName

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridCatogrys.DataSource =a;
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

        private void حذفالتصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                 MessageBox.Show("غير مسموح بالحذف" );

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

                     MessageBox.Show("لا يمكن حذف التصنيف" );

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
