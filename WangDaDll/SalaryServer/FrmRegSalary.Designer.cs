using WangDaDll.SalaryServer;

namespace WangDaDll
{
    partial class FrmRegSalary
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
            this.salaryDataSet = new WangDaDll.SalaryServer.SalaryDataSet();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSCYJ = new DevExpress.XtraEditors.SimpleButton();
            this.vW_AllBusinessSalaryGridControl = new DevExpress.XtraGrid.GridControl();
            this.vW_AllBusinessSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_AllBusinessSalaryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col员工 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col团队提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col提成汇总 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShowDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.monthComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.YearComboBoxEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vW_AllBusinessSalaryYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.tW_SalarySumBindingSourceYW = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSetYW = new WangDaDll.SalaryServer.SalaryDataSet();
            this.col业务提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_SalarySumBindingSourceYW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetYW)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "SalaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSCYJ);
            this.layoutControl1.Controls.Add(this.vW_AllBusinessSalaryGridControl);
            this.layoutControl1.Controls.Add(this.btnShowDetail);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.monthComboBoxEdit);
            this.layoutControl1.Controls.Add(this.YearComboBoxEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(844, 592);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSCYJ
            // 
            this.btnSCYJ.Location = new System.Drawing.Point(291, 36);
            this.btnSCYJ.Name = "btnSCYJ";
            this.btnSCYJ.Size = new System.Drawing.Size(89, 22);
            this.btnSCYJ.StyleController = this.layoutControl1;
            this.btnSCYJ.TabIndex = 10;
            this.btnSCYJ.Text = "生成业绩";
            this.btnSCYJ.Click += new System.EventHandler(this.btnSCYJ_Click);
            // 
            // vW_AllBusinessSalaryGridControl
            // 
            this.vW_AllBusinessSalaryGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.vW_AllBusinessSalaryGridControl.DataSource = this.vW_AllBusinessSalaryBindingSource;
            this.vW_AllBusinessSalaryGridControl.Location = new System.Drawing.Point(12, 62);
            this.vW_AllBusinessSalaryGridControl.MainView = this.vW_AllBusinessSalaryGridView;
            this.vW_AllBusinessSalaryGridControl.Name = "vW_AllBusinessSalaryGridControl";
            this.vW_AllBusinessSalaryGridControl.Size = new System.Drawing.Size(820, 518);
            this.vW_AllBusinessSalaryGridControl.TabIndex = 0;
            this.vW_AllBusinessSalaryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vW_AllBusinessSalaryGridView});
            this.vW_AllBusinessSalaryGridControl.DoubleClick += new System.EventHandler(this.vW_AllBusinessSalaryGridControl_DoubleClick);
            // 
            // vW_AllBusinessSalaryBindingSource
            // 
            this.vW_AllBusinessSalaryBindingSource.DataMember = "VW_AllBusinessSalary";
            this.vW_AllBusinessSalaryBindingSource.DataSource = this.salaryDataSet;
            // 
            // vW_AllBusinessSalaryGridView
            // 
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.Empty.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupButton.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.Options.UseFont = true;
            this.vW_AllBusinessSalaryGridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.vW_AllBusinessSalaryGridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.vW_AllBusinessSalaryGridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.vW_AllBusinessSalaryGridView.Appearance.Preview.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.Preview.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vW_AllBusinessSalaryGridView.Appearance.Row.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.Row.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.vW_AllBusinessSalaryGridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.vW_AllBusinessSalaryGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.vW_AllBusinessSalaryGridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.vW_AllBusinessSalaryGridView.Appearance.VertLine.Options.UseBackColor = true;
            this.vW_AllBusinessSalaryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col员工,
            this.col做账收款额,
            this.col做账提成,
            this.col注册提成,
            this.col团队提成,
            this.col提成汇总,
            this.col业务提成});
            this.vW_AllBusinessSalaryGridView.GridControl = this.vW_AllBusinessSalaryGridControl;
            this.vW_AllBusinessSalaryGridView.Name = "vW_AllBusinessSalaryGridView";
            this.vW_AllBusinessSalaryGridView.OptionsView.ColumnAutoWidth = false;
            this.vW_AllBusinessSalaryGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.vW_AllBusinessSalaryGridView.OptionsView.EnableAppearanceOddRow = true;
            this.vW_AllBusinessSalaryGridView.OptionsView.ShowAutoFilterRow = true;
            this.vW_AllBusinessSalaryGridView.OptionsView.ShowFooter = true;
            this.vW_AllBusinessSalaryGridView.PaintStyleName = "Flat";
            // 
            // col员工
            // 
            this.col员工.FieldName = "员工";
            this.col员工.Name = "col员工";
            this.col员工.OptionsColumn.ReadOnly = true;
            this.col员工.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col员工.Visible = true;
            this.col员工.VisibleIndex = 0;
            // 
            // col做账收款额
            // 
            this.col做账收款额.FieldName = "做账收款额";
            this.col做账收款额.Name = "col做账收款额";
            this.col做账收款额.OptionsColumn.ReadOnly = true;
            this.col做账收款额.Visible = true;
            this.col做账收款额.VisibleIndex = 1;
            // 
            // col做账提成
            // 
            this.col做账提成.FieldName = "做账提成";
            this.col做账提成.Name = "col做账提成";
            this.col做账提成.OptionsColumn.ReadOnly = true;
            this.col做账提成.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账提成", "{0:0.##}")});
            this.col做账提成.Visible = true;
            this.col做账提成.VisibleIndex = 2;
            // 
            // col注册提成
            // 
            this.col注册提成.FieldName = "注册提成";
            this.col注册提成.Name = "col注册提成";
            this.col注册提成.OptionsColumn.ReadOnly = true;
            this.col注册提成.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册提成", "{0:0.##}")});
            this.col注册提成.Visible = true;
            this.col注册提成.VisibleIndex = 3;
            // 
            // col团队提成
            // 
            this.col团队提成.FieldName = "团队提成";
            this.col团队提成.Name = "col团队提成";
            this.col团队提成.OptionsColumn.ReadOnly = true;
            this.col团队提成.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col团队提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "团队提成", "{0:0.##}")});
            this.col团队提成.Visible = true;
            this.col团队提成.VisibleIndex = 4;
            // 
            // col提成汇总
            // 
            this.col提成汇总.FieldName = "提成汇总";
            this.col提成汇总.Name = "col提成汇总";
            this.col提成汇总.OptionsColumn.ReadOnly = true;
            this.col提成汇总.Visible = true;
            this.col提成汇总.VisibleIndex = 6;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Location = new System.Drawing.Point(198, 36);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(89, 22);
            this.btnShowDetail.StyleController = this.layoutControl1;
            this.btnShowDetail.TabIndex = 9;
            this.btnShowDetail.Text = "查看明细";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 36);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // monthComboBoxEdit
            // 
            this.monthComboBoxEdit.Location = new System.Drawing.Point(161, 12);
            this.monthComboBoxEdit.Name = "monthComboBoxEdit";
            this.monthComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthComboBoxEdit.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthComboBoxEdit.Size = new System.Drawing.Size(86, 20);
            this.monthComboBoxEdit.StyleController = this.layoutControl1;
            this.monthComboBoxEdit.TabIndex = 6;
            // 
            // YearComboBoxEdit
            // 
            this.YearComboBoxEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.YearComboBoxEdit.Location = new System.Drawing.Point(31, 12);
            this.YearComboBoxEdit.Name = "YearComboBoxEdit";
            this.YearComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.YearComboBoxEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.YearComboBoxEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.YearComboBoxEdit.Size = new System.Drawing.Size(107, 20);
            this.YearComboBoxEdit.StyleController = this.layoutControl1;
            this.YearComboBoxEdit.TabIndex = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSCYJ;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(279, 24);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(844, 592);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(239, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(585, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(279, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(545, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.monthComboBoxEdit;
            this.layoutControlItem3.CustomizationFormText = "月:";
            this.layoutControlItem3.Location = new System.Drawing.Point(130, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(109, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(109, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "月:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(16, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.YearComboBoxEdit;
            this.layoutControlItem2.CustomizationFormText = "年:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(130, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "年:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(16, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClear;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(93, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnQuery;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnShowDetail;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(186, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.vW_AllBusinessSalaryGridControl;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(824, 522);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // vW_AllBusinessSalaryYearBindingSource
            // 
            this.vW_AllBusinessSalaryYearBindingSource.DataMember = "VW_AllBusinessSalaryYear";
            this.vW_AllBusinessSalaryYearBindingSource.DataSource = this.salaryDataSet;
            // 
            // tW_SalarySumBindingSourceYW
            // 
            this.tW_SalarySumBindingSourceYW.DataMember = "TW_SalarySum";
            this.tW_SalarySumBindingSourceYW.DataSource = this.salaryDataSetYW;
            // 
            // salaryDataSetYW
            // 
            this.salaryDataSetYW.DataSetName = "SalaryDataSet";
            this.salaryDataSetYW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // col业务提成
            // 
            this.col业务提成.FieldName = "业务提成";
            this.col业务提成.Name = "col业务提成";
            this.col业务提成.OptionsColumn.ReadOnly = true;
            this.col业务提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务提成", "{0:0.##}")});
            this.col业务提成.Visible = true;
            this.col业务提成.VisibleIndex = 5;
            // 
            // FrmRegSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 592);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmRegSalary";
            this.Text = "注册员业绩统计";
            this.Load += new System.EventHandler(this.FrmRegSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllBusinessSalaryYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_SalarySumBindingSourceYW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetYW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SalaryDataSet salaryDataSet;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit monthComboBoxEdit;
        private DevExpress.XtraEditors.SpinEdit YearComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource vW_AllBusinessSalaryYearBindingSource;
        private DevExpress.XtraGrid.GridControl vW_AllBusinessSalaryGridControl;
        private System.Windows.Forms.BindingSource vW_AllBusinessSalaryBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView vW_AllBusinessSalaryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn col员工;
        private DevExpress.XtraGrid.Columns.GridColumn col做账提成;
        private DevExpress.XtraGrid.Columns.GridColumn col注册提成;
        private DevExpress.XtraGrid.Columns.GridColumn col团队提成;
        private DevExpress.XtraEditors.SimpleButton btnShowDetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn col做账收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col提成汇总;
        private DevExpress.XtraEditors.SimpleButton btnSCYJ;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tW_SalarySumBindingSourceYW;
        private SalaryDataSet salaryDataSetYW;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private DevExpress.XtraGrid.Columns.GridColumn col业务提成;
    }
}