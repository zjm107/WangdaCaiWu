using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmContractReg
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.dstTCONF_WORD = new Tiger.PdrCommon.DstTCONF_WORD();
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.tW_ContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tW_ContractServiceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(41, 21, 41, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(854, 450, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1684, 1032);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1684, 1032);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractDataSet
            // 
            this.contractDataSet.DataSetName = "ContractDataSet";
            this.contractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tW_ContractBindingSource
            // 
            this.tW_ContractBindingSource.DataMember = "TW_Contract";
            this.tW_ContractBindingSource.DataSource = this.contractDataSet;
            // 
            // tW_ContractServiceInfoBindingSource
            // 
            this.tW_ContractServiceInfoBindingSource.DataMember = "TW_ContractServiceInfo";
            this.tW_ContractServiceInfoBindingSource.DataSource = this.contractDataSet;
            // 
            // FrmContractReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1684, 1032);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(41, 21, 41, 21);
            this.Name = "FrmContractReg";
            this.Text = "新增合同";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private System.Windows.Forms.BindingSource tW_ContractBindingSource;
        private Contract.ContractDataSet contractDataSet;
        private System.Windows.Forms.BindingSource tW_ContractServiceInfoBindingSource;
        private Tiger.PdrCommon.DstTCONF_WORD dstTCONF_WORD;
    }
}