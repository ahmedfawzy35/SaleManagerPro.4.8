namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class FormEmployeeDocuments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.documentItem1 = new SaleManagerPro.Forms.EmployeeForms.DocumentItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new CustomControls.Controls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.lblDecumentName = new System.Windows.Forms.TextBox();
            this.lblDecumentId = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.documentItem1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 817);
            this.panel1.TabIndex = 0;
            // 
            // documentItem1
            // 
            this.documentItem1.BackColor = System.Drawing.Color.Maroon;
            this.documentItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.documentItem1.IdDocument = 1;
            this.documentItem1.Location = new System.Drawing.Point(4, 190);
            this.documentItem1.Name = "documentItem1";
            this.documentItem1.NameDocument = "لا يوجد مستندات";
            this.documentItem1.Size = new System.Drawing.Size(286, 60);
            this.documentItem1.TabIndex = 20;
            this.documentItem1.ActionTaskClicked += new System.EventHandler<SaleManagerPro.Forms.EmployeeForms.DocumentItem.ActionTaskEventArgs>(this.ucButtonActions1_ActionTaskClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "الفيش الجنائي";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "اسم المستند";
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
            this.textName.Location = new System.Drawing.Point(4, 26);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textName.PasswordChar = false;
            this.textName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textName.PlaceholderText = "اسم المستند";
            this.textName.Size = new System.Drawing.Size(265, 42);
            this.textName.TabIndex = 17;
            this.textName.Texts = "";
            this.textName.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 817);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 655);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 162);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(845, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.lblDecumentName);
            this.panel4.Controls.Add(this.lblDecumentId);
            this.panel4.Controls.Add(this.lblPageCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(983, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 162);
            this.panel4.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.btnAdd.Location = new System.Drawing.Point(4, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 44);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.TabStop = false;
            // 
            // lblDecumentName
            // 
            this.lblDecumentName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDecumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecumentName.Location = new System.Drawing.Point(4, 12);
            this.lblDecumentName.Multiline = true;
            this.lblDecumentName.Name = "lblDecumentName";
            this.lblDecumentName.Size = new System.Drawing.Size(171, 66);
            this.lblDecumentName.TabIndex = 5;
            this.lblDecumentName.Text = "مستند جديد للتجربه العمليه على عدد السطور";
            this.lblDecumentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDecumentId
            // 
            this.lblDecumentId.Location = new System.Drawing.Point(118, 105);
            this.lblDecumentId.Name = "lblDecumentId";
            this.lblDecumentId.Size = new System.Drawing.Size(35, 26);
            this.lblDecumentId.TabIndex = 3;
            this.lblDecumentId.Text = "label1";
            this.lblDecumentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDecumentId.Visible = false;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Location = new System.Drawing.Point(4, 79);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(167, 26);
            this.lblPageCount.TabIndex = 4;
            this.lblPageCount.Text = "label1";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(708, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 162);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // FormEmployeeDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 817);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مستندات الموظف";
            this.Load += new System.EventHandler(this.FormEmployeeDocuments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.Controls.RJTextBox textName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox btnAdd;
        public System.Windows.Forms.TextBox lblDecumentName;
        public System.Windows.Forms.Label lblDecumentId;
        public System.Windows.Forms.Label lblPageCount;
        private DocumentItem documentItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}