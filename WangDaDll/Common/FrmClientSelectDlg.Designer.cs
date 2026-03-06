using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmClientSelectDlg
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
            this.btnSaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.tW_ClientGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csDataSet = new WangDaDll.Common.CsDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司地址 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户姓名 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col出生日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col联系电话 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col初始做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收费标准 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户分级 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col费用到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSaveLayout);
            this.layoutControl1.Controls.Add(this.tW_ClientGridControl);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnOK);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(2280, 1483);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(399, 18);
            this.btnSaveLayout.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(133, 33);
            this.btnSaveLayout.StyleController = this.layoutControl1;
            this.btnSaveLayout.TabIndex = 7;
            this.btnSaveLayout.Text = "保存样式";
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // tW_ClientGridControl
            // 
            this.tW_ClientGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_ClientGridControl.DataSource = this.tW_ClientBindingSource;
            this.tW_ClientGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(843, 216, 843, 216);
            this.tW_ClientGridControl.Location = new System.Drawing.Point(18, 57);
            this.tW_ClientGridControl.MainView = this.gridView1;
            this.tW_ClientGridControl.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.tW_ClientGridControl.Name = "tW_ClientGridControl";
            this.tW_ClientGridControl.Size = new System.Drawing.Size(2244, 1408);
            this.tW_ClientGridControl.TabIndex = 6;
            this.tW_ClientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tW_ClientBindingSource
            // 
            this.tW_ClientBindingSource.DataMember = "TW_Client";
            this.tW_ClientBindingSource.DataSource = this.csDataSet;
            // 
            // csDataSet
            // 
            this.csDataSet.DataSetName = "CsDataSet";
            this.csDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
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
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
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
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col客户名称,
            this.col公司性质,
            this.col公司类型,
            this.col公司地址,
            this.col客户姓名,
            this.col出生日期,
            this.col联系电话,
            this.col做账会计,
            this.col初始做账时间,
            this.col收费标准,
            this.col客户分级,
            this.col注册员,
            this.col业务员,
            this.col修改人,
            this.col修改时间,
            this.col做账时间,
            this.col零申报,
            this.col费用到期月份});
            this.gridView1.DetailHeight = 525;
            this.gridView1.GridControl = this.tW_ClientGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.MinWidth = 30;
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.AllowEdit = false;
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 0;
            this.col客户名称.Width = 471;
            // 
            // col公司性质
            // 
            this.col公司性质.FieldName = "公司性质";
            this.col公司性质.MinWidth = 30;
            this.col公司性质.Name = "col公司性质";
            this.col公司性质.OptionsColumn.AllowEdit = false;
            this.col公司性质.OptionsColumn.ReadOnly = true;
            this.col公司性质.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司性质.Visible = true;
            this.col公司性质.VisibleIndex = 1;
            this.col公司性质.Width = 112;
            // 
            // col公司类型
            // 
            this.col公司类型.FieldName = "公司类型";
            this.col公司类型.MinWidth = 30;
            this.col公司类型.Name = "col公司类型";
            this.col公司类型.OptionsColumn.AllowEdit = false;
            this.col公司类型.OptionsColumn.ReadOnly = true;
            this.col公司类型.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司类型.Visible = true;
            this.col公司类型.VisibleIndex = 2;
            this.col公司类型.Width = 112;
            // 
            // col公司地址
            // 
            this.col公司地址.FieldName = "公司地址";
            this.col公司地址.MinWidth = 30;
            this.col公司地址.Name = "col公司地址";
            this.col公司地址.OptionsColumn.AllowEdit = false;
            this.col公司地址.OptionsColumn.ReadOnly = true;
            this.col公司地址.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司地址.Visible = true;
            this.col公司地址.VisibleIndex = 3;
            this.col公司地址.Width = 112;
            // 
            // col客户姓名
            // 
            this.col客户姓名.FieldName = "客户姓名";
            this.col客户姓名.MinWidth = 30;
            this.col客户姓名.Name = "col客户姓名";
            this.col客户姓名.OptionsColumn.AllowEdit = false;
            this.col客户姓名.OptionsColumn.ReadOnly = true;
            this.col客户姓名.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户姓名.Visible = true;
            this.col客户姓名.VisibleIndex = 4;
            this.col客户姓名.Width = 112;
            // 
            // col出生日期
            // 
            this.col出生日期.FieldName = "出生日期";
            this.col出生日期.MinWidth = 30;
            this.col出生日期.Name = "col出生日期";
            this.col出生日期.OptionsColumn.AllowEdit = false;
            this.col出生日期.OptionsColumn.ReadOnly = true;
            this.col出生日期.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col出生日期.Width = 112;
            // 
            // col联系电话
            // 
            this.col联系电话.FieldName = "联系电话";
            this.col联系电话.MinWidth = 30;
            this.col联系电话.Name = "col联系电话";
            this.col联系电话.OptionsColumn.AllowEdit = false;
            this.col联系电话.OptionsColumn.ReadOnly = true;
            this.col联系电话.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col联系电话.Visible = true;
            this.col联系电话.VisibleIndex = 7;
            this.col联系电话.Width = 112;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.MinWidth = 30;
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.AllowEdit = false;
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 8;
            this.col做账会计.Width = 112;
            // 
            // col初始做账时间
            // 
            this.col初始做账时间.FieldName = "初始做账时间";
            this.col初始做账时间.MinWidth = 30;
            this.col初始做账时间.Name = "col初始做账时间";
            this.col初始做账时间.OptionsColumn.AllowEdit = false;
            this.col初始做账时间.OptionsColumn.ReadOnly = true;
            this.col初始做账时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col初始做账时间.Visible = true;
            this.col初始做账时间.VisibleIndex = 9;
            this.col初始做账时间.Width = 138;
            // 
            // col收费标准
            // 
            this.col收费标准.FieldName = "收费标准";
            this.col收费标准.MinWidth = 30;
            this.col收费标准.Name = "col收费标准";
            this.col收费标准.OptionsColumn.AllowEdit = false;
            this.col收费标准.OptionsColumn.ReadOnly = true;
            this.col收费标准.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col收费标准.Visible = true;
            this.col收费标准.VisibleIndex = 6;
            this.col收费标准.Width = 112;
            // 
            // col客户分级
            // 
            this.col客户分级.FieldName = "客户分级";
            this.col客户分级.MinWidth = 30;
            this.col客户分级.Name = "col客户分级";
            this.col客户分级.OptionsColumn.AllowEdit = false;
            this.col客户分级.OptionsColumn.ReadOnly = true;
            this.col客户分级.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户分级.Visible = true;
            this.col客户分级.VisibleIndex = 10;
            this.col客户分级.Width = 112;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.MinWidth = 30;
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.AllowEdit = false;
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 11;
            this.col注册员.Width = 112;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.MinWidth = 30;
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.AllowEdit = false;
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 12;
            this.col业务员.Width = 112;
            // 
            // col修改人
            // 
            this.col修改人.FieldName = "修改人";
            this.col修改人.MinWidth = 30;
            this.col修改人.Name = "col修改人";
            this.col修改人.OptionsColumn.AllowEdit = false;
            this.col修改人.OptionsColumn.ReadOnly = true;
            this.col修改人.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改人.Visible = true;
            this.col修改人.VisibleIndex = 13;
            this.col修改人.Width = 112;
            // 
            // col修改时间
            // 
            this.col修改时间.FieldName = "修改时间";
            this.col修改时间.MinWidth = 30;
            this.col修改时间.Name = "col修改时间";
            this.col修改时间.OptionsColumn.AllowEdit = false;
            this.col修改时间.OptionsColumn.ReadOnly = true;
            this.col修改时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改时间.Visible = true;
            this.col修改时间.VisibleIndex = 14;
            this.col修改时间.Width = 112;
            // 
            // col做账时间
            // 
            this.col做账时间.FieldName = "做账时间";
            this.col做账时间.MinWidth = 30;
            this.col做账时间.Name = "col做账时间";
            this.col做账时间.OptionsColumn.AllowEdit = false;
            this.col做账时间.OptionsColumn.ReadOnly = true;
            this.col做账时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账时间.Visible = true;
            this.col做账时间.VisibleIndex = 15;
            this.col做账时间.Width = 112;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.MinWidth = 30;
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 16;
            this.col零申报.Width = 112;
            // 
            // col费用到期月份
            // 
            this.col费用到期月份.FieldName = "费用到期月份";
            this.col费用到期月份.MinWidth = 30;
            this.col费用到期月份.Name = "col费用到期月份";
            this.col费用到期月份.OptionsColumn.ReadOnly = true;
            this.col费用到期月份.Visible = true;
            this.col费用到期月份.VisibleIndex = 5;
            this.col费用到期月份.Width = 138;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(145, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 33);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(18, 18);
            this.btnOK.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 33);
            this.btnOK.StyleController = this.layoutControl1;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(2280, 1483);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnOK;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(127, 39);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(127, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(127, 39);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tW_ClientGridControl;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 39);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(2250, 1414);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(520, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1730, 39);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSaveLayout;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(381, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(139, 39);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(139, 39);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(139, 39);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(272, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 33);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "添加新客户";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(254, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(127, 39);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(127, 39);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmClientSelectDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(2280, 1483);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.Name = "FrmClientSelectDlg";
            this.Text = "选择客户单位";
            this.Load += new System.EventHandler(this.FrmClientSelectDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl tW_ClientGridControl;
        private System.Windows.Forms.BindingSource tW_ClientBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col公司性质;
        private DevExpress.XtraGrid.Columns.GridColumn col公司类型;
        private DevExpress.XtraGrid.Columns.GridColumn col公司地址;
        private DevExpress.XtraGrid.Columns.GridColumn col客户姓名;
        private DevExpress.XtraGrid.Columns.GridColumn col出生日期;
        private DevExpress.XtraGrid.Columns.GridColumn col联系电话;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col初始做账时间;
        private DevExpress.XtraGrid.Columns.GridColumn col收费标准;
        private DevExpress.XtraGrid.Columns.GridColumn col客户分级;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col修改人;
        private DevExpress.XtraGrid.Columns.GridColumn col修改时间;
        private DevExpress.XtraGrid.Columns.GridColumn col做账时间;
        public CsDataSet csDataSet;
        private DevExpress.XtraEditors.SimpleButton btnSaveLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraGrid.Columns.GridColumn col费用到期月份;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}