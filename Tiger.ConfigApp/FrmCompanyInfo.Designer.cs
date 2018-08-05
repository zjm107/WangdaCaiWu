namespace Tiger.ConfigApp
{
    /// <summary>
    /// 
    /// </summary>
    partial class FrmCompanyInfo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label phone1Label;
            System.Windows.Forms.Label phone2Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label weblinkLabel;
            System.Windows.Forms.Label addressLabel;
            this.companyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tS_COMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstCOMPANY = new Tiger.ConfigApp.DstCOMPANY();
            this.phone1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phone2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.weblinkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            companyLabel = new System.Windows.Forms.Label();
            phone1Label = new System.Windows.Forms.Label();
            phone2Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            weblinkLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_COMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstCOMPANY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weblinkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.BackColor = System.Drawing.Color.Transparent;
            companyLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            companyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            companyLabel.Location = new System.Drawing.Point(30, 169);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(75, 14);
            companyLabel.TabIndex = 0;
            companyLabel.Text = "公司名称:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.BackColor = System.Drawing.Color.Transparent;
            phone1Label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            phone1Label.ForeColor = System.Drawing.SystemColors.ControlText;
            phone1Label.Location = new System.Drawing.Point(30, 195);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(53, 14);
            phone1Label.TabIndex = 2;
            phone1Label.Text = "电话1:";
            // 
            // phone2Label
            // 
            phone2Label.AutoSize = true;
            phone2Label.BackColor = System.Drawing.Color.Transparent;
            phone2Label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            phone2Label.ForeColor = System.Drawing.SystemColors.ControlText;
            phone2Label.Location = new System.Drawing.Point(30, 221);
            phone2Label.Name = "phone2Label";
            phone2Label.Size = new System.Drawing.Size(53, 14);
            phone2Label.TabIndex = 4;
            phone2Label.Text = "电话2:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.BackColor = System.Drawing.Color.Transparent;
            faxLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            faxLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            faxLabel.Location = new System.Drawing.Point(30, 247);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(45, 14);
            faxLabel.TabIndex = 6;
            faxLabel.Text = "传真:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            emailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            emailLabel.Location = new System.Drawing.Point(30, 273);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 14);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "email:";
            // 
            // weblinkLabel
            // 
            weblinkLabel.AutoSize = true;
            weblinkLabel.BackColor = System.Drawing.Color.Transparent;
            weblinkLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            weblinkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            weblinkLabel.Location = new System.Drawing.Point(30, 299);
            weblinkLabel.Name = "weblinkLabel";
            weblinkLabel.Size = new System.Drawing.Size(45, 14);
            weblinkLabel.TabIndex = 10;
            weblinkLabel.Text = "网址:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            addressLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            addressLabel.Location = new System.Drawing.Point(30, 325);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(45, 14);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "地址:";
            // 
            // companyTextEdit
            // 
            this.companyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "company", true));
            this.companyTextEdit.Location = new System.Drawing.Point(107, 166);
            this.companyTextEdit.Name = "companyTextEdit";
            this.companyTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.companyTextEdit.Size = new System.Drawing.Size(336, 21);
            this.companyTextEdit.TabIndex = 1;
            // 
            // tS_COMPANYBindingSource
            // 
            this.tS_COMPANYBindingSource.DataMember = "TS_COMPANY";
            this.tS_COMPANYBindingSource.DataSource = this.dstCOMPANY;
            // 
            // dstCOMPANY
            // 
            this.dstCOMPANY.DataSetName = "DstCOMPANY";
            this.dstCOMPANY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone1TextEdit
            // 
            this.phone1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "phone1", true));
            this.phone1TextEdit.Location = new System.Drawing.Point(107, 192);
            this.phone1TextEdit.Name = "phone1TextEdit";
            this.phone1TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.phone1TextEdit.Size = new System.Drawing.Size(336, 21);
            this.phone1TextEdit.TabIndex = 3;
            // 
            // phone2TextEdit
            // 
            this.phone2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "phone2", true));
            this.phone2TextEdit.Location = new System.Drawing.Point(107, 218);
            this.phone2TextEdit.Name = "phone2TextEdit";
            this.phone2TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.phone2TextEdit.Size = new System.Drawing.Size(336, 21);
            this.phone2TextEdit.TabIndex = 5;
            // 
            // faxTextEdit
            // 
            this.faxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "fax", true));
            this.faxTextEdit.Location = new System.Drawing.Point(107, 244);
            this.faxTextEdit.Name = "faxTextEdit";
            this.faxTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.faxTextEdit.Size = new System.Drawing.Size(336, 21);
            this.faxTextEdit.TabIndex = 7;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(107, 270);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.emailTextEdit.Size = new System.Drawing.Size(336, 21);
            this.emailTextEdit.TabIndex = 9;
            // 
            // weblinkTextEdit
            // 
            this.weblinkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "weblink", true));
            this.weblinkTextEdit.Location = new System.Drawing.Point(107, 296);
            this.weblinkTextEdit.Name = "weblinkTextEdit";
            this.weblinkTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.weblinkTextEdit.Size = new System.Drawing.Size(336, 21);
            this.weblinkTextEdit.TabIndex = 11;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tS_COMPANYBindingSource, "address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(107, 322);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.addressTextEdit.Size = new System.Drawing.Size(336, 21);
            this.addressTextEdit.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(33, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 28);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(156, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
       
            this.ClientSize = new System.Drawing.Size(599, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextEdit);
            this.Controls.Add(phone1Label);
            this.Controls.Add(this.phone1TextEdit);
            this.Controls.Add(phone2Label);
            this.Controls.Add(this.phone2TextEdit);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(weblinkLabel);
            this.Controls.Add(this.weblinkTextEdit);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公司信息";
            this.Load += new System.EventHandler(this.FrmCompanyInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompanyInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.companyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_COMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstCOMPANY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weblinkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DstCOMPANY dstCOMPANY;
        private System.Windows.Forms.BindingSource tS_COMPANYBindingSource;
        private DevExpress.XtraEditors.TextEdit companyTextEdit;
        private DevExpress.XtraEditors.TextEdit phone1TextEdit;
        private DevExpress.XtraEditors.TextEdit phone2TextEdit;
        private DevExpress.XtraEditors.TextEdit faxTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit weblinkTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}