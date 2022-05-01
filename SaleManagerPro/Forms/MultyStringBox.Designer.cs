namespace SaleManagerPro.Forms
{
    partial class MultyStringBox
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textvalue = new CustomControls.Controls.RJTextBox();
            this.dataGridValues = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbladress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textvalue
            // 
            this.textvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textvalue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textvalue.BorderFocusColor = System.Drawing.Color.Red;
            this.textvalue.BorderRadius = 15;
            this.textvalue.BorderSize = 2;
            this.textvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.textvalue.ForeColor = System.Drawing.Color.White;
            this.textvalue.Location = new System.Drawing.Point(65, 33);
            this.textvalue.Margin = new System.Windows.Forms.Padding(4);
            this.textvalue.Multiline = false;
            this.textvalue.Name = "textvalue";
            this.textvalue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textvalue.PasswordChar = false;
            this.textvalue.PlaceholderColor = System.Drawing.Color.White;
            this.textvalue.PlaceholderText = "";
            this.textvalue.Size = new System.Drawing.Size(295, 31);
            this.textvalue.TabIndex = 0;
            this.textvalue.Texts = "";
            this.textvalue.UnderlinedStyle = false;
            // 
            // dataGridValues
            // 
            this.dataGridValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridValues.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValues.ColumnHeadersVisible = false;
            this.dataGridValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridValues.GridColor = System.Drawing.Color.Red;
            this.dataGridValues.Location = new System.Drawing.Point(0, 71);
            this.dataGridValues.MultiSelect = false;
            this.dataGridValues.Name = "dataGridValues";
            this.dataGridValues.ReadOnly = true;
            this.dataGridValues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridValues.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridValues.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridValues.RowTemplate.Height = 25;
            this.dataGridValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridValues.Size = new System.Drawing.Size(364, 89);
            this.dataGridValues.TabIndex = 0;
            this.dataGridValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridValues_CellClick);
            this.dataGridValues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridValues_CellDoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(59, 32);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbladress);
            this.panel1.Controls.Add(this.textvalue);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 71);
            this.panel1.TabIndex = 12;
            // 
            // lbladress
            // 
            this.lbladress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbladress.Location = new System.Drawing.Point(109, 6);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(152, 23);
            this.lbladress.TabIndex = 12;
            this.lbladress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultyStringBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridValues);
            this.Controls.Add(this.panel1);
            this.Name = "MultyStringBox";
            this.Size = new System.Drawing.Size(364, 160);
            this.Load += new System.EventHandler(this.MultyStringBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Controls.RJTextBox textvalue;
        private System.Windows.Forms.DataGridView dataGridValues;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladress;
    }
}
