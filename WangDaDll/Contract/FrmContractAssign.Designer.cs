using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmContractAssign
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
            this.tW_ContractServiceInfoGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_ContractServiceInfoVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSetView = new WangDaDll.Contract.ContractDataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col服务类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务期限月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开始服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col结束服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务项目 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务总时长月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col赠送时长月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.续签CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tW_ContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.tW_PaymentMainGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_PaymentMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsDataSet = new WangDaDll.Common.ProceedsDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col支付总额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付方式 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col备注 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col操作人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col操作时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col缴费月数 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col不收款 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col银行账号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col一次性服务费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col周期性服务费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.注册员ButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.tF_FILEGridControl = new DevExpress.XtraGrid.GridControl();
            this.tF_FILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileDataSet = new WangDaDll.Common.FileDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpload_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ck周期性服务 = new DevExpress.XtraEditors.CheckEdit();
            this.ck一次性服务 = new DevExpress.XtraEditors.CheckEdit();
            this.服务项目ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务项目ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.备注MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.服务类别ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务分类ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务类型ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务金额TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.服务类别ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务分类ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务类型ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.服务金额TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.服务期限月TextBox = new System.Windows.Forms.TextBox();
            this.开始服务月DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.结束服务月DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.赠送时长月TextBox = new System.Windows.Forms.TextBox();
            this.服务总时长月TextBox = new System.Windows.Forms.TextBox();
            this.客户名称ButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.合同编号TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.工本费TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.开票费TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.定金金额TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.合同金额CalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.签约日期DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.做账会计ButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnView附件 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.周期性服务Group = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.一次性服务Group = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.tW_ContractServiceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstTCONF_WORD = new Tiger.PdrCommon.DstTCONF_WORD();
            this.起始月dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.续签CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentMainGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.注册员ButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck周期性服务.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck一次性服务.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务项目ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务项目ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类别ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务分类ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类型ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务金额TextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类别ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务分类ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类型ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务金额TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.开始服务月DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.开始服务月DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束服务月DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束服务月DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称ButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工本费TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.开票费TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.定金金额TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同金额CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计ButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.周期性服务Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.一次性服务Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.起始月dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.起始月dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tW_ContractServiceInfoGridControl);
            this.layoutControl1.Controls.Add(this.续签CheckEdit);
            this.layoutControl1.Controls.Add(this.tW_PaymentMainGridControl);
            this.layoutControl1.Controls.Add(this.注册员ButtonEdit);
            this.layoutControl1.Controls.Add(this.tF_FILEGridControl);
            this.layoutControl1.Controls.Add(this.ck周期性服务);
            this.layoutControl1.Controls.Add(this.ck一次性服务);
            this.layoutControl1.Controls.Add(this.服务项目ComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.服务项目ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.备注MemoEdit);
            this.layoutControl1.Controls.Add(this.服务类别ComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.服务分类ComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.服务类型ComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.服务金额TextEdit1);
            this.layoutControl1.Controls.Add(this.服务类别ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.服务分类ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.服务类型ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.服务金额TextEdit);
            this.layoutControl1.Controls.Add(this.服务期限月TextBox);
            this.layoutControl1.Controls.Add(this.开始服务月DateEdit);
            this.layoutControl1.Controls.Add(this.结束服务月DateEdit);
            this.layoutControl1.Controls.Add(this.赠送时长月TextBox);
            this.layoutControl1.Controls.Add(this.服务总时长月TextBox);
            this.layoutControl1.Controls.Add(this.客户名称ButtonEdit);
            this.layoutControl1.Controls.Add(this.合同编号TextEdit);
            this.layoutControl1.Controls.Add(this.工本费TextEdit);
            this.layoutControl1.Controls.Add(this.开票费TextEdit);
            this.layoutControl1.Controls.Add(this.定金金额TextEdit);
            this.layoutControl1.Controls.Add(this.合同金额CalcEdit);
            this.layoutControl1.Controls.Add(this.签约日期DateEdit);
            this.layoutControl1.Controls.Add(this.做账会计ButtonEdit);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnView附件);
            this.layoutControl1.Controls.Add(this.起始月dateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(854, 450, 599, 555);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1493, 949);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tW_ContractServiceInfoGridControl
            // 
            this.tW_ContractServiceInfoGridControl.DataSource = this.tW_ContractServiceInfoVBindingSource;
            this.tW_ContractServiceInfoGridControl.Location = new System.Drawing.Point(24, 558);
            this.tW_ContractServiceInfoGridControl.MainView = this.gridView3;
            this.tW_ContractServiceInfoGridControl.Name = "tW_ContractServiceInfoGridControl";
            this.tW_ContractServiceInfoGridControl.Size = new System.Drawing.Size(1445, 328);
            this.tW_ContractServiceInfoGridControl.TabIndex = 64;
            this.tW_ContractServiceInfoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // tW_ContractServiceInfoVBindingSource
            // 
            this.tW_ContractServiceInfoVBindingSource.DataMember = "TW_ContractServiceInfo";
            this.tW_ContractServiceInfoVBindingSource.DataSource = this.contractDataSetView;
            // 
            // contractDataSetView
            // 
            this.contractDataSetView.DataSetName = "ContractDataSet";
            this.contractDataSetView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.Empty.Options.UseFont = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView3.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView3.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView3.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView3.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView3.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col服务类别,
            this.col服务金额,
            this.col服务期限月,
            this.col开始服务月,
            this.col结束服务月,
            this.col服务项目,
            this.col服务总时长月,
            this.col赠送时长月});
            this.gridView3.GridControl = this.tW_ContractServiceInfoGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.PaintStyleName = "Style3D";
            // 
            // col服务类别
            // 
            this.col服务类别.FieldName = "服务类别";
            this.col服务类别.MinWidth = 30;
            this.col服务类别.Name = "col服务类别";
            this.col服务类别.Visible = true;
            this.col服务类别.VisibleIndex = 0;
            this.col服务类别.Width = 120;
            // 
            // col服务金额
            // 
            this.col服务金额.FieldName = "服务金额";
            this.col服务金额.MinWidth = 30;
            this.col服务金额.Name = "col服务金额";
            this.col服务金额.Visible = true;
            this.col服务金额.VisibleIndex = 2;
            this.col服务金额.Width = 120;
            // 
            // col服务期限月
            // 
            this.col服务期限月.Caption = "服务期限(月)";
            this.col服务期限月.FieldName = "服务期限月";
            this.col服务期限月.MinWidth = 30;
            this.col服务期限月.Name = "col服务期限月";
            this.col服务期限月.Visible = true;
            this.col服务期限月.VisibleIndex = 3;
            this.col服务期限月.Width = 158;
            // 
            // col开始服务月
            // 
            this.col开始服务月.FieldName = "开始服务月";
            this.col开始服务月.MinWidth = 30;
            this.col开始服务月.Name = "col开始服务月";
            this.col开始服务月.Visible = true;
            this.col开始服务月.VisibleIndex = 4;
            this.col开始服务月.Width = 142;
            // 
            // col结束服务月
            // 
            this.col结束服务月.FieldName = "结束服务月";
            this.col结束服务月.MinWidth = 30;
            this.col结束服务月.Name = "col结束服务月";
            this.col结束服务月.Visible = true;
            this.col结束服务月.VisibleIndex = 5;
            this.col结束服务月.Width = 142;
            // 
            // col服务项目
            // 
            this.col服务项目.FieldName = "服务项目";
            this.col服务项目.MinWidth = 30;
            this.col服务项目.Name = "col服务项目";
            this.col服务项目.Visible = true;
            this.col服务项目.VisibleIndex = 1;
            this.col服务项目.Width = 120;
            // 
            // col服务总时长月
            // 
            this.col服务总时长月.Caption = "服务总时长(月)";
            this.col服务总时长月.FieldName = "服务总时长月";
            this.col服务总时长月.MinWidth = 30;
            this.col服务总时长月.Name = "col服务总时长月";
            this.col服务总时长月.Visible = true;
            this.col服务总时长月.VisibleIndex = 7;
            this.col服务总时长月.Width = 180;
            // 
            // col赠送时长月
            // 
            this.col赠送时长月.FieldName = "赠送时长月";
            this.col赠送时长月.MinWidth = 30;
            this.col赠送时长月.Name = "col赠送时长月";
            this.col赠送时长月.Visible = true;
            this.col赠送时长月.VisibleIndex = 6;
            this.col赠送时长月.Width = 142;
            // 
            // 续签CheckEdit
            // 
            this.续签CheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "续签", true));
            this.续签CheckEdit.Location = new System.Drawing.Point(703, 16);
            this.续签CheckEdit.Name = "续签CheckEdit";
            this.续签CheckEdit.Properties.Caption = "续签";
            this.续签CheckEdit.Properties.ReadOnly = true;
            this.续签CheckEdit.Size = new System.Drawing.Size(385, 27);
            this.续签CheckEdit.StyleController = this.layoutControl1;
            this.续签CheckEdit.TabIndex = 63;
            // 
            // tW_ContractBindingSource
            // 
            this.tW_ContractBindingSource.DataMember = "TW_Contract";
            this.tW_ContractBindingSource.DataSource = this.contractDataSet;
            // 
            // contractDataSet
            // 
            this.contractDataSet.DataSetName = "ContractDataSet";
            this.contractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tW_PaymentMainGridControl
            // 
            this.tW_PaymentMainGridControl.DataSource = this.tW_PaymentMainBindingSource;
            this.tW_PaymentMainGridControl.Location = new System.Drawing.Point(24, 558);
            this.tW_PaymentMainGridControl.MainView = this.gridView2;
            this.tW_PaymentMainGridControl.Name = "tW_PaymentMainGridControl";
            this.tW_PaymentMainGridControl.Size = new System.Drawing.Size(1445, 328);
            this.tW_PaymentMainGridControl.TabIndex = 62;
            this.tW_PaymentMainGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tW_PaymentMainBindingSource
            // 
            this.tW_PaymentMainBindingSource.DataMember = "TW_PaymentMain";
            this.tW_PaymentMainBindingSource.DataSource = this.proceedsDataSet;
            // 
            // proceedsDataSet
            // 
            this.proceedsDataSet.DataSetName = "ProceedsDataSet";
            this.proceedsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.Empty.Options.UseFont = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col支付总额,
            this.col支付日期,
            this.col支付方式,
            this.col收款人,
            this.col收款类别,
            this.col备注,
            this.col操作人,
            this.col操作时间,
            this.col工本费,
            this.col开票费,
            this.col做账会计,
            this.col注册员,
            this.col月做账费,
            this.col缴费月数,
            this.col不收款,
            this.col银行账号,
            this.col零申报,
            this.col一次性服务费,
            this.col周期性服务费});
            this.gridView2.GridControl = this.tW_PaymentMainGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.PaintStyleName = "Style3D";
            // 
            // col支付总额
            // 
            this.col支付总额.FieldName = "支付总额";
            this.col支付总额.MinWidth = 30;
            this.col支付总额.Name = "col支付总额";
            this.col支付总额.OptionsColumn.ReadOnly = true;
            this.col支付总额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "支付总额", "{0:0.##}")});
            this.col支付总额.Visible = true;
            this.col支付总额.VisibleIndex = 1;
            this.col支付总额.Width = 112;
            // 
            // col支付日期
            // 
            this.col支付日期.FieldName = "支付日期";
            this.col支付日期.MinWidth = 30;
            this.col支付日期.Name = "col支付日期";
            this.col支付日期.OptionsColumn.ReadOnly = true;
            this.col支付日期.Visible = true;
            this.col支付日期.VisibleIndex = 0;
            this.col支付日期.Width = 112;
            // 
            // col支付方式
            // 
            this.col支付方式.FieldName = "支付方式";
            this.col支付方式.MinWidth = 30;
            this.col支付方式.Name = "col支付方式";
            this.col支付方式.OptionsColumn.ReadOnly = true;
            this.col支付方式.Visible = true;
            this.col支付方式.VisibleIndex = 4;
            this.col支付方式.Width = 112;
            // 
            // col收款人
            // 
            this.col收款人.FieldName = "收款人";
            this.col收款人.MinWidth = 30;
            this.col收款人.Name = "col收款人";
            this.col收款人.OptionsColumn.ReadOnly = true;
            this.col收款人.Visible = true;
            this.col收款人.VisibleIndex = 5;
            this.col收款人.Width = 112;
            // 
            // col收款类别
            // 
            this.col收款类别.FieldName = "收款类别";
            this.col收款类别.MinWidth = 30;
            this.col收款类别.Name = "col收款类别";
            this.col收款类别.OptionsColumn.ReadOnly = true;
            this.col收款类别.Width = 112;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.MinWidth = 30;
            this.col备注.Name = "col备注";
            this.col备注.OptionsColumn.ReadOnly = true;
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 15;
            this.col备注.Width = 112;
            // 
            // col操作人
            // 
            this.col操作人.FieldName = "操作人";
            this.col操作人.MinWidth = 30;
            this.col操作人.Name = "col操作人";
            this.col操作人.OptionsColumn.ReadOnly = true;
            this.col操作人.Visible = true;
            this.col操作人.VisibleIndex = 16;
            this.col操作人.Width = 112;
            // 
            // col操作时间
            // 
            this.col操作时间.FieldName = "操作时间";
            this.col操作时间.MinWidth = 30;
            this.col操作时间.Name = "col操作时间";
            this.col操作时间.OptionsColumn.ReadOnly = true;
            this.col操作时间.Visible = true;
            this.col操作时间.VisibleIndex = 17;
            this.col操作时间.Width = 112;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.MinWidth = 30;
            this.col工本费.Name = "col工本费";
            this.col工本费.OptionsColumn.ReadOnly = true;
            this.col工本费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", "{0:0.##}")});
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 6;
            this.col工本费.Width = 112;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.MinWidth = 30;
            this.col开票费.Name = "col开票费";
            this.col开票费.OptionsColumn.ReadOnly = true;
            this.col开票费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", "{0:0.##}")});
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 7;
            this.col开票费.Width = 112;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.MinWidth = 30;
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 8;
            this.col做账会计.Width = 112;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.MinWidth = 30;
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 9;
            this.col注册员.Width = 112;
            // 
            // col月做账费
            // 
            this.col月做账费.FieldName = "月做账费";
            this.col月做账费.MinWidth = 30;
            this.col月做账费.Name = "col月做账费";
            this.col月做账费.OptionsColumn.ReadOnly = true;
            this.col月做账费.Visible = true;
            this.col月做账费.VisibleIndex = 10;
            this.col月做账费.Width = 112;
            // 
            // col缴费月数
            // 
            this.col缴费月数.FieldName = "缴费月数";
            this.col缴费月数.MinWidth = 30;
            this.col缴费月数.Name = "col缴费月数";
            this.col缴费月数.OptionsColumn.ReadOnly = true;
            this.col缴费月数.Visible = true;
            this.col缴费月数.VisibleIndex = 11;
            this.col缴费月数.Width = 112;
            // 
            // col不收款
            // 
            this.col不收款.FieldName = "不收款";
            this.col不收款.MinWidth = 30;
            this.col不收款.Name = "col不收款";
            this.col不收款.OptionsColumn.ReadOnly = true;
            this.col不收款.Visible = true;
            this.col不收款.VisibleIndex = 13;
            this.col不收款.Width = 112;
            // 
            // col银行账号
            // 
            this.col银行账号.FieldName = "银行账号";
            this.col银行账号.MinWidth = 30;
            this.col银行账号.Name = "col银行账号";
            this.col银行账号.OptionsColumn.ReadOnly = true;
            this.col银行账号.Visible = true;
            this.col银行账号.VisibleIndex = 12;
            this.col银行账号.Width = 112;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.MinWidth = 30;
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 14;
            this.col零申报.Width = 112;
            // 
            // col一次性服务费
            // 
            this.col一次性服务费.FieldName = "一次性服务费";
            this.col一次性服务费.MinWidth = 30;
            this.col一次性服务费.Name = "col一次性服务费";
            this.col一次性服务费.OptionsColumn.ReadOnly = true;
            this.col一次性服务费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "一次性服务费", "{0:0.##}")});
            this.col一次性服务费.Visible = true;
            this.col一次性服务费.VisibleIndex = 3;
            this.col一次性服务费.Width = 152;
            // 
            // col周期性服务费
            // 
            this.col周期性服务费.FieldName = "周期性服务费";
            this.col周期性服务费.MinWidth = 30;
            this.col周期性服务费.Name = "col周期性服务费";
            this.col周期性服务费.OptionsColumn.ReadOnly = true;
            this.col周期性服务费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "周期性服务费", "{0:0.##}")});
            this.col周期性服务费.Visible = true;
            this.col周期性服务费.VisibleIndex = 2;
            this.col周期性服务费.Width = 152;
            // 
            // 注册员ButtonEdit
            // 
            this.注册员ButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "注册员", true));
            this.注册员ButtonEdit.Location = new System.Drawing.Point(510, 454);
            this.注册员ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.注册员ButtonEdit.Name = "注册员ButtonEdit";
            this.注册员ButtonEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.注册员ButtonEdit.Properties.Appearance.Options.UseFont = true;
            this.注册员ButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.注册员ButtonEdit.Properties.ReadOnly = true;
            this.注册员ButtonEdit.Size = new System.Drawing.Size(233, 32);
            this.注册员ButtonEdit.StyleController = this.layoutControl1;
            this.注册员ButtonEdit.TabIndex = 62;
            this.注册员ButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.注册员ButtonEdit_ButtonClick);
            // 
            // tF_FILEGridControl
            // 
            this.tF_FILEGridControl.DataSource = this.tF_FILEBindingSource;
            this.tF_FILEGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.tF_FILEGridControl.Location = new System.Drawing.Point(24, 594);
            this.tF_FILEGridControl.MainView = this.gridView1;
            this.tF_FILEGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.tF_FILEGridControl.Name = "tF_FILEGridControl";
            this.tF_FILEGridControl.Size = new System.Drawing.Size(1445, 292);
            this.tF_FILEGridControl.TabIndex = 58;
            this.tF_FILEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tF_FILEBindingSource
            // 
            this.tF_FILEBindingSource.DataMember = "TF_FILE";
            this.tF_FILEBindingSource.DataSource = this.fileDataSet;
            // 
            // fileDataSet
            // 
            this.fileDataSet.DataSetName = "FileDataSet";
            this.fileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileName,
            this.colUploader,
            this.colUpload_Date,
            this.colFileType});
            this.gridView1.DetailHeight = 525;
            this.gridView1.GridControl = this.tF_FILEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.MinWidth = 30;
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 445;
            // 
            // colUploader
            // 
            this.colUploader.FieldName = "Uploader";
            this.colUploader.MinWidth = 30;
            this.colUploader.Name = "colUploader";
            this.colUploader.OptionsColumn.ReadOnly = true;
            this.colUploader.Visible = true;
            this.colUploader.VisibleIndex = 1;
            this.colUploader.Width = 168;
            // 
            // colUpload_Date
            // 
            this.colUpload_Date.FieldName = "Upload_Date";
            this.colUpload_Date.MinWidth = 30;
            this.colUpload_Date.Name = "colUpload_Date";
            this.colUpload_Date.OptionsColumn.ReadOnly = true;
            this.colUpload_Date.Visible = true;
            this.colUpload_Date.VisibleIndex = 2;
            this.colUpload_Date.Width = 192;
            // 
            // colFileType
            // 
            this.colFileType.FieldName = "FileType";
            this.colFileType.MinWidth = 30;
            this.colFileType.Name = "colFileType";
            this.colFileType.OptionsColumn.ReadOnly = true;
            this.colFileType.Width = 130;
            // 
            // ck周期性服务
            // 
            this.ck周期性服务.Location = new System.Drawing.Point(12, 172);
            this.ck周期性服务.Margin = new System.Windows.Forms.Padding(4);
            this.ck周期性服务.Name = "ck周期性服务";
            this.ck周期性服务.Properties.Caption = "周期性服务";
            this.ck周期性服务.Properties.ReadOnly = true;
            this.ck周期性服务.Size = new System.Drawing.Size(1469, 27);
            this.ck周期性服务.StyleController = this.layoutControl1;
            this.ck周期性服务.TabIndex = 52;
            
            // 
            // ck一次性服务
            // 
            this.ck一次性服务.Location = new System.Drawing.Point(12, 367);
            this.ck一次性服务.Margin = new System.Windows.Forms.Padding(4);
            this.ck一次性服务.Name = "ck一次性服务";
            this.ck一次性服务.Properties.Caption = "一次性服务";
            this.ck一次性服务.Properties.ReadOnly = true;
            this.ck一次性服务.Size = new System.Drawing.Size(1469, 27);
            this.ck一次性服务.StyleController = this.layoutControl1;
            this.ck一次性服务.TabIndex = 51;
            
            // 
            // 服务项目ComboBoxEdit1
            // 
            this.服务项目ComboBoxEdit1.Location = new System.Drawing.Point(1242, 414);
            this.服务项目ComboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.服务项目ComboBoxEdit1.Name = "服务项目ComboBoxEdit1";
            this.服务项目ComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务项目ComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.服务项目ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务项目ComboBoxEdit1.Properties.ReadOnly = true;
            this.服务项目ComboBoxEdit1.Size = new System.Drawing.Size(226, 32);
            this.服务项目ComboBoxEdit1.StyleController = this.layoutControl1;
            this.服务项目ComboBoxEdit1.TabIndex = 50;
            // 
            // 服务项目ComboBoxEdit
            // 
            this.服务项目ComboBoxEdit.Location = new System.Drawing.Point(1249, 219);
            this.服务项目ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.服务项目ComboBoxEdit.Name = "服务项目ComboBoxEdit";
            this.服务项目ComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务项目ComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.服务项目ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务项目ComboBoxEdit.Properties.ReadOnly = true;
            this.服务项目ComboBoxEdit.Size = new System.Drawing.Size(219, 32);
            this.服务项目ComboBoxEdit.StyleController = this.layoutControl1;
            this.服务项目ComboBoxEdit.TabIndex = 49;
            // 
            // 备注MemoEdit
            // 
            this.备注MemoEdit.Location = new System.Drawing.Point(25, 562);
            this.备注MemoEdit.Margin = new System.Windows.Forms.Padding(4);
            this.备注MemoEdit.Name = "备注MemoEdit";
            this.备注MemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.备注MemoEdit.Properties.Appearance.Options.UseFont = true;
            this.备注MemoEdit.Size = new System.Drawing.Size(1443, 320);
            this.备注MemoEdit.StyleController = this.layoutControl1;
            this.备注MemoEdit.TabIndex = 48;
            // 
            // 服务类别ComboBoxEdit1
            // 
            this.服务类别ComboBoxEdit1.Location = new System.Drawing.Point(151, 414);
            this.服务类别ComboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.服务类别ComboBoxEdit1.Name = "服务类别ComboBoxEdit1";
            this.服务类别ComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务类别ComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.服务类别ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务类别ComboBoxEdit1.Properties.ReadOnly = true;
            this.服务类别ComboBoxEdit1.Size = new System.Drawing.Size(228, 32);
            this.服务类别ComboBoxEdit1.StyleController = this.layoutControl1;
            this.服务类别ComboBoxEdit1.TabIndex = 41;
            // 
            // 服务分类ComboBoxEdit1
            // 
            this.服务分类ComboBoxEdit1.Location = new System.Drawing.Point(511, 414);
            this.服务分类ComboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.服务分类ComboBoxEdit1.Name = "服务分类ComboBoxEdit1";
            this.服务分类ComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务分类ComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.服务分类ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务分类ComboBoxEdit1.Properties.ReadOnly = true;
            this.服务分类ComboBoxEdit1.Size = new System.Drawing.Size(231, 32);
            this.服务分类ComboBoxEdit1.StyleController = this.layoutControl1;
            this.服务分类ComboBoxEdit1.TabIndex = 43;
            // 
            // 服务类型ComboBoxEdit1
            // 
            this.服务类型ComboBoxEdit1.Location = new System.Drawing.Point(874, 414);
            this.服务类型ComboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.服务类型ComboBoxEdit1.Name = "服务类型ComboBoxEdit1";
            this.服务类型ComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务类型ComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.服务类型ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务类型ComboBoxEdit1.Properties.ReadOnly = true;
            this.服务类型ComboBoxEdit1.Size = new System.Drawing.Size(236, 32);
            this.服务类型ComboBoxEdit1.StyleController = this.layoutControl1;
            this.服务类型ComboBoxEdit1.TabIndex = 45;
            // 
            // 服务金额TextEdit1
            // 
            this.服务金额TextEdit1.Location = new System.Drawing.Point(151, 458);
            this.服务金额TextEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.服务金额TextEdit1.Name = "服务金额TextEdit1";
            this.服务金额TextEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.服务金额TextEdit1.Properties.Appearance.Options.UseFont = true;
            this.服务金额TextEdit1.Properties.ReadOnly = true;
            this.服务金额TextEdit1.Size = new System.Drawing.Size(228, 32);
            this.服务金额TextEdit1.StyleController = this.layoutControl1;
            this.服务金额TextEdit1.TabIndex = 47;
            
            // 
            // 服务类别ComboBoxEdit
            // 
            this.服务类别ComboBoxEdit.Location = new System.Drawing.Point(151, 219);
            this.服务类别ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.服务类别ComboBoxEdit.Name = "服务类别ComboBoxEdit";
            this.服务类别ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务类别ComboBoxEdit.Properties.ReadOnly = true;
            this.服务类别ComboBoxEdit.Size = new System.Drawing.Size(252, 28);
            this.服务类别ComboBoxEdit.StyleController = this.layoutControl1;
            this.服务类别ComboBoxEdit.TabIndex = 24;
            // 
            // 服务分类ComboBoxEdit
            // 
            this.服务分类ComboBoxEdit.Location = new System.Drawing.Point(535, 219);
            this.服务分类ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.服务分类ComboBoxEdit.Name = "服务分类ComboBoxEdit";
            this.服务分类ComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务分类ComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.服务分类ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务分类ComboBoxEdit.Properties.ReadOnly = true;
            this.服务分类ComboBoxEdit.Size = new System.Drawing.Size(222, 32);
            this.服务分类ComboBoxEdit.StyleController = this.layoutControl1;
            this.服务分类ComboBoxEdit.TabIndex = 26;
            // 
            // 服务类型ComboBoxEdit
            // 
            this.服务类型ComboBoxEdit.Location = new System.Drawing.Point(889, 219);
            this.服务类型ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.服务类型ComboBoxEdit.Name = "服务类型ComboBoxEdit";
            this.服务类型ComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.服务类型ComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.服务类型ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.服务类型ComboBoxEdit.Properties.ReadOnly = true;
            this.服务类型ComboBoxEdit.Size = new System.Drawing.Size(228, 32);
            this.服务类型ComboBoxEdit.StyleController = this.layoutControl1;
            this.服务类型ComboBoxEdit.TabIndex = 28;
            // 
            // 服务金额TextEdit
            // 
            this.服务金额TextEdit.Location = new System.Drawing.Point(151, 263);
            this.服务金额TextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.服务金额TextEdit.Name = "服务金额TextEdit";
            this.服务金额TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.服务金额TextEdit.Properties.Appearance.Options.UseFont = true;
            this.服务金额TextEdit.Properties.ReadOnly = true;
            this.服务金额TextEdit.Size = new System.Drawing.Size(252, 32);
            this.服务金额TextEdit.StyleController = this.layoutControl1;
            this.服务金额TextEdit.TabIndex = 30;
            
            // 
            // 服务期限月TextBox
            // 
            this.服务期限月TextBox.Location = new System.Drawing.Point(535, 263);
            this.服务期限月TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.服务期限月TextBox.Name = "服务期限月TextBox";
            this.服务期限月TextBox.ReadOnly = true;
            this.服务期限月TextBox.Size = new System.Drawing.Size(138, 36);
            this.服务期限月TextBox.TabIndex = 32;
            
            // 
            // 开始服务月DateEdit
            // 
            this.开始服务月DateEdit.EditValue = null;
            this.开始服务月DateEdit.Location = new System.Drawing.Point(151, 311);
            this.开始服务月DateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.开始服务月DateEdit.Name = "开始服务月DateEdit";
            this.开始服务月DateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.开始服务月DateEdit.Properties.Appearance.Options.UseFont = true;
            this.开始服务月DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.开始服务月DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.开始服务月DateEdit.Properties.ReadOnly = true;
            this.开始服务月DateEdit.Size = new System.Drawing.Size(252, 32);
            this.开始服务月DateEdit.StyleController = this.layoutControl1;
            this.开始服务月DateEdit.TabIndex = 34;
            
            // 
            // 结束服务月DateEdit
            // 
            this.结束服务月DateEdit.EditValue = null;
            this.结束服务月DateEdit.Location = new System.Drawing.Point(535, 311);
            this.结束服务月DateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.结束服务月DateEdit.Name = "结束服务月DateEdit";
            this.结束服务月DateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.结束服务月DateEdit.Properties.Appearance.Options.UseFont = true;
            this.结束服务月DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.结束服务月DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.结束服务月DateEdit.Properties.ReadOnly = true;
            this.结束服务月DateEdit.Size = new System.Drawing.Size(252, 32);
            this.结束服务月DateEdit.StyleController = this.layoutControl1;
            this.结束服务月DateEdit.TabIndex = 36;
            // 
            // 赠送时长月TextBox
            // 
            this.赠送时长月TextBox.Location = new System.Drawing.Point(805, 263);
            this.赠送时长月TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.赠送时长月TextBox.Name = "赠送时长月TextBox";
            this.赠送时长月TextBox.ReadOnly = true;
            this.赠送时长月TextBox.Size = new System.Drawing.Size(138, 36);
            this.赠送时长月TextBox.TabIndex = 38;
          
            // 
            // 服务总时长月TextBox
            // 
            this.服务总时长月TextBox.Location = new System.Drawing.Point(1075, 263);
            this.服务总时长月TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.服务总时长月TextBox.Name = "服务总时长月TextBox";
            this.服务总时长月TextBox.ReadOnly = true;
            this.服务总时长月TextBox.Size = new System.Drawing.Size(138, 36);
            this.服务总时长月TextBox.TabIndex = 40;
            // 
            // 客户名称ButtonEdit
            // 
            this.客户名称ButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "客户名称", true));
            this.客户名称ButtonEdit.Location = new System.Drawing.Point(139, 60);
            this.客户名称ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.客户名称ButtonEdit.Name = "客户名称ButtonEdit";
            this.客户名称ButtonEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.客户名称ButtonEdit.Properties.Appearance.Options.UseFont = true;
            this.客户名称ButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.客户名称ButtonEdit.Properties.ReadOnly = true;
            
            this.客户名称ButtonEdit.Size = new System.Drawing.Size(1243, 32);
            this.客户名称ButtonEdit.StyleController = this.layoutControl1;
            this.客户名称ButtonEdit.TabIndex = 5;
            // 
            // 合同编号TextEdit
            // 
            this.合同编号TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "合同编号", true));
            this.合同编号TextEdit.Location = new System.Drawing.Point(139, 16);
            this.合同编号TextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.合同编号TextEdit.Name = "合同编号TextEdit";
            this.合同编号TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.合同编号TextEdit.Properties.Appearance.Options.UseFont = true;
            this.合同编号TextEdit.Properties.ReadOnly = true;
            this.合同编号TextEdit.Size = new System.Drawing.Size(234, 32);
            this.合同编号TextEdit.StyleController = this.layoutControl1;
            this.合同编号TextEdit.TabIndex = 7;
            // 
            // 工本费TextEdit
            // 
            this.工本费TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "工本费", true));
            this.工本费TextEdit.Location = new System.Drawing.Point(829, 108);
            this.工本费TextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.工本费TextEdit.Name = "工本费TextEdit";
            this.工本费TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.工本费TextEdit.Properties.Appearance.Options.UseFont = true;
            this.工本费TextEdit.Properties.ReadOnly = true;
            this.工本费TextEdit.Size = new System.Drawing.Size(187, 32);
            this.工本费TextEdit.StyleController = this.layoutControl1;
            this.工本费TextEdit.TabIndex = 9;
            
            // 
            // 开票费TextEdit
            // 
            this.开票费TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "开票费", true));
            this.开票费TextEdit.Location = new System.Drawing.Point(1148, 108);
            this.开票费TextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.开票费TextEdit.Name = "开票费TextEdit";
            this.开票费TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.开票费TextEdit.Properties.Appearance.Options.UseFont = true;
            this.开票费TextEdit.Properties.ReadOnly = true;
            this.开票费TextEdit.Size = new System.Drawing.Size(215, 32);
            this.开票费TextEdit.StyleController = this.layoutControl1;
            this.开票费TextEdit.TabIndex = 11;
            
            // 
            // 定金金额TextEdit
            // 
            this.定金金额TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "定金金额", true));
            this.定金金额TextEdit.Location = new System.Drawing.Point(505, 108);
            this.定金金额TextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.定金金额TextEdit.Name = "定金金额TextEdit";
            this.定金金额TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.定金金额TextEdit.Properties.Appearance.Options.UseFont = true;
            this.定金金额TextEdit.Properties.ReadOnly = true;
            this.定金金额TextEdit.Size = new System.Drawing.Size(192, 32);
            this.定金金额TextEdit.StyleController = this.layoutControl1;
            this.定金金额TextEdit.TabIndex = 13;
            // 
            // 合同金额CalcEdit
            // 
            this.合同金额CalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "合同金额", true));
            this.合同金额CalcEdit.Location = new System.Drawing.Point(139, 108);
            this.合同金额CalcEdit.Margin = new System.Windows.Forms.Padding(4);
            this.合同金额CalcEdit.Name = "合同金额CalcEdit";
            this.合同金额CalcEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.合同金额CalcEdit.Properties.Appearance.Options.UseFont = true;
            this.合同金额CalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.合同金额CalcEdit.Properties.ReadOnly = true;
            this.合同金额CalcEdit.Size = new System.Drawing.Size(234, 32);
            this.合同金额CalcEdit.StyleController = this.layoutControl1;
            this.合同金额CalcEdit.TabIndex = 15;
            // 
            // 签约日期DateEdit
            // 
            this.签约日期DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "签约日期", true));
            this.签约日期DateEdit.EditValue = null;
            this.签约日期DateEdit.Location = new System.Drawing.Point(505, 16);
            this.签约日期DateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.签约日期DateEdit.Name = "签约日期DateEdit";
            this.签约日期DateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.签约日期DateEdit.Properties.Appearance.Options.UseFont = true;
            this.签约日期DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit.Properties.ReadOnly = true;
            this.签约日期DateEdit.Size = new System.Drawing.Size(192, 32);
            this.签约日期DateEdit.StyleController = this.layoutControl1;
            this.签约日期DateEdit.TabIndex = 19;
            // 
            // 做账会计ButtonEdit
            // 
            this.做账会计ButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_ContractBindingSource, "做账会计", true));
            this.做账会计ButtonEdit.Location = new System.Drawing.Point(919, 311);
            this.做账会计ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.做账会计ButtonEdit.Name = "做账会计ButtonEdit";
            this.做账会计ButtonEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.做账会计ButtonEdit.Properties.Appearance.Options.UseFont = true;
            this.做账会计ButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.做账会计ButtonEdit.Properties.ReadOnly = true;
            this.做账会计ButtonEdit.Size = new System.Drawing.Size(208, 32);
            this.做账会计ButtonEdit.StyleController = this.layoutControl1;
            this.做账会计ButtonEdit.TabIndex = 23;
            this.做账会计ButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.做账会计ButtonEdit_ButtonClick);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(237, 902);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 35);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(492, 902);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 35);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "取消";
            // 
            // btnView附件
            // 
            this.btnView附件.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnView附件.Appearance.Options.UseFont = true;
            this.btnView附件.Location = new System.Drawing.Point(24, 558);
            this.btnView附件.Margin = new System.Windows.Forms.Padding(4);
            this.btnView附件.Name = "btnView附件";
            this.btnView附件.Size = new System.Drawing.Size(104, 32);
            this.btnView附件.StyleController = this.layoutControl1;
            this.btnView附件.TabIndex = 61;
            this.btnView附件.Text = "查看";
            this.btnView附件.Click += new System.EventHandler(this.btnView附件_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem12,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.周期性服务Group,
            this.一次性服务Group,
            this.layoutControlItem16,
            this.layoutControlItem27,
            this.layoutControlItem1,
            this.itemSave,
            this.layoutControlItem30,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem8,
            this.tabbedControlGroup1,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.emptySpaceItem11,
            this.emptySpaceItem12,
            this.layoutControlItem33});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1493, 949);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.客户名称ButtonEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(1375, 48);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(1375, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem2.Size = new System.Drawing.Size(1375, 48);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "客户名称:";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.合同金额CalcEdit;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem12.Size = new System.Drawing.Size(366, 44);
            this.layoutControlItem12.Text = "合同金额:";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.合同编号TextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem4.Size = new System.Drawing.Size(366, 44);
            this.layoutControlItem4.Text = "合同编号:";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.定金金额TextEdit;
            this.layoutControlItem10.Location = new System.Drawing.Point(366, 92);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem10.Size = new System.Drawing.Size(324, 44);
            this.layoutControlItem10.Text = "定金金额:";
            // 
            // 周期性服务Group
            // 
            this.周期性服务Group.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.layoutControlItem15,
            this.layoutControlItem17,
            this.emptySpaceItem6,
            this.layoutControlItem19,
            this.layoutControlItem26,
            this.layoutControlItem28,
            this.layoutControlItem22,
            this.layoutControlItem24,
            this.layoutControlItem20,
            this.layoutControlItem32,
            this.emptySpaceItem7});
            this.周期性服务Group.Location = new System.Drawing.Point(0, 191);
            this.周期性服务Group.Name = "周期性服务Group";
            this.周期性服务Group.Size = new System.Drawing.Size(1473, 164);
            this.周期性服务Group.Text = "周期性服务";
            this.周期性服务Group.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.服务类别ComboBoxEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(384, 44);
            this.layoutControlItem3.Text = "服务类别:";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.服务分类ComboBoxEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(384, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem7.Size = new System.Drawing.Size(354, 44);
            this.layoutControlItem7.Text = "服务分类:";
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.服务类型ComboBoxEdit;
            this.layoutControlItem11.Location = new System.Drawing.Point(738, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem11.Size = new System.Drawing.Size(360, 44);
            this.layoutControlItem11.Text = "服务类型:";
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.服务金额TextEdit;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem15.Size = new System.Drawing.Size(384, 48);
            this.layoutControlItem15.Text = "月服务金额:";
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.服务项目ComboBoxEdit;
            this.layoutControlItem17.Location = new System.Drawing.Point(1098, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem17.Size = new System.Drawing.Size(351, 44);
            this.layoutControlItem17.Text = "服务项目:";
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.Location = new System.Drawing.Point(1194, 44);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(255, 48);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.Location = new System.Drawing.Point(1438, 92);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(11, 48);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.服务期限月TextBox;
            this.layoutControlItem19.Location = new System.Drawing.Point(384, 44);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem19.Size = new System.Drawing.Size(270, 48);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "服务期限月:";
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.赠送时长月TextBox;
            this.layoutControlItem26.Location = new System.Drawing.Point(654, 44);
            this.layoutControlItem26.MaxSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem26.MinSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem26.Size = new System.Drawing.Size(270, 48);
            this.layoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem26.Text = "赠送时长月:";
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.服务总时长月TextBox;
            this.layoutControlItem28.Location = new System.Drawing.Point(924, 44);
            this.layoutControlItem28.MaxSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem28.MinSize = new System.Drawing.Size(270, 48);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem28.Size = new System.Drawing.Size(270, 48);
            this.layoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem28.Text = "服务总时长月:";
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.开始服务月DateEdit;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem22.MaxSize = new System.Drawing.Size(384, 36);
            this.layoutControlItem22.MinSize = new System.Drawing.Size(384, 36);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem22.Size = new System.Drawing.Size(384, 48);
            this.layoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem22.Text = "开始服务月:";
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.结束服务月DateEdit;
            this.layoutControlItem24.Location = new System.Drawing.Point(384, 92);
            this.layoutControlItem24.MaxSize = new System.Drawing.Size(384, 36);
            this.layoutControlItem24.MinSize = new System.Drawing.Size(384, 36);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem24.Size = new System.Drawing.Size(384, 48);
            this.layoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem24.Text = "结束服务月:";
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem20.AppearanceItemCaption.ForeColor = System.Drawing.Color.Firebrick;
            this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem20.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem20.Control = this.做账会计ButtonEdit;
            this.layoutControlItem20.Location = new System.Drawing.Point(768, 92);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(214, 48);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem20.Size = new System.Drawing.Size(340, 48);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.Text = "做账会计:";
            // 
            // 一次性服务Group
            // 
            this.一次性服务Group.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem5,
            this.layoutControlItem13,
            this.layoutControlItem21,
            this.layoutControlItem23,
            this.emptySpaceItem9,
            this.layoutControlItem18});
            this.一次性服务Group.Location = new System.Drawing.Point(0, 386);
            this.一次性服务Group.Name = "一次性服务Group";
            this.一次性服务Group.Size = new System.Drawing.Size(1473, 112);
            this.一次性服务Group.Text = "一次性服务";
            this.一次性服务Group.TextVisible = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.服务金额TextEdit1;
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem25.Size = new System.Drawing.Size(360, 44);
            this.layoutControlItem25.Text = "服务金额:";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.服务类别ComboBoxEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem5.Size = new System.Drawing.Size(360, 44);
            this.layoutControlItem5.Text = "服务类别:";
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.服务分类ComboBoxEdit1;
            this.layoutControlItem13.Location = new System.Drawing.Point(360, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem13.Size = new System.Drawing.Size(363, 44);
            this.layoutControlItem13.Text = "服务分类:";
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.服务类型ComboBoxEdit1;
            this.layoutControlItem21.Location = new System.Drawing.Point(723, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem21.Size = new System.Drawing.Size(368, 44);
            this.layoutControlItem21.Text = "服务类型:";
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.服务项目ComboBoxEdit1;
            this.layoutControlItem23.Location = new System.Drawing.Point(1091, 0);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem23.Size = new System.Drawing.Size(358, 44);
            this.layoutControlItem23.Text = "服务项目:";
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.Location = new System.Drawing.Point(723, 44);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(726, 44);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.注册员ButtonEdit;
            this.layoutControlItem18.Location = new System.Drawing.Point(360, 44);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(363, 44);
            this.layoutControlItem18.Text = "注册员:";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.签约日期DateEdit;
            this.layoutControlItem16.Location = new System.Drawing.Point(366, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem16.Size = new System.Drawing.Size(324, 44);
            this.layoutControlItem16.Text = "签约日期:";
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.ck周期性服务;
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(1473, 31);
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ck一次性服务;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 355);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1473, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // itemSave
            // 
            this.itemSave.Control = this.btnSave;
            this.itemSave.Location = new System.Drawing.Point(225, 890);
            this.itemSave.MaxSize = new System.Drawing.Size(225, 39);
            this.itemSave.MinSize = new System.Drawing.Size(225, 39);
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(225, 39);
            this.itemSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemSave.TextSize = new System.Drawing.Size(0, 0);
            this.itemSave.TextVisible = false;
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.btnCancel;
            this.layoutControlItem30.Location = new System.Drawing.Point(480, 890);
            this.layoutControlItem30.MaxSize = new System.Drawing.Size(225, 39);
            this.layoutControlItem30.MinSize = new System.Drawing.Size(225, 39);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(225, 39);
            this.layoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem30.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem30.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(450, 890);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(30, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(30, 15);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(30, 39);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 890);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(225, 39);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(705, 890);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(768, 39);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 136);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(1473, 24);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.Location = new System.Drawing.Point(1081, 0);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(392, 44);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 498);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1473, 392);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlGroup2.Text = "备注";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.备注MemoEdit;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem9.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlItem9.Text = "备注:";
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem29,
            this.emptySpaceItem10,
            this.layoutControlItem34});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlGroup3.Text = "附件";
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.tF_FILEGridControl;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(1449, 296);
            this.layoutControlItem29.TextVisible = false;
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.Location = new System.Drawing.Point(108, 0);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(1341, 36);
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.btnView附件;
            this.layoutControlItem34.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(108, 36);
            this.layoutControlItem34.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem14});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlGroup4.Text = "收款记录";
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.tW_PaymentMainGridControl;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem31});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlGroup5.Text = "历史合同";
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.tW_ContractServiceInfoGridControl;
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(1449, 332);
            this.layoutControlItem31.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.工本费TextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(690, 92);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem6.Size = new System.Drawing.Size(319, 44);
            this.layoutControlItem6.Text = "工本费:";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.开票费TextEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(1009, 92);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem8.Size = new System.Drawing.Size(347, 44);
            this.layoutControlItem8.Text = "开票费:";
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.Location = new System.Drawing.Point(1375, 44);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(98, 48);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.Location = new System.Drawing.Point(1356, 92);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(117, 44);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.续签CheckEdit;
            this.layoutControlItem33.Location = new System.Drawing.Point(690, 0);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 2);
            this.layoutControlItem33.Size = new System.Drawing.Size(391, 44);
            this.layoutControlItem33.Text = "续签:";
            this.layoutControlItem33.TextVisible = false;
            // 
            // tW_ContractServiceInfoBindingSource
            // 
            this.tW_ContractServiceInfoBindingSource.DataMember = "TW_ContractServiceInfo";
            this.tW_ContractServiceInfoBindingSource.DataSource = this.contractDataSet;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 起始月dateEdit
            // 
            this.起始月dateEdit.EditValue = null;
            this.起始月dateEdit.Location = new System.Drawing.Point(1259, 311);
            this.起始月dateEdit.Name = "起始月dateEdit";
            this.起始月dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.起始月dateEdit.Properties.Appearance.Options.UseFont = true;
            this.起始月dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.起始月dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.起始月dateEdit.Size = new System.Drawing.Size(198, 32);
            this.起始月dateEdit.StyleController = this.layoutControl1;
            this.起始月dateEdit.TabIndex = 65;
            this.起始月dateEdit.ToolTip = "会计开始做账的起始月";
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem32.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layoutControlItem32.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem32.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem32.Control = this.起始月dateEdit;
            this.layoutControlItem32.Location = new System.Drawing.Point(1108, 92);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 6);
            this.layoutControlItem32.Size = new System.Drawing.Size(330, 48);
            this.layoutControlItem32.Text = "起始月：";
            // 
            // FrmContractAssign
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1493, 949);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.Name = "FrmContractAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合同信息";
            this.Load += new System.EventHandler(this.FrmContractEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.续签CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentMainGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注册员ButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck周期性服务.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck一次性服务.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务项目ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务项目ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类别ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务分类ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类型ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务金额TextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类别ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务分类ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务类型ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务金额TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.开始服务月DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.开始服务月DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束服务月DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束服务月DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称ButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工本费TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.开票费TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.定金金额TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同金额CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计ButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.周期性服务Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.一次性服务Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractServiceInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.起始月dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.起始月dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private System.Windows.Forms.BindingSource tW_ContractBindingSource;
        private Contract.ContractDataSet contractDataSet;
        private DevExpress.XtraEditors.ComboBoxEdit 服务类别ComboBoxEdit;
        private System.Windows.Forms.BindingSource tW_ContractServiceInfoBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit 服务分类ComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 服务类型ComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit 服务金额TextEdit;
        private System.Windows.Forms.TextBox 服务期限月TextBox;
        private DevExpress.XtraEditors.DateEdit 开始服务月DateEdit;
        private DevExpress.XtraEditors.DateEdit 结束服务月DateEdit;
        private System.Windows.Forms.TextBox 赠送时长月TextBox;
        private System.Windows.Forms.TextBox 服务总时长月TextBox;
        private DevExpress.XtraEditors.ButtonEdit 客户名称ButtonEdit;
        private DevExpress.XtraEditors.TextEdit 合同编号TextEdit;
        private DevExpress.XtraEditors.TextEdit 工本费TextEdit;
        private DevExpress.XtraEditors.TextEdit 开票费TextEdit;
        private DevExpress.XtraEditors.TextEdit 定金金额TextEdit;
        private DevExpress.XtraEditors.CalcEdit 合同金额CalcEdit;
        private DevExpress.XtraEditors.DateEdit 签约日期DateEdit;
        private DevExpress.XtraEditors.ButtonEdit 做账会计ButtonEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup 周期性服务Group;
        private DevExpress.XtraEditors.MemoEdit 备注MemoEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 服务类别ComboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit 服务分类ComboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit 服务类型ComboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit 服务金额TextEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup 一次性服务Group;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.ComboBoxEdit 服务项目ComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.ComboBoxEdit 服务项目ComboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraEditors.CheckEdit ck周期性服务;
        private DevExpress.XtraEditors.CheckEdit ck一次性服务;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private Tiger.PdrCommon.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.LayoutControlItem itemSave;
        private DevExpress.XtraGrid.GridControl tF_FILEGridControl;
        private System.Windows.Forms.BindingSource tF_FILEBindingSource;
        private FileDataSet fileDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colUploader;
        private DevExpress.XtraGrid.Columns.GridColumn colUpload_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colFileType;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnView附件;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraEditors.ButtonEdit 注册员ButtonEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private ProceedsDataSet proceedsDataSet;
        private System.Windows.Forms.BindingSource tW_PaymentMainBindingSource;
        private DevExpress.XtraGrid.GridControl tW_PaymentMainGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col支付总额;
        private DevExpress.XtraGrid.Columns.GridColumn col支付日期;
        private DevExpress.XtraGrid.Columns.GridColumn col支付方式;
        private DevExpress.XtraGrid.Columns.GridColumn col收款人;
        private DevExpress.XtraGrid.Columns.GridColumn col收款类别;
        private DevExpress.XtraGrid.Columns.GridColumn col备注;
        private DevExpress.XtraGrid.Columns.GridColumn col操作人;
        private DevExpress.XtraGrid.Columns.GridColumn col操作时间;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col月做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col缴费月数;
        private DevExpress.XtraGrid.Columns.GridColumn col不收款;
        private DevExpress.XtraGrid.Columns.GridColumn col银行账号;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraGrid.Columns.GridColumn col一次性服务费;
        private DevExpress.XtraGrid.Columns.GridColumn col周期性服务费;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.CheckEdit 续签CheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private System.Windows.Forms.BindingSource tW_ContractServiceInfoVBindingSource;
        private Contract.ContractDataSet contractDataSetView;
        private DevExpress.XtraGrid.GridControl tW_ContractServiceInfoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col服务类别;
        private DevExpress.XtraGrid.Columns.GridColumn col服务金额;
        private DevExpress.XtraGrid.Columns.GridColumn col服务期限月;
        private DevExpress.XtraGrid.Columns.GridColumn col开始服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col结束服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col服务项目;
        private DevExpress.XtraGrid.Columns.GridColumn col服务总时长月;
        private DevExpress.XtraGrid.Columns.GridColumn col赠送时长月;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraEditors.DateEdit 起始月dateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
    }
}