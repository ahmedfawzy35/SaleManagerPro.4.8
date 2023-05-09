using System.Windows.Forms;

namespace SaleManagerPro.Forms.ProductsForms
{
    partial class FormUnitsAddEdit
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textdDetails = new TextBox();
            this.labePriceSaleError = new System.Windows.Forms.Label();
            this.textName = new TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labeNamelError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridUnits = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnits)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textdDetails);
            this.panel1.Controls.Add(this.labePriceSaleError);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labeNamelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 578);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "التفاصيل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اسم الوحده";
            // 
            // textdDetails
            // 
            this.textdDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));

            this.textdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textdDetails.ForeColor = System.Drawing.Color.White;
            this.textdDetails.Location = new System.Drawing.Point(58, 172);
            this.textdDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textdDetails.Multiline = true;
            this.textdDetails.Name = "textdDetails";
            this.textdDetails.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);

            this.textdDetails.Size = new System.Drawing.Size(292, 116);
            this.textdDetails.TabIndex = 1;

            this.textdDetails.TextChanged += new System.EventHandler(this.textPriceSale_TextChanged);
            // 
            // labePriceSaleError
            // 
            this.labePriceSaleError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labePriceSaleError.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labePriceSaleError.ForeColor = System.Drawing.Color.Red;
            this.labePriceSaleError.Location = new System.Drawing.Point(75, 292);
            this.labePriceSaleError.Name = "labePriceSaleError";
            this.labePriceSaleError.Size = new System.Drawing.Size(269, 39);
            this.labePriceSaleError.TabIndex = 9;
            this.labePriceSaleError.Text = ".";
            this.labePriceSaleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.textName.TabIndex = 0;

            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(58, 478);
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
            this.btnCancel.TabIndex = 6;
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
            this.btnSave.TabIndex = 5;
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
            this.labeNamelError.Location = new System.Drawing.Point(75, 96);
            this.labeNamelError.Name = "labeNamelError";
            this.labeNamelError.Size = new System.Drawing.Size(274, 41);
            this.labeNamelError.TabIndex = 4;
            this.labeNamelError.Text = ".";
            this.labeNamelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridUnits);
            this.panel2.Location = new System.Drawing.Point(394, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(839, 578);
            this.panel2.TabIndex = 9;
            // 
            // dataGridUnits
            // 
            this.dataGridUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUnits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnits.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridUnits.GridColor = System.Drawing.Color.Red;
            this.dataGridUnits.Location = new System.Drawing.Point(0, 0);
            this.dataGridUnits.MultiSelect = false;
            this.dataGridUnits.Name = "dataGridUnits";
            this.dataGridUnits.ReadOnly = true;
            this.dataGridUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridUnits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridUnits.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridUnits.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUnits.RowTemplate.Height = 25;
            this.dataGridUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUnits.Size = new System.Drawing.Size(839, 544);
            this.dataGridUnits.TabIndex = 7;
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
            // FormUnitsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnitsAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormProductAddEdit";
            this.Load += new System.EventHandler(this.FormProductAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnits)).EndInit();
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
        private DataGridView dataGridUnits;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلالمنتجToolStripMenuItem;
        private ToolStripMenuItem حذفالمنتجToolStripMenuItem;
        private TextBox textdDetails;
        public Label labePriceSaleError;
        public Panel panel1;
        private Label label6;
        private Label label5;
    }
}