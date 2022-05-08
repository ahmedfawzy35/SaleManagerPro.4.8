namespace SaleManagerPro.Forms.EmployeeForms
{
    partial class LabelAdress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblDecumentId = new System.Windows.Forms.Label();
            this.lblDecumentName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Location = new System.Drawing.Point(3, 71);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(149, 26);
            this.lblPageCount.TabIndex = 0;
            this.lblPageCount.Text = "label1";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPageCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDecumentId
            // 
            this.lblDecumentId.Location = new System.Drawing.Point(117, 97);
            this.lblDecumentId.Name = "lblDecumentId";
            this.lblDecumentId.Size = new System.Drawing.Size(35, 26);
            this.lblDecumentId.TabIndex = 0;
            this.lblDecumentId.Text = "label1";
            this.lblDecumentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDecumentId.Visible = false;
            // 
            // lblDecumentName
            // 
            this.lblDecumentName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDecumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecumentName.Location = new System.Drawing.Point(3, 3);
            this.lblDecumentName.Multiline = true;
            this.lblDecumentName.Name = "lblDecumentName";
            this.lblDecumentName.Size = new System.Drawing.Size(149, 66);
            this.lblDecumentName.TabIndex = 1;
            this.lblDecumentName.Text = "مستند جديد للتجربه العمليه على عدد السطور";
            this.lblDecumentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.btnAdd.Location = new System.Drawing.Point(3, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 44);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // LabelAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDecumentName);
            this.Controls.Add(this.lblDecumentId);
            this.Controls.Add(this.lblPageCount);
            this.Name = "LabelAdress";
            this.Size = new System.Drawing.Size(155, 147);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox btnAdd;
        public System.Windows.Forms.Label lblPageCount;
        public System.Windows.Forms.Label lblDecumentId;
        public System.Windows.Forms.TextBox lblDecumentName;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
