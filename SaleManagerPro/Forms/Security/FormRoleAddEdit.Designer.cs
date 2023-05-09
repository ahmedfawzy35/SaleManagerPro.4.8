using System.Windows.Forms;

namespace SaleManagerPro.Forms.Security
{
    partial class FormRoleAddEdit
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
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالتصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالتصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 584);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم الصلاحيه";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(66, 154);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 1;
            this.textName .Text = "";
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(49, 465);
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
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(75, 210);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(283, 25);
            this.labeNamelError.TabIndex = 4;
            this.labeNamelError.Text = ".";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridRoles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(404, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(829, 584);
            this.panel2.TabIndex = 9;
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRoles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridRoles.GridColor = System.Drawing.Color.Red;
            this.dataGridRoles.Location = new System.Drawing.Point(0, 0);
            this.dataGridRoles.MultiSelect = false;
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRoles.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridRoles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRoles.RowTemplate.Height = 25;
            this.dataGridRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRoles.Size = new System.Drawing.Size(829, 556);
            this.dataGridRoles.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالتصنيفToolStripMenuItem,
            this.حذفالتصنيفToolStripMenuItem,
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(253, 70);
            // 
            // تعديلالتصنيفToolStripMenuItem
            // 
            this.تعديلالتصنيفToolStripMenuItem.Name = "تعديلالتصنيفToolStripMenuItem";
            this.تعديلالتصنيفToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.تعديلالتصنيفToolStripMenuItem.Text = "تعديل المستخدم";
            this.تعديلالتصنيفToolStripMenuItem.Click += new System.EventHandler(this.تعديلالتصنيفToolStripMenuItem_Click);
            // 
            // حذفالتصنيفToolStripMenuItem
            // 
            this.حذفالتصنيفToolStripMenuItem.Name = "حذفالتصنيفToolStripMenuItem";
            this.حذفالتصنيفToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.حذفالتصنيفToolStripMenuItem.Text = "حذف المستخدم";
            this.حذفالتصنيفToolStripMenuItem.Click += new System.EventHandler(this.حذفالتصنيفToolStripMenuItem_Click);
            // 
            // تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem
            // 
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem.Name = "تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem";
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem.Text = "تعديل اجراءات الصلاحيه المسموح بها";
            this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem.Click += new System.EventHandler(this.تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem_Click);
            // 
            // FormRoleAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoleAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormUserAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private DataGridView dataGridRoles;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلالتصنيفToolStripMenuItem;
        private ToolStripMenuItem حذفالتصنيفToolStripMenuItem;
        public Panel panel1;
        private Label label5;
        private ToolStripMenuItem تعديلاجراءاتالصلاحيهالمسموحبهاToolStripMenuItem;
    }
}