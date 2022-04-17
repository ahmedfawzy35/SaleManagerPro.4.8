﻿using CustomControls.Controls;
using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models.Products;
using SaleManagerPro.Models.Roles;
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
    public partial class FormProductAddEdit : Form
    {
        #region getter

        //
        private static FormProductAddEdit ProductAddEdit;
        static void ProductAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            ProductAddEdit = null;
        }
        public static FormProductAddEdit GetFormProductAddEdit
        {
            get
            {
                if (ProductAddEdit == null)
                {
                    ProductAddEdit = new FormProductAddEdit();
                    ProductAddEdit.FormClosed += new FormClosedEventHandler(ProductAddEdit_formclosed);
                }
                return ProductAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public FormProductAddEdit()
        {
            InitializeComponent();
            if (ProductAddEdit == null) ProductAddEdit = this;


        }


        #region Methods
        private int validations()
        {

            int error = 0;  
            if(string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم المنتج مطلوب";
                error++;
            }

            if (string.IsNullOrEmpty(textPriceSale.Texts))
            {
                textPriceSale.BackColor = Color.Red;
                labePriceSaleError.Text = "سعر البيع  مطلوب";
                error++;
            }
            if (string.IsNullOrEmpty(textPricePurchase.Texts))
            {
                textPricePurchase.BackColor = Color.Red;
                labePricePurchaseError.Text = "سعر الشراء  مطلوب";
                error++;
            }


            if (panelunit2.Visible==true)
            {
                if (string.IsNullOrEmpty(textunit2count.Texts))
                {
                    textunit2count.BackColor = Color.Red;
                    labeunit2lError.Text = "هذا الرقم مطلوب";
                    error++;
                }
               

               

            }   
            if (panelunit3.Visible==true)
            {
                if (string.IsNullOrEmpty(textunit3count.Texts))
                {
                    textunit3count.BackColor = Color.Red;
                    labeunit3lError.Text = "هذا الرقم مطلوب";
                    error++;
                }
              

               

            }
            if(error>0)
            CustomMessageBox.show($"لديك عدد  {error} اخطاء ", CustomMessageBox.enmType.Error);

            return error;
        }
        private void Textchange(CustomControls.Controls.RJTextBox textbox,Label label)
        {
            textbox.BackColor = Color.FromArgb(82, 75, 75);
            label.Text = "";
        }
        private bool IsExitsName()
        {
            Product product = db.Products.Where(c => c.Name == textName.Texts).FirstOrDefault();
            if (product != null)
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
            if(validations() >0)
            {
                return;
                
            }
            if (IsExitsName())
            {
                CustomMessageBox.show("اسم المنتج موجود بالفعل", CustomMessageBox.enmType.Error);
                return;
            }
            var product = new Product();
            product.Name = textName.Texts;
            product.Price =double.Parse( textPriceSale.Texts);
            product.LastPurchasePrice = double.Parse( textPricePurchase.Texts);
            product.LimitInStok =!string.IsNullOrEmpty(textLimitStock.Texts)? int.Parse( textLimitStock.Texts):1;
            product.StartStock =!string.IsNullOrEmpty(textStartStock.Texts)? int.Parse(textStartStock.Texts):1;
            product.IdCatogry =int.Parse(TextCatogry.SelectedValue.ToString());
            product.DateCreated = DateTime.Now;
            product.IdUser = Properties.Settings.Default.UserId;

            db.Products.Add(product);
            db.SaveChanges();
            List<ProductUnits> units = new List<ProductUnits>();
            var productunit = new ProductUnits();
            productunit.IdProduct = product.IdProduct;
            productunit.IdUnit =int.Parse( combounit1.SelectedValue.ToString());
            productunit.Count = 1;
            productunit.Rate = 1;
            units.Add(productunit);
            if (panelunit2.Visible == true)
            {
                var productunit2 = new ProductUnits();
                productunit2.IdProduct = product.IdProduct;
                productunit2.IdUnit = int.Parse(combounit2.SelectedValue.ToString());
                productunit2.Count = int.Parse(textunit2count.Texts);
                productunit2.Rate = 2;
                units.Add(productunit2);
            }
            if (panelunit3.Visible == true)
            {
                var productunit3 = new ProductUnits();
                productunit3.IdProduct = product.IdProduct;
                productunit3.IdUnit = int.Parse(combounit3.SelectedValue.ToString());
                productunit3.Count = int.Parse(textunit3count.Texts);
                productunit3.Rate = 2;
                units.Add(productunit3);
            }
            db.ProductUnits.AddRange(units);
            db.SaveChanges();
            CustomMessageBox.show("تم اضافة المنتج", CustomMessageBox.enmType.Success);
            cleartext();

        }  
        private void Edit()
        {
            
            var product =db.Products.Include(p=>p.Units).Where(x=>x.IdProduct == int.Parse(labelId.Text)).FirstOrDefault();
            if (product == null)
            {
                CustomMessageBox.dialog("قم بإختيار المنتج مجددا");
                return;
            }
            if (!canedit)
            {
                CustomMessageBox.dialog("غير مرخص بالتعديل");
                return;
            }
            if(validations() >0)
            {
                return;
                
            }
            if (product.Name != textName.Texts)
            {
                if (IsExitsName())
                {
                    CustomMessageBox.show("اسم المنتج موجود بالفعل", CustomMessageBox.enmType.Error);
                    return;
                }
            }
           
            product.Name = textName.Texts;
            product.Price =double.Parse( textPriceSale.Texts);
            product.LastPurchasePrice = double.Parse( textPricePurchase.Texts);
            product.LimitInStok = !string.IsNullOrEmpty(textLimitStock.Texts) ? int.Parse(textLimitStock.Texts) : 1;
            product.StartStock = !string.IsNullOrEmpty(textStartStock.Texts) ? int.Parse(textStartStock.Texts) : 1;
            product.IdCatogry =int.Parse(TextCatogry.SelectedValue.ToString());
            product.DateCreated = DateTime.Now;
            product.IdUser = Properties.Settings.Default.UserId;

            db.Products.Update(product);
            db.SaveChanges();


                List<ProductUnits> units = new List<ProductUnits>();

                    if (panelunit2.Visible == true && panelunit2.Enabled == true)
                    {
                    ProductUnits units2 = new ProductUnits();
                    units2.IdProduct = product.IdProduct;
                    units2.IdUnit = int.Parse(combounit2.SelectedValue.ToString());
                    units2.Count = int.Parse(textunit2count.Texts.ToString());
                    units.Add(units2);

                    }
                if (panelunit3.Visible == true && panelunit3.Enabled == true)
                {
                    ProductUnits units3 = new ProductUnits();
                    units3.IdProduct = product.IdProduct;
                    units3.IdUnit = int.Parse(combounit3.SelectedValue.ToString());
                    units3.Count = int.Parse(textunit3count.Texts.ToString());
                    units.Add(units3);

                }
                if (units.Count > 0)
                {
                    db.ProductUnits.AddRange(units);
                    db.SaveChanges();
                }

            CustomMessageBox.show("تم تعديل المنتج", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " ":textName.Texts;
            var a = db.Products.Include(x => x.User).Include(x=>x.Catogry).Select(ct => new ProductyDto
            {
                IdProduct = ct.IdProduct,
                Name = ct.Name,
                Price = ct.Price,
                LastPurchasePrice = ct.LastPurchasePrice,
                LimitInStok = ct.LimitInStok,
                CatogryName = ct.Catogry.Name,
                IsEdit = ct.IsEdit,
                DateEdit = ct.DateEdit,
                DateCreated = ct.DateCreated,
                UserName = ct.User.UserName

            }).Where(r=>r.Name.Contains(search)).ToList();
            dataGridProducts.DataSource = a;
        }

        void cleartext()
        {
            textName.Texts = "";
            textPriceSale.Texts = "";
            textPricePurchase.Texts = "0";
            textLimitStock.Texts = "";
            combounit1.Enabled = true ;

            btnSave.Text = "إضافه";
            IsNew = true;

            pictureaddunit2.Visible =true;
            pictureaddunit3.Visible =false;
            textunit2count.Texts = "";
            textunit3count.Texts = "";
            panelunit2.Visible =false;
            panelunit3.Visible =false;
            panelunit2.Enabled = true;
            search();
        }
        #endregion




        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsNew)
            {
                Add();
            }else
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
            Textchange(textPriceSale, labePriceSaleError);

        }
        //int editproductunitcount = 0;

        private async void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridProducts.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridProducts.CurrentRow.Cells[0].Value.ToString());
                var product = await db.Products.Include(p => p.Units).Where(x => x.IdProduct == id).FirstOrDefaultAsync();
                


              
                cleartext();
                pictureaddunit2.Visible = false;
                int idunit1 = product.Units.Where(x => x.Rate == 1).FirstOrDefault().IdUnit;
                combounit1.Text =db.Units.Find(idunit1).Name;
                combounit1.Enabled = false;
                if (product.Units.Count()<3)
                    {
                    pictureaddunit2.Visible = true;
                    //editproductunitcount = product.Units.Count();
                    
                    }
                if (product.Units.Count()==2)
                {
                    int idunit2 = product.Units.Where(x => x.Rate == 2).FirstOrDefault().IdUnit;
                    combounit2.Text = db.Units.Find(idunit2).Name;
                    textunit2count.Texts = product.Units.Where(x => x.Rate == 2).FirstOrDefault().Count.ToString();
                    panelunit2.Enabled = false;
                }
                
              
                labelId.Text = product.IdProduct.ToString();
                textName.Texts = product.Name;
                textPriceSale.Texts = product.Price.ToString();
                textPricePurchase.Texts = product.LastPurchasePrice.ToString();
                textLimitStock.Texts = product.LimitInStok.ToString();
                textStartStock.Texts = product.StartStock.ToString();
                btnSave.Text = "تعديل";
                IsNew = false;

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }
        }

        private void حذفالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!candelete)
            {
                CustomMessageBox.show("غير مسموح بالحذف", CustomMessageBox.enmType.Error);

                return;
            }
            if (!string.IsNullOrEmpty(dataGridProducts.CurrentRow.Cells[0].Value.ToString()))
            {
               
                try
                {
                    int id = int.Parse(dataGridProducts.CurrentRow.Cells[0].Value.ToString());
                    var product = db.Products.Find(id);
                    db.Products.Remove(product);
                    db.SaveChanges();
                    search();

                }
                catch (Exception)
                {

                    CustomMessageBox.show("لا يمكن حذف المنتج", CustomMessageBox.enmType.Error);

                }

            }
            else
            {
                MessageBox.Show("قم بإختيار تصنيف");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureaddunit2_Click(object sender, EventArgs e)
        {
            if (panelunit2.Visible == false)
            {

                    panelunit2.Visible = true;
                    pictureaddunit2.Visible = false;
                    pictureaddunit3.Visible = true;


            }
        }

        private void pictureaddunit3_Click(object sender, EventArgs e)
        {

            if (panelunit3.Visible == false)
            {
                panelunit3.Visible = true;
                pictureaddunit3.Visible = false;
            }
        }

        private void btnunit2cancel_Click(object sender, EventArgs e)
        {
            if (panelunit2.Visible == true)
            {
                panelunit2.Visible = false;
                pictureaddunit2.Visible = true;
                pictureaddunit3.Visible = false;

            }
        }

        private void btnunit3cancel_Click(object sender, EventArgs e)
        {

        }

        private void btnunit3cancel_Click_1(object sender, EventArgs e)
        {
            if (panelunit3.Visible == true)
            {
                panelunit3.Visible = false;
                pictureaddunit3.Visible = true;

            }
        }

        private void textunit2count__TextChanged(object sender, EventArgs e)
        {
            Textchange(textunit2count, labeunit2lError);

        }

        private void textunit3count__TextChanged(object sender, EventArgs e)
        {
            Textchange(textunit3count, labeunit3lError);

        }

        private void textPriceSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textPricePurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textLimitStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void textStartStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textunit2count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textunit3count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPricePurchase__TextChanged(object sender, EventArgs e)
        {
            Textchange(textPricePurchase, labePricePurchaseError);

        }

        private void textLimitStock__TextChanged(object sender, EventArgs e)
        {
            Textchange(textLimitStock, labeLimitStockError);

        }


        private void FormProductAddEdit_Load(object sender, EventArgs e)
        {
            #region permetions
            canview = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.View(Permissions.ModulsName.Product));
            cancreat = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Creat(Permissions.ModulsName.Product));
            canedit = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Edit(Permissions.ModulsName.Product));
            candelete = Master.MasterForm.GetFormMasterForm.userClaims.Any(x => x.Value == Permissions.Delete(Permissions.ModulsName.Product));
            if (!canview)
            {
                dataGridProducts.Visible = false;
            }

            #endregion
            // combo box load data
            TextCatogry.DataSource = db.Catogrys.ToList();
            TextCatogry.DisplayMember = "Name";
            TextCatogry.ValueMember = "IdCatogry";
            //var allunits = db.Units.ToList();

            combounit1.DataSource = db.Units.ToList();
            combounit1.DisplayMember = "Name";
            combounit1.ValueMember = "IdUnit";

             combounit2.DataSource = db.Units.ToList();
            combounit2.DisplayMember = "Name";
            combounit2.ValueMember = "IdUnit";

             combounit3.DataSource = db.Units.ToList();
            combounit3.DisplayMember = "Name";
            combounit3.ValueMember = "IdUnit";


            search();

        }
        #endregion
    }

    public class ProductyDto
    {

        [DisplayName("رقم المنتج")]
        public int IdProduct { get; set; }
        [DisplayName("اسم المنتج")]

        public string Name { get; set; }
        [DisplayName("سعر البيع")]

        public double Price { get; set; }
        [DisplayName("اخر سعر شراء")]

        public double LastPurchasePrice { get; set; }
        [DisplayName("حد المخزون")]

        public int LimitInStok { get; set; }

        [DisplayName("اسم التصنيف ")]

        public string CatogryName { get; set; }
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
