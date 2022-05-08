using CustomControls.Controls;
using CustomControls.MessageBox;
using Microsoft.EntityFrameworkCore;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Models;
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
    public partial class FormEmployeeAddEdit : Form
    {
        #region getter

        //
        private static FormEmployeeAddEdit EmployeeAddEdit;
        static void EmployeeAddEdit_formclosed(object sender, FormClosedEventArgs e)
        {
            EmployeeAddEdit = null;
        }
        public static FormEmployeeAddEdit GetFormProductAddEdit
        {
            get
            {
                if (EmployeeAddEdit == null)
                {
                    EmployeeAddEdit = new FormEmployeeAddEdit();
                    EmployeeAddEdit.FormClosed += new FormClosedEventHandler(EmployeeAddEdit_formclosed);
                }
                return EmployeeAddEdit;
            }
        }
        //
        #endregion
        AppDbContext db = new AppDbContext();
        bool canview, cancreat, candelete, canedit;
        bool IsNew = true;
        public FormEmployeeAddEdit()
        {
            InitializeComponent();
            if (EmployeeAddEdit == null) EmployeeAddEdit = this;


        }


        #region Methods
        private int validations()
        {

            int error = 0;
            if (string.IsNullOrEmpty(textName.Texts))
            {
                textName.BackColor = Color.Red;
                labeNamelError.Text = "أسم الموظف مطلوب";
                error++;
            }

            if (string.IsNullOrEmpty(textAdress.Texts))
            {
                textAdress.BackColor = Color.Red;
                lableAdressError.Text = "عنوان الموظف  مطلوب";
                error++;
            }
            if (string.IsNullOrEmpty(textPhone.Texts))
            {
                textPhone.BackColor = Color.Red;
                lablePhoneerror.Text = "هاتف الموظف  مطلوب";
                error++;
            }
          if (string.IsNullOrEmpty(textSalary.Texts))
            {
                textPhone.BackColor = Color.Red;
                lablePhoneerror.Text = "مرتب الموظف  مطلوب";
                error++;
            }
           if (lblIdDepartment.Text == "0")
            {
                comboDepartment.BackColor = Color.Red;
                labelDepartmentError.Text = "القسم  مطلوب";
                error++;
            }
            if (lblIdJob.Text == "0")
            {
                comboJob.BackColor = Color.Red;
                labelJobEroor.Text = "الوظيفه  مطلوب";
                error++;
            }
             if (lblIdJobDegree.Text == "0")
            {
                comboJobDegree.BackColor = Color.Red;
                labelJobDegreeError.Text = "الدرجه الاداريه  مطلوبه";
                error++;
            }
             if (lblbIdFinancialDegree.Text == "0")
            {
                comboFinancialDegree.BackColor = Color.Red;
                labelFinancialDegreeError.Text = "الدرجه الماليه  مطلوبه";
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
            Employee employee = db.Employees.Where(c => c.FullName == textName.Texts).FirstOrDefault();
            if (employee != null)
                return true;
            return false;
        }
         private int IsExitsPhonee()
        {
            int employeeyd =0;
            EmployeeDetails employee = db.EmployeeDetails.Where(c => c.Phone == textPhone.Texts).FirstOrDefault();
            if (employee != null)
                employeeyd = employee.IdEmployee ;
            return employeeyd;
        }
         private int IsExitsNationalNumber()
        {
            int employeeyd = 0;

            EmployeeDetails employee = db.EmployeeDetails.Where(c => c.NationalNumber == textNationalNumber.Texts).FirstOrDefault();
            if (employee != null)
                employeeyd = employee.IdEmployee;
            return employeeyd;
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
                CustomMessageBox.show("اسم الموظف موجود بالفعل", CustomMessageBox.enmType.Error);
                return;
            }
            int idnational = IsExitsNationalNumber();
             if (idnational > 0)
            {
                var employeeyd = db.Employees.Where(c => c.IdEmployee == idnational).FirstOrDefault();
                CustomMessageBox.show($"الرقم القومي مسجل مسبقا باسم الموظف {employeeyd.FullName}", CustomMessageBox.enmType.Error);
                return;
            }
             int idphone = IsExitsPhonee();
             if (idphone > 0)
            {
                var employeeyd = db.Employees.Where(c => c.IdEmployee == idphone).FirstOrDefault();
                CustomMessageBox.show($"رقم الهاتف مسجل مسبقا باسم الموظف {employeeyd.FullName}", CustomMessageBox.enmType.Error);
                return;
            }

            Employee employeetoadd = new Employee();
            employeetoadd.FullName = textName.Texts;
            employeetoadd.Salary =double.Parse( textSalary.Texts);
            employeetoadd.IdJob =int.Parse(lblIdJob.Text);
            employeetoadd.IdGobDegree = int.Parse(lblIdJobDegree.Text);
            employeetoadd.IdDepartment = int.Parse(lblIdDepartment.Text);
            employeetoadd.IdFinancialDegree = int.Parse(lblbIdFinancialDegree.Text);
            
            db.Employees.Add(employeetoadd);
            db.SaveChanges();

            EmployeeDetails details = new EmployeeDetails();
            details.IdEmployee = employeetoadd.IdEmployee;
            details.Adress = textAdress.Texts;
            details.DateStart = dateStart.Value;
            details.DateOfBirth = dateOfBirth.Value;
            details.DateCreated = DateTime.Now;
            details.Phone = textPhone.Texts;
            details.NationalNumber = textNationalNumber.Texts;
            details.Gender = comboGender.Text;
            details.IsMaried = comboIsMarid.Text;
            details.ScientificDegree = comboScientificDegree.Text;
            details.EducationalQualification = textEducationalQualification.Texts;
            details.IdUser = Properties.Settings.Default.UserId;
            CustomMessageBox.show("تم اضافة الموظف", CustomMessageBox.enmType.Success);
            cleartext();
            search();
        }
        private void Edit()
        {

            var product = db.Products.Include(p => p.Units).Where(x => x.IdProduct == int.Parse(labelId.Text)).FirstOrDefault();
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
            if (validations() > 0)
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
            product.Price = double.Parse(textAdress.Texts);
            product.LastPurchasePrice = double.Parse(textPhone.Texts);
            product.LimitInStok = !string.IsNullOrEmpty(textSalary.Texts) ? int.Parse(textSalary.Texts) : 1;
            product.StartStock = !string.IsNullOrEmpty(textNationalNumber.Texts) ? int.Parse(textNationalNumber.Texts) : 1;
            product.IdCatogry = int.Parse(comboJob.SelectedValue.ToString());
            product.DateCreated = DateTime.Now;
            product.IdUser = Properties.Settings.Default.UserId;

            db.Products.Update(product);
            db.SaveChanges();



            CustomMessageBox.show("تم تعديل المنتج", CustomMessageBox.enmType.Success);
            cleartext();

        }
        private void search()
        {
            string search = string.IsNullOrEmpty(textName.Texts) ? " " : textName.Texts;
            var a = db.Products.Include(x => x.User).Include(x => x.Catogry).Select(ct => new ProductyDto
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
                UserName = ct.User.UserName,
                StartStock = ct.StartStock,
                Process = new ProductProcess
                {
                    Orders = ct.Orders.Sum(x => x.Quantity),
                    OrdersBak = ct.OrdersBak.Sum(x => x.Quantity),
                    Purchase = ct.Purchase.Sum(x => x.Quantity),
                    PurchaseBack = ct.PurchaseBack.Sum(x => x.Quantity),
                    ProductEquationsAdd = ct.ProductEquations.Where(x => x.Type == ProductEquationType.Add.ToString()).Sum(e => e.Count),
                    ProductEquationsDeduct = ct.ProductEquations.Where(x => x.Type == ProductEquationType.Deduct.ToString()).Sum(e => e.Count)
                }

            }).Where(r => r.Name.Contains(search)).ToList();
            dataGridEmployee.DataSource = a;
        }

        void cleartext()
        {
            textName.Texts = "";
            textAdress.Texts = "";
            textPhone.Texts = "0";
            textSalary.Texts = "";
            comboJobDegree.Enabled = true;

            btnSave.Text = "إضافه";
            IsNew = true;

         

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
            Textchange(textAdress, lableAdressError);

        }
        //int editproductunitcount = 0;

        private async void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {
                int id = int.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
                var product = await db.Products.Include(p => p.Units).Where(x => x.IdProduct == id).FirstOrDefaultAsync();




                cleartext();
                int idunit1 = product.Units.Where(x => x.Rate == 1).FirstOrDefault().IdUnit;
                comboJobDegree.Text = db.Units.Find(idunit1).Name;
                comboJobDegree.Enabled = false;
                if (product.Units.Count() < 3)
                {
                    //editproductunitcount = product.Units.Count();

                }
                if (product.Units.Count() == 2)
                {
                    int idunit2 = product.Units.Where(x => x.Rate == 2).FirstOrDefault().IdUnit;
                    comboDepartment.Text = db.Units.Find(idunit2).Name;
                    panelunit2.Enabled = false;
                }


                labelId.Text = product.IdProduct.ToString();
                textName.Texts = product.Name;
                textAdress.Texts = product.Price.ToString();
                textPhone.Texts = product.LastPurchasePrice.ToString();
                textSalary.Texts = product.LimitInStok.ToString();
                textNationalNumber.Texts = product.StartStock.ToString();
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
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {

                try
                {
                    int id = int.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
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
               


            }
        }

        private void pictureaddunit3_Click(object sender, EventArgs e)
        {

         
        }

        private void btnunit2cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnunit3cancel_Click(object sender, EventArgs e)
        {

        }

        private void btnunit3cancel_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textunit2count__TextChanged(object sender, EventArgs e)
        {

        }

        private void textunit3count__TextChanged(object sender, EventArgs e)
        {

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

        private void textunit3count_KeyPress(object sender, KeyPressEventArgs e)
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

        private void عرضمستنداتالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridEmployee.CurrentRow.Cells[0].Value.ToString()))
            {
                int id =int.Parse( dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
                //string name = dataGridProducts.CurrentRow.Cells[1].Value.ToString();
                Master.MasterForm.GetFormMasterForm.showform($"", new FormEmployeeDocuments { EmployeeId = id});
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Master.MasterForm.GetFormMasterForm.showform($"", new FormDepartmentAddEdit());

        }

        private void textPricePurchase__TextChanged(object sender, EventArgs e)
        {
            Textchange(textPhone, lablePhoneerror);

        }

        private void textLimitStock__TextChanged(object sender, EventArgs e)
        {
            Textchange(textSalary, lableSalaryError);

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
                dataGridEmployee.Visible = false;
            }

            #endregion
            // combo box load data
            comboJob.DataSource = db.Jobs.ToList();
            comboJob.DisplayMember = "Name";
            comboJob.ValueMember = "IdJob";
            //var allunits = db.Units.ToList();

            comboJobDegree.DataSource = db.JobDegrees.ToList();
            comboJobDegree.DisplayMember = "Name";
            comboJobDegree.ValueMember = "IdGobDegree";

            comboDepartment.DataSource = db.Departments.ToList();
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "IdDepartment";

            comboScientificDegree.DataSource = Enum.GetValues(typeof(ScientificDegree));

            comboGender.DataSource = Enum.GetValues(typeof(Gender));

            comboIsMarid.DataSource = Enum.GetValues(typeof(IsMaried));


           


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
        [DisplayName("رصيد البدايه")]

        public int StartStock { get; set; }

        [DisplayName("اسم اخر مستخدم")]

        public string UserName { get; set; }
        public ProductProcess Process { get; set; }

        [DisplayName("الرصيد الحالي")]
        public int AccountBalance => StartStock + Process.Purchase + Process.OrdersBak + Process.ProductEquationsAdd - Process.Orders - Process.PurchaseBack - Process.ProductEquationsDeduct;
    }
    public class ProductProcess
    {
        public int Orders { get; set; }
        public int OrdersBak { get; set; }
        public int Purchase { get; set; }
        public int PurchaseBack { get; set; }
        public int ProductEquationsAdd { get; set; }
        public int ProductEquationsDeduct { get; set; }

    }
}
