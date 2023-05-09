using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class FormJobDegreeAddEdit
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancel = new Button();
            this.btnSave = new Button();
            this.textDetails = new TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridJobsDegrees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobsDegrees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.AutoSize = true;
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(137, 146);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(16, 25);
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
            this.labelId.Location = new System.Drawing.Point(207, 43);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "0";
            this.labelId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textDetails);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 578);
            this.panel1.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(49, 105);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 0;
            this.textName .Text = "";
            this.textName.TextChanged += new System.EventHandler(this.textNameTextChanged);
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

            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(17, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 39);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "إضافه";
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textDetails
            // 
            this.textDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textDetails.CausesValidation = false;
            this.textDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textDetails.ForeColor = System.Drawing.Color.White;
            this.textDetails.Location = new System.Drawing.Point(49, 196);
            this.textDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textDetails.Size = new System.Drawing.Size(292, 91);
            this.textDetails.TabIndex = 1;
            this.textDetails .Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridJobsDegrees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(846, 578);
            this.panel2.TabIndex = 7;
            // 
            // dataGridJobsDegrees
            // 
            this.dataGridJobsDegrees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridJobsDegrees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridJobsDegrees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridJobsDegrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobsDegrees.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridJobsDegrees.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridJobsDegrees.GridColor = System.Drawing.Color.Red;
            this.dataGridJobsDegrees.Location = new System.Drawing.Point(0, 0);
            this.dataGridJobsDegrees.MultiSelect = false;
            this.dataGridJobsDegrees.Name = "dataGridJobsDegrees";
            this.dataGridJobsDegrees.ReadOnly = true;
            this.dataGridJobsDegrees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridJobsDegrees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridJobsDegrees.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridJobsDegrees.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridJobsDegrees.RowTemplate.Height = 25;
            this.dataGridJobsDegrees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridJobsDegrees.Size = new System.Drawing.Size(846, 575);
            this.dataGridJobsDegrees.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem,
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            // 
            // تعديل_الدرجه_الوظيفيهToolStripMenuItem
            // 
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem.Name = "تعديل_الدرجه_الوظيفيهToolStripMenuItem";
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem.Text = "تعديل الدرجه الوظيفيه";
            this.تعديل_الدرجه_الوظيفيهToolStripMenuItem.Click += new System.EventHandler(this.تعديل_الدرجه_الوظيفيههToolStripMenuItem_Click);
            // 
            // حذف_الدرجه_الوظيفيهToolStripMenuItem
            // 
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem.Name = "حذف_الدرجه_الوظيفيهToolStripMenuItem";
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem.Text = "حذف الدرجة الوظيفيه";
            this.حذف_الدرجه_الوظيفيهToolStripMenuItem.Click += new System.EventHandler(this.حذف_الدرجه_الوظيفيههToolStripMenuItem_Click);
            // 
            // FormJobDegreeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJobDegreeAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormCatogryAddEdit";
            this.Load += new System.EventHandler(this.FormJobAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobsDegrees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        public System.Windows.Forms.Label labeNamelError;
        public System.Windows.Forms.Label labelId;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridJobsDegrees;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديل_الدرجه_الوظيفيهToolStripMenuItem;
        private ToolStripMenuItem حذف_الدرجه_الوظيفيهToolStripMenuItem;
        private Panel panel3;
        private Button btn_cancel;
        private Button btnSave;
        private TextBox textName;
        private TextBox textDetails;
    }
}