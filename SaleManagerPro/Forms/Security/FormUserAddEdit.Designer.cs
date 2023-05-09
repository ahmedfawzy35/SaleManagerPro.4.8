using System.Windows.Forms;

namespace SaleManagerPro.Forms.Security
{
    partial class FormUserAddEdit
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
            this.textenable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFullName = new TextBox();
            this.labeFullNameError = new System.Windows.Forms.Label();
            this.textRePassword = new TextBox();
            this.labeRePasswordError = new System.Windows.Forms.Label();
            this.textPassword = new TextBox();
            this.labePasswordError = new System.Windows.Forms.Label();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالتصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالتصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلالصلاحياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textenable);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textFullName);
            this.panel1.Controls.Add(this.labeFullNameError);
            this.panel1.Controls.Add(this.textRePassword);
            this.panel1.Controls.Add(this.labeRePasswordError);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.labePasswordError);
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
            // textenable
            // 
            this.textenable.AutoSize = true;
            this.textenable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textenable.Location = new System.Drawing.Point(280, 383);
            this.textenable.Name = "textenable";
            this.textenable.Size = new System.Drawing.Size(61, 28);
            this.textenable.TabIndex = 21;
            this.textenable.Text = "تفعيل";
            this.textenable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "الاسم الكامل للمستخدم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "اعادة كلمة المرور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم المستخدم";
            // 
            // textFullName
            // 
            this.textFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textFullName.ForeColor = System.Drawing.Color.White;
            this.textFullName.Location = new System.Drawing.Point(58, 306);
            this.textFullName.Margin = new System.Windows.Forms.Padding(4);
            this.textFullName.Multiline = false;
            this.textFullName.Name = "textFullName";
            this.textFullName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textFullName.Size = new System.Drawing.Size(292, 42);
            this.textFullName.TabIndex = 12;
            this.textFullName .Text = "";
            this.textFullName.TextChanged += new System.EventHandler(this.textFullName_TextChanged);
            // 
            // labeFullNameError
            // 
            this.labeFullNameError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeFullNameError.AutoSize = true;
            this.labeFullNameError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeFullNameError.ForeColor = System.Drawing.Color.Red;
            this.labeFullNameError.Location = new System.Drawing.Point(146, 351);
            this.labeFullNameError.Name = "labeFullNameError";
            this.labeFullNameError.Size = new System.Drawing.Size(16, 25);
            this.labeFullNameError.TabIndex = 13;
            this.labeFullNameError.Text = ".";
            // 
            // textRePassword
            // 
            this.textRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textRePassword.ForeColor = System.Drawing.Color.White;
            this.textRePassword.Location = new System.Drawing.Point(58, 225);
            this.textRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.textRePassword.Multiline = false;
            this.textRePassword.Name = "textRePassword";
            this.textRePassword.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textRePassword.Size = new System.Drawing.Size(292, 42);
            this.textRePassword.TabIndex = 10;
            this.textRePassword .Text = "";
            this.textRePassword.TextChanged += new System.EventHandler(this.textRePassword_TextChanged);
            // 
            // labeRePasswordError
            // 
            this.labeRePasswordError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeRePasswordError.AutoSize = true;
            this.labeRePasswordError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeRePasswordError.ForeColor = System.Drawing.Color.Red;
            this.labeRePasswordError.Location = new System.Drawing.Point(146, 266);
            this.labeRePasswordError.Name = "labeRePasswordError";
            this.labeRePasswordError.Size = new System.Drawing.Size(16, 25);
            this.labeRePasswordError.TabIndex = 11;
            this.labeRePasswordError.Text = ".";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPassword.ForeColor = System.Drawing.Color.White;
            this.textPassword.Location = new System.Drawing.Point(58, 137);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Multiline = false;
            this.textPassword.Name = "textPassword";
            this.textPassword.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textPassword.Size = new System.Drawing.Size(292, 42);
            this.textPassword.TabIndex = 8;
            this.textPassword .Text = "";
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // labePasswordError
            // 
            this.labePasswordError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labePasswordError.AutoSize = true;
            this.labePasswordError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labePasswordError.ForeColor = System.Drawing.Color.Red;
            this.labePasswordError.Location = new System.Drawing.Point(146, 182);
            this.labePasswordError.Name = "labePasswordError";
            this.labePasswordError.Size = new System.Drawing.Size(16, 25);
            this.labePasswordError.TabIndex = 9;
            this.labePasswordError.Text = ".";
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

            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 1;
            this.textName .Text = "";
          //  this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
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
            this.labeNamelError.AutoSize = true;
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(146, 95);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(16, 25);
            this.labeNamelError.TabIndex = 4;
            this.labeNamelError.Text = ".";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(414, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(819, 584);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.RowTemplate.Height = 25;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(819, 556);
            this.dataGridUsers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالتصنيفToolStripMenuItem,
            this.حذفالتصنيفToolStripMenuItem,
            this.تعديلالصلاحياتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // تعديلالتصنيفToolStripMenuItem
            // 
            this.تعديلالتصنيفToolStripMenuItem.Name = "تعديلالتصنيفToolStripMenuItem";
            this.تعديلالتصنيفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديلالتصنيفToolStripMenuItem.Text = "تعديل المستخدم";
            this.تعديلالتصنيفToolStripMenuItem.Click += new System.EventHandler(this.تعديلالتصنيفToolStripMenuItem_Click);
            // 
            // حذفالتصنيفToolStripMenuItem
            // 
            this.حذفالتصنيفToolStripMenuItem.Name = "حذفالتصنيفToolStripMenuItem";
            this.حذفالتصنيفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذفالتصنيفToolStripMenuItem.Text = "تعديل الصلاحيات";
            this.حذفالتصنيفToolStripMenuItem.Click += new System.EventHandler(this.حذفالتصنيفToolStripMenuItem_Click);
            // 
            // تعديلالصلاحياتToolStripMenuItem
            // 
            this.تعديلالصلاحياتToolStripMenuItem.Name = "تعديلالصلاحياتToolStripMenuItem";
            this.تعديلالصلاحياتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديلالصلاحياتToolStripMenuItem.Text = "حذف المستخدم";
            this.تعديلالصلاحياتToolStripMenuItem.Click += new System.EventHandler(this.تعديلالصلاحياتToolStripMenuItem_Click);
            // 
            // FormUserAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormUserAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
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
        private DataGridView dataGridUsers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلالتصنيفToolStripMenuItem;
        private ToolStripMenuItem حذفالتصنيفToolStripMenuItem;
        private TextBox textFullName;
        public Label labeFullNameError;
        private TextBox textRePassword;
        public Label labeRePasswordError;
        private TextBox textPassword;
        public Label labePasswordError;
        public Panel panel1;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private CheckBox textenable;
        private ToolStripMenuItem تعديلالصلاحياتToolStripMenuItem;
    }
}