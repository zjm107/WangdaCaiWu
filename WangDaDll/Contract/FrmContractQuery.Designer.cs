using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmContractQuery
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col服务类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务分类 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务项目 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col结束服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务总时长月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务期限月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开始服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col赠送时长月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ContractbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSet1 = new WangDaDll.Contract.ContractDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.合同编号HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.客户名称HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col合同金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col已付款金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col签约日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col创建人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col创建时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col纳税性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批状态 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col定金金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col最后修改人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col最后修改时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col备注 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col未付款金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.公司名称Text = new DevExpress.XtraEditors.ButtonEdit();
            this.做账会计Text = new DevExpress.XtraEditors.ButtonEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.未付款金额comboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.审批状态comboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.合同到期月spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.fileDataSet1 = new WangDaDll.Common.FileDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公司名称Text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计Text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.未付款金额comboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.审批状态comboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同到期月spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col服务类别,
            this.col服务分类,
            this.col服务类型,
            this.col服务金额,
            this.col服务项目,
            this.col结束服务月,
            this.col服务总时长月,
            this.col服务期限月,
            this.col开始服务月,
            this.col赠送时长月});
            this.gridView2.DetailHeight = 525;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PaintStyleName = "Office2003";
            this.gridView2.ViewCaption = "服务内容";
            // 
            // col服务类别
            // 
            this.col服务类别.FieldName = "服务类别";
            this.col服务类别.MinWidth = 30;
            this.col服务类别.Name = "col服务类别";
            this.col服务类别.Visible = true;
            this.col服务类别.VisibleIndex = 1;
            this.col服务类别.Width = 154;
            // 
            // col服务分类
            // 
            this.col服务分类.FieldName = "服务分类";
            this.col服务分类.MinWidth = 30;
            this.col服务分类.Name = "col服务分类";
            this.col服务分类.Visible = true;
            this.col服务分类.VisibleIndex = 2;
            this.col服务分类.Width = 165;
            // 
            // col服务类型
            // 
            this.col服务类型.FieldName = "服务类型";
            this.col服务类型.MinWidth = 30;
            this.col服务类型.Name = "col服务类型";
            this.col服务类型.Visible = true;
            this.col服务类型.VisibleIndex = 0;
            this.col服务类型.Width = 193;
            // 
            // col服务金额
            // 
            this.col服务金额.FieldName = "服务金额";
            this.col服务金额.MinWidth = 30;
            this.col服务金额.Name = "col服务金额";
            this.col服务金额.Visible = true;
            this.col服务金额.VisibleIndex = 4;
            this.col服务金额.Width = 112;
            // 
            // col服务项目
            // 
            this.col服务项目.FieldName = "服务项目";
            this.col服务项目.MinWidth = 30;
            this.col服务项目.Name = "col服务项目";
            this.col服务项目.Visible = true;
            this.col服务项目.VisibleIndex = 3;
            this.col服务项目.Width = 294;
            // 
            // col结束服务月
            // 
            this.col结束服务月.FieldName = "结束服务月";
            this.col结束服务月.MinWidth = 30;
            this.col结束服务月.Name = "col结束服务月";
            this.col结束服务月.Visible = true;
            this.col结束服务月.VisibleIndex = 6;
            this.col结束服务月.Width = 112;
            // 
            // col服务总时长月
            // 
            this.col服务总时长月.FieldName = "服务总时长月";
            this.col服务总时长月.MinWidth = 30;
            this.col服务总时长月.Name = "col服务总时长月";
            this.col服务总时长月.Visible = true;
            this.col服务总时长月.VisibleIndex = 7;
            this.col服务总时长月.Width = 123;
            // 
            // col服务期限月
            // 
            this.col服务期限月.FieldName = "服务期限月";
            this.col服务期限月.MinWidth = 30;
            this.col服务期限月.Name = "col服务期限月";
            this.col服务期限月.Visible = true;
            this.col服务期限月.VisibleIndex = 8;
            this.col服务期限月.Width = 112;
            // 
            // col开始服务月
            // 
            this.col开始服务月.FieldName = "开始服务月";
            this.col开始服务月.MinWidth = 30;
            this.col开始服务月.Name = "col开始服务月";
            this.col开始服务月.Visible = true;
            this.col开始服务月.VisibleIndex = 5;
            this.col开始服务月.Width = 112;
            // 
            // col赠送时长月
            // 
            this.col赠送时长月.FieldName = "赠送时长月";
            this.col赠送时长月.MinWidth = 30;
            this.col赠送时长月.Name = "col赠送时长月";
            this.col赠送时长月.Visible = true;
            this.col赠送时长月.VisibleIndex = 9;
            this.col赠送时长月.Width = 112;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ContractbindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "TW_Contract_TW_ContractServiceInfo";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 119);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.客户名称HyperLinkEdit,
            this.合同编号HyperLinkEdit});
            this.gridControl1.Size = new System.Drawing.Size(1256, 587);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // ContractbindingSource
            // 
            this.ContractbindingSource.DataMember = "TW_Contract";
            this.ContractbindingSource.DataSource = this.contractDataSet1;
            // 
            // contractDataSet1
            // 
            this.contractDataSet1.DataSetName = "ContractDataSet";
            this.contractDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.Empty.Options.UseFont = true;
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
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
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
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
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
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
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
            this.col合同编号,
            this.col客户名称,
            this.col合同金额,
            this.col已付款金额,
            this.col签约日期,
            this.col创建人,
            this.col创建时间,
            this.col纳税性质,
            this.col公司性质,
            this.col审批日期,
            this.col审批状态,
            this.col工本费,
            this.col开票费,
            this.col定金金额,
            this.col最后修改人,
            this.col最后修改时间,
            this.col备注,
            this.col未付款金额,
            this.col做账会计,
            this.col注册员});
            this.gridView1.DetailHeight = 525;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Style3D";
            // 
            // col合同编号
            // 
            this.col合同编号.ColumnEdit = this.合同编号HyperLinkEdit;
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.MinWidth = 30;
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.OptionsColumn.ReadOnly = true;
            this.col合同编号.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "合同编号", "{0}")});
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 0;
            this.col合同编号.Width = 162;
            // 
            // 合同编号HyperLinkEdit
            // 
            this.合同编号HyperLinkEdit.AutoHeight = false;
            this.合同编号HyperLinkEdit.Name = "合同编号HyperLinkEdit";
            this.合同编号HyperLinkEdit.DoubleClick += new System.EventHandler(this.合同编号HyperLinkEdit_DoubleClick);
            // 
            // col客户名称
            // 
            this.col客户名称.ColumnEdit = this.客户名称HyperLinkEdit;
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.MinWidth = 30;
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 1;
            this.col客户名称.Width = 429;
            // 
            // 客户名称HyperLinkEdit
            // 
            this.客户名称HyperLinkEdit.AutoHeight = false;
            this.客户名称HyperLinkEdit.Name = "客户名称HyperLinkEdit";
            this.客户名称HyperLinkEdit.DoubleClick += new System.EventHandler(this.客户名称HyperLinkEdit_DoubleClick);
            // 
            // col合同金额
            // 
            this.col合同金额.FieldName = "合同金额";
            this.col合同金额.MinWidth = 30;
            this.col合同金额.Name = "col合同金额";
            this.col合同金额.OptionsColumn.ReadOnly = true;
            this.col合同金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "合同金额", "{0:#.##}")});
            this.col合同金额.Visible = true;
            this.col合同金额.VisibleIndex = 2;
            this.col合同金额.Width = 162;
            // 
            // col已付款金额
            // 
            this.col已付款金额.FieldName = "已付款金额";
            this.col已付款金额.MinWidth = 30;
            this.col已付款金额.Name = "col已付款金额";
            this.col已付款金额.OptionsColumn.ReadOnly = true;
            this.col已付款金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "已付款金额", "{0:#.##}")});
            this.col已付款金额.Width = 157;
            // 
            // col签约日期
            // 
            this.col签约日期.FieldName = "签约日期";
            this.col签约日期.MinWidth = 30;
            this.col签约日期.Name = "col签约日期";
            this.col签约日期.OptionsColumn.ReadOnly = true;
            this.col签约日期.Visible = true;
            this.col签约日期.VisibleIndex = 5;
            this.col签约日期.Width = 162;
            // 
            // col创建人
            // 
            this.col创建人.FieldName = "创建人";
            this.col创建人.MinWidth = 30;
            this.col创建人.Name = "col创建人";
            this.col创建人.OptionsColumn.ReadOnly = true;
            this.col创建人.Visible = true;
            this.col创建人.VisibleIndex = 12;
            this.col创建人.Width = 129;
            // 
            // col创建时间
            // 
            this.col创建时间.FieldName = "创建时间";
            this.col创建时间.MinWidth = 30;
            this.col创建时间.Name = "col创建时间";
            this.col创建时间.OptionsColumn.ReadOnly = true;
            this.col创建时间.Visible = true;
            this.col创建时间.VisibleIndex = 13;
            this.col创建时间.Width = 162;
            // 
            // col纳税性质
            // 
            this.col纳税性质.FieldName = "纳税性质";
            this.col纳税性质.MinWidth = 30;
            this.col纳税性质.Name = "col纳税性质";
            this.col纳税性质.OptionsColumn.ReadOnly = true;
            this.col纳税性质.Visible = true;
            this.col纳税性质.VisibleIndex = 3;
            this.col纳税性质.Width = 162;
            // 
            // col公司性质
            // 
            this.col公司性质.FieldName = "公司性质";
            this.col公司性质.MinWidth = 30;
            this.col公司性质.Name = "col公司性质";
            this.col公司性质.OptionsColumn.ReadOnly = true;
            this.col公司性质.Visible = true;
            this.col公司性质.VisibleIndex = 4;
            this.col公司性质.Width = 162;
            // 
            // col审批日期
            // 
            this.col审批日期.FieldName = "审批日期";
            this.col审批日期.MinWidth = 30;
            this.col审批日期.Name = "col审批日期";
            this.col审批日期.OptionsColumn.ReadOnly = true;
            this.col审批日期.Visible = true;
            this.col审批日期.VisibleIndex = 10;
            this.col审批日期.Width = 162;
            // 
            // col审批状态
            // 
            this.col审批状态.FieldName = "审批状态";
            this.col审批状态.MinWidth = 30;
            this.col审批状态.Name = "col审批状态";
            this.col审批状态.OptionsColumn.ReadOnly = true;
            this.col审批状态.Visible = true;
            this.col审批状态.VisibleIndex = 9;
            this.col审批状态.Width = 162;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.MinWidth = 30;
            this.col工本费.Name = "col工本费";
            this.col工本费.OptionsColumn.ReadOnly = true;
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 7;
            this.col工本费.Width = 129;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.MinWidth = 30;
            this.col开票费.Name = "col开票费";
            this.col开票费.OptionsColumn.ReadOnly = true;
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 8;
            this.col开票费.Width = 129;
            // 
            // col定金金额
            // 
            this.col定金金额.FieldName = "定金金额";
            this.col定金金额.MinWidth = 30;
            this.col定金金额.Name = "col定金金额";
            this.col定金金额.OptionsColumn.ReadOnly = true;
            this.col定金金额.Visible = true;
            this.col定金金额.VisibleIndex = 6;
            this.col定金金额.Width = 162;
            // 
            // col最后修改人
            // 
            this.col最后修改人.FieldName = "最后修改人";
            this.col最后修改人.MinWidth = 30;
            this.col最后修改人.Name = "col最后修改人";
            this.col最后修改人.OptionsColumn.ReadOnly = true;
            this.col最后修改人.Visible = true;
            this.col最后修改人.VisibleIndex = 14;
            this.col最后修改人.Width = 195;
            // 
            // col最后修改时间
            // 
            this.col最后修改时间.FieldName = "最后修改时间";
            this.col最后修改时间.MinWidth = 30;
            this.col最后修改时间.Name = "col最后修改时间";
            this.col最后修改时间.OptionsColumn.ReadOnly = true;
            this.col最后修改时间.Visible = true;
            this.col最后修改时间.VisibleIndex = 15;
            this.col最后修改时间.Width = 228;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.MinWidth = 30;
            this.col备注.Name = "col备注";
            this.col备注.OptionsColumn.ReadOnly = true;
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 11;
            this.col备注.Width = 235;
            // 
            // col未付款金额
            // 
            this.col未付款金额.FieldName = "未付款金额";
            this.col未付款金额.MinWidth = 30;
            this.col未付款金额.Name = "col未付款金额";
            this.col未付款金额.OptionsColumn.ReadOnly = true;
            this.col未付款金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "未付款金额", "{0:#.##}")});
            this.col未付款金额.Width = 183;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.MinWidth = 30;
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 16;
            this.col做账会计.Width = 112;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.MinWidth = 30;
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 17;
            this.col注册员.Width = 112;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.公司名称Text);
            this.layoutControl1.Controls.Add(this.做账会计Text);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.未付款金额comboBoxEdit);
            this.layoutControl1.Controls.Add(this.审批状态comboBoxEdit);
            this.layoutControl1.Controls.Add(this.合同到期月spinEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(854, 450, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1280, 718);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // 公司名称Text
            // 
            this.公司名称Text.Location = new System.Drawing.Point(139, 12);
            this.公司名称Text.Margin = new System.Windows.Forms.Padding(4);
            this.公司名称Text.Name = "公司名称Text";
            this.公司名称Text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.公司名称Text.Size = new System.Drawing.Size(472, 28);
            this.公司名称Text.StyleController = this.layoutControl1;
            this.公司名称Text.TabIndex = 5;
            this.公司名称Text.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.公司名称Text_ButtonClick);
            // 
            // 做账会计Text
            // 
            this.做账会计Text.Location = new System.Drawing.Point(742, 12);
            this.做账会计Text.Margin = new System.Windows.Forms.Padding(4);
            this.做账会计Text.Name = "做账会计Text";
            this.做账会计Text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.做账会计Text.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.做账会计Text_Properties_ButtonClick);
            this.做账会计Text.Size = new System.Drawing.Size(197, 28);
            this.做账会计Text.StyleController = this.layoutControl1;
            this.做账会计Text.TabIndex = 6;
            this.做账会计Text.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.做账会计Text_Properties_ButtonClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 80);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 35);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 80);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(146, 35);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // 未付款金额comboBoxEdit
            // 
            this.未付款金额comboBoxEdit.Location = new System.Drawing.Point(377, 44);
            this.未付款金额comboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.未付款金额comboBoxEdit.Name = "未付款金额comboBoxEdit";
            this.未付款金额comboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.未付款金额comboBoxEdit.Properties.Items.AddRange(new object[] {
            "大于0",
            "等于0"});
            this.未付款金额comboBoxEdit.Size = new System.Drawing.Size(125, 28);
            this.未付款金额comboBoxEdit.StyleController = this.layoutControl1;
            this.未付款金额comboBoxEdit.TabIndex = 15;
            // 
            // 审批状态comboBoxEdit
            // 
            this.审批状态comboBoxEdit.Location = new System.Drawing.Point(633, 44);
            this.审批状态comboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.审批状态comboBoxEdit.Name = "审批状态comboBoxEdit";
            this.审批状态comboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.审批状态comboBoxEdit.Properties.Items.AddRange(new object[] {
            "全部",
            "未提交",
            "待审批",
            "已审批",
            "已驳回"});
            this.审批状态comboBoxEdit.Size = new System.Drawing.Size(134, 28);
            this.审批状态comboBoxEdit.StyleController = this.layoutControl1;
            this.审批状态comboBoxEdit.TabIndex = 17;
            // 
            // 合同到期月spinEdit
            // 
            this.合同到期月spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.合同到期月spinEdit.Location = new System.Drawing.Point(139, 44);
            this.合同到期月spinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.合同到期月spinEdit.Name = "合同到期月spinEdit";
            this.合同到期月spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.合同到期月spinEdit.Size = new System.Drawing.Size(107, 28);
            this.合同到期月spinEdit.StyleController = this.layoutControl1;
            this.合同到期月spinEdit.TabIndex = 18;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.layoutControlItem7,
            this.layoutControlItem11});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1280, 718);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.公司名称Text;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(603, 32);
            this.layoutControlItem2.Text = "公司名称：";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.做账会计Text;
            this.layoutControlItem1.Location = new System.Drawing.Point(603, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(328, 32);
            this.layoutControlItem1.Text = "做账会计：";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnQuery;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(150, 39);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(150, 39);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(150, 39);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1260, 591);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(320, 68);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(940, 39);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnClear;
            this.layoutControlItem8.Location = new System.Drawing.Point(160, 68);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(150, 39);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(150, 39);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(150, 39);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.未付款金额comboBoxEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(238, 32);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(256, 36);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(256, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(256, 36);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "未付款金额:";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(759, 32);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(501, 36);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(931, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(329, 32);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(150, 68);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 39);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(310, 68);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 39);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.审批状态comboBoxEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(494, 32);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(265, 36);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(265, 36);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(265, 36);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "审批状态：";
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.合同到期月spinEdit;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(238, 36);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(238, 36);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(238, 36);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "将到期(月）：";
            // 
            // fileDataSet1
            // 
            this.fileDataSet1.DataSetName = "FileDataSet";
            this.fileDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmContractQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.Name = "FrmContractQuery";
            this.Text = "合同管理";
            this.Load += new System.EventHandler(this.FrmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.公司名称Text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计Text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.未付款金额comboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.审批状态comboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同到期月spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private Contract.ContractDataSet contractDataSet1;
        private FileDataSet fileDataSet1;
        private DevExpress.XtraEditors.ButtonEdit 公司名称Text;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ButtonEdit 做账会计Text;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource ContractbindingSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col合同金额;
        private DevExpress.XtraGrid.Columns.GridColumn col已付款金额;
        private DevExpress.XtraGrid.Columns.GridColumn col签约日期;
        private DevExpress.XtraGrid.Columns.GridColumn col创建人;
        private DevExpress.XtraGrid.Columns.GridColumn col创建时间;
        private DevExpress.XtraGrid.Columns.GridColumn col纳税性质;
        private DevExpress.XtraGrid.Columns.GridColumn col公司性质;
        private DevExpress.XtraGrid.Columns.GridColumn col审批日期;
        private DevExpress.XtraGrid.Columns.GridColumn col审批状态;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费;
        private DevExpress.XtraGrid.Columns.GridColumn col定金金额;
        private DevExpress.XtraGrid.Columns.GridColumn col最后修改人;
        private DevExpress.XtraGrid.Columns.GridColumn col最后修改时间;
        private DevExpress.XtraGrid.Columns.GridColumn col备注;
        private DevExpress.XtraGrid.Columns.GridColumn col未付款金额;
        private DevExpress.XtraEditors.ComboBoxEdit 未付款金额comboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.ComboBoxEdit 审批状态comboBoxEdit;
        private DevExpress.XtraEditors.SpinEdit 合同到期月spinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col服务类别;
        private DevExpress.XtraGrid.Columns.GridColumn col服务分类;
        private DevExpress.XtraGrid.Columns.GridColumn col服务类型;
        private DevExpress.XtraGrid.Columns.GridColumn col服务金额;
        private DevExpress.XtraGrid.Columns.GridColumn col服务项目;
        private DevExpress.XtraGrid.Columns.GridColumn col结束服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col服务总时长月;
        private DevExpress.XtraGrid.Columns.GridColumn col服务期限月;
        private DevExpress.XtraGrid.Columns.GridColumn col开始服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col赠送时长月;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 合同编号HyperLinkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 客户名称HyperLinkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
    }
}