using WangDaDll.Contract;
namespace WangDaDll
{
    partial class FrmContractReceivables
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
            this.vw_ContractReceivablesPeriodGridControl = new DevExpress.XtraGrid.GridControl();
            this.vw_ContractReceivablesPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.客户名称HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.合同编号HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col签约日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col最后收款日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col应收款金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col合同金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col累计已收款金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col已收一次性服务费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col已收周期性服务费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col续签 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.签约日期DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.签约日期DateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.客户名称TextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ContractReceivablesPeriodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ContractReceivablesPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.vw_ContractReceivablesPeriodGridControl);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.签约日期DateEdit1);
            this.layoutControl1.Controls.Add(this.签约日期DateEdit2);
            this.layoutControl1.Controls.Add(this.客户名称TextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1271, 806);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // vw_ContractReceivablesPeriodGridControl
            // 
            this.vw_ContractReceivablesPeriodGridControl.DataSource = this.vw_ContractReceivablesPeriodBindingSource;
            this.vw_ContractReceivablesPeriodGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.vw_ContractReceivablesPeriodGridControl.Location = new System.Drawing.Point(12, 84);
            this.vw_ContractReceivablesPeriodGridControl.MainView = this.gridView1;
            this.vw_ContractReceivablesPeriodGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vw_ContractReceivablesPeriodGridControl.Name = "vw_ContractReceivablesPeriodGridControl";
            this.vw_ContractReceivablesPeriodGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.客户名称HyperLinkEdit,
            this.合同编号HyperLinkEdit});
            this.vw_ContractReceivablesPeriodGridControl.Size = new System.Drawing.Size(1247, 710);
            this.vw_ContractReceivablesPeriodGridControl.TabIndex = 8;
            this.vw_ContractReceivablesPeriodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vw_ContractReceivablesPeriodBindingSource
            // 
            this.vw_ContractReceivablesPeriodBindingSource.DataMember = "vw_ContractReceivables";
            this.vw_ContractReceivablesPeriodBindingSource.DataSource = this.contractDataSet;
            // 
            // contractDataSet
            // 
            this.contractDataSet.DataSetName = "ContractDataSet";
            this.contractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.col客户名称,
            this.col合同编号,
            this.col签约日期,
            this.col最后收款日期,
            this.col应收款金额,
            this.col合同金额,
            this.col累计已收款金额,
            this.colCID,
            this.col已收一次性服务费,
            this.col已收周期性服务费,
            this.col续签});
            this.gridView1.DetailHeight = 425;
            this.gridView1.GridControl = this.vw_ContractReceivablesPeriodGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 914;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Style3D";
            // 
            // col客户名称
            // 
            this.col客户名称.ColumnEdit = this.客户名称HyperLinkEdit;
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.MinWidth = 23;
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 0;
            this.col客户名称.Width = 383;
            // 
            // 客户名称HyperLinkEdit
            // 
            this.客户名称HyperLinkEdit.AutoHeight = false;
            this.客户名称HyperLinkEdit.Name = "客户名称HyperLinkEdit";
            this.客户名称HyperLinkEdit.DoubleClick += new System.EventHandler(this.客户名称HyperLinkEdit_DoubleClick);
            // 
            // col合同编号
            // 
            this.col合同编号.ColumnEdit = this.合同编号HyperLinkEdit;
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.MinWidth = 23;
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 1;
            this.col合同编号.Width = 130;
            // 
            // 合同编号HyperLinkEdit
            // 
            this.合同编号HyperLinkEdit.AutoHeight = false;
            this.合同编号HyperLinkEdit.Name = "合同编号HyperLinkEdit";
            this.合同编号HyperLinkEdit.DoubleClick += new System.EventHandler(this.合同编号HyperLinkEdit_DoubleClick);
            // 
            // col签约日期
            // 
            this.col签约日期.FieldName = "签约日期";
            this.col签约日期.MinWidth = 23;
            this.col签约日期.Name = "col签约日期";
            this.col签约日期.Visible = true;
            this.col签约日期.VisibleIndex = 2;
            this.col签约日期.Width = 131;
            // 
            // col最后收款日期
            // 
            this.col最后收款日期.FieldName = "最后收款日期";
            this.col最后收款日期.MinWidth = 23;
            this.col最后收款日期.Name = "col最后收款日期";
            this.col最后收款日期.Visible = true;
            this.col最后收款日期.VisibleIndex = 8;
            this.col最后收款日期.Width = 180;
            // 
            // col应收款金额
            // 
            this.col应收款金额.FieldName = "应收款金额";
            this.col应收款金额.MinWidth = 23;
            this.col应收款金额.Name = "col应收款金额";
            this.col应收款金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "应收款金额", "{0:0.##}")});
            this.col应收款金额.Visible = true;
            this.col应收款金额.VisibleIndex = 4;
            this.col应收款金额.Width = 155;
            // 
            // col合同金额
            // 
            this.col合同金额.FieldName = "合同金额";
            this.col合同金额.MinWidth = 23;
            this.col合同金额.Name = "col合同金额";
            this.col合同金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "合同金额", "{0:0.##}")});
            this.col合同金额.Visible = true;
            this.col合同金额.VisibleIndex = 3;
            this.col合同金额.Width = 142;
            // 
            // col累计已收款金额
            // 
            this.col累计已收款金额.FieldName = "已收款金额";
            this.col累计已收款金额.MinWidth = 23;
            this.col累计已收款金额.Name = "col累计已收款金额";
            this.col累计已收款金额.OptionsColumn.ReadOnly = true;
            this.col累计已收款金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "已收款金额", "{0:0.##}")});
            this.col累计已收款金额.Visible = true;
            this.col累计已收款金额.VisibleIndex = 5;
            this.col累计已收款金额.Width = 208;
            // 
            // colCID
            // 
            this.colCID.FieldName = "CID";
            this.colCID.MinWidth = 23;
            this.colCID.Name = "colCID";
            this.colCID.Width = 86;
            // 
            // col已收一次性服务费
            // 
            this.col已收一次性服务费.FieldName = "已收一次性服务费";
            this.col已收一次性服务费.MinWidth = 30;
            this.col已收一次性服务费.Name = "col已收一次性服务费";
            this.col已收一次性服务费.OptionsColumn.ReadOnly = true;
            this.col已收一次性服务费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "已收一次性服务费", "{0:0.##}")});
            this.col已收一次性服务费.Visible = true;
            this.col已收一次性服务费.VisibleIndex = 6;
            this.col已收一次性服务费.Width = 241;
            // 
            // col已收周期性服务费
            // 
            this.col已收周期性服务费.FieldName = "已收周期性服务费";
            this.col已收周期性服务费.MinWidth = 30;
            this.col已收周期性服务费.Name = "col已收周期性服务费";
            this.col已收周期性服务费.OptionsColumn.ReadOnly = true;
            this.col已收周期性服务费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "已收周期性服务费", "{0:0.##}")});
            this.col已收周期性服务费.Visible = true;
            this.col已收周期性服务费.VisibleIndex = 7;
            this.col已收周期性服务费.Width = 233;
            // 
            // col续签
            // 
            this.col续签.FieldName = "续签";
            this.col续签.MinWidth = 30;
            this.col续签.Name = "col续签";
            this.col续签.OptionsColumn.ReadOnly = true;
            this.col续签.Visible = true;
            this.col续签.VisibleIndex = 9;
            this.col续签.Width = 112;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 48);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 48);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(95, 32);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // 签约日期DateEdit1
            // 
            this.签约日期DateEdit1.EditValue = null;
            this.签约日期DateEdit1.Location = new System.Drawing.Point(642, 12);
            this.签约日期DateEdit1.Name = "签约日期DateEdit1";
            this.签约日期DateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.签约日期DateEdit1.Properties.Appearance.Options.UseFont = true;
            this.签约日期DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit1.Size = new System.Drawing.Size(171, 32);
            this.签约日期DateEdit1.StyleController = this.layoutControl1;
            this.签约日期DateEdit1.TabIndex = 11;
            // 
            // 签约日期DateEdit2
            // 
            this.签约日期DateEdit2.EditValue = null;
            this.签约日期DateEdit2.Location = new System.Drawing.Point(912, 12);
            this.签约日期DateEdit2.Name = "签约日期DateEdit2";
            this.签约日期DateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.签约日期DateEdit2.Properties.Appearance.Options.UseFont = true;
            this.签约日期DateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit2.Properties.DisplayFormat.FormatString = "";
            this.签约日期DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.签约日期DateEdit2.Properties.EditFormat.FormatString = "";
            this.签约日期DateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.签约日期DateEdit2.Properties.MaskSettings.Set("mask", "");
            this.签约日期DateEdit2.Size = new System.Drawing.Size(183, 32);
            this.签约日期DateEdit2.StyleController = this.layoutControl1;
            this.签约日期DateEdit2.TabIndex = 12;
            // 
            // 客户名称TextEdit
            // 
            this.客户名称TextEdit.Location = new System.Drawing.Point(115, 12);
            this.客户名称TextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.客户名称TextEdit.Name = "客户名称TextEdit";
            this.客户名称TextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.客户名称TextEdit.Properties.Appearance.Options.UseFont = true;
            this.客户名称TextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.客户名称TextEdit.Size = new System.Drawing.Size(396, 32);
            this.客户名称TextEdit.StyleController = this.layoutControl1;
            this.客户名称TextEdit.TabIndex = 8;
            this.客户名称TextEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.客户名称TextEdit_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.emptySpaceItem4,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem8,
            this.emptySpaceItem5,
            this.simpleLabelItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1271, 806);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.客户名称TextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(503, 36);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(503, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(503, 36);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "客户名称:";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vw_ContractReceivablesPeriodGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1251, 714);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(216, 36);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1035, 36);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnQuery;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(99, 36);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(99, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(99, 36);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnClear;
            this.layoutControlItem2.Location = new System.Drawing.Point(117, 36);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(99, 36);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(99, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(99, 36);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(99, 36);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(18, 36);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.签约日期DateEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(527, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(278, 36);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(278, 36);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(278, 36);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "签约日期:";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(1087, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(164, 36);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.签约日期DateEdit2;
            this.layoutControlItem8.Location = new System.Drawing.Point(900, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(187, 36);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(187, 36);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(187, 36);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "到";
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(503, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(24, 36);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem2.Location = new System.Drawing.Point(805, 0);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(95, 36);
            this.simpleLabelItem2.Text = "到";
            // 
            // FrmContractReceivables
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 806);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmContractReceivables";
            this.Text = "合同应收款";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vw_ContractReceivablesPeriodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ContractReceivablesPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl vw_ContractReceivablesPeriodGridControl;
        private System.Windows.Forms.BindingSource vw_ContractReceivablesPeriodBindingSource;
        private ContractDataSet contractDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col签约日期;
        private DevExpress.XtraGrid.Columns.GridColumn col最后收款日期;
        private DevExpress.XtraGrid.Columns.GridColumn col应收款金额;
        private DevExpress.XtraGrid.Columns.GridColumn col合同金额;
        private DevExpress.XtraGrid.Columns.GridColumn col累计已收款金额;
        private DevExpress.XtraGrid.Columns.GridColumn colCID;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.DateEdit 签约日期DateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit 签约日期DateEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraEditors.ButtonEdit 客户名称TextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 客户名称HyperLinkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 合同编号HyperLinkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn col已收一次性服务费;
        private DevExpress.XtraGrid.Columns.GridColumn col已收周期性服务费;
        private DevExpress.XtraGrid.Columns.GridColumn col续签;
    }
}