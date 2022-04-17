namespace SaleManagerPro.Forms.Security
{
    partial class ModelRoleCard
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
            this.labelModelName = new System.Windows.Forms.Label();
            this.checkboxCreate = new System.Windows.Forms.CheckBox();
            this.checkboxEdit = new System.Windows.Forms.CheckBox();
            this.checkboxView = new System.Windows.Forms.CheckBox();
            this.checkboxDelete = new System.Windows.Forms.CheckBox();
            this.checkSelectAll = new System.Windows.Forms.CheckBox();
            this.lbl_id_creat = new System.Windows.Forms.Label();
            this.lbl_id_view = new System.Windows.Forms.Label();
            this.lbl_id_edit = new System.Windows.Forms.Label();
            this.lbl_id_delete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelModelName.Location = new System.Drawing.Point(93, 14);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(60, 24);
            this.labelModelName.TabIndex = 0;
            this.labelModelName.Text = "label1";
            // 
            // checkboxCreate
            // 
            this.checkboxCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxCreate.AutoSize = true;
            this.checkboxCreate.Location = new System.Drawing.Point(105, 155);
            this.checkboxCreate.Name = "checkboxCreate";
            this.checkboxCreate.Size = new System.Drawing.Size(53, 17);
            this.checkboxCreate.TabIndex = 1;
            this.checkboxCreate.Text = "اضافة";
            this.checkboxCreate.UseVisualStyleBackColor = true;
            this.checkboxCreate.CheckedChanged += new System.EventHandler(this.checkboxCreate_CheckedChanged);
            // 
            // checkboxEdit
            // 
            this.checkboxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxEdit.AutoSize = true;
            this.checkboxEdit.Location = new System.Drawing.Point(106, 178);
            this.checkboxEdit.Name = "checkboxEdit";
            this.checkboxEdit.Size = new System.Drawing.Size(52, 17);
            this.checkboxEdit.TabIndex = 2;
            this.checkboxEdit.Text = "تعديل";
            this.checkboxEdit.UseVisualStyleBackColor = true;
            this.checkboxEdit.CheckedChanged += new System.EventHandler(this.checkboxEdit_CheckedChanged);
            // 
            // checkboxView
            // 
            this.checkboxView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxView.AutoSize = true;
            this.checkboxView.Location = new System.Drawing.Point(109, 132);
            this.checkboxView.Name = "checkboxView";
            this.checkboxView.Size = new System.Drawing.Size(49, 17);
            this.checkboxView.TabIndex = 1;
            this.checkboxView.Text = "عرض";
            this.checkboxView.UseVisualStyleBackColor = true;
            this.checkboxView.CheckedChanged += new System.EventHandler(this.checkboxView_CheckedChanged);
            // 
            // checkboxDelete
            // 
            this.checkboxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxDelete.AutoSize = true;
            this.checkboxDelete.Location = new System.Drawing.Point(111, 201);
            this.checkboxDelete.Name = "checkboxDelete";
            this.checkboxDelete.Size = new System.Drawing.Size(47, 17);
            this.checkboxDelete.TabIndex = 2;
            this.checkboxDelete.Text = "حذف";
            this.checkboxDelete.UseVisualStyleBackColor = true;
            this.checkboxDelete.CheckedChanged += new System.EventHandler(this.checkboxDelete_CheckedChanged);
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Location = new System.Drawing.Point(159, 77);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(77, 17);
            this.checkSelectAll.TabIndex = 3;
            this.checkSelectAll.Text = "إختيار الكل";
            this.checkSelectAll.UseVisualStyleBackColor = true;
            this.checkSelectAll.CheckedChanged += new System.EventHandler(this.checkSelectAll_CheckedChanged);
            // 
            // lbl_id_creat
            // 
            this.lbl_id_creat.AutoSize = true;
            this.lbl_id_creat.Location = new System.Drawing.Point(185, 159);
            this.lbl_id_creat.Name = "lbl_id_creat";
            this.lbl_id_creat.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_creat.TabIndex = 4;
            this.lbl_id_creat.Text = "label1";
            // 
            // lbl_id_view
            // 
            this.lbl_id_view.AutoSize = true;
            this.lbl_id_view.Location = new System.Drawing.Point(185, 136);
            this.lbl_id_view.Name = "lbl_id_view";
            this.lbl_id_view.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_view.TabIndex = 5;
            this.lbl_id_view.Text = "label1";
            // 
            // lbl_id_edit
            // 
            this.lbl_id_edit.AutoSize = true;
            this.lbl_id_edit.Location = new System.Drawing.Point(185, 182);
            this.lbl_id_edit.Name = "lbl_id_edit";
            this.lbl_id_edit.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_edit.TabIndex = 6;
            this.lbl_id_edit.Text = "label1";
            // 
            // lbl_id_delete
            // 
            this.lbl_id_delete.AutoSize = true;
            this.lbl_id_delete.Location = new System.Drawing.Point(185, 205);
            this.lbl_id_delete.Name = "lbl_id_delete";
            this.lbl_id_delete.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_delete.TabIndex = 7;
            this.lbl_id_delete.Text = "label1";
            // 
            // ModelRoleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl_id_delete);
            this.Controls.Add(this.lbl_id_edit);
            this.Controls.Add(this.lbl_id_view);
            this.Controls.Add(this.lbl_id_creat);
            this.Controls.Add(this.checkSelectAll);
            this.Controls.Add(this.checkboxDelete);
            this.Controls.Add(this.checkboxEdit);
            this.Controls.Add(this.checkboxView);
            this.Controls.Add(this.checkboxCreate);
            this.Controls.Add(this.labelModelName);
            this.Name = "ModelRoleCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(250, 250);
            this.Load += new System.EventHandler(this.ModelRoleCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelModelName;
        public System.Windows.Forms.CheckBox checkboxCreate;
        public System.Windows.Forms.CheckBox checkboxEdit;
        public System.Windows.Forms.CheckBox checkboxView;
        public System.Windows.Forms.CheckBox checkboxDelete;
        public System.Windows.Forms.CheckBox checkSelectAll;
        private System.Windows.Forms.Label lbl_id_creat;
        private System.Windows.Forms.Label lbl_id_view;
        private System.Windows.Forms.Label lbl_id_edit;
        private System.Windows.Forms.Label lbl_id_delete;
    }
}
