namespace WangDaDll.SalaryServer
{
    partial class FrmTJClientDetail
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
            this.proceedsDataSet = new WangDaDll.Common.ProceedsDataSet();
            this.tW_PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_PaymentGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col支付单位 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付金额 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.col上次到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col本次到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月平均费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col不收款 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账部经理提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务主管团队提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账主管团队提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册主管提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员做账费提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col累计工本开票提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账部经理业务团队提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col初始做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col费用到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col首年提成结束期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月收费标准 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PaymentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // proceedsDataSet
            // 
            this.proceedsDataSet.DataSetName = "ProceedsDataSet";
            this.proceedsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tW_PaymentBindingSource
            // 
            this.tW_PaymentBindingSource.DataMember = "TW_Payment";
            this.tW_PaymentBindingSource.DataSource = this.proceedsDataSet;
            // 
            // vW_PaymentBindingSource
            // 
            this.vW_PaymentBindingSource.DataMember = "VW_Payment";
            this.vW_PaymentBindingSource.DataSource = this.proceedsDataSet;
            // 
            // vW_PaymentGridControl
            // 
            this.vW_PaymentGridControl.DataSource = this.vW_PaymentBindingSource;
            this.vW_PaymentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vW_PaymentGridControl.Location = new System.Drawing.Point(0, 0);
            this.vW_PaymentGridControl.MainView = this.gridView1;
            this.vW_PaymentGridControl.Name = "vW_PaymentGridControl";
            this.vW_PaymentGridControl.Size = new System.Drawing.Size(943, 600);
            this.vW_PaymentGridControl.TabIndex = 0;
            this.vW_PaymentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.col支付单位,
            this.col支付金额,
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
            this.col上次到期月份,
            this.col本次到期月份,
            this.col业务员,
            this.col注册员,
            this.col月平均费,
            this.col不收款,
            this.col零申报,
            this.col注册员提成,
            this.col业务员提成,
            this.col做账提成,
            this.col做账部经理提成,
            this.col业务主管团队提成,
            this.col做账主管团队提成,
            this.col注册主管提成,
            this.col注册员做账费提成,
            this.col累计工本开票提成,
            this.col做账部经理业务团队提成,
            this.col初始做账时间,
            this.col费用到期月份,
            this.col首年提成结束期,
            this.col月收费标准});
            this.gridView1.GridControl = this.vW_PaymentGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", this.col工本费, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", this.col开票费, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "累计工本开票提成", this.col累计工本开票提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "支付金额", this.col支付金额, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务员提成", this.col业务员提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务主管团队提成", this.col业务主管团队提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册员提成", this.col注册员提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账提成", this.col做账提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账部经理提成", this.col做账部经理提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账主管团队提成", this.col做账主管团队提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册员做账费提成", this.col注册员做账费提成, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册主管提成", this.col注册主管提成, "{0:0.##}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col支付单位
            // 
            this.col支付单位.FieldName = "支付单位";
            this.col支付单位.Name = "col支付单位";
            this.col支付单位.OptionsColumn.ReadOnly = true;
            this.col支付单位.Visible = true;
            this.col支付单位.VisibleIndex = 0;
            // 
            // col支付金额
            // 
            this.col支付金额.FieldName = "支付金额";
            this.col支付金额.Name = "col支付金额";
            this.col支付金额.OptionsColumn.ReadOnly = true;
            this.col支付金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "支付金额", "{0:0.##}")});
            this.col支付金额.Visible = true;
            this.col支付金额.VisibleIndex = 1;
            // 
            // col支付日期
            // 
            this.col支付日期.FieldName = "支付日期";
            this.col支付日期.Name = "col支付日期";
            this.col支付日期.OptionsColumn.ReadOnly = true;
            this.col支付日期.Visible = true;
            this.col支付日期.VisibleIndex = 2;
            // 
            // col支付方式
            // 
            this.col支付方式.FieldName = "支付方式";
            this.col支付方式.Name = "col支付方式";
            this.col支付方式.OptionsColumn.ReadOnly = true;
            this.col支付方式.Visible = true;
            this.col支付方式.VisibleIndex = 3;
            // 
            // col收款人
            // 
            this.col收款人.FieldName = "收款人";
            this.col收款人.Name = "col收款人";
            this.col收款人.OptionsColumn.ReadOnly = true;
            this.col收款人.Visible = true;
            this.col收款人.VisibleIndex = 4;
            // 
            // col收款类别
            // 
            this.col收款类别.FieldName = "收款类别";
            this.col收款类别.Name = "col收款类别";
            this.col收款类别.OptionsColumn.ReadOnly = true;
            this.col收款类别.Visible = true;
            this.col收款类别.VisibleIndex = 5;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.Name = "col备注";
            this.col备注.OptionsColumn.ReadOnly = true;
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 8;
            // 
            // col操作人
            // 
            this.col操作人.FieldName = "操作人";
            this.col操作人.Name = "col操作人";
            this.col操作人.OptionsColumn.ReadOnly = true;
            this.col操作人.Visible = true;
            this.col操作人.VisibleIndex = 30;
            // 
            // col操作时间
            // 
            this.col操作时间.FieldName = "操作时间";
            this.col操作时间.Name = "col操作时间";
            this.col操作时间.OptionsColumn.ReadOnly = true;
            this.col操作时间.Visible = true;
            this.col操作时间.VisibleIndex = 31;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.Name = "col工本费";
            this.col工本费.OptionsColumn.ReadOnly = true;
            this.col工本费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", "{0:0.##}")});
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 6;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.Name = "col开票费";
            this.col开票费.OptionsColumn.ReadOnly = true;
            this.col开票费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", "{0:0.##}")});
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 7;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 11;
            // 
            // col上次到期月份
            // 
            this.col上次到期月份.FieldName = "上次到期月份";
            this.col上次到期月份.Name = "col上次到期月份";
            this.col上次到期月份.OptionsColumn.ReadOnly = true;
            this.col上次到期月份.Visible = true;
            this.col上次到期月份.VisibleIndex = 9;
            this.col上次到期月份.Width = 92;
            // 
            // col本次到期月份
            // 
            this.col本次到期月份.FieldName = "本次到期月份";
            this.col本次到期月份.Name = "col本次到期月份";
            this.col本次到期月份.OptionsColumn.ReadOnly = true;
            this.col本次到期月份.Visible = true;
            this.col本次到期月份.VisibleIndex = 10;
            this.col本次到期月份.Width = 92;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 12;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 13;
            // 
            // col月平均费
            // 
            this.col月平均费.FieldName = "月平均费";
            this.col月平均费.Name = "col月平均费";
            this.col月平均费.OptionsColumn.ReadOnly = true;
            // 
            // col不收款
            // 
            this.col不收款.FieldName = "不收款";
            this.col不收款.Name = "col不收款";
            this.col不收款.OptionsColumn.ReadOnly = true;
            this.col不收款.Visible = true;
            this.col不收款.VisibleIndex = 14;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 15;
            // 
            // col注册员提成
            // 
            this.col注册员提成.FieldName = "注册员提成";
            this.col注册员提成.Name = "col注册员提成";
            this.col注册员提成.OptionsColumn.ReadOnly = true;
            this.col注册员提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册员提成", "{0:0.##}")});
            this.col注册员提成.Visible = true;
            this.col注册员提成.VisibleIndex = 16;
            this.col注册员提成.Width = 80;
            // 
            // col业务员提成
            // 
            this.col业务员提成.FieldName = "业务员提成";
            this.col业务员提成.Name = "col业务员提成";
            this.col业务员提成.OptionsColumn.ReadOnly = true;
            this.col业务员提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务员提成", "{0:0.##}")});
            this.col业务员提成.Visible = true;
            this.col业务员提成.VisibleIndex = 17;
            this.col业务员提成.Width = 80;
            // 
            // col做账提成
            // 
            this.col做账提成.FieldName = "做账提成";
            this.col做账提成.Name = "col做账提成";
            this.col做账提成.OptionsColumn.ReadOnly = true;
            this.col做账提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账提成", "{0:0.##}")});
            this.col做账提成.Visible = true;
            this.col做账提成.VisibleIndex = 18;
            // 
            // col做账部经理提成
            // 
            this.col做账部经理提成.FieldName = "做账部经理提成";
            this.col做账部经理提成.Name = "col做账部经理提成";
            this.col做账部经理提成.OptionsColumn.ReadOnly = true;
            this.col做账部经理提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账部经理提成", "{0:0.##}")});
            this.col做账部经理提成.Visible = true;
            this.col做账部经理提成.VisibleIndex = 19;
            this.col做账部经理提成.Width = 104;
            // 
            // col业务主管团队提成
            // 
            this.col业务主管团队提成.FieldName = "业务主管团队提成";
            this.col业务主管团队提成.Name = "col业务主管团队提成";
            this.col业务主管团队提成.OptionsColumn.ReadOnly = true;
            this.col业务主管团队提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务主管团队提成", "{0:0.##}")});
            this.col业务主管团队提成.Visible = true;
            this.col业务主管团队提成.VisibleIndex = 20;
            this.col业务主管团队提成.Width = 116;
            // 
            // col做账主管团队提成
            // 
            this.col做账主管团队提成.FieldName = "做账主管团队提成";
            this.col做账主管团队提成.Name = "col做账主管团队提成";
            this.col做账主管团队提成.OptionsColumn.ReadOnly = true;
            this.col做账主管团队提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账主管团队提成", "{0:0.##}")});
            this.col做账主管团队提成.Visible = true;
            this.col做账主管团队提成.VisibleIndex = 21;
            this.col做账主管团队提成.Width = 116;
            // 
            // col注册主管提成
            // 
            this.col注册主管提成.FieldName = "注册主管提成";
            this.col注册主管提成.Name = "col注册主管提成";
            this.col注册主管提成.OptionsColumn.ReadOnly = true;
            this.col注册主管提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册主管提成", "{0:0.##}")});
            this.col注册主管提成.Visible = true;
            this.col注册主管提成.VisibleIndex = 22;
            this.col注册主管提成.Width = 92;
            // 
            // col注册员做账费提成
            // 
            this.col注册员做账费提成.FieldName = "注册员做账费提成";
            this.col注册员做账费提成.Name = "col注册员做账费提成";
            this.col注册员做账费提成.OptionsColumn.ReadOnly = true;
            this.col注册员做账费提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册员做账费提成", "{0:0.##}")});
            this.col注册员做账费提成.Visible = true;
            this.col注册员做账费提成.VisibleIndex = 23;
            this.col注册员做账费提成.Width = 116;
            // 
            // col累计工本开票提成
            // 
            this.col累计工本开票提成.FieldName = "累计工本开票提成";
            this.col累计工本开票提成.Name = "col累计工本开票提成";
            this.col累计工本开票提成.OptionsColumn.ReadOnly = true;
            this.col累计工本开票提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "累计工本开票提成", "{0:0.##}")});
            this.col累计工本开票提成.Visible = true;
            this.col累计工本开票提成.VisibleIndex = 24;
            this.col累计工本开票提成.Width = 116;
            // 
            // col做账部经理业务团队提成
            // 
            this.col做账部经理业务团队提成.FieldName = "做账部经理业务团队提成";
            this.col做账部经理业务团队提成.Name = "col做账部经理业务团队提成";
            this.col做账部经理业务团队提成.OptionsColumn.ReadOnly = true;
            this.col做账部经理业务团队提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账部经理业务团队提成", "{0:0.##}")});
            this.col做账部经理业务团队提成.Visible = true;
            this.col做账部经理业务团队提成.VisibleIndex = 25;
            this.col做账部经理业务团队提成.Width = 152;
            // 
            // col初始做账时间
            // 
            this.col初始做账时间.FieldName = "初始做账时间";
            this.col初始做账时间.Name = "col初始做账时间";
            this.col初始做账时间.OptionsColumn.ReadOnly = true;
            this.col初始做账时间.Visible = true;
            this.col初始做账时间.VisibleIndex = 26;
            this.col初始做账时间.Width = 92;
            // 
            // col费用到期月份
            // 
            this.col费用到期月份.FieldName = "费用到期月份";
            this.col费用到期月份.Name = "col费用到期月份";
            this.col费用到期月份.OptionsColumn.ReadOnly = true;
            this.col费用到期月份.Visible = true;
            this.col费用到期月份.VisibleIndex = 29;
            this.col费用到期月份.Width = 92;
            // 
            // col首年提成结束期
            // 
            this.col首年提成结束期.FieldName = "首年提成结束期";
            this.col首年提成结束期.Name = "col首年提成结束期";
            this.col首年提成结束期.OptionsColumn.ReadOnly = true;
            this.col首年提成结束期.Visible = true;
            this.col首年提成结束期.VisibleIndex = 27;
            this.col首年提成结束期.Width = 104;
            // 
            // col月收费标准
            // 
            this.col月收费标准.FieldName = "月收费标准";
            this.col月收费标准.Name = "col月收费标准";
            this.col月收费标准.OptionsColumn.ReadOnly = true;
            this.col月收费标准.Visible = true;
            this.col月收费标准.VisibleIndex = 28;
            this.col月收费标准.Width = 80;
            // 
            // FrmTJClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.vW_PaymentGridControl);
            this.Name = "FrmTJClientDetail";
            this.Text = "客户统计收款明细";
            this.Load += new System.EventHandler(this.FrmTJClientDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PaymentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.ProceedsDataSet proceedsDataSet;
        private System.Windows.Forms.BindingSource tW_PaymentBindingSource;
        private System.Windows.Forms.BindingSource vW_PaymentBindingSource;
        private DevExpress.XtraGrid.GridControl vW_PaymentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col支付单位;
        private DevExpress.XtraGrid.Columns.GridColumn col支付金额;
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
        private DevExpress.XtraGrid.Columns.GridColumn col上次到期月份;
        private DevExpress.XtraGrid.Columns.GridColumn col本次到期月份;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col月平均费;
        private DevExpress.XtraGrid.Columns.GridColumn col不收款;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员提成;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员提成;
        private DevExpress.XtraGrid.Columns.GridColumn col做账提成;
        private DevExpress.XtraGrid.Columns.GridColumn col做账部经理提成;
        private DevExpress.XtraGrid.Columns.GridColumn col业务主管团队提成;
        private DevExpress.XtraGrid.Columns.GridColumn col做账主管团队提成;
        private DevExpress.XtraGrid.Columns.GridColumn col注册主管提成;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员做账费提成;
        private DevExpress.XtraGrid.Columns.GridColumn col累计工本开票提成;
        private DevExpress.XtraGrid.Columns.GridColumn col做账部经理业务团队提成;
        private DevExpress.XtraGrid.Columns.GridColumn col初始做账时间;
        private DevExpress.XtraGrid.Columns.GridColumn col费用到期月份;
        private DevExpress.XtraGrid.Columns.GridColumn col首年提成结束期;
        private DevExpress.XtraGrid.Columns.GridColumn col月收费标准;
    }
}