using System.Windows.Forms;

namespace SaleManagerPro.Forms.CustomersForms
{
    partial class FormCustomerAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerAddEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_BankAccounts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديل_العميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالتصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذف_العميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_idban = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_BankBranchName = new TextBox();
            this.text_BankName = new TextBox();
            this.text_BankAccountNumber = new TextBox();
            this.btn_bankcancel = new System.Windows.Forms.Button();
            this.btn_AddBankAccount = new System.Windows.Forms.Button();
            this.textHideInOrder = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this .textStartAccount = new TextBox();
            this.labelStartAccountError = new System.Windows.Forms.Label();
            this.textAdress = new TextBox();
            this.labelAdressError = new System.Windows.Forms.Label();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.cutomerphones = new SaleManagerPro.Forms.MultyStringBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BankAccounts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cutomerphones);
            this.panel1.Controls.Add(this.textHideInOrder);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this .textStartAccount);
            this.panel1.Controls.Add(this.labelStartAccountError);
            this.panel1.Controls.Add(this.textAdress);
            this.panel1.Controls.Add(this.labelAdressError);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 883);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "الحسابات البنكيه";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView_BankAccounts);
            this.panel4.Controls.Add(this.lbl_idban);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.text_BankBranchName);
            this.panel4.Controls.Add(this.text_BankName);
            this.panel4.Controls.Add(this.text_BankAccountNumber);
            this.panel4.Controls.Add(this.btn_bankcancel);
            this.panel4.Controls.Add(this.btn_AddBankAccount);
            this.panel4.Location = new System.Drawing.Point(13, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 261);
            this.panel4.TabIndex = 23;
            // 
            // dataGridView_BankAccounts
            // 
            this.dataGridView_BankAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BankAccounts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_BankAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_BankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BankAccounts.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_BankAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_BankAccounts.GridColor = System.Drawing.Color.Red;
            this.dataGridView_BankAccounts.Location = new System.Drawing.Point(0, 123);
            this.dataGridView_BankAccounts.MultiSelect = false;
            this.dataGridView_BankAccounts.Name = "dataGridView_BankAccounts";
            this.dataGridView_BankAccounts.ReadOnly = true;
            this.dataGridView_BankAccounts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_BankAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_BankAccounts.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridView_BankAccounts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BankAccounts.RowTemplate.Height = 25;
            this.dataGridView_BankAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BankAccounts.Size = new System.Drawing.Size(454, 136);
            this.dataGridView_BankAccounts.TabIndex = 18;
            this.dataGridView_BankAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BankAccounts_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديل_العميلToolStripMenuItem,
            this.حذفالتصنيفToolStripMenuItem,
            this.حذف_العميلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // تعديل_العميلToolStripMenuItem
            // 
            this.تعديل_العميلToolStripMenuItem.Name = "تعديل_العميلToolStripMenuItem";
            this.تعديل_العميلToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.تعديل_العميلToolStripMenuItem.Text = "تعديل العميل";
            this.تعديل_العميلToolStripMenuItem.Click += new System.EventHandler(this.تعديلالتصنيفToolStripMenuItem_Click);
            // 
            // حذفالتصنيفToolStripMenuItem
            // 
            this.حذفالتصنيفToolStripMenuItem.Name = "حذفالتصنيفToolStripMenuItem";
            this.حذفالتصنيفToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.حذفالتصنيفToolStripMenuItem.Text = "تعديل الصلاحيات";
            this.حذفالتصنيفToolStripMenuItem.Click += new System.EventHandler(this.حذفالتصنيفToolStripMenuItem_Click);
            // 
            // حذف_العميلToolStripMenuItem
            // 
            this.حذف_العميلToolStripMenuItem.Name = "حذف_العميلToolStripMenuItem";
            this.حذف_العميلToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.حذف_العميلToolStripMenuItem.Text = "حذف العميل";
            this.حذف_العميلToolStripMenuItem.Click += new System.EventHandler(this.تعديلالصلاحياتToolStripMenuItem_Click);
            // 
            // lbl_idban
            // 
            this.lbl_idban.AutoSize = true;
            this.lbl_idban.Location = new System.Drawing.Point(292, 39);
            this.lbl_idban.Name = "lbl_idban";
            this.lbl_idban.Size = new System.Drawing.Size(13, 13);
            this.lbl_idban.TabIndex = 17;
            this.lbl_idban.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "الفرع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "البنك";
            // 
            // text_BankBranchName
            // 
            this.text_BankBranchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_BankBranchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.text_BankBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.text_BankBranchName.ForeColor = System.Drawing.Color.White;
            this.text_BankBranchName.Location = new System.Drawing.Point(4, 56);
            this.text_BankBranchName.Margin = new System.Windows.Forms.Padding(4);
            this.text_BankBranchName.Multiline = false;
            this.text_BankBranchName.Name = "text_BankBranchName";
            this.text_BankBranchName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);

            this.text_BankBranchName.Size = new System.Drawing.Size(174, 31);
            this.text_BankBranchName.TabIndex = 13;
            this.text_BankBranchName .Text = "";
            this.text_BankBranchName.TextChanged += new System.EventHandler(this.text_BankBranchName_TextChanged);
            // 
            // text_BankName
            // 
            this.text_BankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_BankName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.text_BankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.text_BankName.ForeColor = System.Drawing.Color.White;
            this.text_BankName.Location = new System.Drawing.Point(186, 56);
            this.text_BankName.Margin = new System.Windows.Forms.Padding(4);
            this.text_BankName.Multiline = false;
            this.text_BankName.Name = "text_BankName";
            this.text_BankName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);

            this.text_BankName.Size = new System.Drawing.Size(253, 31);
            this.text_BankName.TabIndex = 13;
            this.text_BankName .Text = "";
            this.text_BankName.TextChanged += new System.EventHandler(this.text_BankName_TextChanged);
            // 
            // text_BankAccountNumber
            // 
            this.text_BankAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_BankAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.text_BankAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.text_BankAccountNumber.ForeColor = System.Drawing.Color.White;
            this.text_BankAccountNumber.Location = new System.Drawing.Point(-3, 4);
            this.text_BankAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.text_BankAccountNumber.Multiline = false;
            this.text_BankAccountNumber.Name = "text_BankAccountNumber";
            this.text_BankAccountNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);

            this.text_BankAccountNumber.Size = new System.Drawing.Size(457, 31);
            this.text_BankAccountNumber.TabIndex = 13;
            this.text_BankAccountNumber .Text = "";
            this.text_BankAccountNumber.TextChanged += new System.EventHandler(this.text_BankAccountNumber_TextChanged);
            // 
            // btn_bankcancel
            // 
            this.btn_bankcancel.BackColor = System.Drawing.Color.Red;
            this.btn_bankcancel.ForeColor = System.Drawing.Color.White;
            this.btn_bankcancel.Location = new System.Drawing.Point(68, 87);
            this.btn_bankcancel.Name = "btn_bankcancel";
            this.btn_bankcancel.Size = new System.Drawing.Size(59, 32);
            this.btn_bankcancel.TabIndex = 12;
            this.btn_bankcancel.Text = "الغاء";
            this.btn_bankcancel.UseVisualStyleBackColor = false;
            this.btn_bankcancel.Click += new System.EventHandler(this.btn_bankcancek_Click);
            // 
            // btn_AddBankAccount
            // 
            this.btn_AddBankAccount.Location = new System.Drawing.Point(3, 87);
            this.btn_AddBankAccount.Name = "btn_AddBankAccount";
            this.btn_AddBankAccount.Size = new System.Drawing.Size(59, 32);
            this.btn_AddBankAccount.TabIndex = 12;
            this.btn_AddBankAccount.Text = "اضافه";
            this.btn_AddBankAccount.UseVisualStyleBackColor = true;
            this.btn_AddBankAccount.Click += new System.EventHandler(this.btn_AddBankAccount_Click);
            // 
            // textHideInOrder
            // 
            this.textHideInOrder.AutoSize = true;
            this.textHideInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textHideInOrder.Location = new System.Drawing.Point(231, 740);
            this.textHideInOrder.Name = "textHideInOrder";
            this.textHideInOrder.Size = new System.Drawing.Size(130, 28);
            this.textHideInOrder.TabIndex = 21;
            this.textHideInOrder.Text = "اخفاء في الفواتير";
            this.textHideInOrder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "الرصيد المبدئي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "العنوان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم العميل";
            // 
            // textStartAccount
            // 
            this .textStartAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this .textStartAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this .textStartAccount.ForeColor = System.Drawing.Color.White;
            this .textStartAccount.Location = new System.Drawing.Point(58, 225);
            this .textStartAccount.Margin = new System.Windows.Forms.Padding(4);
            this .textStartAccount.Multiline = false;
            this .textStartAccount.Name = "textStartAccount";
            this .textStartAccount.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this .textStartAccount.Size = new System.Drawing.Size(292, 42);
            this .textStartAccount.TabIndex = 10;
            this .textStartAccount .Text = "";
            this .textStartAccount.TextChanged += new System.EventHandler(this.textRePassword_TextChanged);
            // 
            // labelStartAccountError
            // 
            this.labelStartAccountError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartAccountError.AutoSize = true;
            this.labelStartAccountError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelStartAccountError.ForeColor = System.Drawing.Color.Red;
            this.labelStartAccountError.Location = new System.Drawing.Point(146, 266);
            this.labelStartAccountError.Name = "labelStartAccountError";
            this.labelStartAccountError.Size = new System.Drawing.Size(16, 25);
            this.labelStartAccountError.TabIndex = 11;
            this.labelStartAccountError.Text = ".";
            // 
            // textAdress
            // 
            this.textAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textAdress.ForeColor = System.Drawing.Color.White;
            this.textAdress.Location = new System.Drawing.Point(58, 137);
            this.textAdress.Margin = new System.Windows.Forms.Padding(4);
            this.textAdress.Multiline = false;
            this.textAdress.Name = "textAdress";
            this.textAdress.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textAdress.Size = new System.Drawing.Size(292, 42);
            this.textAdress.TabIndex = 8;
            this.textAdress .Text = "";
            this.textAdress.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // labelAdressError
            // 
            this.labelAdressError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdressError.AutoSize = true;
            this.labelAdressError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelAdressError.ForeColor = System.Drawing.Color.Red;
            this.labelAdressError.Location = new System.Drawing.Point(146, 182);
            this.labelAdressError.Name = "labelAdressError";
            this.labelAdressError.Size = new System.Drawing.Size(16, 25);
            this.labelAdressError.TabIndex = 9;
            this.labelAdressError.Text = ".";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(58, 50);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textName.Size = new System.Drawing.Size(303, 42);
            this.textName.TabIndex = 1;
            this.textName .Text = "";
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(82, 774);
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
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.ForeColor = System.Drawing.Color.White;
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
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "إضافه";
            this.btnSave.ForeColor = System.Drawing.Color.Black;
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
            // labelNamelError
            // 
            this.labelNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamelError.AutoSize = true;
            this.labelNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNamelError.ForeColor = System.Drawing.Color.Red;
            this.labelNamelError.Location = new System.Drawing.Point(146, 95);
            this.labelNamelError.Name = "labelNamelError";
            this.labelNamelError.Size = new System.Drawing.Size(16, 25);
            this.labelNamelError.TabIndex = 4;
            this.labelNamelError.Text = ".";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(687, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(704, 883);
            this.panel2.TabIndex = 9;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridUsers.GridColor = System.Drawing.Color.Red;
            this.dataGridUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridUsers.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridUsers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.RowTemplate.Height = 25;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(704, 556);
            this.dataGridUsers.TabIndex = 0;
            // 
            // cutomerphones
            // 
            this.cutomerphones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cutomerphones.LableText = "ارقام الهواتف";
            this.cutomerphones.Location = new System.Drawing.Point(58, 294);
            this.cutomerphones.Name = "cutomerphones";
            this.cutomerphones.Size = new System.Drawing.Size(307, 160);
            this.cutomerphones.TabIndex = 22;
            this.cutomerphones.Values = ((System.Collections.Generic.List<string>)(resources.GetObject("cutomerphones.Values")));
            // 
            // FormCustomerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 883);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormUserAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BankAccounts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textName;
        private Panel panel3;
        private Button btnCancel;
        private Button btnSave;
        public Label labelId;
        public Label labelNamelError;
        private Panel panel2;
        private DataGridView dataGridUsers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديل_العميلToolStripMenuItem;
        private ToolStripMenuItem حذفالتصنيفToolStripMenuItem;
        private TextBox textStartAccount;
        public Label labelStartAccountError;
        private TextBox textAdress;
        public Label labelAdressError;
        public Panel panel1;
        private Label label6;
        private Label label5;
        private Label label7;
        private CheckBox textHideInOrder;
        private ToolStripMenuItem حذف_العميلToolStripMenuItem;
        private MultyStringBox cutomerphones;
        private Label label1;
        private Panel panel4;
        private Button btn_AddBankAccount;
        private DataGridView dataGridView_BankAccounts;
        private Label label3;
        private Label label2;
        private TextBox text_BankAccountNumber;
        private TextBox text_BankBranchName;
        private TextBox text_BankName;
        private Label lbl_idban;
        private Button btn_bankcancel;
    }
}