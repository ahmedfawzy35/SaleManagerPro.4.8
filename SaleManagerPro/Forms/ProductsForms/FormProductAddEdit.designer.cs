using System.Windows.Forms;

namespace SaleManagerPro.Forms.ProductsForms
{
    partial class FormProductAddEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelunit3 = new System.Windows.Forms.Panel();
            this.btnunit3cancel = new CustomControls.Controls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textunit3count = new CustomControls.Controls.RJTextBox();
            this.combounit3 = new System.Windows.Forms.ComboBox();
            this.pictureaddunit3 = new System.Windows.Forms.PictureBox();
            this.pictureaddunit2 = new System.Windows.Forms.PictureBox();
            this.panelunit2 = new System.Windows.Forms.Panel();
            this.btnunit2cancel = new CustomControls.Controls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textunit2count = new CustomControls.Controls.RJTextBox();
            this.combounit2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextCatogry = new System.Windows.Forms.ComboBox();
            this.combounit1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLimitStock = new CustomControls.Controls.RJTextBox();
            this.labeLimitStockError = new System.Windows.Forms.Label();
            this.textPricePurchase = new CustomControls.Controls.RJTextBox();
            this.labePricePurchaseError = new System.Windows.Forms.Label();
            this.textPriceSale = new CustomControls.Controls.RJTextBox();
            this.labePriceSaleError = new System.Windows.Forms.Label();
            this.textName = new CustomControls.Controls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new CustomControls.Controls.RJButton();
            this.btnSave = new CustomControls.Controls.RJButton();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.labeunit2lError = new System.Windows.Forms.Label();
            this.labeunit3lError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textStartStock = new CustomControls.Controls.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelunit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureaddunit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureaddunit2)).BeginInit();
            this.panelunit2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panelunit3);
            this.panel1.Controls.Add(this.pictureaddunit3);
            this.panel1.Controls.Add(this.panelunit2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextCatogry);
            this.panel1.Controls.Add(this.combounit1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textStartStock);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textLimitStock);
            this.panel1.Controls.Add(this.labeLimitStockError);
            this.panel1.Controls.Add(this.textPricePurchase);
            this.panel1.Controls.Add(this.labePricePurchaseError);
            this.panel1.Controls.Add(this.textPriceSale);
            this.panel1.Controls.Add(this.labePriceSaleError);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Controls.Add(this.pictureaddunit2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 703);
            this.panel1.TabIndex = 8;
            // 
            // panelunit3
            // 
            this.panelunit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelunit3.Controls.Add(this.labeunit3lError);
            this.panelunit3.Controls.Add(this.btnunit3cancel);
            this.panelunit3.Controls.Add(this.label3);
            this.panelunit3.Controls.Add(this.textunit3count);
            this.panelunit3.Controls.Add(this.combounit3);
            this.panelunit3.Location = new System.Drawing.Point(5, 241);
            this.panelunit3.Name = "panelunit3";
            this.panelunit3.Size = new System.Drawing.Size(280, 198);
            this.panelunit3.TabIndex = 25;
            this.panelunit3.Visible = false;
            // 
            // btnunit3cancel
            // 
            this.btnunit3cancel.BackColor = System.Drawing.Color.Red;
            this.btnunit3cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btnunit3cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnunit3cancel.BorderRadius = 15;
            this.btnunit3cancel.BorderSize = 0;
            this.btnunit3cancel.FlatAppearance.BorderSize = 0;
            this.btnunit3cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunit3cancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnunit3cancel.ForeColor = System.Drawing.Color.White;
            this.btnunit3cancel.Location = new System.Drawing.Point(14, 156);
            this.btnunit3cancel.Name = "btnunit3cancel";
            this.btnunit3cancel.Size = new System.Drawing.Size(81, 39);
            this.btnunit3cancel.TabIndex = 19;
            this.btnunit3cancel.Text = "الغاء";
            this.btnunit3cancel.TextColor = System.Drawing.Color.White;
            this.btnunit3cancel.UseVisualStyleBackColor = false;
            this.btnunit3cancel.Click += new System.EventHandler(this.btnunit3cancel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "الوحده الثالثه";
            // 
            // textunit3count
            // 
            this.textunit3count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textunit3count.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textunit3count.BorderFocusColor = System.Drawing.Color.Red;
            this.textunit3count.BorderRadius = 15;
            this.textunit3count.BorderSize = 2;
            this.textunit3count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textunit3count.ForeColor = System.Drawing.Color.White;
            this.textunit3count.Location = new System.Drawing.Point(14, 97);
            this.textunit3count.Margin = new System.Windows.Forms.Padding(4);
            this.textunit3count.Multiline = false;
            this.textunit3count.Name = "textunit3count";
            this.textunit3count.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textunit3count.PasswordChar = false;
            this.textunit3count.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textunit3count.PlaceholderText = "عدد الوحدات الاساسيه";
            this.textunit3count.Size = new System.Drawing.Size(253, 42);
            this.textunit3count.TabIndex = 17;
            this.textunit3count.Texts = "";
            this.textunit3count.UnderlinedStyle = false;
            this.textunit3count._TextChanged += new System.EventHandler(this.textunit3count__TextChanged);
            this.textunit3count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textunit3count_KeyPress);
            // 
            // combounit3
            // 
            this.combounit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.combounit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combounit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combounit3.ForeColor = System.Drawing.Color.White;
            this.combounit3.FormattingEnabled = true;
            this.combounit3.Location = new System.Drawing.Point(14, 45);
            this.combounit3.Name = "combounit3";
            this.combounit3.Size = new System.Drawing.Size(253, 32);
            this.combounit3.TabIndex = 16;
            // 
            // pictureaddunit3
            // 
            this.pictureaddunit3.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureaddunit3.Location = new System.Drawing.Point(127, 246);
            this.pictureaddunit3.Name = "pictureaddunit3";
            this.pictureaddunit3.Size = new System.Drawing.Size(48, 48);
            this.pictureaddunit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureaddunit3.TabIndex = 24;
            this.pictureaddunit3.TabStop = false;
            this.pictureaddunit3.Visible = false;
            this.pictureaddunit3.Click += new System.EventHandler(this.pictureaddunit3_Click);
            // 
            // pictureaddunit2
            // 
            this.pictureaddunit2.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.pictureaddunit2.Location = new System.Drawing.Point(127, 43);
            this.pictureaddunit2.Name = "pictureaddunit2";
            this.pictureaddunit2.Size = new System.Drawing.Size(48, 48);
            this.pictureaddunit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureaddunit2.TabIndex = 23;
            this.pictureaddunit2.TabStop = false;
            this.pictureaddunit2.Click += new System.EventHandler(this.pictureaddunit2_Click);
            // 
            // panelunit2
            // 
            this.panelunit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelunit2.Controls.Add(this.labeunit2lError);
            this.panelunit2.Controls.Add(this.btnunit2cancel);
            this.panelunit2.Controls.Add(this.label2);
            this.panelunit2.Controls.Add(this.textunit2count);
            this.panelunit2.Controls.Add(this.combounit2);
            this.panelunit2.Location = new System.Drawing.Point(5, 43);
            this.panelunit2.Name = "panelunit2";
            this.panelunit2.Size = new System.Drawing.Size(280, 197);
            this.panelunit2.TabIndex = 22;
            this.panelunit2.Visible = false;
            // 
            // btnunit2cancel
            // 
            this.btnunit2cancel.BackColor = System.Drawing.Color.Red;
            this.btnunit2cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btnunit2cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnunit2cancel.BorderRadius = 15;
            this.btnunit2cancel.BorderSize = 0;
            this.btnunit2cancel.FlatAppearance.BorderSize = 0;
            this.btnunit2cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunit2cancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnunit2cancel.ForeColor = System.Drawing.Color.White;
            this.btnunit2cancel.Location = new System.Drawing.Point(14, 152);
            this.btnunit2cancel.Name = "btnunit2cancel";
            this.btnunit2cancel.Size = new System.Drawing.Size(81, 39);
            this.btnunit2cancel.TabIndex = 19;
            this.btnunit2cancel.Text = "الغاء";
            this.btnunit2cancel.TextColor = System.Drawing.Color.White;
            this.btnunit2cancel.UseVisualStyleBackColor = false;
            this.btnunit2cancel.Click += new System.EventHandler(this.btnunit2cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "الوحده الثانيه";
            // 
            // textunit2count
            // 
            this.textunit2count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textunit2count.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textunit2count.BorderFocusColor = System.Drawing.Color.Red;
            this.textunit2count.BorderRadius = 15;
            this.textunit2count.BorderSize = 2;
            this.textunit2count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textunit2count.ForeColor = System.Drawing.Color.White;
            this.textunit2count.Location = new System.Drawing.Point(14, 97);
            this.textunit2count.Margin = new System.Windows.Forms.Padding(4);
            this.textunit2count.Multiline = false;
            this.textunit2count.Name = "textunit2count";
            this.textunit2count.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textunit2count.PasswordChar = false;
            this.textunit2count.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textunit2count.PlaceholderText = "عدد الوحدات الاساسيه";
            this.textunit2count.Size = new System.Drawing.Size(253, 42);
            this.textunit2count.TabIndex = 17;
            this.textunit2count.Texts = "";
            this.textunit2count.UnderlinedStyle = false;
            this.textunit2count._TextChanged += new System.EventHandler(this.textunit2count__TextChanged);
            this.textunit2count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textunit2count_KeyPress);
            // 
            // combounit2
            // 
            this.combounit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.combounit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combounit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combounit2.ForeColor = System.Drawing.Color.White;
            this.combounit2.FormattingEnabled = true;
            this.combounit2.Location = new System.Drawing.Point(14, 45);
            this.combounit2.Name = "combounit2";
            this.combounit2.Size = new System.Drawing.Size(253, 32);
            this.combounit2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "الوحده الاساسيه";
            // 
            // TextCatogry
            // 
            this.TextCatogry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TextCatogry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextCatogry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextCatogry.ForeColor = System.Drawing.Color.White;
            this.TextCatogry.FormattingEnabled = true;
            this.TextCatogry.Location = new System.Drawing.Point(298, 494);
            this.TextCatogry.Name = "TextCatogry";
            this.TextCatogry.Size = new System.Drawing.Size(283, 32);
            this.TextCatogry.TabIndex = 4;
            // 
            // combounit1
            // 
            this.combounit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.combounit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combounit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combounit1.ForeColor = System.Drawing.Color.White;
            this.combounit1.FormattingEnabled = true;
            this.combounit1.Location = new System.Drawing.Point(299, 554);
            this.combounit1.Name = "combounit1";
            this.combounit1.Size = new System.Drawing.Size(283, 32);
            this.combounit1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "الحد الادني في المخرن";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "سعر الشراء";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "سعر البيع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "التصنيف";
            // 
            // textLimitStock
            // 
            this.textLimitStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textLimitStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textLimitStock.BorderFocusColor = System.Drawing.Color.Red;
            this.textLimitStock.BorderRadius = 15;
            this.textLimitStock.BorderSize = 2;
            this.textLimitStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textLimitStock.ForeColor = System.Drawing.Color.White;
            this.textLimitStock.Location = new System.Drawing.Point(290, 299);
            this.textLimitStock.Margin = new System.Windows.Forms.Padding(4);
            this.textLimitStock.Multiline = false;
            this.textLimitStock.Name = "textLimitStock";
            this.textLimitStock.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textLimitStock.PasswordChar = false;
            this.textLimitStock.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textLimitStock.PlaceholderText = "الحد الادنى في المخزن";
            this.textLimitStock.Size = new System.Drawing.Size(292, 42);
            this.textLimitStock.TabIndex = 3;
            this.textLimitStock.Texts = "";
            this.textLimitStock.UnderlinedStyle = false;
            this.textLimitStock._TextChanged += new System.EventHandler(this.textLimitStock__TextChanged);
            this.textLimitStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLimitStock_KeyPress);
            // 
            // labeLimitStockError
            // 
            this.labeLimitStockError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeLimitStockError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeLimitStockError.ForeColor = System.Drawing.Color.Red;
            this.labeLimitStockError.Location = new System.Drawing.Point(307, 344);
            this.labeLimitStockError.Name = "labeLimitStockError";
            this.labeLimitStockError.Size = new System.Drawing.Size(265, 25);
            this.labeLimitStockError.TabIndex = 13;
            // 
            // textPricePurchase
            // 
            this.textPricePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textPricePurchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textPricePurchase.BorderFocusColor = System.Drawing.Color.Red;
            this.textPricePurchase.BorderRadius = 15;
            this.textPricePurchase.BorderSize = 2;
            this.textPricePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPricePurchase.ForeColor = System.Drawing.Color.White;
            this.textPricePurchase.Location = new System.Drawing.Point(290, 218);
            this.textPricePurchase.Margin = new System.Windows.Forms.Padding(4);
            this.textPricePurchase.Multiline = false;
            this.textPricePurchase.Name = "textPricePurchase";
            this.textPricePurchase.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textPricePurchase.PasswordChar = false;
            this.textPricePurchase.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textPricePurchase.PlaceholderText = "سعر الشراء";
            this.textPricePurchase.Size = new System.Drawing.Size(292, 42);
            this.textPricePurchase.TabIndex = 2;
            this.textPricePurchase.Texts = "";
            this.textPricePurchase.UnderlinedStyle = false;
            this.textPricePurchase._TextChanged += new System.EventHandler(this.textPricePurchase__TextChanged);
            this.textPricePurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPricePurchase_KeyPress);
            // 
            // labePricePurchaseError
            // 
            this.labePricePurchaseError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labePricePurchaseError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labePricePurchaseError.ForeColor = System.Drawing.Color.Red;
            this.labePricePurchaseError.Location = new System.Drawing.Point(307, 259);
            this.labePricePurchaseError.Name = "labePricePurchaseError";
            this.labePricePurchaseError.Size = new System.Drawing.Size(265, 25);
            this.labePricePurchaseError.TabIndex = 11;
            // 
            // textPriceSale
            // 
            this.textPriceSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textPriceSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textPriceSale.BorderFocusColor = System.Drawing.Color.Red;
            this.textPriceSale.BorderRadius = 15;
            this.textPriceSale.BorderSize = 2;
            this.textPriceSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPriceSale.ForeColor = System.Drawing.Color.White;
            this.textPriceSale.Location = new System.Drawing.Point(290, 130);
            this.textPriceSale.Margin = new System.Windows.Forms.Padding(4);
            this.textPriceSale.Multiline = false;
            this.textPriceSale.Name = "textPriceSale";
            this.textPriceSale.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textPriceSale.PasswordChar = false;
            this.textPriceSale.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textPriceSale.PlaceholderText = "سعر البيع";
            this.textPriceSale.Size = new System.Drawing.Size(292, 42);
            this.textPriceSale.TabIndex = 1;
            this.textPriceSale.Texts = "";
            this.textPriceSale.UnderlinedStyle = false;
            this.textPriceSale._TextChanged += new System.EventHandler(this.textPriceSale__TextChanged);
            this.textPriceSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceSale_KeyPress);
            // 
            // labePriceSaleError
            // 
            this.labePriceSaleError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labePriceSaleError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labePriceSaleError.ForeColor = System.Drawing.Color.Red;
            this.labePriceSaleError.Location = new System.Drawing.Point(307, 175);
            this.labePriceSaleError.Name = "labePriceSaleError";
            this.labePriceSaleError.Size = new System.Drawing.Size(265, 25);
            this.labePriceSaleError.TabIndex = 9;
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
            this.textName.Location = new System.Drawing.Point(290, 43);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textName.PasswordChar = false;
            this.textName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textName.PlaceholderText = "اسم المنتج";
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
            this.panel3.Location = new System.Drawing.Point(290, 607);
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
            this.btnCancel.TabIndex = 6;
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
            this.btnSave.TabIndex = 5;
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
            this.labeNamelError.Location = new System.Drawing.Point(307, 88);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(265, 25);
            this.labeNamelError.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridProducts);
            this.panel2.Location = new System.Drawing.Point(612, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(757, 711);
            this.panel2.TabIndex = 9;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridProducts.GridColor = System.Drawing.Color.Red;
            this.dataGridProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridProducts.MultiSelect = false;
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducts.RowTemplate.Height = 25;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(757, 544);
            this.dataGridProducts.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالمنتجToolStripMenuItem,
            this.حذفالمنتجToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // تعديلالمنتجToolStripMenuItem
            // 
            this.تعديلالمنتجToolStripMenuItem.Name = "تعديلالمنتجToolStripMenuItem";
            this.تعديلالمنتجToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.تعديلالمنتجToolStripMenuItem.Text = "تعديل المنتج";
            this.تعديلالمنتجToolStripMenuItem.Click += new System.EventHandler(this.تعديلالمنتجToolStripMenuItem_Click);
            // 
            // حذفالمنتجToolStripMenuItem
            // 
            this.حذفالمنتجToolStripMenuItem.Name = "حذفالمنتجToolStripMenuItem";
            this.حذفالمنتجToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.حذفالمنتجToolStripMenuItem.Text = "حذف المنتج";
            this.حذفالمنتجToolStripMenuItem.Click += new System.EventHandler(this.حذفالمنتجToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(111, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "الوحدات";
            // 
            // labeunit2lError
            // 
            this.labeunit2lError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeunit2lError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labeunit2lError.ForeColor = System.Drawing.Color.Red;
            this.labeunit2lError.Location = new System.Drawing.Point(105, 152);
            this.labeunit2lError.Name = "labeunit2lError";
            this.labeunit2lError.Size = new System.Drawing.Size(153, 25);
            this.labeunit2lError.TabIndex = 20;
            // 
            // labeunit3lError
            // 
            this.labeunit3lError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeunit3lError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labeunit3lError.ForeColor = System.Drawing.Color.Red;
            this.labeunit3lError.Location = new System.Drawing.Point(101, 149);
            this.labeunit3lError.Name = "labeunit3lError";
            this.labeunit3lError.Size = new System.Drawing.Size(162, 25);
            this.labeunit3lError.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(307, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 25);
            this.label10.TabIndex = 13;
            // 
            // textStartStock
            // 
            this.textStartStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textStartStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textStartStock.BorderFocusColor = System.Drawing.Color.Red;
            this.textStartStock.BorderRadius = 15;
            this.textStartStock.BorderSize = 2;
            this.textStartStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textStartStock.ForeColor = System.Drawing.Color.White;
            this.textStartStock.Location = new System.Drawing.Point(290, 391);
            this.textStartStock.Margin = new System.Windows.Forms.Padding(4);
            this.textStartStock.Multiline = false;
            this.textStartStock.Name = "textStartStock";
            this.textStartStock.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textStartStock.PasswordChar = false;
            this.textStartStock.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textStartStock.PlaceholderText = "الرصيد المبدئي";
            this.textStartStock.Size = new System.Drawing.Size(292, 42);
            this.textStartStock.TabIndex = 3;
            this.textStartStock.Texts = "";
            this.textStartStock.UnderlinedStyle = false;
            this.textStartStock._TextChanged += new System.EventHandler(this.textLimitStock__TextChanged);
            this.textStartStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStartStock_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "الرصيد المبدئي";
            // 
            // FormProductAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormProductAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelunit3.ResumeLayout(false);
            this.panelunit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureaddunit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureaddunit2)).EndInit();
            this.panelunit2.ResumeLayout(false);
            this.panelunit2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
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
        private DataGridView dataGridProducts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلالمنتجToolStripMenuItem;
        private ToolStripMenuItem حذفالمنتجToolStripMenuItem;
        private CustomControls.Controls.RJTextBox textLimitStock;
        public Label labeLimitStockError;
        private CustomControls.Controls.RJTextBox textPricePurchase;
        public Label labePricePurchaseError;
        private CustomControls.Controls.RJTextBox textPriceSale;
        public Label labePriceSaleError;
        private Label label4;
        public Panel panel1;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private ComboBox TextCatogry;
        private ComboBox combounit1;
        private Label label1;
        private Panel panelunit3;
        private CustomControls.Controls.RJButton btnunit3cancel;
        private Label label3;
        private CustomControls.Controls.RJTextBox textunit3count;
        private ComboBox combounit3;
        private PictureBox pictureaddunit3;
        private PictureBox pictureaddunit2;
        private Panel panelunit2;
        private CustomControls.Controls.RJButton btnunit2cancel;
        private Label label2;
        private CustomControls.Controls.RJTextBox textunit2count;
        private ComboBox combounit2;
        private Label label9;
        public Label labeunit3lError;
        public Label labeunit2lError;
        private Label label11;
        private CustomControls.Controls.RJTextBox textStartStock;
        public Label label10;
    }
}