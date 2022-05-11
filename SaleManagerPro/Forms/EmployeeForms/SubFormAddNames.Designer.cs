namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class SubFormAddNames
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
            this.textName = new CustomControls.Controls.RJTextBox();
            this.textDetails = new CustomControls.Controls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancel = new CustomControls.Controls.RJButton();
            this.btnSave = new CustomControls.Controls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.lblFatherId = new System.Windows.Forms.Label();
            this.combodeparments = new System.Windows.Forms.ComboBox();
            this.TextFather = new CustomControls.Controls.RJTextBox();
            this.labeFatherError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.textName.Location = new System.Drawing.Point(23, 176);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Multiline = false;
            this.textName.Name = "textName";
            this.textName.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textName.PasswordChar = false;
            this.textName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textName.PlaceholderText = "اسم القسم";
            this.textName.Size = new System.Drawing.Size(292, 42);
            this.textName.TabIndex = 2;
            this.textName.Texts = "";
            this.textName.UnderlinedStyle = false;
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
            this.textDetails.Location = new System.Drawing.Point(23, 271);
            this.textDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textDetails.Multiline = true;
            this.textDetails.Name = "textDetails";
            this.textDetails.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.textDetails.PasswordChar = false;
            this.textDetails.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.textDetails.PlaceholderText = "الوصف";
            this.textDetails.Size = new System.Drawing.Size(292, 91);
            this.textDetails.TabIndex = 3;
            this.textDetails.Texts = "";
            this.textDetails.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(23, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 89);
            this.panel3.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cancel.BorderRadius = 15;
            this.btn_cancel.BorderSize = 0;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "الاسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "الوصف";
            // 
            // labeNamelError
            // 
            this.labeNamelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeNamelError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeNamelError.ForeColor = System.Drawing.Color.Red;
            this.labeNamelError.Location = new System.Drawing.Point(42, 222);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(266, 25);
            this.labeNamelError.TabIndex = 20;
            // 
            // lblFatherId
            // 
            this.lblFatherId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFatherId.AutoSize = true;
            this.lblFatherId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFatherId.ForeColor = System.Drawing.Color.Red;
            this.lblFatherId.Location = new System.Drawing.Point(-6, 105);
            this.lblFatherId.Name = "lblFatherId";
            this.lblFatherId.Size = new System.Drawing.Size(22, 25);
            this.lblFatherId.TabIndex = 23;
            this.lblFatherId.Text = "0";
            this.lblFatherId.Visible = false;
            // 
            // combodeparments
            // 
            this.combodeparments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodeparments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combodeparments.FormattingEnabled = true;
            this.combodeparments.Location = new System.Drawing.Point(23, 37);
            this.combodeparments.Name = "combodeparments";
            this.combodeparments.Size = new System.Drawing.Size(292, 32);
            this.combodeparments.TabIndex = 22;
            this.combodeparments.Visible = false;
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
            this.TextFather.Location = new System.Drawing.Point(23, 88);
            this.TextFather.Margin = new System.Windows.Forms.Padding(4);
            this.TextFather.Multiline = false;
            this.TextFather.Name = "TextFather";
            this.TextFather.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.TextFather.PasswordChar = false;
            this.TextFather.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.TextFather.PlaceholderText = "القسم الاب";
            this.TextFather.Size = new System.Drawing.Size(292, 42);
            this.TextFather.TabIndex = 21;
            this.TextFather.Texts = "";
            this.TextFather.UnderlinedStyle = false;
            this.TextFather.Visible = false;
            // 
            // labeFatherError
            // 
            this.labeFatherError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeFatherError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labeFatherError.ForeColor = System.Drawing.Color.Red;
            this.labeFatherError.Location = new System.Drawing.Point(36, 134);
            this.labeFatherError.Name = "labeFatherError";
            this.labeFatherError.Size = new System.Drawing.Size(257, 25);
            this.labeFatherError.TabIndex = 24;
            this.labeFatherError.Text = ".";
            this.labeFatherError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "اختر القسم الاب من هنا";
            this.label2.Visible = false;
            // 
            // SubFormAddNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeFatherError);
            this.Controls.Add(this.lblFatherId);
            this.Controls.Add(this.combodeparments);
            this.Controls.Add(this.TextFather);
            this.Controls.Add(this.labeNamelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textDetails);
            this.Name = "SubFormAddNames";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubFormAddNames";
            this.Load += new System.EventHandler(this.SubFormAddNames_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Controls.RJTextBox textName;
        private CustomControls.Controls.RJTextBox textDetails;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.Controls.RJButton btn_cancel;
        private CustomControls.Controls.RJButton btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labeNamelError;
        public System.Windows.Forms.Label lblFatherId;
        private System.Windows.Forms.ComboBox combodeparments;
        private CustomControls.Controls.RJTextBox TextFather;
        public System.Windows.Forms.Label labeFatherError;
        private System.Windows.Forms.Label label2;
    }
}