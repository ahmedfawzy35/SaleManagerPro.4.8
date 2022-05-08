using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class FormEmployeeAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panelunit2 = new System.Windows.Forms.Panel();
            this.pictureAddFinancialDegree = new System.Windows.Forms.PictureBox();
            this.pictureAddJobDegree = new System.Windows.Forms.PictureBox();
            this.pictureAddJob = new System.Windows.Forms.PictureBox();
            this.pictureAddDepartment = new System.Windows.Forms.PictureBox();
            this.labelScientificDegreeError = new System.Windows.Forms.Label();
            this.labelIsMaridError = new System.Windows.Forms.Label();
            this.labelcomboGenderError = new System.Windows.Forms.Label();
            this.labelFinancialDegreeError = new System.Windows.Forms.Label();
            this.labelJobDegreeError = new System.Windows.Forms.Label();
            this.labelJobEroor = new System.Windows.Forms.Label();
            this.labelDepartmentError = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboScientificDegree = new System.Windows.Forms.ComboBox();
            this.comboIsMarid = new System.Windows.Forms.ComboBox();
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.comboJobDegree = new System.Windows.Forms.ComboBox();
            this.comboFinancialDegree = new System.Windows.Forms.ComboBox();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblbIdFinancialDegree = new System.Windows.Forms.Label();
            this.lblIdJobDegree = new System.Windows.Forms.Label();
            this.lblIdJob = new System.Windows.Forms.Label();
            this.lblIdDepartment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNationalNumber = new CustomControls.Controls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textEducationalQualification = new CustomControls.Controls.RJTextBox();
            this.labelNationalNumberError = new System.Windows.Forms.Label();
            this.labelEducationalQualificationError = new System.Windows.Forms.Label();
            this.textSalary = new CustomControls.Controls.RJTextBox();
            this.lableSalaryError = new System.Windows.Forms.Label();
            this.textPhone = new CustomControls.Controls.RJTextBox();
            this.lablePhoneerror = new System.Windows.Forms.Label();
            this.textAdress = new CustomControls.Controls.RJTextBox();
            this.lableAdressError = new System.Windows.Forms.Label();
            this.textName = new CustomControls.Controls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new CustomControls.Controls.RJButton();
            this.btnSave = new CustomControls.Controls.RJButton();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضمستنداتالموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelunit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddFinancialDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddJobDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddDepartment)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.dateOfBirth);
            this.panel1.Controls.Add(this.panelunit2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textNationalNumber);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textEducationalQualification);
            this.panel1.Controls.Add(this.labelNationalNumberError);
            this.panel1.Controls.Add(this.labelEducationalQualificationError);
            this.panel1.Controls.Add(this.textSalary);
            this.panel1.Controls.Add(this.lableSalaryError);
            this.panel1.Controls.Add(this.textPhone);
            this.panel1.Controls.Add(this.lablePhoneerror);
            this.panel1.Controls.Add(this.textAdress);
            this.panel1.Controls.Add(this.lableAdressError);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 814);
            this.panel1.TabIndex = 8;
            // 
            // dateStart
            // 
            this.dateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(456, 652);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeftLayout = true;
            this.dateStart.Size = new System.Drawing.Size(292, 29);
            this.dateStart.TabIndex = 7;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth.Location = new System.Drawing.Point(456, 582);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.RightToLeftLayout = true;
            this.dateOfBirth.Size = new System.Drawing.Size(292, 29);
            this.dateOfBirth.TabIndex = 6;
            // 
            // panelunit2
            // 
            this.panelunit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelunit2.Controls.Add(this.pictureAddFinancialDegree);
            this.panelunit2.Controls.Add(this.pictureAddJobDegree);
            this.panelunit2.Controls.Add(this.pictureAddJob);
            this.panelunit2.Controls.Add(this.pictureAddDepartment);
            this.panelunit2.Controls.Add(this.labelScientificDegreeError);
            this.panelunit2.Controls.Add(this.labelIsMaridError);
            this.panelunit2.Controls.Add(this.labelcomboGenderError);
            this.panelunit2.Controls.Add(this.labelFinancialDegreeError);
            this.panelunit2.Controls.Add(this.labelJobDegreeError);
            this.panelunit2.Controls.Add(this.labelJobEroor);
            this.panelunit2.Controls.Add(this.labelDepartmentError);
            this.panelunit2.Controls.Add(this.label16);
            this.panelunit2.Controls.Add(this.label14);
            this.panelunit2.Controls.Add(this.label1);
            this.panelunit2.Controls.Add(this.label13);
            this.panelunit2.Controls.Add(this.comboGender);
            this.panelunit2.Controls.Add(this.label2);
            this.panelunit2.Controls.Add(this.comboScientificDegree);
            this.panelunit2.Controls.Add(this.comboIsMarid);
            this.panelunit2.Controls.Add(this.comboJob);
            this.panelunit2.Controls.Add(this.comboJobDegree);
            this.panelunit2.Controls.Add(this.comboFinancialDegree);
            this.panelunit2.Controls.Add(this.comboDepartment);
            this.panelunit2.Controls.Add(this.label15);
            this.panelunit2.Controls.Add(this.label4);
            this.panelunit2.Controls.Add(this.label32);
            this.panelunit2.Controls.Add(this.label31);
            this.panelunit2.Controls.Add(this.label30);
            this.panelunit2.Controls.Add(this.lblbIdFinancialDegree);
            this.panelunit2.Controls.Add(this.lblIdJobDegree);
            this.panelunit2.Controls.Add(this.lblIdJob);
            this.panelunit2.Controls.Add(this.lblIdDepartment);
            this.panelunit2.Location = new System.Drawing.Point(22, 24);
            this.panelunit2.Name = "panelunit2";
            this.panelunit2.Size = new System.Drawing.Size(427, 764);
            this.panelunit2.TabIndex = 22;
            // 
            // pictureAddFinancialDegree
            // 
            this.pictureAddFinancialDegree.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureAddFinancialDegree.Location = new System.Drawing.Point(46, 202);
            this.pictureAddFinancialDegree.Name = "pictureAddFinancialDegree";
            this.pictureAddFinancialDegree.Size = new System.Drawing.Size(29, 32);
            this.pictureAddFinancialDegree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddFinancialDegree.TabIndex = 22;
            this.pictureAddFinancialDegree.TabStop = false;
            // 
            // pictureAddJobDegree
            // 
            this.pictureAddJobDegree.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureAddJobDegree.Location = new System.Drawing.Point(47, 139);
            this.pictureAddJobDegree.Name = "pictureAddJobDegree";
            this.pictureAddJobDegree.Size = new System.Drawing.Size(29, 32);
            this.pictureAddJobDegree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddJobDegree.TabIndex = 22;
            this.pictureAddJobDegree.TabStop = false;
            // 
            // pictureAddJob
            // 
            this.pictureAddJob.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureAddJob.Location = new System.Drawing.Point(47, 75);
            this.pictureAddJob.Name = "pictureAddJob";
            this.pictureAddJob.Size = new System.Drawing.Size(29, 32);
            this.pictureAddJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddJob.TabIndex = 22;
            this.pictureAddJob.TabStop = false;
            // 
            // pictureAddDepartment
            // 
            this.pictureAddDepartment.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureAddDepartment.Location = new System.Drawing.Point(47, 9);
            this.pictureAddDepartment.Name = "pictureAddDepartment";
            this.pictureAddDepartment.Size = new System.Drawing.Size(29, 32);
            this.pictureAddDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddDepartment.TabIndex = 22;
            this.pictureAddDepartment.TabStop = false;
            this.pictureAddDepartment.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // labelScientificDegreeError
            // 
            this.labelScientificDegreeError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScientificDegreeError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelScientificDegreeError.ForeColor = System.Drawing.Color.Red;
            this.labelScientificDegreeError.Location = new System.Drawing.Point(81, 426);
            this.labelScientificDegreeError.Name = "labelScientificDegreeError";
            this.labelScientificDegreeError.Size = new System.Drawing.Size(255, 25);
            this.labelScientificDegreeError.TabIndex = 20;
            // 
            // labelIsMaridError
            // 
            this.labelIsMaridError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIsMaridError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelIsMaridError.ForeColor = System.Drawing.Color.Red;
            this.labelIsMaridError.Location = new System.Drawing.Point(82, 360);
            this.labelIsMaridError.Name = "labelIsMaridError";
            this.labelIsMaridError.Size = new System.Drawing.Size(254, 25);
            this.labelIsMaridError.TabIndex = 20;
            // 
            // labelcomboGenderError
            // 
            this.labelcomboGenderError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelcomboGenderError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelcomboGenderError.ForeColor = System.Drawing.Color.Red;
            this.labelcomboGenderError.Location = new System.Drawing.Point(83, 297);
            this.labelcomboGenderError.Name = "labelcomboGenderError";
            this.labelcomboGenderError.Size = new System.Drawing.Size(252, 25);
            this.labelcomboGenderError.TabIndex = 20;
            // 
            // labelFinancialDegreeError
            // 
            this.labelFinancialDegreeError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinancialDegreeError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFinancialDegreeError.ForeColor = System.Drawing.Color.Red;
            this.labelFinancialDegreeError.Location = new System.Drawing.Point(81, 234);
            this.labelFinancialDegreeError.Name = "labelFinancialDegreeError";
            this.labelFinancialDegreeError.Size = new System.Drawing.Size(255, 25);
            this.labelFinancialDegreeError.TabIndex = 20;
            // 
            // labelJobDegreeError
            // 
            this.labelJobDegreeError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJobDegreeError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelJobDegreeError.ForeColor = System.Drawing.Color.Red;
            this.labelJobDegreeError.Location = new System.Drawing.Point(82, 174);
            this.labelJobDegreeError.Name = "labelJobDegreeError";
            this.labelJobDegreeError.Size = new System.Drawing.Size(254, 25);
            this.labelJobDegreeError.TabIndex = 20;
            // 
            // labelJobEroor
            // 
            this.labelJobEroor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJobEroor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelJobEroor.ForeColor = System.Drawing.Color.Red;
            this.labelJobEroor.Location = new System.Drawing.Point(81, 110);
            this.labelJobEroor.Name = "labelJobEroor";
            this.labelJobEroor.Size = new System.Drawing.Size(255, 25);
            this.labelJobEroor.TabIndex = 20;
            // 
            // labelDepartmentError
            // 
            this.labelDepartmentError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepartmentError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDepartmentError.ForeColor = System.Drawing.Color.Red;
            this.labelDepartmentError.Location = new System.Drawing.Point(82, 47);
            this.labelDepartmentError.Name = "labelDepartmentError";
            this.labelDepartmentError.Size = new System.Drawing.Size(254, 25);
            this.labelDepartmentError.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(341, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "الدرجه العلميه";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "الحاله الاجتماعيه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "الدرجه الاداريه";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "الدرجه الماليه";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboGender.ForeColor = System.Drawing.Color.White;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 24;
            this.comboGender.Location = new System.Drawing.Point(83, 262);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(253, 32);
            this.comboGender.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "القسم";
            // 
            // comboScientificDegree
            // 
            this.comboScientificDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboScientificDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScientificDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboScientificDegree.ForeColor = System.Drawing.Color.White;
            this.comboScientificDegree.FormattingEnabled = true;
            this.comboScientificDegree.Location = new System.Drawing.Point(82, 391);
            this.comboScientificDegree.Name = "comboScientificDegree";
            this.comboScientificDegree.Size = new System.Drawing.Size(252, 32);
            this.comboScientificDegree.TabIndex = 14;
            // 
            // comboIsMarid
            // 
            this.comboIsMarid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboIsMarid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIsMarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboIsMarid.ForeColor = System.Drawing.Color.White;
            this.comboIsMarid.FormattingEnabled = true;
            this.comboIsMarid.Location = new System.Drawing.Point(83, 325);
            this.comboIsMarid.Name = "comboIsMarid";
            this.comboIsMarid.Size = new System.Drawing.Size(252, 32);
            this.comboIsMarid.TabIndex = 13;
            // 
            // comboJob
            // 
            this.comboJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboJob.ForeColor = System.Drawing.Color.White;
            this.comboJob.FormattingEnabled = true;
            this.comboJob.ItemHeight = 24;
            this.comboJob.Location = new System.Drawing.Point(82, 75);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(253, 32);
            this.comboJob.TabIndex = 9;
            // 
            // comboJobDegree
            // 
            this.comboJobDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboJobDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJobDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboJobDegree.ForeColor = System.Drawing.Color.White;
            this.comboJobDegree.FormattingEnabled = true;
            this.comboJobDegree.ItemHeight = 24;
            this.comboJobDegree.Location = new System.Drawing.Point(83, 139);
            this.comboJobDegree.Name = "comboJobDegree";
            this.comboJobDegree.Size = new System.Drawing.Size(252, 32);
            this.comboJobDegree.TabIndex = 10;
            // 
            // comboFinancialDegree
            // 
            this.comboFinancialDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboFinancialDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinancialDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboFinancialDegree.ForeColor = System.Drawing.Color.White;
            this.comboFinancialDegree.FormattingEnabled = true;
            this.comboFinancialDegree.ItemHeight = 24;
            this.comboFinancialDegree.Location = new System.Drawing.Point(83, 202);
            this.comboFinancialDegree.Name = "comboFinancialDegree";
            this.comboFinancialDegree.Size = new System.Drawing.Size(253, 32);
            this.comboFinancialDegree.TabIndex = 11;
            // 
            // comboDepartment
            // 
            this.comboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboDepartment.ForeColor = System.Drawing.Color.White;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(82, 9);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(253, 32);
            this.comboDepartment.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "النوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "الوظيفه";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(3, 398);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 48);
            this.label32.TabIndex = 5;
            this.label32.Text = "0";
            this.label32.Visible = false;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(3, 334);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 48);
            this.label31.TabIndex = 5;
            this.label31.Text = "0";
            this.label31.Visible = false;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(3, 274);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 48);
            this.label30.TabIndex = 5;
            this.label30.Text = "0";
            this.label30.Visible = false;
            // 
            // lblbIdFinancialDegree
            // 
            this.lblbIdFinancialDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbIdFinancialDegree.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblbIdFinancialDegree.ForeColor = System.Drawing.Color.Red;
            this.lblbIdFinancialDegree.Location = new System.Drawing.Point(-1, 210);
            this.lblbIdFinancialDegree.Name = "lblbIdFinancialDegree";
            this.lblbIdFinancialDegree.Size = new System.Drawing.Size(13, 48);
            this.lblbIdFinancialDegree.TabIndex = 5;
            this.lblbIdFinancialDegree.Text = "0";
            this.lblbIdFinancialDegree.Visible = false;
            // 
            // lblIdJobDegree
            // 
            this.lblIdJobDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdJobDegree.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIdJobDegree.ForeColor = System.Drawing.Color.Red;
            this.lblIdJobDegree.Location = new System.Drawing.Point(-1, 154);
            this.lblIdJobDegree.Name = "lblIdJobDegree";
            this.lblIdJobDegree.Size = new System.Drawing.Size(13, 48);
            this.lblIdJobDegree.TabIndex = 5;
            this.lblIdJobDegree.Text = "0";
            this.lblIdJobDegree.Visible = false;
            // 
            // lblIdJob
            // 
            this.lblIdJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdJob.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIdJob.ForeColor = System.Drawing.Color.Red;
            this.lblIdJob.Location = new System.Drawing.Point(-1, 82);
            this.lblIdJob.Name = "lblIdJob";
            this.lblIdJob.Size = new System.Drawing.Size(13, 48);
            this.lblIdJob.TabIndex = 5;
            this.lblIdJob.Text = "0";
            this.lblIdJob.Visible = false;
            // 
            // lblIdDepartment
            // 
            this.lblIdDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdDepartment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIdDepartment.ForeColor = System.Drawing.Color.Red;
            this.lblIdDepartment.Location = new System.Drawing.Point(3, 16);
            this.lblIdDepartment.Name = "lblIdDepartment";
            this.lblIdDepartment.Size = new System.Drawing.Size(13, 48);
            this.lblIdDepartment.TabIndex = 5;
            this.lblIdDepartment.Text = "0";
            this.lblIdDepartment.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(591, 636);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "تاريخ التعيين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "تاريخ الميلاد";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "الرقم القومي";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(586, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "المؤهل الدراسي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "المرتب الاساسي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "الهاتف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "العنوان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم الموظف";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(473, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(433, 25);
            this.label9.TabIndex = 13;
            // 
            // textNationalNumber
            // 
            this.textNationalNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textNationalNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textNationalNumber.BorderFocusColor = System.Drawing.Color.Red;
            this.textNationalNumber.BorderRadius = 15;
            this.textNationalNumber.BorderSize = 2;
            this.textNationalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textNationalNumber.ForeColor = System.Drawing.Color.White;
            this.textNationalNumber.Location = new System.Drawing.Point(456, 470);
            this.textNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNationalNumber.Multiline = false;
            this.textNationalNumber.Name = "textNationalNumber";
            this.textNationalNumber.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textNationalNumber.PasswordChar = false;
            this.textNationalNumber.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textNationalNumber.PlaceholderText = "الرقم القومي";
            this.textNationalNumber.Size = new System.Drawing.Size(292, 42);
            this.textNationalNumber.TabIndex = 5;
            this.textNationalNumber.Texts = "";
            this.textNationalNumber.UnderlinedStyle = false;
            this.textNationalNumber._TextChanged += new System.EventHandler(this.textLimitStock__TextChanged);
            this.textNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStartStock_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(473, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(433, 25);
            this.label10.TabIndex = 13;
            // 
            // textEducationalQualification
            // 
            this.textEducationalQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textEducationalQualification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textEducationalQualification.BorderFocusColor = System.Drawing.Color.Red;
            this.textEducationalQualification.BorderRadius = 15;
            this.textEducationalQualification.BorderSize = 2;
            this.textEducationalQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textEducationalQualification.ForeColor = System.Drawing.Color.White;
            this.textEducationalQualification.Location = new System.Drawing.Point(456, 372);
            this.textEducationalQualification.Margin = new System.Windows.Forms.Padding(4);
            this.textEducationalQualification.Multiline = false;
            this.textEducationalQualification.Name = "textEducationalQualification";
            this.textEducationalQualification.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textEducationalQualification.PasswordChar = false;
            this.textEducationalQualification.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textEducationalQualification.PlaceholderText = "المؤهل الدراسي";
            this.textEducationalQualification.Size = new System.Drawing.Size(292, 42);
            this.textEducationalQualification.TabIndex = 4;
            this.textEducationalQualification.Texts = "";
            this.textEducationalQualification.UnderlinedStyle = false;
            this.textEducationalQualification._TextChanged += new System.EventHandler(this.textLimitStock__TextChanged);
            this.textEducationalQualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLimitStock_KeyPress);
            // 
            // labelNationalNumberError
            // 
            this.labelNationalNumberError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNationalNumberError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNationalNumberError.ForeColor = System.Drawing.Color.Red;
            this.labelNationalNumberError.Location = new System.Drawing.Point(461, 516);
            this.labelNationalNumberError.Name = "labelNationalNumberError";
            this.labelNationalNumberError.Size = new System.Drawing.Size(287, 25);
            this.labelNationalNumberError.TabIndex = 13;
            // 
            // labelEducationalQualificationError
            // 
            this.labelEducationalQualificationError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEducationalQualificationError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelEducationalQualificationError.ForeColor = System.Drawing.Color.Red;
            this.labelEducationalQualificationError.Location = new System.Drawing.Point(461, 418);
            this.labelEducationalQualificationError.Name = "labelEducationalQualificationError";
            this.labelEducationalQualificationError.Size = new System.Drawing.Size(273, 25);
            this.labelEducationalQualificationError.TabIndex = 13;
            // 
            // textSalary
            // 
            this.textSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textSalary.BorderFocusColor = System.Drawing.Color.Red;
            this.textSalary.BorderRadius = 15;
            this.textSalary.BorderSize = 2;
            this.textSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textSalary.ForeColor = System.Drawing.Color.White;
            this.textSalary.Location = new System.Drawing.Point(456, 287);
            this.textSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textSalary.Multiline = false;
            this.textSalary.Name = "textSalary";
            this.textSalary.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textSalary.PasswordChar = false;
            this.textSalary.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textSalary.PlaceholderText = "المرتب الاساسي";
            this.textSalary.Size = new System.Drawing.Size(292, 42);
            this.textSalary.TabIndex = 3;
            this.textSalary.Texts = "";
            this.textSalary.UnderlinedStyle = false;
            this.textSalary._TextChanged += new System.EventHandler(this.textLimitStock__TextChanged);
            this.textSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLimitStock_KeyPress);
            // 
            // lableSalaryError
            // 
            this.lableSalaryError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lableSalaryError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lableSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lableSalaryError.Location = new System.Drawing.Point(461, 333);
            this.lableSalaryError.Name = "lableSalaryError";
            this.lableSalaryError.Size = new System.Drawing.Size(268, 25);
            this.lableSalaryError.TabIndex = 13;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textPhone.BorderFocusColor = System.Drawing.Color.Red;
            this.textPhone.BorderRadius = 15;
            this.textPhone.BorderSize = 2;
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPhone.ForeColor = System.Drawing.Color.White;
            this.textPhone.Location = new System.Drawing.Point(456, 199);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textPhone.Multiline = false;
            this.textPhone.Name = "textPhone";
            this.textPhone.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textPhone.PasswordChar = false;
            this.textPhone.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textPhone.PlaceholderText = "الهاتف";
            this.textPhone.Size = new System.Drawing.Size(292, 42);
            this.textPhone.TabIndex = 2;
            this.textPhone.Texts = "";
            this.textPhone.UnderlinedStyle = false;
            this.textPhone._TextChanged += new System.EventHandler(this.textPricePurchase__TextChanged);
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPricePurchase_KeyPress);
            // 
            // lablePhoneerror
            // 
            this.lablePhoneerror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lablePhoneerror.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lablePhoneerror.ForeColor = System.Drawing.Color.Red;
            this.lablePhoneerror.Location = new System.Drawing.Point(473, 245);
            this.lablePhoneerror.Name = "lablePhoneerror";
            this.lablePhoneerror.Size = new System.Drawing.Size(256, 25);
            this.lablePhoneerror.TabIndex = 11;
            // 
            // textAdress
            // 
            this.textAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textAdress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textAdress.BorderFocusColor = System.Drawing.Color.Red;
            this.textAdress.BorderRadius = 15;
            this.textAdress.BorderSize = 2;
            this.textAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textAdress.ForeColor = System.Drawing.Color.White;
            this.textAdress.Location = new System.Drawing.Point(456, 111);
            this.textAdress.Margin = new System.Windows.Forms.Padding(4);
            this.textAdress.Multiline = false;
            this.textAdress.Name = "textAdress";
            this.textAdress.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textAdress.PasswordChar = false;
            this.textAdress.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textAdress.PlaceholderText = "العنوان";
            this.textAdress.Size = new System.Drawing.Size(292, 42);
            this.textAdress.TabIndex = 1;
            this.textAdress.Texts = "";
            this.textAdress.UnderlinedStyle = false;
            this.textAdress._TextChanged += new System.EventHandler(this.textPriceSale__TextChanged);
            this.textAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceSale_KeyPress);
            // 
            // lableAdressError
            // 
            this.lableAdressError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lableAdressError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lableAdressError.ForeColor = System.Drawing.Color.Red;
            this.lableAdressError.Location = new System.Drawing.Point(473, 156);
            this.lableAdressError.Name = "lableAdressError";
            this.lableAdressError.Size = new System.Drawing.Size(261, 25);
            this.lableAdressError.TabIndex = 9;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textName.BorderFocusColor = System.Drawing.Color.Red;
            this.textName.BorderRadius = 15;
            this.textName.BorderSize = 2;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(456, 24);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textName.PasswordChar = false;
            this.textName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textName.PlaceholderText = "اسم الموظف";
            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 0;
            this.textName.Texts = "";
            this.textName.UnderlinedStyle = false;
            this.textName._TextChanged += new System.EventHandler(this.textName__TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(456, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 89);
            this.panel3.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(17, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.BackgroundColor = System.Drawing.Color.Lime;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(149, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 39);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "إضافه";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelId.ForeColor = System.Drawing.Color.Red;
            this.labelId.Location = new System.Drawing.Point(3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "0";
            this.labelId.Visible = false;
            // 
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(473, 69);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(266, 25);
            this.labeNamelError.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridEmployee);
            this.panel2.Location = new System.Drawing.Point(769, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(600, 822);
            this.panel2.TabIndex = 9;
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridEmployee.GridColor = System.Drawing.Color.Red;
            this.dataGridEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmployee.MultiSelect = false;
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.ReadOnly = true;
            this.dataGridEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEmployee.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridEmployee.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmployee.RowTemplate.Height = 25;
            this.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployee.Size = new System.Drawing.Size(600, 544);
            this.dataGridEmployee.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالمنتجToolStripMenuItem,
            this.حذفالمنتجToolStripMenuItem,
            this.عرضمستنداتالموظفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 70);
            // 
            // تعديلالمنتجToolStripMenuItem
            // 
            this.تعديلالمنتجToolStripMenuItem.Name = "تعديلالمنتجToolStripMenuItem";
            this.تعديلالمنتجToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.تعديلالمنتجToolStripMenuItem.Text = "تعديل المنتج";
            this.تعديلالمنتجToolStripMenuItem.Click += new System.EventHandler(this.تعديلالمنتجToolStripMenuItem_Click);
            // 
            // حذفالمنتجToolStripMenuItem
            // 
            this.حذفالمنتجToolStripMenuItem.Name = "حذفالمنتجToolStripMenuItem";
            this.حذفالمنتجToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.حذفالمنتجToolStripMenuItem.Text = "حذف المنتج";
            this.حذفالمنتجToolStripMenuItem.Click += new System.EventHandler(this.حذفالمنتجToolStripMenuItem_Click);
            // 
            // عرضمستنداتالموظفToolStripMenuItem
            // 
            this.عرضمستنداتالموظفToolStripMenuItem.Name = "عرضمستنداتالموظفToolStripMenuItem";
            this.عرضمستنداتالموظفToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.عرضمستنداتالموظفToolStripMenuItem.Text = "عرض مستندات الموظف";
            this.عرضمستنداتالموظفToolStripMenuItem.Click += new System.EventHandler(this.عرضمستنداتالموظفToolStripMenuItem_Click);
            // 
            // FormEmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormProductAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelunit2.ResumeLayout(false);
            this.panelunit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddFinancialDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddJobDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddDepartment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.Controls.RJTextBox textName;
        private Panel panel3;
        private CustomControls.Controls.RJButton btnCancel;
        private CustomControls.Controls.RJButton btnSave;
        public Label labelId;
        public Label labeNamelError;
        private Panel panel2;
        private DataGridView dataGridEmployee;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلالمنتجToolStripMenuItem;
        private ToolStripMenuItem حذفالمنتجToolStripMenuItem;
        private CustomControls.Controls.RJTextBox textSalary;
        public Label lableSalaryError;
        private CustomControls.Controls.RJTextBox textPhone;
        public Label lablePhoneerror;
        private CustomControls.Controls.RJTextBox textAdress;
        public Label lableAdressError;
        private Label label4;
        public Panel panel1;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private ComboBox comboJob;
        private ComboBox comboJobDegree;
        private Label label1;
        private Panel panelunit2;
        private ComboBox comboDepartment;
        public Label labelDepartmentError;
        private Label label11;
        private CustomControls.Controls.RJTextBox textNationalNumber;
        public Label label10;
        private Label label2;
        private DateTimePicker dateStart;
        private DateTimePicker dateOfBirth;
        private Label label14;
        private Label label13;
        private ComboBox comboGender;
        private ComboBox comboIsMarid;
        private ComboBox comboFinancialDegree;
        private Label label15;
        private Label label12;
        private Label label3;
        public Label label9;
        private Label label16;
        private ComboBox comboScientificDegree;
        private Label label18;
        private CustomControls.Controls.RJTextBox textEducationalQualification;
        public Label labelEducationalQualificationError;
        public Label labelNationalNumberError;
        public Label labelScientificDegreeError;
        public Label labelIsMaridError;
        public Label labelcomboGenderError;
        public Label labelFinancialDegreeError;
        public Label labelJobDegreeError;
        public Label labelJobEroor;
        public Label label32;
        public Label label31;
        public Label label30;
        public Label lblbIdFinancialDegree;
        public Label lblIdJobDegree;
        public Label lblIdJob;
        public Label lblIdDepartment;
        private PictureBox pictureAddFinancialDegree;
        private PictureBox pictureAddJobDegree;
        private PictureBox pictureAddJob;
        private PictureBox pictureAddDepartment;
        private ToolStripMenuItem عرضمستنداتالموظفToolStripMenuItem;
    }
}