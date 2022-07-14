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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNameError = new System.Windows.Forms.Label();
            this.btnSaveDocument = new CustomControls.Controls.RJButton();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new CustomControls.Controls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.طباعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةالصفحةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةجميعالمستنداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظالصفحهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظالمستندToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظجميعالمستنداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلالصفحهالحاليهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالصفحةالحاليهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمستندToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفجميعالمستنداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDecumentName = new System.Windows.Forms.TextBox();
            this.lblDecumentId = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_imageid = new System.Windows.Forms.Label();
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.btnDeleteImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnChangeImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelNameError);
            this.panel1.Controls.Add(this.btnSaveDocument);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 817);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNameError
            // 
            this.labelNameError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(89, 107);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(171, 25);
            this.labelNameError.TabIndex = 22;
            this.labelNameError.Text = ".";
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.BackColor = System.Drawing.Color.Lime;
            this.btnSaveDocument.BackgroundColor = System.Drawing.Color.Lime;
            this.btnSaveDocument.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSaveDocument.BorderRadius = 15;
            this.btnSaveDocument.BorderSize = 0;
            this.btnSaveDocument.FlatAppearance.BorderSize = 0;
            this.btnSaveDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDocument.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSaveDocument.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDocument.Location = new System.Drawing.Point(3, 104);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(80, 38);
            this.btnSaveDocument.TabIndex = 21;
            this.btnSaveDocument.Text = "إضافه";
            this.btnSaveDocument.TextColor = System.Drawing.Color.Black;
            this.btnSaveDocument.UseVisualStyleBackColor = false;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEmployeeName.Location = new System.Drawing.Point(7, 8);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(264, 32);
            this.lblEmployeeName.TabIndex = 18;
            this.lblEmployeeName.Text = "الموظف / ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 45);
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
            this.textName.Location = new System.Drawing.Point(6, 62);
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
            this.textName._TextChanged += new System.EventHandler(this.textName__TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(283, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 557);
            this.panel2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طباعةToolStripMenuItem,
            this.حفظToolStripMenuItem,
            this.تعديلالصفحهالحاليهToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 92);
            // 
            // طباعةToolStripMenuItem
            // 
            this.طباعةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طباعةالصفحةToolStripMenuItem,
            this.طباعةالكلToolStripMenuItem,
            this.طباعةجميعالمستنداتToolStripMenuItem});
            this.طباعةToolStripMenuItem.Name = "طباعةToolStripMenuItem";
            this.طباعةToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.طباعةToolStripMenuItem.Text = "طباعة ";
            // 
            // طباعةالصفحةToolStripMenuItem
            // 
            this.طباعةالصفحةToolStripMenuItem.Name = "طباعةالصفحةToolStripMenuItem";
            this.طباعةالصفحةToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.طباعةالصفحةToolStripMenuItem.Text = "طباعة الصفحة";
            this.طباعةالصفحةToolStripMenuItem.Click += new System.EventHandler(this.طباعةالصفحةToolStripMenuItem_Click);
            // 
            // طباعةالكلToolStripMenuItem
            // 
            this.طباعةالكلToolStripMenuItem.Name = "طباعةالكلToolStripMenuItem";
            this.طباعةالكلToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.طباعةالكلToolStripMenuItem.Text = "طباعة المستند";
            // 
            // طباعةجميعالمستنداتToolStripMenuItem
            // 
            this.طباعةجميعالمستنداتToolStripMenuItem.Name = "طباعةجميعالمستنداتToolStripMenuItem";
            this.طباعةجميعالمستنداتToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.طباعةجميعالمستنداتToolStripMenuItem.Text = "طباعة جميع المستندات";
            // 
            // حفظToolStripMenuItem
            // 
            this.حفظToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حفظالصفحهToolStripMenuItem,
            this.حفظالمستندToolStripMenuItem,
            this.حفظجميعالمستنداتToolStripMenuItem});
            this.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            this.حفظToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حفظToolStripMenuItem.Text = "حفظ";
            // 
            // حفظالصفحهToolStripMenuItem
            // 
            this.حفظالصفحهToolStripMenuItem.Name = "حفظالصفحهToolStripMenuItem";
            this.حفظالصفحهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حفظالصفحهToolStripMenuItem.Text = "حفظ الصفحه";
            this.حفظالصفحهToolStripMenuItem.Click += new System.EventHandler(this.حفظالصفحهToolStripMenuItem_Click);
            // 
            // حفظالمستندToolStripMenuItem
            // 
            this.حفظالمستندToolStripMenuItem.Name = "حفظالمستندToolStripMenuItem";
            this.حفظالمستندToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حفظالمستندToolStripMenuItem.Text = "حفظ المستند";
            // 
            // حفظجميعالمستنداتToolStripMenuItem
            // 
            this.حفظجميعالمستنداتToolStripMenuItem.Name = "حفظجميعالمستنداتToolStripMenuItem";
            this.حفظجميعالمستنداتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حفظجميعالمستنداتToolStripMenuItem.Text = "حفظ جميع المستندات";
            // 
            // تعديلالصفحهالحاليهToolStripMenuItem
            // 
            this.تعديلالصفحهالحاليهToolStripMenuItem.Name = "تعديلالصفحهالحاليهToolStripMenuItem";
            this.تعديلالصفحهالحاليهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديلالصفحهالحاليهToolStripMenuItem.Text = "تعديل الصفحه الحاليه";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفالصفحةالحاليهToolStripMenuItem,
            this.حذفالمستندToolStripMenuItem,
            this.حذفجميعالمستنداتToolStripMenuItem});
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // حذفالصفحةالحاليهToolStripMenuItem
            // 
            this.حذفالصفحةالحاليهToolStripMenuItem.Name = "حذفالصفحةالحاليهToolStripMenuItem";
            this.حذفالصفحةالحاليهToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.حذفالصفحةالحاليهToolStripMenuItem.Text = "حذف الصفحة الحاليه";
            // 
            // حذفالمستندToolStripMenuItem
            // 
            this.حذفالمستندToolStripMenuItem.Name = "حذفالمستندToolStripMenuItem";
            this.حذفالمستندToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.حذفالمستندToolStripMenuItem.Text = "حذف المستند";
            // 
            // حذفجميعالمستنداتToolStripMenuItem
            // 
            this.حذفجميعالمستنداتToolStripMenuItem.Name = "حذفجميعالمستنداتToolStripMenuItem";
            this.حذفجميعالمستنداتToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.حذفجميعالمستنداتToolStripMenuItem.Text = "حذف جميع المستندات";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 201);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.lblDecumentName);
            this.panel4.Controls.Add(this.lblDecumentId);
            this.panel4.Controls.Add(this.lblPageCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(995, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 201);
            this.panel4.TabIndex = 0;
            // 
            // lblDecumentName
            // 
            this.lblDecumentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecumentName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDecumentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDecumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecumentName.Location = new System.Drawing.Point(4, 12);
            this.lblDecumentName.Multiline = true;
            this.lblDecumentName.Name = "lblDecumentName";
            this.lblDecumentName.Size = new System.Drawing.Size(171, 66);
            this.lblDecumentName.TabIndex = 5;
            this.lblDecumentName.Text = "....";
            // 
            // lblDecumentId
            // 
            this.lblDecumentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecumentId.Location = new System.Drawing.Point(118, 105);
            this.lblDecumentId.Name = "lblDecumentId";
            this.lblDecumentId.Size = new System.Drawing.Size(35, 26);
            this.lblDecumentId.TabIndex = 3;
            this.lblDecumentId.Text = "0";
            this.lblDecumentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDecumentId.Visible = false;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Location = new System.Drawing.Point(9, 79);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(167, 26);
            this.lblPageCount.TabIndex = 4;
            this.lblPageCount.Text = ".....";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(283, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1172, 201);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.trackBar1);
            this.panel6.Controls.Add(this.btnDeleteImage);
            this.panel6.Controls.Add(this.lbl_imageid);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.btnChangeImage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(283, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1172, 59);
            this.panel6.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(439, 6);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(335, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_imageid
            // 
            this.lbl_imageid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imageid.Location = new System.Drawing.Point(262, 25);
            this.lbl_imageid.Name = "lbl_imageid";
            this.lbl_imageid.Size = new System.Drawing.Size(35, 26);
            this.lbl_imageid.TabIndex = 3;
            this.lbl_imageid.Text = "0";
            this.lbl_imageid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_imageid.Visible = false;
            // 
            // pictureView
            // 
            this.pictureView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureView.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureView.Location = new System.Drawing.Point(208, 6);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(787, 272);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureView.TabIndex = 1;
            this.pictureView.TabStop = false;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDeleteImage.Image = global::SaleManagerPro.Properties.Resources.icons8_delete_128px;
            this.btnDeleteImage.Location = new System.Drawing.Point(177, 3);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(53, 56);
            this.btnDeleteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteImage.TabIndex = 0;
            this.btnDeleteImage.TabStop = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pictureBox1.Image = global::SaleManagerPro.Properties.Resources.icons8_print_240px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pictureBox2.Image = global::SaleManagerPro.Properties.Resources.icons8_save_200px;
            this.pictureBox2.Location = new System.Drawing.Point(59, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnChangeImage.Image = global::SaleManagerPro.Properties.Resources.icons8_edit_file_240px;
            this.btnChangeImage.Location = new System.Drawing.Point(118, 0);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(53, 56);
            this.btnChangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeImage.TabIndex = 0;
            this.btnChangeImage.TabStop = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::SaleManagerPro.Properties.Resources.icon_add_48px;
            this.btnAdd.Location = new System.Drawing.Point(4, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 44);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormEmployeeDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 817);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مستندات الموظف";
            this.Load += new System.EventHandler(this.FormEmployeeDocuments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.Controls.RJTextBox textName;
        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox btnAdd;
        public System.Windows.Forms.TextBox lblDecumentName;
        public System.Windows.Forms.Label lblDecumentId;
        public System.Windows.Forms.Label lblPageCount;
        private CustomControls.Controls.RJButton btnSaveDocument;
        public System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnDeleteImage;
        private System.Windows.Forms.PictureBox btnChangeImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.Label lbl_imageid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem طباعةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةالصفحةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةجميعالمستنداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظالصفحهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظالمستندToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظجميعالمستنداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلالصفحهالحاليهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالصفحةالحاليهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالمستندToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفجميعالمستنداتToolStripMenuItem;
        public System.Windows.Forms.Label lblEmployeeName;
    }
}