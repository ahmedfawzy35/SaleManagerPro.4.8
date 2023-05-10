using System.Windows.Forms;

namespace SaleManagerPro.Forms.Master
{
    partial class MasterForm
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
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureRestore = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureSidBarView = new System.Windows.Forms.PictureBox();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.المنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مونتاجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صوتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صورهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.SubPanelUsersAndRoles = new System.Windows.Forms.Panel();
            this.BtnUsersAndRoles = new System.Windows.Forms.Button();
            this.SubPanelEmployees = new System.Windows.Forms.Panel();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.SubPanelLoans = new System.Windows.Forms.Panel();
            this.BtnLoans = new System.Windows.Forms.Button();
            this.SubPanelInstallments = new System.Windows.Forms.Panel();
            this.BtnInstallments = new System.Windows.Forms.Button();
            this.SubPanelChecKs = new System.Windows.Forms.Panel();
            this.BtnChecks = new System.Windows.Forms.Button();
            this.SubPanelCash = new System.Windows.Forms.Panel();
            this.BtnCash = new System.Windows.Forms.Button();
            this.SubPanelOrdersAndPurchases = new System.Windows.Forms.Panel();
            this.BtnOrdersAndPurchases = new System.Windows.Forms.Button();
            this.SubPanelCustomersAndSalers = new System.Windows.Forms.Panel();
            this.BtnCustomersAndSalers = new System.Windows.Forms.Button();
            this.SubPanelProducts = new System.Windows.Forms.Panel();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MasterTabPage = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSidBarView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureRestore);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 21);
            this.panel1.TabIndex = 0;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimize.Image = global::SaleManagerPro.Properties.Resources.minimize_window_32px;
            this.pictureMinimize.Location = new System.Drawing.Point(1277, 0);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(19, 21);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 2;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureRestore
            // 
            this.pictureRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureRestore.Image = global::SaleManagerPro.Properties.Resources.restore_down_32px;
            this.pictureRestore.Location = new System.Drawing.Point(1296, 0);
            this.pictureRestore.Name = "pictureRestore";
            this.pictureRestore.Size = new System.Drawing.Size(19, 21);
            this.pictureRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRestore.TabIndex = 1;
            this.pictureRestore.TabStop = false;
            this.pictureRestore.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureClose.Image = global::SaleManagerPro.Properties.Resources.close_window_32px;
            this.pictureClose.Location = new System.Drawing.Point(1315, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(19, 21);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureSidBarView);
            this.panel2.Controls.Add(this.lbl_userid);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 55);
            this.panel2.TabIndex = 1;
            // 
            // PictureSidBarView
            // 
            this.PictureSidBarView.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureSidBarView.Image = global::SaleManagerPro.Properties.Resources.menu_50px;
            this.PictureSidBarView.Location = new System.Drawing.Point(1308, 24);
            this.PictureSidBarView.Name = "PictureSidBarView";
            this.PictureSidBarView.Size = new System.Drawing.Size(26, 31);
            this.PictureSidBarView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSidBarView.TabIndex = 2;
            this.PictureSidBarView.TabStop = false;
            this.PictureSidBarView.Click += new System.EventHandler(this.PictureSidBarView_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(28, 7);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(35, 13);
            this.lbl_userid.TabIndex = 1;
            this.lbl_userid.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المنتجاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // المنتجاتToolStripMenuItem
            // 
            this.المنتجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.مونتاجToolStripMenuItem,
            this.صوتToolStripMenuItem,
            this.صورهToolStripMenuItem});
            this.المنتجاتToolStripMenuItem.Name = "المنتجاتToolStripMenuItem";
            this.المنتجاتToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.المنتجاتToolStripMenuItem.Text = "المنتجات";
            this.المنتجاتToolStripMenuItem.Click += new System.EventHandler(this.المنتجاتToolStripMenuItem_Click);
            // 
            // اضافةToolStripMenuItem
            // 
            this.اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem";
            this.اضافةToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.اضافةToolStripMenuItem.Text = "اضافة";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            // 
            // مونتاجToolStripMenuItem
            // 
            this.مونتاجToolStripMenuItem.Name = "مونتاجToolStripMenuItem";
            this.مونتاجToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.مونتاجToolStripMenuItem.Text = "مونتاج";
            // 
            // صوتToolStripMenuItem
            // 
            this.صوتToolStripMenuItem.Name = "صوتToolStripMenuItem";
            this.صوتToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.صوتToolStripMenuItem.Text = "صوت";
            // 
            // صورهToolStripMenuItem
            // 
            this.صورهToolStripMenuItem.Name = "صورهToolStripMenuItem";
            this.صورهToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.صورهToolStripMenuItem.Text = "صوره";
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoScroll = true;
            this.panelSideBar.Controls.Add(this.SubPanelUsersAndRoles);
            this.panelSideBar.Controls.Add(this.BtnUsersAndRoles);
            this.panelSideBar.Controls.Add(this.SubPanelEmployees);
            this.panelSideBar.Controls.Add(this.BtnEmployee);
            this.panelSideBar.Controls.Add(this.SubPanelLoans);
            this.panelSideBar.Controls.Add(this.BtnLoans);
            this.panelSideBar.Controls.Add(this.SubPanelInstallments);
            this.panelSideBar.Controls.Add(this.BtnInstallments);
            this.panelSideBar.Controls.Add(this.SubPanelChecKs);
            this.panelSideBar.Controls.Add(this.BtnChecks);
            this.panelSideBar.Controls.Add(this.SubPanelCash);
            this.panelSideBar.Controls.Add(this.BtnCash);
            this.panelSideBar.Controls.Add(this.SubPanelOrdersAndPurchases);
            this.panelSideBar.Controls.Add(this.BtnOrdersAndPurchases);
            this.panelSideBar.Controls.Add(this.SubPanelCustomersAndSalers);
            this.panelSideBar.Controls.Add(this.BtnCustomersAndSalers);
            this.panelSideBar.Controls.Add(this.SubPanelProducts);
            this.panelSideBar.Controls.Add(this.BtnProduct);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 76);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(287, 701);
            this.panelSideBar.TabIndex = 3;
            // 
            // SubPanelUsersAndRoles
            // 
            this.SubPanelUsersAndRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelUsersAndRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelUsersAndRoles.Location = new System.Drawing.Point(0, 575);
            this.SubPanelUsersAndRoles.Name = "SubPanelUsersAndRoles";
            this.SubPanelUsersAndRoles.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelUsersAndRoles.Size = new System.Drawing.Size(287, 15);
            this.SubPanelUsersAndRoles.TabIndex = 16;
            this.SubPanelUsersAndRoles.Visible = false;
            // 
            // BtnUsersAndRoles
            // 
            this.BtnUsersAndRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsersAndRoles.FlatAppearance.BorderSize = 0;
            this.BtnUsersAndRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsersAndRoles.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnUsersAndRoles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsersAndRoles.Location = new System.Drawing.Point(0, 524);
            this.BtnUsersAndRoles.Name = "BtnUsersAndRoles";
            this.BtnUsersAndRoles.Size = new System.Drawing.Size(287, 51);
            this.BtnUsersAndRoles.TabIndex = 15;
            this.BtnUsersAndRoles.Text = "المستخدمين والصلاحيات";
            this.BtnUsersAndRoles.UseVisualStyleBackColor = true;
            this.BtnUsersAndRoles.Click += new System.EventHandler(this.BtnUsersAndRoles_Click);
            this.BtnUsersAndRoles.MouseHover += new System.EventHandler(this.BtnUsersAndRoles_Click);
            // 
            // SubPanelEmployees
            // 
            this.SubPanelEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelEmployees.Location = new System.Drawing.Point(0, 509);
            this.SubPanelEmployees.Name = "SubPanelEmployees";
            this.SubPanelEmployees.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelEmployees.Size = new System.Drawing.Size(287, 15);
            this.SubPanelEmployees.TabIndex = 14;
            this.SubPanelEmployees.Visible = false;
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmployee.Location = new System.Drawing.Point(0, 458);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(287, 51);
            this.BtnEmployee.TabIndex = 13;
            this.BtnEmployee.Text = "الموظفين";
            this.BtnEmployee.UseVisualStyleBackColor = true;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            this.BtnEmployee.MouseHover += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // SubPanelLoans
            // 
            this.SubPanelLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelLoans.Location = new System.Drawing.Point(0, 443);
            this.SubPanelLoans.Name = "SubPanelLoans";
            this.SubPanelLoans.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelLoans.Size = new System.Drawing.Size(287, 15);
            this.SubPanelLoans.TabIndex = 12;
            this.SubPanelLoans.Visible = false;
            // 
            // BtnLoans
            // 
            this.BtnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLoans.FlatAppearance.BorderSize = 0;
            this.BtnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoans.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnLoans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLoans.Location = new System.Drawing.Point(0, 392);
            this.BtnLoans.Name = "BtnLoans";
            this.BtnLoans.Size = new System.Drawing.Size(287, 51);
            this.BtnLoans.TabIndex = 11;
            this.BtnLoans.Text = "القروض";
            this.BtnLoans.UseVisualStyleBackColor = true;
            this.BtnLoans.Click += new System.EventHandler(this.BtnLoans_Click);
            this.BtnLoans.MouseHover += new System.EventHandler(this.BtnLoans_Click);
            // 
            // SubPanelInstallments
            // 
            this.SubPanelInstallments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelInstallments.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelInstallments.Location = new System.Drawing.Point(0, 377);
            this.SubPanelInstallments.Name = "SubPanelInstallments";
            this.SubPanelInstallments.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelInstallments.Size = new System.Drawing.Size(287, 15);
            this.SubPanelInstallments.TabIndex = 10;
            this.SubPanelInstallments.Visible = false;
            // 
            // BtnInstallments
            // 
            this.BtnInstallments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInstallments.FlatAppearance.BorderSize = 0;
            this.BtnInstallments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstallments.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnInstallments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInstallments.Location = new System.Drawing.Point(0, 326);
            this.BtnInstallments.Name = "BtnInstallments";
            this.BtnInstallments.Size = new System.Drawing.Size(287, 51);
            this.BtnInstallments.TabIndex = 1;
            this.BtnInstallments.Text = "الاقساط";
            this.BtnInstallments.UseVisualStyleBackColor = true;
            this.BtnInstallments.Click += new System.EventHandler(this.button6_Click);
            this.BtnInstallments.MouseHover += new System.EventHandler(this.button6_Click);
            // 
            // SubPanelChecKs
            // 
            this.SubPanelChecKs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelChecKs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelChecKs.Location = new System.Drawing.Point(0, 311);
            this.SubPanelChecKs.Name = "SubPanelChecKs";
            this.SubPanelChecKs.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelChecKs.Size = new System.Drawing.Size(287, 15);
            this.SubPanelChecKs.TabIndex = 9;
            this.SubPanelChecKs.Visible = false;
            // 
            // BtnChecks
            // 
            this.BtnChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChecks.FlatAppearance.BorderSize = 0;
            this.BtnChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChecks.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnChecks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnChecks.Location = new System.Drawing.Point(0, 260);
            this.BtnChecks.Name = "BtnChecks";
            this.BtnChecks.Size = new System.Drawing.Size(287, 51);
            this.BtnChecks.TabIndex = 1;
            this.BtnChecks.Text = "الشيكات";
            this.BtnChecks.UseVisualStyleBackColor = true;
            this.BtnChecks.Click += new System.EventHandler(this.button5_Click);
            this.BtnChecks.MouseHover += new System.EventHandler(this.button5_Click);
            // 
            // SubPanelCash
            // 
            this.SubPanelCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelCash.Location = new System.Drawing.Point(0, 247);
            this.SubPanelCash.Name = "SubPanelCash";
            this.SubPanelCash.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelCash.Size = new System.Drawing.Size(287, 13);
            this.SubPanelCash.TabIndex = 7;
            this.SubPanelCash.Visible = false;
            // 
            // BtnCash
            // 
            this.BtnCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCash.FlatAppearance.BorderSize = 0;
            this.BtnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCash.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCash.Location = new System.Drawing.Point(0, 196);
            this.BtnCash.Name = "BtnCash";
            this.BtnCash.Size = new System.Drawing.Size(287, 51);
            this.BtnCash.TabIndex = 1;
            this.BtnCash.Text = "النقدية";
            this.BtnCash.UseVisualStyleBackColor = true;
            this.BtnCash.Click += new System.EventHandler(this.button4_Click);
            this.BtnCash.MouseHover += new System.EventHandler(this.button4_Click);
            // 
            // SubPanelOrdersAndPurchases
            // 
            this.SubPanelOrdersAndPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelOrdersAndPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelOrdersAndPurchases.Location = new System.Drawing.Point(0, 186);
            this.SubPanelOrdersAndPurchases.Name = "SubPanelOrdersAndPurchases";
            this.SubPanelOrdersAndPurchases.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelOrdersAndPurchases.Size = new System.Drawing.Size(287, 10);
            this.SubPanelOrdersAndPurchases.TabIndex = 5;
            this.SubPanelOrdersAndPurchases.Visible = false;
            // 
            // BtnOrdersAndPurchases
            // 
            this.BtnOrdersAndPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrdersAndPurchases.FlatAppearance.BorderSize = 0;
            this.BtnOrdersAndPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdersAndPurchases.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnOrdersAndPurchases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOrdersAndPurchases.Location = new System.Drawing.Point(0, 124);
            this.BtnOrdersAndPurchases.Name = "BtnOrdersAndPurchases";
            this.BtnOrdersAndPurchases.Size = new System.Drawing.Size(287, 62);
            this.BtnOrdersAndPurchases.TabIndex = 1;
            this.BtnOrdersAndPurchases.Text = "المبيعات والمشتريات";
            this.BtnOrdersAndPurchases.UseVisualStyleBackColor = true;
            this.BtnOrdersAndPurchases.Click += new System.EventHandler(this.button3_Click);
            this.BtnOrdersAndPurchases.MouseHover += new System.EventHandler(this.button3_Click);
            // 
            // SubPanelCustomersAndSalers
            // 
            this.SubPanelCustomersAndSalers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelCustomersAndSalers.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelCustomersAndSalers.Location = new System.Drawing.Point(0, 113);
            this.SubPanelCustomersAndSalers.Name = "SubPanelCustomersAndSalers";
            this.SubPanelCustomersAndSalers.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelCustomersAndSalers.Size = new System.Drawing.Size(287, 11);
            this.SubPanelCustomersAndSalers.TabIndex = 3;
            this.SubPanelCustomersAndSalers.Visible = false;
            // 
            // BtnCustomersAndSalers
            // 
            this.BtnCustomersAndSalers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomersAndSalers.FlatAppearance.BorderSize = 0;
            this.BtnCustomersAndSalers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomersAndSalers.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnCustomersAndSalers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCustomersAndSalers.Location = new System.Drawing.Point(0, 62);
            this.BtnCustomersAndSalers.Name = "BtnCustomersAndSalers";
            this.BtnCustomersAndSalers.Size = new System.Drawing.Size(287, 51);
            this.BtnCustomersAndSalers.TabIndex = 1;
            this.BtnCustomersAndSalers.Text = "العملاء والموردين";
            this.BtnCustomersAndSalers.UseVisualStyleBackColor = true;
            this.BtnCustomersAndSalers.Click += new System.EventHandler(this.button2_Click);
            this.BtnCustomersAndSalers.MouseHover += new System.EventHandler(this.button2_Click);
            // 
            // SubPanelProducts
            // 
            this.SubPanelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SubPanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelProducts.Location = new System.Drawing.Point(0, 51);
            this.SubPanelProducts.Name = "SubPanelProducts";
            this.SubPanelProducts.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.SubPanelProducts.Size = new System.Drawing.Size(287, 11);
            this.SubPanelProducts.TabIndex = 1;
            this.SubPanelProducts.Visible = false;
            // 
            // BtnProduct
            // 
            this.BtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduct.FlatAppearance.BorderSize = 0;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.BtnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProduct.Location = new System.Drawing.Point(0, 0);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(287, 51);
            this.BtnProduct.TabIndex = 0;
            this.BtnProduct.Text = "ادارة المنتجات";
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.button1_Click_1);
            this.BtnProduct.MouseHover += new System.EventHandler(this.button1_Click_1);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(287, 690);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1047, 87);
            this.panel5.TabIndex = 3;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1299, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(35, 614);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MasterTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(287, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 614);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // MasterTabPage
            // 
            this.MasterTabPage.BackColor = System.Drawing.Color.White;
            this.MasterTabPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MasterTabPage.Location = new System.Drawing.Point(4, 22);
            this.MasterTabPage.Name = "MasterTabPage";
            this.MasterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MasterTabPage.Size = new System.Drawing.Size(1004, 588);
            this.MasterTabPage.TabIndex = 0;
            this.MasterTabPage.Text = "الرئيسيه";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1334, 777);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSidBarView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureMinimize;
        private PictureBox pictureRestore;
        private PictureBox pictureClose;
        private Panel panel2;
        private Panel panelSideBar;
        private Panel panel5;
        private Panel panel6;
        private Panel SubPanelOrdersAndPurchases;
        private Panel SubPanelCustomersAndSalers;
        private Panel SubPanelProducts;
        private Button BtnInstallments;
        private Button BtnChecks;
        private Button BtnCash;
        private Button BtnOrdersAndPurchases;
        private Button BtnCustomersAndSalers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem المنتجاتToolStripMenuItem;
        private ToolStripMenuItem اضافةToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripMenuItem مونتاجToolStripMenuItem;
        private ToolStripMenuItem صوتToolStripMenuItem;
        private ToolStripMenuItem صورهToolStripMenuItem;
        private Button BtnProduct;
        private TabControl tabControl1;
        private TabPage MasterTabPage;
        private Label lbl_userid;
        private Panel SubPanelInstallments;
        private Panel SubPanelChecKs;
        private Panel SubPanelCash;
        private Panel SubPanelUsersAndRoles;
        private Button BtnUsersAndRoles;
        private Panel SubPanelEmployees;
        private Button BtnEmployee;
        private Panel SubPanelLoans;
        private Button BtnLoans;
        private PictureBox PictureSidBarView;
    }
}