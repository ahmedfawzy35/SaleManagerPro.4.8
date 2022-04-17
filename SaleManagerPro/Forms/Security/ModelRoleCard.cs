using SaleManagerPro.Data;
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

namespace SaleManagerPro.Forms.Security
{
    public partial class ModelRoleCard : UserControl
    {
        public string ModelRoleName { get; set; }
        public int _IdROle { get; set; }


        AppDbContext db = new AppDbContext();
        string permisioncreat;
        string permisionview;
        string permisionedit;
        string permisiondelet;
        Claime View = new Claime();
        Claime Create = new Claime();
        Claime Edit = new Claime();
        Claime Delete = new Claime();
        RoleClaime _View = new RoleClaime();
        RoleClaime _Create = new RoleClaime();
        RoleClaime _Edit = new RoleClaime();
        RoleClaime _Delete = new RoleClaime();
        bool isload = true;
        public ModelRoleCard()
        {
            InitializeComponent();
        }

        private void ModelRoleCard_Load(object sender, EventArgs e)
        {
            labelModelName.Text = ModelRoleName;
            setcheckbox();
        }
       void setcheckbox()
        {
            permisioncreat = Assist.Permissions.Creat(ModelRoleName);
            permisionview = Assist.Permissions.View(ModelRoleName);
            permisionedit = Assist.Permissions.Edit(ModelRoleName);
            permisiondelet = Assist.Permissions.Delete(ModelRoleName);

            View = db.Claimes.Where(x=> x.Value == permisionview).FirstOrDefault();
            Create = db.Claimes.Where(x => x.Value == permisioncreat).FirstOrDefault();
            Edit = db.Claimes.Where(x => x.Value == permisionedit).FirstOrDefault();
            Delete = db.Claimes.Where(x => x.Value == permisiondelet).FirstOrDefault();

              _View = db.RoleClaimes.Where(x=> x.IdClaime == View.IdClaime&& x.IdRole == _IdROle).FirstOrDefault() == null? new RoleClaime(){ IdClaime = View.IdClaime , IdRole =this._IdROle}
                                         : db.RoleClaimes.Where(x => x.IdClaime == View.IdClaime && x.IdRole == _IdROle).FirstOrDefault();

                
              _Create = db.RoleClaimes.Where(x => x.IdClaime == Create.IdClaime && x.IdRole == _IdROle).FirstOrDefault() == null ? new RoleClaime() { IdClaime = Create.IdClaime, IdRole = this._IdROle }
                                         : db.RoleClaimes.Where(x => x.IdClaime == Create.IdClaime && x.IdRole == _IdROle).FirstOrDefault();



            _Edit = db.RoleClaimes.Where(x => x.IdClaime == Edit.IdClaime && x.IdRole == _IdROle).FirstOrDefault() == null ? new RoleClaime() { IdClaime = Edit.IdClaime, IdRole = this._IdROle }
                                          : db.RoleClaimes.Where(x => x.IdClaime == Edit.IdClaime && x.IdRole == _IdROle).FirstOrDefault();

            _Delete = db.RoleClaimes.Where(x => x.IdClaime == Delete.IdClaime && x.IdRole == _IdROle).FirstOrDefault() == null ? new RoleClaime() { IdClaime = Delete.IdClaime, IdRole = this._IdROle }
                                          : db.RoleClaimes.Where(x => x.IdClaime == Delete.IdClaime && x.IdRole == _IdROle).FirstOrDefault();

            lbl_id_creat.Text = Create.IdClaime.ToString(); 
            lbl_id_view.Text = View.IdClaime.ToString(); 
            lbl_id_edit.Text = Edit.IdClaime.ToString();
            lbl_id_delete.Text = Delete.IdClaime.ToString();

            //checkboxCreate.Text = permisioncreat; 
            //checkboxView.Text = permisionview; 
            //checkboxEdit.Text = permisionedit; 
            //checkboxDelete.Text = permisiondelet; 
            if (FormRoleClaimManager.GetFormRoleClaimManager.RoleClaimesList.Any(p => p.Value == permisionview))
            {


                checkboxView.Checked = true;
                
            }
            if (FormRoleClaimManager.GetFormRoleClaimManager.RoleClaimesList.Any(p => p.Value == permisioncreat))
            {
                checkboxCreate.Checked = true;
            }
            if (FormRoleClaimManager.GetFormRoleClaimManager.RoleClaimesList.Any(p => p.Value == permisionedit))
            {
                checkboxEdit.Checked = true;
            }
            if (FormRoleClaimManager.GetFormRoleClaimManager.RoleClaimesList.Any(p => p.Value == permisiondelet))
            {
                checkboxDelete.Checked = true;
            }

            isload = false;
        }
        void selectpermission(RoleClaime claim )
        {
            if (!db.RoleClaimes.Any(x=>x.IdClaime == claim.IdClaime && x.IdRole == claim.IdRole))
            {
                db.RoleClaimes.Add(claim);
                db.SaveChanges();
            }
            FormRoleClaimManager.GetFormRoleClaimManager.getdata();
        }
        void unselectpermission(RoleClaime claim )
        {
            if (db.RoleClaimes.Any(x => x.IdClaime == claim.IdClaime && x.IdRole == claim.IdRole))
            {

                db.RoleClaimes.Remove(claim);
                db.SaveChanges();
            }
            FormRoleClaimManager.GetFormRoleClaimManager.getdata();

        }
        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSelectAll.Checked)
            {
                checkSelectAll.Text = "الغاء الكل";
                checkboxView.Checked = true;
                checkboxCreate.Checked = true;
                checkboxEdit.Checked = true;
                checkboxDelete.Checked = true;
            }else
            {
                checkSelectAll.Text = "إختيار الكل";
                checkboxView.Checked = false;
                checkboxCreate.Checked = false;
                checkboxEdit.Checked = false;
                checkboxDelete.Checked = false;
            }
        }

        private void checkboxView_CheckedChanged(object sender, EventArgs e)
        {
            if (!isload)
            {
                if (checkboxView.Checked)
                {
                    //if(_View!=null)
                    selectpermission(_View);
                }
                else
                {
                    unselectpermission(_View);
                }
            }



        }

        private void checkboxCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (!isload)
            {
                if (checkboxCreate.Checked)
                {
                    selectpermission(_Create);
                }
                else
                {
                    unselectpermission(_Create);
                }
            }
           
        }

        private void checkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (!isload)
            {
                if (checkboxEdit.Checked)
                {
                    selectpermission(_Edit);
                }
                else
                {
                    unselectpermission(_Edit);
                }
            }
          
        }

        private void checkboxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (!isload)
            {
                if (checkboxDelete.Checked)
                {
                    selectpermission(_Delete);
                }
                else
                {
                    unselectpermission(_Delete);
                }

            }

        }
    }
}
