using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class FormDepartmentAddEdit
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
            this.labeNamelError = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFatherId = new System.Windows.Forms.Label();
            this.combodeparments = new System.Windows.Forms.ComboBox();
            this.TextFather = new CustomControls.Controls.RJTextBox();
            this.textName = new CustomControls.Controls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancel = new CustomControls.Controls.RJButton();
            this.btnSave = new CustomControls.Controls.RJButton();
            this.textDetails = new CustomControls.Controls.RJTextBox();
            this.labeFatherError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridFinancialDegeree = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديل_الدرجه_الماليهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذف_الدرجه_الماليهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinancialDegeree)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(66, 209);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(257, 34);
            this.labeNamelError.TabIndex = 4;
            this.labeNamelError.Text = ".";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelId.ForeColor = System.Drawing.Color.Red;
            this.labelId.Location = new System.Drawing.Point(306, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "0";
            this.labelId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblFatherId);
            this.panel1.Controls.Add(this.combodeparments);
            this.panel1.Controls.Add(this.TextFather);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textDetails);
            this.panel1.Controls.Add(this.labeFatherError);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 578);
            this.panel1.TabIndex = 6;
            // 
            // lblFatherId
            // 
            this.lblFatherId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFatherId.AutoSize = true;
            this.lblFatherId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFatherId.ForeColor = System.Drawing.Color.Red;
            this.lblFatherId.Location = new System.Drawing.Point(20, 105);
            this.lblFatherId.Name = "lblFatherId";
            this.lblFatherId.Size = new System.Drawing.Size(22, 25);
            this.lblFatherId.TabIndex = 9;
            this.lblFatherId.Text = "0";
            this.lblFatherId.Visible = false;
            // 
            // combodeparments
            // 
            this.combodeparments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodeparments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combodeparments.FormattingEnabled = true;
            this.combodeparments.Location = new System.Drawing.Point(49, 37);
            this.combodeparments.Name = "combodeparments";
            this.combodeparments.Size = new System.Drawing.Size(292, 32);
            this.combodeparments.TabIndex = 8;
            this.combodeparments.SelectedIndexChanged += new System.EventHandler(this.combodeparments_SelectedIndexChanged);
            // 
            // TextFather
            // 
            this.TextFather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TextFather.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextFather.BorderFocusColor = System.Drawing.Color.Red;
            this.TextFather.BorderRadius = 15;
            this.TextFather.BorderSize = 2;
            this.TextFather.Enabled = false;
            this.TextFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextFather.ForeColor = System.Drawing.Color.White;
            this.TextFather.Location = new System.Drawing.Point(49, 88);
            this.TextFather.Margin = new System.Windows.Forms.Padding(4);
            this.TextFather.Multiline = false;
            this.TextFather.Name = "TextFather";
            this.TextFather.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.TextFather.PasswordChar = false;
            this.TextFather.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.TextFather.PlaceholderText = "القسم الاب";
            this.TextFather.Size = new System.Drawing.Size(292, 42);
            this.TextFather.TabIndex = 0;
            this.TextFather.Texts = "";
            this.TextFather.UnderlinedStyle = false;
            this.TextFather._TextChanged += new System.EventHandler(this.TextFather_TextChanged);
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
            this.textName.Location = new System.Drawing.Point(49, 163);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textName.PasswordChar = false;
            this.textName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textName.PlaceholderText = "اسم القسم";
            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 0;
            this.textName.Texts = "";
            this.textName.UnderlinedStyle = false;
            this.textName._TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(49, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 89);
            this.panel3.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cancel.BorderRadius = 15;
            this.btn_cancel.BorderSize = 0;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(17, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 39);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.TextColor = System.Drawing.Color.White;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "إضافه";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textDetails
            // 
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textDetails.BorderFocusColor = System.Drawing.Color.Red;
            this.textDetails.BorderRadius = 15;
            this.textDetails.BorderSize = 1;
            this.textDetails.CausesValidation = false;
            this.textDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textDetails.ForeColor = System.Drawing.Color.White;
            this.textDetails.Location = new System.Drawing.Point(49, 276);
            this.textDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textDetails.PasswordChar = false;
            this.textDetails.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textDetails.PlaceholderText = "الوصف";
            this.textDetails.Size = new System.Drawing.Size(292, 91);
            this.textDetails.TabIndex = 1;
            this.textDetails.Texts = "";
            this.textDetails.UnderlinedStyle = false;
            // 
            // labeFatherError
            // 
            this.labeFatherError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeFatherError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeFatherError.ForeColor = System.Drawing.Color.Red;
            this.labeFatherError.Location = new System.Drawing.Point(71, 134);
            this.labeFatherError.Name = "labeFatherError";
            this.labeFatherError.Size = new System.Drawing.Size(257, 25);
            this.labeFatherError.TabIndex = 4;
            this.labeFatherError.Text = ".";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridFinancialDegeree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(846, 578);
            this.panel2.TabIndex = 7;
            // 
            // dataGridFinancialDegeree
            // 
            this.dataGridFinancialDegeree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFinancialDegeree.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFinancialDegeree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFinancialDegeree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFinancialDegeree.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridFinancialDegeree.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridFinancialDegeree.GridColor = System.Drawing.Color.Red;
            this.dataGridFinancialDegeree.Location = new System.Drawing.Point(0, 0);
            this.dataGridFinancialDegeree.MultiSelect = false;
            this.dataGridFinancialDegeree.Name = "dataGridFinancialDegeree";
            this.dataGridFinancialDegeree.ReadOnly = true;
            this.dataGridFinancialDegeree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridFinancialDegeree.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFinancialDegeree.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridFinancialDegeree.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFinancialDegeree.RowTemplate.Height = 25;
            this.dataGridFinancialDegeree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFinancialDegeree.Size = new System.Drawing.Size(846, 575);
            this.dataGridFinancialDegeree.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديل_الدرجه_الماليهToolStripMenuItem,
            this.حذف_الدرجه_الماليهToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // تعديل_الدرجه_الماليهToolStripMenuItem
            // 
            this.تعديل_الدرجه_الماليهToolStripMenuItem.Name = "تعديل_الدرجه_الماليهToolStripMenuItem";
            this.تعديل_الدرجه_الماليهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديل_الدرجه_الماليهToolStripMenuItem.Text = "تعديل  القسم";
            this.تعديل_الدرجه_الماليهToolStripMenuItem.Click += new System.EventHandler(this.تعديل_الدرجه_الماليهToolStripMenuItem_Click);
            // 
            // حذف_الدرجه_الماليهToolStripMenuItem
            // 
            this.حذف_الدرجه_الماليهToolStripMenuItem.Name = "حذف_الدرجه_الماليهToolStripMenuItem";
            this.حذف_الدرجه_الماليهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذف_الدرجه_الماليهToolStripMenuItem.Text = "حذف القسم";
            this.حذف_الدرجه_الماليهToolStripMenuItem.Click += new System.EventHandler(this.حذف_الدرجه_الماليهToolStripMenuItem_Click);
            // 
            // FormDepartmentAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartmentAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormCatogryAddEdit";
            this.Load += new System.EventHandler(this.FormJobAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinancialDegeree)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label labeNamelError;
        public System.Windows.Forms.Label labelId;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridFinancialDegeree;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديل_الدرجه_الماليهToolStripMenuItem;
        private ToolStripMenuItem حذف_الدرجه_الماليهToolStripMenuItem;
        private Panel panel3;
        private CustomControls.Controls.RJButton btn_cancel;
        private CustomControls.Controls.RJButton btnSave;
        private CustomControls.Controls.RJTextBox textName;
        private CustomControls.Controls.RJTextBox textDetails;
        private ComboBox combodeparments;
        private CustomControls.Controls.RJTextBox TextFather;
        public Label labeFatherError;
        public Label lblFatherId;
    }
}