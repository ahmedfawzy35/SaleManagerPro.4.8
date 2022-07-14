//using SaleManagerPro.Forms.ProductsForms;
////using SaleManagerPro.Forms.Test;
using SaleManagerPro.Assist;
using SaleManagerPro.Data;
using SaleManagerPro.Forms.CustomersForms;
using SaleManagerPro.Forms.EmployeeForms;
using SaleManagerPro.Forms.ProductsForms;
using SaleManagerPro.Forms.Security;
using SaleManagerPro.Models.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.Master
{
    public partial class MasterForm : Form
    {
        #region getter

        //
        private static MasterForm masterForm;
        static void masterForm_formclosed(object sender, FormClosedEventArgs e)
        {
            masterForm = null;
        }
        public static MasterForm GetFormMasterForm
        {
            get
            {
                if (masterForm == null)
                {
                    masterForm = new MasterForm();
                    masterForm.FormClosed += new FormClosedEventHandler(masterForm_formclosed);
                }
                return masterForm;
            }
        }
        //
        #endregion
        List<Panel> SupPsnels = new List<Panel>();
        List<Panel> MasterPsnels = new List<Panel>();
        public  List<Claime> userClaims = new List<Claime>();

        public UserRoleManager roleManager = new UserRoleManager();
        public static AppDbContext db = new AppDbContext();
        private Form _ActivForm =null;
        Image CloseImage;
        public MasterForm()
        {
            InitializeComponent();
            if (masterForm == null) masterForm = this;
           
        }


        #region Methods

 

        private void ShowForm(Form form)
        {
            //if (_ActivForm != null) _ActivForm.Close();
            //_ActivForm = form;
            ////panelForm.TopLevelControl = false;
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            //panelForm.Controls.Add(form);
            //panelForm.Tag = form;
            //form.BringToFront();
            //form.Show();
        }
        private void showpanel(Panel panel)
        {

            foreach (var PANEL in SupPsnels)
            {
                if (PANEL.Name == panel.Name)
                {
                    if (panel.Visible == false)
                    {
                        PANEL.Height = 285;
                        PANEL.Visible = true;

                    }
                    else
                        panel.Visible = false;
                        //PANEL.Height = 280;

                }
                else
                {
                    PANEL.Visible = false;
                }

            }
        }
        int is_exits(string x)
        {
            int a = -1;
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {

                if (tabControl1.TabPages[i].Text == x)
                {

                    tabControl1.SelectTab(i);
                    a = i;
                    break;
                }
            }

            return a;

        }
        public void showform(string x, Form frm)
        {

            int select = is_exits(x);
            if (select == -1)
            {

                //frm.MdiParent = this;
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.Orange;
                //Label adress = new Label();
                //adress.Location = new Point(0, 0);
                //adress.Size = new Size(200, 15);
                //adress.Font = new Font("Traditional Arabic", 24, FontStyle.Bold);
                //adress.Text = x;
                //frm.Controls.Add(adress);
                //frm.Controls.Add(new Label { Location = new Point(13, 13), AutoSize = true, Text = x, Font = new Font("Traditional Arabic", 24, FontStyle.Bold) });
                //foreach (Label lbl in frm.Controls.OfType<Label>().ToList())
                //{
                //    lbl.BringToFront();
                //}
                int index1 = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(x);

                tabControl1.TabPages[index1].Controls.Clear();
                tabControl1.TabPages[index1].Text = x;
                tabControl1.TabPages[index1].Controls.Add(frm);
                tabControl1.TabPages[index1].Name = frm.Name;
                tabControl1.SelectTab(index1);
                return;



            }
            else
            {
                tabControl1.SelectTab(select);
            }

        }

        #endregion
        #region FormActions
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }

        }
        #endregion
        #region FormEvents
        private void MasterForm_Load(object sender, EventArgs e)
        {
            #region add panel to list
            //SupPsnels = this.Controls.OfType<Panel>().Where(x => x.Name.Contains("SubPanel")).ToList();
            SupPsnels.Add(SubPanel1); SupPsnels.Add(SubPanel2); SupPsnels.Add(SubPanel3); SupPsnels.Add(SubPanel4); SupPsnels.Add(SubPanel5);
            SupPsnels.Add(SubPanel6);
            MasterPsnels.Add(MasterPanel1); MasterPsnels.Add(MasterPanel2); MasterPsnels.Add(MasterPanel3); MasterPsnels.Add(MasterPanel4); MasterPsnels.Add(MasterPanel5);
            MasterPsnels.Add(MasterPanel6);
            #endregion
            // get claims
            userClaims = roleManager.getuserclaims(Properties.Settings.Default.UserId);


            // set sidebar minimize
            panelSideBar.Width = 15;
            // tab control setting
            CloseImage = Properties.Resources.close_window_32px;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Padding = new Point(20, 7);
        }
        #endregion
        #region SidBar Master Button Events
        private void button1_Click_1(object sender, EventArgs e)
        {
            showpanel(this.SubPanel1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            showpanel(this.SubPanel6);

        }
        #endregion
        #region SideBar Button Events
        private void button7_Click(object sender, EventArgs e)
        {
            showform("إنشاء تصنيف جديد",  FormCatogryAddEdit.GetFormCatogryAddEdit);
        }

        #endregion
        #region Tab Controle
        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index == this.tabControl1.SelectedIndex)
                {
                    Brush _BackBrush = new SolidBrush(Color.LightSkyBlue);

                    var tabRect = this.tabControl1.GetTabRect(e.Index);
                    tabRect.Inflate(-2, -2);
                    var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                             tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                             CloseImage.Width,
                                             CloseImage.Height);

                    var sf = new StringFormat(StringFormat.GenericDefault);
                    if (this.tabControl1.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                        this.tabControl1.RightToLeftLayout == true)
                    {
                        tabRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, tabRect);
                        imageRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, imageRect);
                        sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;

                    }
                    e.Graphics.FillRectangle(_BackBrush, (tabRect.X) + 4, tabRect.Y, (tabRect.Width) - 4, tabRect.Height);
                    e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, new Font("Traditional Arabic", 12, FontStyle.Bold), Brushes.White, tabRect, sf);
                    e.Graphics.DrawImage(CloseImage, imageRect.Location);
                   


                    Rectangle paddedBounds = e.Bounds;
                    int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
                    paddedBounds.Offset(1, yOffset);

                }
                else
                {
                  var tabRect = this.tabControl1.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (this.tabControl1.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    this.tabControl1.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;

                }

                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, new Font("Traditional Arabic", 12, FontStyle.Bold), Brushes.Black, tabRect, sf);
                e.Graphics.DrawImage(CloseImage, imageRect.Location);



                Rectangle paddedBounds = e.Bounds;
                int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
                paddedBounds.Offset(1, yOffset);
            }}
            catch (Exception) { }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                var tabRect = this.tabControl1.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    if (i == 0)
                    {
                        int xx = this.tabControl1.TabPages.Count;
                        for (int x = 1; x < xx; x++)
                        {
                            if (x == 0) continue;
                            if (tabControl1.TabPages[x].Text == "إدارة الاجراءات الصلاحيه")
                            {
                                Form frm = tabControl1.TabPages[x].Controls.OfType<Form>().FirstOrDefault();
                                frm.Close();
                            }

                            this.tabControl1.TabPages.RemoveAt(1);
                        }
                    }
                    else
                    {
                        if (tabControl1.TabPages[i].Text == "إدارة الاجراءات الصلاحيه")
                        {
                            Form frm = tabControl1.TabPages[i].Controls.OfType<Form>().FirstOrDefault();
                            frm.Close();
                        }

                        this.tabControl1.TabPages.RemoveAt(i);

                        this.tabControl1.SelectTab(i - 1);
                        break;
                    }

                }
            }
        }
        #endregion
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            showpanel(new Panel());
            if (panelSideBar.Width == 259)
            {
                panelSideBar.Width = 15;

            }
            else
            {
                panelSideBar.Width = 259;
            }
        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            showform("إنشاء منتج جديد", new FormProductAddEdit());

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            if (panelSideBar.Width == 259)
            {
                showpanel(new Panel());
                panelSideBar.Width = 15;

            }
            else
            {
                
                panelSideBar.Width = 259;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            //showform("إدارة الاجراءات الصلاحيه", new FormRoleClaimManager() { IdRole = 1 , RoleName = "Admin"});
            showform("إدارة الاقسام", FormDepartmentAddEdit.GetFormDepartmentAddEdit );

        }

        private void button10_Click(object sender, EventArgs e)
        {
            showform("ادراة المستخدمين", new FormUserAddEdit());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            showform("ادراة الوحدات", FormUnitsAddEdit.GetFormUnitsAddEdit);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            showform("ادراة العملاء", FormCustomerAddEdit.GetFormCustomerAddEdit);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
             showform("ادراة الموظفين",new  FormEmployeeAddEdit());

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //EmployeePromotionAddEdit
            showform("ادراة الترقيات", EmployeePromotionAddEdit.GetFormEmployeePromotionAddEdit);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showform("ادراة الجزاءات", FormEmployeePunishmentAddEdit.GetFormEmployeePunishmentAddEdit);

        }
    }
}
