using WangDaDll.SalaryServer;

namespace WangDaDll
{
    partial class FrmAccountantSalaryDetail2022
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
            this.btnExp = new DevExpress.XtraEditors.SimpleButton();
            this.vW_AllAccountantSalaryDetailGridControl = new DevExpress.XtraGrid.GridControl();
            this.vW_AllAccountantSalaryDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet = new WangDaDll.SalaryServer.SalaryDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col员工 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本收款费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票收款费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col年做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工资统计类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开始时间1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col结束时间1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col操作时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.xlsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryDetailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExp);
            this.layoutControl1.Controls.Add(this.vW_AllAccountantSalaryDetailGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-8, -8, 1936, 1096);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1413, 764);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(18, 18);
            this.btnExp.Margin = new System.Windows.Forms.Padding(62, 21, 62, 21);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(153, 37);
            this.btnExp.StyleController = this.layoutControl1;
            this.btnExp.TabIndex = 9;
            this.btnExp.Text = "导出";
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // vW_AllAccountantSalaryDetailGridControl
            // 
            this.vW_AllAccountantSalaryDetailGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.vW_AllAccountantSalaryDetailGridControl.DataSource = this.vW_AllAccountantSalaryDetailBindingSource;
            this.vW_AllAccountantSalaryDetailGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(843, 216, 843, 216);
            this.vW_AllAccountantSalaryDetailGridControl.Location = new System.Drawing.Point(18, 61);
            this.vW_AllAccountantSalaryDetailGridControl.MainView = this.gridView1;
            this.vW_AllAccountantSalaryDetailGridControl.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.vW_AllAccountantSalaryDetailGridControl.Name = "vW_AllAccountantSalaryDetailGridControl";
            this.vW_AllAccountantSalaryDetailGridControl.Size = new System.Drawing.Size(1377, 685);
            this.vW_AllAccountantSalaryDetailGridControl.TabIndex = 4;
            this.vW_AllAccountantSalaryDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vW_AllAccountantSalaryDetailBindingSource
            // 
            this.vW_AllAccountantSalaryDetailBindingSource.DataMember = "VW_AllAccountantSalaryDetail";
            this.vW_AllAccountantSalaryDetailBindingSource.DataSource = this.salaryDataSet;
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "SalaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.col员工,
            this.col客户名称,
            this.col做账收款额,
            this.col工本收款费,
            this.col开票收款费,
            this.col支付日期,
            this.col收款类别,
            this.col月做账费,
            this.col年做账费,
            this.col工资统计类型,
            this.col开始时间1,
            this.col结束时间1,
            this.col操作时间});
            this.gridView1.DetailHeight = 525;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.vW_AllAccountantSalaryDetailGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col员工
            // 
            this.col员工.FieldName = "员工";
            this.col员工.MinWidth = 30;
            this.col员工.Name = "col员工";
            this.col员工.Visible = true;
            this.col员工.VisibleIndex = 0;
            this.col员工.Width = 112;
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.MinWidth = 30;
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 1;
            this.col客户名称.Width = 138;
            // 
            // col做账收款额
            // 
            this.col做账收款额.FieldName = "做账收款额";
            this.col做账收款额.MinWidth = 30;
            this.col做账收款额.Name = "col做账收款额";
            this.col做账收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账收款额", "{0:0.##}")});
            this.col做账收款额.Width = 120;
            // 
            // col工本收款费
            // 
            this.col工本收款费.FieldName = "工本收款费";
            this.col工本收款费.MinWidth = 30;
            this.col工本收款费.Name = "col工本收款费";
            this.col工本收款费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本收款费", "{0:0.##}")});
            this.col工本收款费.Visible = true;
            this.col工本收款费.VisibleIndex = 2;
            this.col工本收款费.Width = 165;
            // 
            // col开票收款费
            // 
            this.col开票收款费.FieldName = "开票收款费";
            this.col开票收款费.MinWidth = 30;
            this.col开票收款费.Name = "col开票收款费";
            this.col开票收款费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票收款费", "{0:0.##}")});
            this.col开票收款费.Visible = true;
            this.col开票收款费.VisibleIndex = 3;
            this.col开票收款费.Width = 165;
            // 
            // col支付日期
            // 
            this.col支付日期.FieldName = "支付日期";
            this.col支付日期.MinWidth = 30;
            this.col支付日期.Name = "col支付日期";
            this.col支付日期.Visible = true;
            this.col支付日期.VisibleIndex = 4;
            this.col支付日期.Width = 138;
            // 
            // col收款类别
            // 
            this.col收款类别.FieldName = "收款类别";
            this.col收款类别.MinWidth = 30;
            this.col收款类别.Name = "col收款类别";
            this.col收款类别.Visible = true;
            this.col收款类别.VisibleIndex = 5;
            this.col收款类别.Width = 138;
            // 
            // col月做账费
            // 
            this.col月做账费.DisplayFormat.FormatString = "{0:0.##}";
            this.col月做账费.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col月做账费.FieldName = "月做账费";
            this.col月做账费.MinWidth = 30;
            this.col月做账费.Name = "col月做账费";
            this.col月做账费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "月做账费", "{0:0.##}")});
            this.col月做账费.Visible = true;
            this.col月做账费.VisibleIndex = 6;
            this.col月做账费.Width = 138;
            // 
            // col年做账费
            // 
            this.col年做账费.FieldName = "年做账费";
            this.col年做账费.MinWidth = 30;
            this.col年做账费.Name = "col年做账费";
            this.col年做账费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "年做账费", "{0:0.##}")});
            this.col年做账费.Width = 112;
            // 
            // col工资统计类型
            // 
            this.col工资统计类型.FieldName = "工资统计类型";
            this.col工资统计类型.MinWidth = 30;
            this.col工资统计类型.Name = "col工资统计类型";
            this.col工资统计类型.Width = 138;
            // 
            // col开始时间1
            // 
            this.col开始时间1.FieldName = "开始时间";
            this.col开始时间1.MinWidth = 30;
            this.col开始时间1.Name = "col开始时间1";
            this.col开始时间1.OptionsColumn.ReadOnly = true;
            this.col开始时间1.Visible = true;
            this.col开始时间1.VisibleIndex = 7;
            this.col开始时间1.Width = 138;
            // 
            // col结束时间1
            // 
            this.col结束时间1.FieldName = "结束时间";
            this.col结束时间1.MinWidth = 30;
            this.col结束时间1.Name = "col结束时间1";
            this.col结束时间1.OptionsColumn.ReadOnly = true;
            this.col结束时间1.Visible = true;
            this.col结束时间1.VisibleIndex = 8;
            this.col结束时间1.Width = 138;
            // 
            // col操作时间
            // 
            this.col操作时间.FieldName = "操作时间";
            this.col操作时间.MinWidth = 30;
            this.col操作时间.Name = "col操作时间";
            this.col操作时间.OptionsColumn.ReadOnly = true;
            this.col操作时间.Visible = true;
            this.col操作时间.VisibleIndex = 9;
            this.col操作时间.Width = 138;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1413, 764);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vW_AllAccountantSalaryDetailGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1383, 691);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnExp;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(159, 43);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(159, 43);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(159, 43);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(159, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1224, 43);
            // 
            // xlsSaveFileDialog
            // 
            this.xlsSaveFileDialog.Filter = "Excel文件 (*.xlsx)|所有文件(*.*)";
            // 
            // FrmAccountantSalaryDetail2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1413, 764);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(62, 32, 62, 32);
            this.Name = "FrmAccountantSalaryDetail2022";
            this.Text = "做账会计业绩统计明细";
            this.Load += new System.EventHandler(this.FrmAccountantSalaryDetail2021_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryDetailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private SalaryDataSet salaryDataSet;
        private DevExpress.XtraGrid.GridControl vW_AllAccountantSalaryDetailGridControl;
        private System.Windows.Forms.BindingSource vW_AllAccountantSalaryDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col员工;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col做账收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col工本收款费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票收款费;
        private DevExpress.XtraGrid.Columns.GridColumn col支付日期;
        private DevExpress.XtraGrid.Columns.GridColumn col收款类别;
        private DevExpress.XtraGrid.Columns.GridColumn col月做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col年做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col工资统计类型;
        private DevExpress.XtraEditors.SimpleButton btnExp;
        private System.Windows.Forms.SaveFileDialog xlsSaveFileDialog;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private DevExpress.XtraGrid.Columns.GridColumn col开始时间1;
        private DevExpress.XtraGrid.Columns.GridColumn col结束时间1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col操作时间;
    }
}