using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class EmployeePromotionAddEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new Button();
            this.panelImages = new System.Windows.Forms.Panel();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضالقرارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblbIdFinancialDegree = new System.Windows.Forms.Label();
            this.lblIdJobDegree = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labledateStartError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textAddToSalary = new TextBox();
            this.lableAddToSalaryError = new System.Windows.Forms.Label();
            this.labelFinancialDegreeError = new System.Windows.Forms.Label();
            this.textDetails = new TextBox();
            this.lableDetailsError = new System.Windows.Forms.Label();
            this.labelJobDegreeError = new System.Windows.Forms.Label();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.lblidEmployee = new System.Windows.Forms.Label();
            this.lblPictureCount = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.comboFinancialDegree = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboJobDegree = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_clear = new Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.panelImages);
            this.panel1.Controls.Add(this.dataGridEmployee);
            this.panel1.Controls.Add(this.lblbIdFinancialDegree);
            this.panel1.Controls.Add(this.lblIdJobDegree);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labledateStartError);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textAddToSalary);
            this.panel1.Controls.Add(this.lableAddToSalaryError);
            this.panel1.Controls.Add(this.labelFinancialDegreeError);
            this.panel1.Controls.Add(this.textDetails);
            this.panel1.Controls.Add(this.lableDetailsError);
            this.panel1.Controls.Add(this.labelJobDegreeError);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblidEmployee);
            this.panel1.Controls.Add(this.lblPictureCount);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Controls.Add(this.comboFinancialDegree);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboJobDegree);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 814);
            this.panel1.TabIndex = 8;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Green;
 
 
 
 
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(85, 504);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(229, 40);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.Text = "اضافة المستندات";
 
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panelImages
            // 
            this.panelImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImages.Location = new System.Drawing.Point(11, 546);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(303, 246);
            this.panelImages.TabIndex = 25;
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridEmployee.GridColor = System.Drawing.Color.Red;
            this.dataGridEmployee.Location = new System.Drawing.Point(11, 28);
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
            this.dataGridEmployee.Size = new System.Drawing.Size(233, 414);
            this.dataGridEmployee.TabIndex = 24;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالقرارToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // عرضالقرارToolStripMenuItem
            // 
            this.عرضالقرارToolStripMenuItem.Name = "عرضالقرارToolStripMenuItem";
            this.عرضالقرارToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.عرضالقرارToolStripMenuItem.Text = "عرض القرار";
            this.عرضالقرارToolStripMenuItem.Click += new System.EventHandler(this.عرضالقرارToolStripMenuItem_Click);
            // 
            // lblbIdFinancialDegree
            // 
            this.lblbIdFinancialDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbIdFinancialDegree.AutoSize = true;
            this.lblbIdFinancialDegree.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblbIdFinancialDegree.ForeColor = System.Drawing.Color.Red;
            this.lblbIdFinancialDegree.Location = new System.Drawing.Point(294, 630);
            this.lblbIdFinancialDegree.Name = "lblbIdFinancialDegree";
            this.lblbIdFinancialDegree.Size = new System.Drawing.Size(20, 25);
            this.lblbIdFinancialDegree.TabIndex = 23;
            this.lblbIdFinancialDegree.Text = "0";
            this.lblbIdFinancialDegree.Visible = false;
            // 
            // lblIdJobDegree
            // 
            this.lblIdJobDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdJobDegree.AutoSize = true;
            this.lblIdJobDegree.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblIdJobDegree.ForeColor = System.Drawing.Color.Red;
            this.lblIdJobDegree.Location = new System.Drawing.Point(294, 540);
            this.lblIdJobDegree.Name = "lblIdJobDegree";
            this.lblIdJobDegree.Size = new System.Drawing.Size(20, 25);
            this.lblIdJobDegree.TabIndex = 23;
            this.lblIdJobDegree.Text = "0";
            this.lblIdJobDegree.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(316, 375);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeftLayout = true;
            this.dateStart.Size = new System.Drawing.Size(292, 29);
            this.dateStart.TabIndex = 7;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(316, 318);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(292, 29);
            this.date.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "تاريخ التطبيق";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "تاريخ صدور القرار";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "الزياده على المرتب";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "تفاصيل الترقيه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "اختار موظف";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم الموظف";
            // 
            // labledateStartError
            // 
            this.labledateStartError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labledateStartError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labledateStartError.ForeColor = System.Drawing.Color.Red;
            this.labledateStartError.Location = new System.Drawing.Point(337, 407);
            this.labledateStartError.Name = "labledateStartError";
            this.labledateStartError.Size = new System.Drawing.Size(267, 25);
            this.labledateStartError.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(295, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 13;
            // 
            // textAddToSalary
            // 
            this.textAddToSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddToSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textAddToSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textAddToSalary.ForeColor = System.Drawing.Color.White;
            this.textAddToSalary.Location = new System.Drawing.Point(320, 239);
            this.textAddToSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textAddToSalary.Multiline = false;
            this.textAddToSalary.Name = "textAddToSalary";
            this.textAddToSalary.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textAddToSalary.Size = new System.Drawing.Size(292, 42);
            this.textAddToSalary.TabIndex = 3;
            this.textAddToSalary .Text = "";
            this.textAddToSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPricePurchase_KeyPress);
            // 
            // lableAddToSalaryError
            // 
            this.lableAddToSalaryError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lableAddToSalaryError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lableAddToSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lableAddToSalaryError.Location = new System.Drawing.Point(327, 285);
            this.lableAddToSalaryError.Name = "lableAddToSalaryError";
            this.lableAddToSalaryError.Size = new System.Drawing.Size(267, 25);
            this.lableAddToSalaryError.TabIndex = 13;
            // 
            // labelFinancialDegreeError
            // 
            this.labelFinancialDegreeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinancialDegreeError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFinancialDegreeError.ForeColor = System.Drawing.Color.Red;
            this.labelFinancialDegreeError.Location = new System.Drawing.Point(328, 584);
            this.labelFinancialDegreeError.Name = "labelFinancialDegreeError";
            this.labelFinancialDegreeError.Size = new System.Drawing.Size(267, 25);
            this.labelFinancialDegreeError.TabIndex = 20;
            // 
            // textDetails
            // 
            this.textDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textDetails.ForeColor = System.Drawing.Color.White;
            this.textDetails.Location = new System.Drawing.Point(320, 109);
            this.textDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textDetails.Size = new System.Drawing.Size(292, 79);
            this.textDetails.TabIndex = 1;
            this.textDetails .Text = "";
            this.textDetails.TextChanged += new System.EventHandler(this.textPriceSale_TextChanged);
            // 
            // lableDetailsError
            // 
            this.lableDetailsError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lableDetailsError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lableDetailsError.ForeColor = System.Drawing.Color.Red;
            this.lableDetailsError.Location = new System.Drawing.Point(327, 192);
            this.lableDetailsError.Name = "lableDetailsError";
            this.lableDetailsError.Size = new System.Drawing.Size(267, 25);
            this.lableDetailsError.TabIndex = 9;
            // 
            // labelJobDegreeError
            // 
            this.labelJobDegreeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJobDegreeError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelJobDegreeError.ForeColor = System.Drawing.Color.Red;
            this.labelJobDegreeError.Location = new System.Drawing.Point(328, 491);
            this.labelJobDegreeError.Name = "labelJobDegreeError";
            this.labelJobDegreeError.Size = new System.Drawing.Size(267, 25);
            this.labelJobDegreeError.TabIndex = 20;
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(320, 22);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 0;
            this.textName .Text = "";
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(321, 612);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 89);
            this.panel3.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;

            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(17, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;

            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(149, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 39);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "إضافه";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblidEmployee
            // 
            this.lblidEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblidEmployee.AutoSize = true;
            this.lblidEmployee.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblidEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblidEmployee.Location = new System.Drawing.Point(592, -2);
            this.lblidEmployee.Name = "lblidEmployee";
            this.lblidEmployee.Size = new System.Drawing.Size(20, 25);
            this.lblidEmployee.TabIndex = 5;
            this.lblidEmployee.Text = "0";
            this.lblidEmployee.Visible = false;
            // 
            // lblPictureCount
            // 
            this.lblPictureCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPictureCount.AutoSize = true;
            this.lblPictureCount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPictureCount.ForeColor = System.Drawing.Color.Red;
            this.lblPictureCount.Location = new System.Drawing.Point(11, 463);
            this.lblPictureCount.Name = "lblPictureCount";
            this.lblPictureCount.Size = new System.Drawing.Size(20, 25);
            this.lblPictureCount.TabIndex = 5;
            this.lblPictureCount.Text = "0";
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
            this.labelId.Size = new System.Drawing.Size(20, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "0";
            this.labelId.Visible = false;
            // 
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(327, 67);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(267, 25);
            this.labeNamelError.TabIndex = 4;
            // 
            // comboFinancialDegree
            // 
            this.comboFinancialDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFinancialDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboFinancialDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinancialDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboFinancialDegree.ForeColor = System.Drawing.Color.White;
            this.comboFinancialDegree.FormattingEnabled = true;
            this.comboFinancialDegree.ItemHeight = 24;
            this.comboFinancialDegree.Location = new System.Drawing.Point(339, 546);
            this.comboFinancialDegree.Name = "comboFinancialDegree";
            this.comboFinancialDegree.Size = new System.Drawing.Size(274, 32);
            this.comboFinancialDegree.TabIndex = 11;
            this.comboFinancialDegree.SelectedIndexChanged += new System.EventHandler(this.comboFinancialDegree_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "الدرجه الوظيفيه";
            // 
            // comboJobDegree
            // 
            this.comboJobDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboJobDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboJobDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJobDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboJobDegree.ForeColor = System.Drawing.Color.White;
            this.comboJobDegree.FormattingEnabled = true;
            this.comboJobDegree.ItemHeight = 24;
            this.comboJobDegree.Location = new System.Drawing.Point(342, 456);
            this.comboJobDegree.Name = "comboJobDegree";
            this.comboJobDegree.Size = new System.Drawing.Size(271, 32);
            this.comboJobDegree.TabIndex = 10;
            this.comboJobDegree.SelectedIndexChanged += new System.EventHandler(this.comboJobDegree_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 531);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "الدرجه الماليه";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridEmployees);
            this.panel2.Location = new System.Drawing.Point(633, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(736, 822);
            this.panel2.TabIndex = 9;
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridEmployees.GridColor = System.Drawing.Color.Red;
            this.dataGridEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmployees.MultiSelect = false;
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridEmployees.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmployees.RowTemplate.Height = 25;
            this.dataGridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployees.Size = new System.Drawing.Size(736, 765);
            this.dataGridEmployees.TabIndex = 7;
            this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;

            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(11, 504);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(68, 40);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "تفريغ";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // EmployeePromotionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePromotionAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormProductAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textName;
        private Panel panel3;
        private Button btnCancel;
        private Button btnSave;
        public Label labelId;
        public Label labeNamelError;
        private Panel panel2;
        private DataGridView dataGridEmployees;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem عرضالقرارToolStripMenuItem;
        private TextBox textAddToSalary;
        public Label lableAddToSalaryError;
        private TextBox textDetails;
        public Label lableDetailsError;
        public Panel panel1;
        private Label label6;
        private Label label5;
        private Label label8;
        private ComboBox comboJobDegree;
        private Label label1;
        public Label label10;
        private DateTimePicker dateStart;
        private DateTimePicker date;
        private Label label13;
        private ComboBox comboFinancialDegree;
        private Label label12;
        private Label label3;
        public Label labledateStartError;
        public Label labelFinancialDegreeError;
        public Label labelJobDegreeError;
        private OpenFileDialog openFileDialog1;
        public Label lblidEmployee;
        public Label lblbIdFinancialDegree;
        public Label lblIdJobDegree;
        private Label label2;
        private DataGridView dataGridEmployee;
        private Panel panelImages;
        private Button rjButton1;
        public Label lblPictureCount;
        private Button btn_clear;
    }
}