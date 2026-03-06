namespace WangDaDll
{
    partial class FrmContractChangedRc
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
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.tW_ContractChangedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tW_ContractChangedGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.合同编号HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col变更原因及说明 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批状态 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批结果 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审批时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col创建人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col创建时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col原单价 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col新单价 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col涨价 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col变更月数 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.客户名称HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.创建时间DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.创建时间DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.合同编号textEdit = new DevExpress.XtraEditors.TextEdit();
            this.客户名称textEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnApproval = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.编辑Item = new DevExpress.XtraLayout.LayoutControlItem();
            this.审批Item = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnZS = new DevExpress.XtraEditors.SimpleButton();
            this.终身lItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractChangedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractChangedGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.编辑Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.审批Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.终身lItem)).BeginInit();
            this.SuspendLayout();
            // 
            // contractDataSet
            // 
            this.contractDataSet.DataSetName = "ContractDataSet";
            this.contractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tW_ContractChangedBindingSource
            // 
            this.tW_ContractChangedBindingSource.DataMember = "TW_ContractChanged";
            this.tW_ContractChangedBindingSource.DataSource = this.contractDataSet;
            // 
            // tW_ContractChangedGridControl
            // 
            this.tW_ContractChangedGridControl.DataSource = this.tW_ContractChangedBindingSource;
            this.tW_ContractChangedGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tW_ContractChangedGridControl.Location = new System.Drawing.Point(12, 93);
            this.tW_ContractChangedGridControl.MainView = this.gridView1;
            this.tW_ContractChangedGridControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tW_ContractChangedGridControl.Name = "tW_ContractChangedGridControl";
            this.tW_ContractChangedGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.客户名称HyperLinkEdit,
            this.合同编号HyperLinkEdit});
            this.tW_ContractChangedGridControl.Size = new System.Drawing.Size(1423, 678);
            this.tW_ContractChangedGridControl.TabIndex = 1;
            this.tW_ContractChangedGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.col变更原因及说明,
            this.col审批人,
            this.col审批状态,
            this.col审批结果,
            this.col审批时间,
            this.col创建人,
            this.col创建时间,
            this.col原单价,
            this.col新单价,
            this.col涨价,
            this.col变更月数,
            this.col客户名称});
            this.gridView1.DetailHeight = 550;
            this.gridView1.GridControl = this.tW_ContractChangedGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1143;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.PaintStyleName = "Style3D";
            // 
            // col合同编号
            // 
            this.col合同编号.ColumnEdit = this.合同编号HyperLinkEdit;
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.MinWidth = 29;
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.OptionsColumn.ReadOnly = true;
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 0;
            this.col合同编号.Width = 152;
            // 
            // 合同编号HyperLinkEdit
            // 
            this.合同编号HyperLinkEdit.AutoHeight = false;
            this.合同编号HyperLinkEdit.Name = "合同编号HyperLinkEdit";
            this.合同编号HyperLinkEdit.DoubleClick += new System.EventHandler(this.合同编号HyperLinkEdit_DoubleClick);
            // 
            // col变更原因及说明
            // 
            this.col变更原因及说明.FieldName = "变更原因及说明";
            this.col变更原因及说明.MinWidth = 29;
            this.col变更原因及说明.Name = "col变更原因及说明";
            this.col变更原因及说明.OptionsColumn.AllowEdit = false;
            this.col变更原因及说明.OptionsColumn.ReadOnly = true;
            this.col变更原因及说明.Visible = true;
            this.col变更原因及说明.VisibleIndex = 2;
            this.col变更原因及说明.Width = 271;
            // 
            // col审批人
            // 
            this.col审批人.FieldName = "审批人";
            this.col审批人.MinWidth = 29;
            this.col审批人.Name = "col审批人";
            this.col审批人.OptionsColumn.AllowEdit = false;
            this.col审批人.OptionsColumn.ReadOnly = true;
            this.col审批人.Visible = true;
            this.col审批人.VisibleIndex = 10;
            this.col审批人.Width = 88;
            // 
            // col审批状态
            // 
            this.col审批状态.FieldName = "审批状态";
            this.col审批状态.MinWidth = 29;
            this.col审批状态.Name = "col审批状态";
            this.col审批状态.OptionsColumn.AllowEdit = false;
            this.col审批状态.OptionsColumn.ReadOnly = true;
            this.col审批状态.Visible = true;
            this.col审批状态.VisibleIndex = 7;
            this.col审批状态.Width = 117;
            // 
            // col审批结果
            // 
            this.col审批结果.FieldName = "审批结果";
            this.col审批结果.MinWidth = 29;
            this.col审批结果.Name = "col审批结果";
            this.col审批结果.OptionsColumn.AllowEdit = false;
            this.col审批结果.OptionsColumn.ReadOnly = true;
            this.col审批结果.Visible = true;
            this.col审批结果.VisibleIndex = 8;
            this.col审批结果.Width = 113;
            // 
            // col审批时间
            // 
            this.col审批时间.FieldName = "审批时间";
            this.col审批时间.MinWidth = 29;
            this.col审批时间.Name = "col审批时间";
            this.col审批时间.OptionsColumn.AllowEdit = false;
            this.col审批时间.OptionsColumn.ReadOnly = true;
            this.col审批时间.Visible = true;
            this.col审批时间.VisibleIndex = 9;
            this.col审批时间.Width = 119;
            // 
            // col创建人
            // 
            this.col创建人.Caption = "申请人";
            this.col创建人.FieldName = "创建人";
            this.col创建人.MinWidth = 29;
            this.col创建人.Name = "col创建人";
            this.col创建人.OptionsColumn.AllowEdit = false;
            this.col创建人.OptionsColumn.ReadOnly = true;
            this.col创建人.Visible = true;
            this.col创建人.VisibleIndex = 11;
            this.col创建人.Width = 88;
            // 
            // col创建时间
            // 
            this.col创建时间.Caption = "申请时间";
            this.col创建时间.FieldName = "创建时间";
            this.col创建时间.MinWidth = 29;
            this.col创建时间.Name = "col创建时间";
            this.col创建时间.OptionsColumn.AllowEdit = false;
            this.col创建时间.OptionsColumn.ReadOnly = true;
            this.col创建时间.Visible = true;
            this.col创建时间.VisibleIndex = 12;
            this.col创建时间.Width = 134;
            // 
            // col原单价
            // 
            this.col原单价.FieldName = "原单价";
            this.col原单价.MinWidth = 30;
            this.col原单价.Name = "col原单价";
            this.col原单价.OptionsColumn.ReadOnly = true;
            this.col原单价.Visible = true;
            this.col原单价.VisibleIndex = 3;
            this.col原单价.Width = 121;
            // 
            // col新单价
            // 
            this.col新单价.FieldName = "新单价";
            this.col新单价.MinWidth = 30;
            this.col新单价.Name = "col新单价";
            this.col新单价.OptionsColumn.ReadOnly = true;
            this.col新单价.Visible = true;
            this.col新单价.VisibleIndex = 4;
            this.col新单价.Width = 121;
            // 
            // col涨价
            // 
            this.col涨价.FieldName = "涨价";
            this.col涨价.MinWidth = 30;
            this.col涨价.Name = "col涨价";
            this.col涨价.OptionsColumn.ReadOnly = true;
            this.col涨价.Visible = true;
            this.col涨价.VisibleIndex = 5;
            this.col涨价.Width = 121;
            // 
            // col变更月数
            // 
            this.col变更月数.FieldName = "变更月数";
            this.col变更月数.MinWidth = 30;
            this.col变更月数.Name = "col变更月数";
            this.col变更月数.OptionsColumn.ReadOnly = true;
            this.col变更月数.Visible = true;
            this.col变更月数.VisibleIndex = 6;
            this.col变更月数.Width = 121;
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
            this.col客户名称.Width = 316;
            // 
            // 客户名称HyperLinkEdit
            // 
            this.客户名称HyperLinkEdit.AutoHeight = false;
            this.客户名称HyperLinkEdit.Name = "客户名称HyperLinkEdit";
            this.客户名称HyperLinkEdit.DoubleClick += new System.EventHandler(this.客户名称HyperLinkEdit_DoubleClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.创建时间DateEdit1);
            this.layoutControl1.Controls.Add(this.创建时间DateEdit);
            this.layoutControl1.Controls.Add(this.tW_ContractChangedGridControl);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.合同编号textEdit);
            this.layoutControl1.Controls.Add(this.客户名称textEdit);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnApproval);
            this.layoutControl1.Controls.Add(this.btnZS);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1447, 783);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // 创建时间DateEdit1
            // 
            this.创建时间DateEdit1.EditValue = null;
            this.创建时间DateEdit1.Location = new System.Drawing.Point(481, 54);
            this.创建时间DateEdit1.Name = "创建时间DateEdit1";
            this.创建时间DateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.创建时间DateEdit1.Properties.Appearance.Options.UseFont = true;
            this.创建时间DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.创建时间DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.创建时间DateEdit1.Size = new System.Drawing.Size(225, 32);
            this.创建时间DateEdit1.StyleController = this.layoutControl1;
            this.创建时间DateEdit1.TabIndex = 10;
            // 
            // 创建时间DateEdit
            // 
            this.创建时间DateEdit.EditValue = null;
            this.创建时间DateEdit.Location = new System.Drawing.Point(131, 54);
            this.创建时间DateEdit.Name = "创建时间DateEdit";
            this.创建时间DateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.创建时间DateEdit.Properties.Appearance.Options.UseFont = true;
            this.创建时间DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.创建时间DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.创建时间DateEdit.Size = new System.Drawing.Size(225, 32);
            this.创建时间DateEdit.StyleController = this.layoutControl1;
            this.创建时间DateEdit.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(712, 52);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(136, 37);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // 合同编号textEdit
            // 
            this.合同编号textEdit.Location = new System.Drawing.Point(131, 14);
            this.合同编号textEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.合同编号textEdit.Name = "合同编号textEdit";
            this.合同编号textEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.合同编号textEdit.Properties.Appearance.Options.UseFont = true;
            this.合同编号textEdit.Size = new System.Drawing.Size(225, 32);
            this.合同编号textEdit.StyleController = this.layoutControl1;
            this.合同编号textEdit.TabIndex = 6;
            // 
            // 客户名称textEdit
            // 
            this.客户名称textEdit.Location = new System.Drawing.Point(481, 14);
            this.客户名称textEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.客户名称textEdit.Name = "客户名称textEdit";
            this.客户名称textEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.客户名称textEdit.Properties.Appearance.Options.UseFont = true;
            this.客户名称textEdit.Size = new System.Drawing.Size(462, 32);
            this.客户名称textEdit.StyleController = this.layoutControl1;
            this.客户名称textEdit.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(852, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 37);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(994, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 33);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnApproval
            // 
            this.btnApproval.Location = new System.Drawing.Point(1134, 54);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(132, 33);
            this.btnApproval.StyleController = this.layoutControl1;
            this.btnApproval.TabIndex = 13;
            this.btnApproval.Text = "审批";
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.编辑Item,
            this.审批Item,
            this.emptySpaceItem2,
            this.终身lItem});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1447, 783);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_ContractChangedGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1427, 682);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.合同编号textEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 40);
            this.layoutControlItem4.Text = "合同编号：";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.客户名称textEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(350, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(587, 38);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(587, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(587, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "客户名称：";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(937, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(490, 40);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.创建时间DateEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(350, 41);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(350, 41);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(350, 41);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "变更时间：";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.创建时间DateEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(350, 40);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(350, 41);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(350, 41);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(350, 41);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "到：";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnQuery;
            this.layoutControlItem3.Location = new System.Drawing.Point(700, 40);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(140, 41);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(140, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 41);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnClear;
            this.layoutControlItem2.Location = new System.Drawing.Point(840, 40);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(140, 41);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(140, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(140, 41);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextVisible = false;
            // 
            // 编辑Item
            // 
            this.编辑Item.Control = this.btnEdit;
            this.编辑Item.Location = new System.Drawing.Point(980, 40);
            this.编辑Item.MaxSize = new System.Drawing.Size(140, 41);
            this.编辑Item.MinSize = new System.Drawing.Size(140, 41);
            this.编辑Item.Name = "编辑Item";
            this.编辑Item.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.编辑Item.Size = new System.Drawing.Size(140, 41);
            this.编辑Item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.编辑Item.TextVisible = false;
            // 
            // 审批Item
            // 
            this.审批Item.Control = this.btnApproval;
            this.审批Item.Location = new System.Drawing.Point(1120, 40);
            this.审批Item.MaxSize = new System.Drawing.Size(140, 41);
            this.审批Item.MinSize = new System.Drawing.Size(140, 41);
            this.审批Item.Name = "审批Item";
            this.审批Item.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.审批Item.Size = new System.Drawing.Size(140, 41);
            this.审批Item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.审批Item.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(1390, 40);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(37, 41);
            // 
            // btnZS
            // 
            this.btnZS.Location = new System.Drawing.Point(1274, 54);
            this.btnZS.Name = "btnZS";
            this.btnZS.Size = new System.Drawing.Size(122, 33);
            this.btnZS.StyleController = this.layoutControl1;
            this.btnZS.TabIndex = 14;
            this.btnZS.Text = "终审";
            this.btnZS.Click += new System.EventHandler(this.btnZS_Click);
            // 
            // 终身lItem
            // 
            this.终身lItem.Control = this.btnZS;
            this.终身lItem.Location = new System.Drawing.Point(1260, 40);
            this.终身lItem.MaxSize = new System.Drawing.Size(130, 41);
            this.终身lItem.MinSize = new System.Drawing.Size(130, 41);
            this.终身lItem.Name = "终身lItem";
            this.终身lItem.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.终身lItem.Size = new System.Drawing.Size(130, 41);
            this.终身lItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.终身lItem.TextVisible = false;
            // 
            // FrmContractChangedRc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 783);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmContractChangedRc";
            this.Text = "合同金额变更记录";
            this.Load += new System.EventHandler(this.FrmContractChangedRc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractChangedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ContractChangedGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建时间DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.编辑Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.审批Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.终身lItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Contract.ContractDataSet contractDataSet;
        private System.Windows.Forms.BindingSource tW_ContractChangedBindingSource;
        private DevExpress.XtraGrid.GridControl tW_ContractChangedGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col变更原因及说明;
        private DevExpress.XtraGrid.Columns.GridColumn col审批人;
        private DevExpress.XtraGrid.Columns.GridColumn col审批状态;
        private DevExpress.XtraGrid.Columns.GridColumn col审批结果;
        private DevExpress.XtraGrid.Columns.GridColumn col审批时间;
        private DevExpress.XtraGrid.Columns.GridColumn col创建人;
        private DevExpress.XtraGrid.Columns.GridColumn col创建时间;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit 合同编号textEdit;
        private DevExpress.XtraEditors.TextEdit 客户名称textEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col原单价;
        private DevExpress.XtraGrid.Columns.GridColumn col新单价;
        private DevExpress.XtraGrid.Columns.GridColumn col涨价;
        private DevExpress.XtraGrid.Columns.GridColumn col变更月数;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraEditors.DateEdit 创建时间DateEdit1;
        private DevExpress.XtraEditors.DateEdit 创建时间DateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 客户名称HyperLinkEdit;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem 编辑Item;
        private DevExpress.XtraEditors.SimpleButton btnApproval;
        private DevExpress.XtraLayout.LayoutControlItem 审批Item;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 合同编号HyperLinkEdit;
        private DevExpress.XtraEditors.SimpleButton btnZS;
        private DevExpress.XtraLayout.LayoutControlItem 终身lItem;
    }
}