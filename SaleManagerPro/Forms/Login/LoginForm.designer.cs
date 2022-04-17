using System.Windows.Forms;

namespace SaleManagerPro.Forms.Login
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new CustomControls.Controls.RJButton();
            this.button1 = new CustomControls.Controls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_error_message = new System.Windows.Forms.Label();
            this.text_user_name = new CustomControls.Controls.RJTextBox();
            this.text_pass = new CustomControls.Controls.RJTextBox();
            this.picture_loading = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(105, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Here";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(33, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 61);
            this.panel3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundColor = System.Drawing.Color.Red;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.BorderRadius = 15;
            this.button2.BorderSize = 0;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(178, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.BorderRadius = 15;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.TextColor = System.Drawing.Color.Black;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(296, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 55);
            this.panel4.TabIndex = 7;
            // 
            // lbl_error_message
            // 
            this.lbl_error_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_error_message.AutoSize = true;
            this.lbl_error_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_error_message.ForeColor = System.Drawing.Color.White;
            this.lbl_error_message.Location = new System.Drawing.Point(147, 335);
            this.lbl_error_message.Name = "lbl_error_message";
            this.lbl_error_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_message.TabIndex = 8;
            // 
            // text_user_name
            // 
            this.text_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.text_user_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.text_user_name.BorderFocusColor = System.Drawing.Color.Red;
            this.text_user_name.BorderRadius = 15;
            this.text_user_name.BorderSize = 1;
            this.text_user_name.CausesValidation = false;
            this.text_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.text_user_name.ForeColor = System.Drawing.Color.White;
            this.text_user_name.Location = new System.Drawing.Point(45, 192);
            this.text_user_name.Multiline = false;
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.text_user_name.PasswordChar = false;
            this.text_user_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.text_user_name.PlaceholderText = "User Name";
            this.text_user_name.Size = new System.Drawing.Size(292, 42);
            this.text_user_name.TabIndex = 1;
            this.text_user_name.Texts = "";
            this.text_user_name.UnderlinedStyle = false;
            // 
            // text_pass
            // 
            this.text_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.text_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.text_pass.BorderFocusColor = System.Drawing.Color.Red;
            this.text_pass.BorderRadius = 15;
            this.text_pass.BorderSize = 1;
            this.text_pass.CausesValidation = false;
            this.text_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.text_pass.ForeColor = System.Drawing.Color.White;
            this.text_pass.Location = new System.Drawing.Point(45, 273);
            this.text_pass.Multiline = false;
            this.text_pass.Name = "text_pass";
            this.text_pass.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.text_pass.PasswordChar = false;
            this.text_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.text_pass.PlaceholderText = "Password";
            this.text_pass.Size = new System.Drawing.Size(292, 42);
            this.text_pass.TabIndex = 2;
            this.text_pass.Texts = "";
            this.text_pass.UnderlinedStyle = false;
            // 
            // picture_loading
            // 
            this.picture_loading.Image = global::SaleManagerPro.Properties.Resources.LodingGreen;
            this.picture_loading.Location = new System.Drawing.Point(10, 137);
            this.picture_loading.Name = "picture_loading";
            this.picture_loading.Size = new System.Drawing.Size(43, 49);
            this.picture_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_loading.TabIndex = 1;
            this.picture_loading.TabStop = false;
            this.picture_loading.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(380, 549);
            this.Controls.Add(this.picture_loading);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.lbl_error_message);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox picture_loading;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label lbl_error_message;
        private CustomControls.Controls.RJTextBox text_user_name;
        private CustomControls.Controls.RJTextBox text_pass;
        private CustomControls.Controls.RJButton button1;
        private CustomControls.Controls.RJButton button2;
    }
}