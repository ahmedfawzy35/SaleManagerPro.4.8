using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
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
    public partial class FormUnitsAddEdit : Form
    {
        #region getter

        //
        private static FormUnitsAddEdit UnitsAddEdit;
        static void UnitsAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            UnitsAddEdit = null;
        }
        public static FormUnitsAddEdit GetFormUnitsAddEdit
        {
            get
            {
                if (UnitsAddEdit == null)
                {
                    UnitsAddEdit = new FormUnitsAddEdit();
                    UnitsAddEdit.FormClosed += new FormClosedEventHandler(UnitsAddEdit_formclosed);
                }
                return UnitsAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public FormUnitsAddEdit()
        {
            InitializeComponent();
            if (UnitsAddEdit == null) UnitsAddEdit = this;
        }
        #region Methods
        private int validations()
        {

            int error = 0;
            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الوحده مطلوب";
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
        private bool IsExitsName()
        {
            Units unit = db.Units.Where(c => c.Name == textName.Texts).FirstOrDefault();
            if (unit != null)
                return true;
            return false;
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
            if (IsExitsName())
            {
                CustomMessageBox.show("اسم الوحده موجود بالفعل", CustomMessageBox.enmType.Error);
                return;
            }
            var unit = new Units();
            unit.Name = textName.Texts;
            unit.Details =textdDetails.Texts;


            db.Units.Add(unit);
            db.SaveChanges();
            CustomMessageBox.show("تم اضافة الوحده", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void Edit()
        {

            var unit = db.Units.Find(int.Parse(labelId.Text));
            if (unit == null)
            {
                CustomMessageBox.dialog("قم بإختيار الوحده مجددا");
                return;
            }
            if (!canedit)
            {
                CustomMessageBox.dialog("غير مرخص بالتعديل");
                return;
            }
            if (validations() > 0)
            {
                return;

            }
            if (unit.Name != textName.Texts)
            {
                if (IsExitsName())
                {
                    CustomMessageBox.show("اسم الوحده موجود بالفعل", CustomMessageBox.enmType.Error);
                    return;
                }
            }

            unit.Name = textName.Texts;
            unit.Details =textdDetails.Texts;
          

            db.Units.Update(unit);
            db.SaveChanges();
            CustomMessageBox.show("تم تعديل الوحده", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.Units.ToList();
            dataGridUnits.DataSource = a;
        }

        void cleartext()
        {
            textName.Texts = "";
            textdDetails.Texts = "";
       
            btnSave.Text = "إضافه";
            IsNew = true;
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
            Textchange(textdDetails, labePriceSaleError);

        }

        private void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridUnits.CurrentRow.Cells[0].Value.ToString()))
            {
                string id = dataGridUnits.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridUnits.CurrentRow.Cells[1].Value.ToString();
                string details = dataGridUnits.CurrentRow.Cells[2].Value.ToString();
                if (CustomMessageBox.dialog($"تأكيد حذف الوحده  {name}") == DialogResult.OK)
                {
                    labelId.Text = id;
                    textName.Texts = name;
                    textdDetails.Texts = details;
                    btnSave.Text = "تعديل";
                    IsNew = false;
                }
            }
            else
            {
                MessageBox.Show("قم بإختيار وحده");
            }
        }

        private void حذفالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);

                return;
            }
            if (!string.IsNullOrEmpty(dataGridUnits.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridUnits.CurrentRow.Cells[0].Value.ToString());
                    var unit = db.Units.Find(id);
                    if (CustomMessageBox.dialog($"تأكيد حذف الوحده  {unit.Name}") == DialogResult.OK)
                    {
                       
                        db.Units.Remove(unit);
                        db.SaveChanges();
                        search();
                    }

                }
                catch (Exception)
                {

                    CustomMessageBox.show("لا يمكن حذف الوحده", CustomMessageBox.enmType.Error);

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار وحده");
            }
        }

  
    


        private void FormProductAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Units));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Units));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Units));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Units));
            if (!canview)
            {
                dataGridUnits.Visible = false;
            }

            #endregion
            
            search();

        }
        #endregion
    }
}
