using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmPaymentGeneralView
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
            this.tW_PaymentGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsDataSet = new WangDaDll.Common.ProceedsDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTW_PaymentID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.col本次到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月平均费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col不收款 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.零申报CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tW_PaymentmainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.不收款CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.缴费月数TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.做账会计TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.总额TextBox = new System.Windows.Forms.TextBox();
            this.收款人TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.备注MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.操作人TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.支付单位ButtonEdit = new DevExpress.XtraEditors.TextEdit();
            this.月平均费TextEdit = new DevExpress.XtraEditors.CalcEdit();
            this.本次到期月DateEdit = new DevExpress.XtraEditors.TextEdit();
            this.上次到期月DateEdit = new DevExpress.XtraEditors.TextEdit();
            this.支付日期DateEdit = new DevExpress.XtraEditors.TextEdit();
            this.支付方式ComboBoxEdit = new DevExpress.XtraEditors.TextEdit();
            this.支付金额CalcEdit = new DevExpress.XtraEditors.TextEdit();
            this.工本费CalcEdit = new DevExpress.XtraEditors.TextEdit();
            this.开票费CalcEdit = new DevExpress.XtraEditors.TextEdit();
            this.操作时间DateEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.零申报CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentmainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.不收款CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.缴费月数TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款人TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.操作人TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位ButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月平均费TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.上次到期月DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付金额CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工本费CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.开票费CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.操作时间DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tW_PaymentGridControl);
            this.layoutControl1.Controls.Add(this.零申报CheckEdit);
            this.layoutControl1.Controls.Add(this.不收款CheckEdit);
            this.layoutControl1.Controls.Add(this.缴费月数TextEdit);
            this.layoutControl1.Controls.Add(this.做账会计TextEdit);
            this.layoutControl1.Controls.Add(this.总额TextBox);
            this.layoutControl1.Controls.Add(this.收款人TextEdit);
            this.layoutControl1.Controls.Add(this.备注MemoEdit);
            this.layoutControl1.Controls.Add(this.操作人TextEdit);
            this.layoutControl1.Controls.Add(this.支付单位ButtonEdit);
            this.layoutControl1.Controls.Add(this.月平均费TextEdit);
            this.layoutControl1.Controls.Add(this.本次到期月DateEdit);
            this.layoutControl1.Controls.Add(this.上次到期月DateEdit);
            this.layoutControl1.Controls.Add(this.支付日期DateEdit);
            this.layoutControl1.Controls.Add(this.支付方式ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.支付金额CalcEdit);
            this.layoutControl1.Controls.Add(this.工本费CalcEdit);
            this.layoutControl1.Controls.Add(this.开票费CalcEdit);
            this.layoutControl1.Controls.Add(this.操作时间DateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(854, 450, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1230, 957);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tW_PaymentGridControl
            // 
            this.tW_PaymentGridControl.DataSource = this.tW_PaymentBindingSource;
            this.tW_PaymentGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tW_PaymentGridControl.Location = new System.Drawing.Point(37, 72);
            this.tW_PaymentGridControl.MainView = this.gridView1;
            this.tW_PaymentGridControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tW_PaymentGridControl.Name = "tW_PaymentGridControl";
            this.tW_PaymentGridControl.Size = new System.Drawing.Size(1155, 847);
            this.tW_PaymentGridControl.TabIndex = 35;
            this.tW_PaymentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tW_PaymentBindingSource
            // 
            this.tW_PaymentBindingSource.DataMember = "TW_Payment";
            this.tW_PaymentBindingSource.DataSource = this.proceedsDataSet;
            // 
            // proceedsDataSet
            // 
            this.proceedsDataSet.DataSetName = "ProceedsDataSet";
            this.proceedsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colTW_PaymentID,
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
            this.col本次到期月份,
            this.col业务员,
            this.col注册员,
            this.col月平均费,
            this.col不收款,
            this.col零申报});
            this.gridView1.GridControl = this.tW_PaymentGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // colTW_PaymentID
            // 
            this.colTW_PaymentID.FieldName = "TW_PaymentID";
            this.colTW_PaymentID.Name = "colTW_PaymentID";
            this.colTW_PaymentID.Width = 111;
            // 
            // col支付单位
            // 
            this.col支付单位.FieldName = "支付单位";
            this.col支付单位.Name = "col支付单位";
            this.col支付单位.Visible = true;
            this.col支付单位.VisibleIndex = 0;
            this.col支付单位.Width = 92;
            // 
            // col支付金额
            // 
            this.col支付金额.FieldName = "支付金额";
            this.col支付金额.Name = "col支付金额";
            this.col支付金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "支付金额", "{0:0.##}")});
            this.col支付金额.Visible = true;
            this.col支付金额.VisibleIndex = 1;
            this.col支付金额.Width = 92;
            // 
            // col支付日期
            // 
            this.col支付日期.FieldName = "支付日期";
            this.col支付日期.Name = "col支付日期";
            this.col支付日期.Visible = true;
            this.col支付日期.VisibleIndex = 4;
            this.col支付日期.Width = 92;
            // 
            // col支付方式
            // 
            this.col支付方式.FieldName = "支付方式";
            this.col支付方式.Name = "col支付方式";
            this.col支付方式.Visible = true;
            this.col支付方式.VisibleIndex = 5;
            this.col支付方式.Width = 92;
            // 
            // col收款人
            // 
            this.col收款人.FieldName = "收款人";
            this.col收款人.Name = "col收款人";
            this.col收款人.Visible = true;
            this.col收款人.VisibleIndex = 6;
            // 
            // col收款类别
            // 
            this.col收款类别.FieldName = "收款类别";
            this.col收款类别.Name = "col收款类别";
            this.col收款类别.Visible = true;
            this.col收款类别.VisibleIndex = 7;
            this.col收款类别.Width = 92;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.Name = "col备注";
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 13;
            // 
            // col操作人
            // 
            this.col操作人.FieldName = "操作人";
            this.col操作人.Name = "col操作人";
            this.col操作人.Visible = true;
            this.col操作人.VisibleIndex = 14;
            // 
            // col操作时间
            // 
            this.col操作时间.FieldName = "操作时间";
            this.col操作时间.Name = "col操作时间";
            this.col操作时间.Visible = true;
            this.col操作时间.VisibleIndex = 15;
            this.col操作时间.Width = 92;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.Name = "col工本费";
            this.col工本费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", "{0:0.##}")});
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 2;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.Name = "col开票费";
            this.col开票费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", "{0:0.##}")});
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 3;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 9;
            this.col做账会计.Width = 92;
            // 
            // col本次到期月份
            // 
            this.col本次到期月份.FieldName = "本次到期月份";
            this.col本次到期月份.Name = "col本次到期月份";
            this.col本次到期月份.Visible = true;
            this.col本次到期月份.VisibleIndex = 8;
            this.col本次到期月份.Width = 128;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 12;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 10;
            // 
            // col月平均费
            // 
            this.col月平均费.FieldName = "月平均费";
            this.col月平均费.Name = "col月平均费";
            this.col月平均费.Visible = true;
            this.col月平均费.VisibleIndex = 11;
            this.col月平均费.Width = 92;
            // 
            // col不收款
            // 
            this.col不收款.FieldName = "不收款";
            this.col不收款.Name = "col不收款";
            this.col不收款.Visible = true;
            this.col不收款.VisibleIndex = 16;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.Name = "col零申报";
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 17;
            // 
            // 零申报CheckEdit
            // 
            this.零申报CheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "零申报", true));
            this.零申报CheckEdit.Location = new System.Drawing.Point(327, 891);
            this.零申报CheckEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.零申报CheckEdit.Name = "零申报CheckEdit";
            this.零申报CheckEdit.Properties.Caption = "零申报收款";
            this.零申报CheckEdit.Size = new System.Drawing.Size(284, 26);
            this.零申报CheckEdit.StyleController = this.layoutControl1;
            this.零申报CheckEdit.TabIndex = 35;
            // 
            // tW_PaymentmainBindingSource
            // 
            this.tW_PaymentmainBindingSource.DataMember = "TW_PaymentMain";
            this.tW_PaymentmainBindingSource.DataSource = this.proceedsDataSet;
            // 
            // 不收款CheckEdit
            // 
            this.不收款CheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "不收款", true));
            this.不收款CheckEdit.Location = new System.Drawing.Point(37, 891);
            this.不收款CheckEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.不收款CheckEdit.Name = "不收款CheckEdit";
            this.不收款CheckEdit.Properties.Caption = "不收款";
            this.不收款CheckEdit.Properties.ReadOnly = true;
            this.不收款CheckEdit.Size = new System.Drawing.Size(284, 26);
            this.不收款CheckEdit.StyleController = this.layoutControl1;
            this.不收款CheckEdit.TabIndex = 34;
            // 
            // 缴费月数TextEdit
            // 
            this.缴费月数TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "缴费月数", true));
            this.缴费月数TextEdit.Location = new System.Drawing.Point(710, 278);
            this.缴费月数TextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.缴费月数TextEdit.Name = "缴费月数TextEdit";
            this.缴费月数TextEdit.Properties.ReadOnly = true;
            this.缴费月数TextEdit.Size = new System.Drawing.Size(68, 28);
            this.缴费月数TextEdit.StyleController = this.layoutControl1;
            this.缴费月数TextEdit.TabIndex = 32;
            // 
            // 做账会计TextEdit
            // 
            this.做账会计TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "做账会计", true));
            this.做账会计TextEdit.Location = new System.Drawing.Point(130, 106);
            this.做账会计TextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.做账会计TextEdit.Name = "做账会计TextEdit";
            this.做账会计TextEdit.Properties.ReadOnly = true;
            this.做账会计TextEdit.Size = new System.Drawing.Size(1062, 28);
            this.做账会计TextEdit.StyleController = this.layoutControl1;
            this.做账会计TextEdit.TabIndex = 28;
            // 
            // 总额TextBox
            // 
            this.总额TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tW_PaymentmainBindingSource, "总额", true));
            this.总额TextBox.Location = new System.Drawing.Point(992, 189);
            this.总额TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.总额TextBox.Name = "总额TextBox";
            this.总额TextBox.ReadOnly = true;
            this.总额TextBox.Size = new System.Drawing.Size(181, 30);
            this.总额TextBox.TabIndex = 27;
            // 
            // 收款人TextEdit
            // 
            this.收款人TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "收款人", true));
            this.收款人TextEdit.Location = new System.Drawing.Point(903, 244);
            this.收款人TextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.收款人TextEdit.Name = "收款人TextEdit";
            this.收款人TextEdit.Properties.ReadOnly = true;
            this.收款人TextEdit.Size = new System.Drawing.Size(289, 28);
            this.收款人TextEdit.StyleController = this.layoutControl1;
            this.收款人TextEdit.TabIndex = 13;
            // 
            // 备注MemoEdit
            // 
            this.备注MemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "备注", true));
            this.备注MemoEdit.Location = new System.Drawing.Point(130, 312);
            this.备注MemoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.备注MemoEdit.Name = "备注MemoEdit";
            this.备注MemoEdit.Properties.ReadOnly = true;
            this.备注MemoEdit.Size = new System.Drawing.Size(1062, 573);
            this.备注MemoEdit.StyleController = this.layoutControl1;
            this.备注MemoEdit.TabIndex = 17;
            // 
            // 操作人TextEdit
            // 
            this.操作人TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "操作人", true));
            this.操作人TextEdit.Location = new System.Drawing.Point(710, 891);
            this.操作人TextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.操作人TextEdit.Name = "操作人TextEdit";
            this.操作人TextEdit.Properties.ReadOnly = true;
            this.操作人TextEdit.Size = new System.Drawing.Size(192, 28);
            this.操作人TextEdit.StyleController = this.layoutControl1;
            this.操作人TextEdit.TabIndex = 19;
            // 
            // 支付单位ButtonEdit
            // 
            this.支付单位ButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "支付单位", true));
            this.支付单位ButtonEdit.Location = new System.Drawing.Point(130, 72);
            this.支付单位ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.支付单位ButtonEdit.Name = "支付单位ButtonEdit";
            this.支付单位ButtonEdit.Properties.ReadOnly = true;
            this.支付单位ButtonEdit.Size = new System.Drawing.Size(1062, 28);
            this.支付单位ButtonEdit.StyleController = this.layoutControl1;
            this.支付单位ButtonEdit.TabIndex = 5;
            // 
            // 月平均费TextEdit
            // 
            this.月平均费TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "月平均费", true));
            this.月平均费TextEdit.Location = new System.Drawing.Point(877, 278);
            this.月平均费TextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.月平均费TextEdit.Name = "月平均费TextEdit";
            this.月平均费TextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.月平均费TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.月平均费TextEdit.Properties.ReadOnly = true;
            this.月平均费TextEdit.Size = new System.Drawing.Size(315, 28);
            this.月平均费TextEdit.StyleController = this.layoutControl1;
            this.月平均费TextEdit.TabIndex = 33;
            // 
            // 本次到期月DateEdit
            // 
            this.本次到期月DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "本次到期月份", true));
            this.本次到期月DateEdit.Location = new System.Drawing.Point(420, 278);
            this.本次到期月DateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.本次到期月DateEdit.Name = "本次到期月DateEdit";
            this.本次到期月DateEdit.Properties.Mask.EditMask = "d";
            this.本次到期月DateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.本次到期月DateEdit.Properties.ReadOnly = true;
            this.本次到期月DateEdit.Size = new System.Drawing.Size(191, 28);
            this.本次到期月DateEdit.StyleController = this.layoutControl1;
            this.本次到期月DateEdit.TabIndex = 30;
            // 
            // 上次到期月DateEdit
            // 
            this.上次到期月DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "上次到期月份", true));
            this.上次到期月DateEdit.Location = new System.Drawing.Point(130, 278);
            this.上次到期月DateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.上次到期月DateEdit.Name = "上次到期月DateEdit";
            this.上次到期月DateEdit.Properties.Mask.EditMask = "d";
            this.上次到期月DateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.上次到期月DateEdit.Properties.ReadOnly = true;
            this.上次到期月DateEdit.Size = new System.Drawing.Size(191, 28);
            this.上次到期月DateEdit.StyleController = this.layoutControl1;
            this.上次到期月DateEdit.TabIndex = 29;
            // 
            // 支付日期DateEdit
            // 
            this.支付日期DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "支付日期", true));
            this.支付日期DateEdit.Location = new System.Drawing.Point(130, 244);
            this.支付日期DateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.支付日期DateEdit.Name = "支付日期DateEdit";
            this.支付日期DateEdit.Properties.Mask.EditMask = "d";
            this.支付日期DateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.支付日期DateEdit.Properties.ReadOnly = true;
            this.支付日期DateEdit.Size = new System.Drawing.Size(288, 28);
            this.支付日期DateEdit.StyleController = this.layoutControl1;
            this.支付日期DateEdit.TabIndex = 9;
            // 
            // 支付方式ComboBoxEdit
            // 
            this.支付方式ComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "支付方式", true));
            this.支付方式ComboBoxEdit.Location = new System.Drawing.Point(517, 244);
            this.支付方式ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.支付方式ComboBoxEdit.Name = "支付方式ComboBoxEdit";
            this.支付方式ComboBoxEdit.Properties.ReadOnly = true;
            this.支付方式ComboBoxEdit.Size = new System.Drawing.Size(287, 28);
            this.支付方式ComboBoxEdit.StyleController = this.layoutControl1;
            this.支付方式ComboBoxEdit.TabIndex = 11;
            // 
            // 支付金额CalcEdit
            // 
            this.支付金额CalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "支付金额", true));
            this.支付金额CalcEdit.Location = new System.Drawing.Point(149, 189);
            this.支付金额CalcEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.支付金额CalcEdit.Name = "支付金额CalcEdit";
            this.支付金额CalcEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.支付金额CalcEdit.Properties.ReadOnly = true;
            this.支付金额CalcEdit.Size = new System.Drawing.Size(181, 28);
            this.支付金额CalcEdit.StyleController = this.layoutControl1;
            this.支付金额CalcEdit.TabIndex = 7;
            // 
            // 工本费CalcEdit
            // 
            this.工本费CalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "工本费", true));
            this.工本费CalcEdit.Location = new System.Drawing.Point(429, 189);
            this.工本费CalcEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.工本费CalcEdit.Name = "工本费CalcEdit";
            this.工本费CalcEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.工本费CalcEdit.Properties.ReadOnly = true;
            this.工本费CalcEdit.Size = new System.Drawing.Size(182, 28);
            this.工本费CalcEdit.StyleController = this.layoutControl1;
            this.工本费CalcEdit.TabIndex = 25;
            // 
            // 开票费CalcEdit
            // 
            this.开票费CalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "开票费", true));
            this.开票费CalcEdit.Location = new System.Drawing.Point(710, 189);
            this.开票费CalcEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.开票费CalcEdit.Name = "开票费CalcEdit";
            this.开票费CalcEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.开票费CalcEdit.Properties.ReadOnly = true;
            this.开票费CalcEdit.Size = new System.Drawing.Size(183, 28);
            this.开票费CalcEdit.StyleController = this.layoutControl1;
            this.开票费CalcEdit.TabIndex = 26;
            // 
            // 操作时间DateEdit
            // 
            this.操作时间DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentmainBindingSource, "操作时间", true));
            this.操作时间DateEdit.Location = new System.Drawing.Point(1001, 891);
            this.操作时间DateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.操作时间DateEdit.Name = "操作时间DateEdit";
            this.操作时间DateEdit.Properties.Mask.EditMask = "d";
            this.操作时间DateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.操作时间DateEdit.Properties.ReadOnly = true;
            this.操作时间DateEdit.Size = new System.Drawing.Size(191, 28);
            this.操作时间DateEdit.StyleController = this.layoutControl1;
            this.操作时间DateEdit.TabIndex = 21;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1230, 957);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1200, 927);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup4});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem12,
            this.layoutControlGroup3,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem20,
            this.layoutControlItem17,
            this.layoutControlItem15,
            this.layoutControlItem14,
            this.layoutControlItem21,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem16,
            this.layoutControlItem18});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1161, 853);
            this.layoutControlGroup2.Text = "收款记录";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.支付单位ButtonEdit;
            this.layoutControlItem2.CustomizationFormText = "支付单位:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1161, 34);
            this.layoutControlItem2.Text = "支付单位:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.做账会计TextEdit;
            this.layoutControlItem12.CustomizationFormText = "做账会计:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1161, 34);
            this.layoutControlItem12.Text = "做账会计:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "支付金额";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem13});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1161, 104);
            this.layoutControlGroup3.Text = "支付金额";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.支付金额CalcEdit;
            this.layoutControlItem4.CustomizationFormText = "做账费:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(280, 36);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "做账费:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.工本费CalcEdit;
            this.layoutControlItem9.CustomizationFormText = "工本费:";
            this.layoutControlItem9.Location = new System.Drawing.Point(280, 0);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(281, 36);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "工本费:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.开票费CalcEdit;
            this.layoutControlItem11.CustomizationFormText = "开票费:";
            this.layoutControlItem11.Location = new System.Drawing.Point(561, 0);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(282, 36);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "开票费:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.总额TextBox;
            this.layoutControlItem13.CustomizationFormText = "总额:";
            this.layoutControlItem13.Location = new System.Drawing.Point(843, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(280, 36);
            this.layoutControlItem13.Text = "总额:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.支付日期DateEdit;
            this.layoutControlItem6.CustomizationFormText = "支付日期:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 172);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(387, 34);
            this.layoutControlItem6.Text = "支付日期:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.支付方式ComboBoxEdit;
            this.layoutControlItem8.CustomizationFormText = "支付方式:";
            this.layoutControlItem8.Location = new System.Drawing.Point(387, 172);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(386, 34);
            this.layoutControlItem8.Text = "支付方式:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.收款人TextEdit;
            this.layoutControlItem10.CustomizationFormText = "收款人:";
            this.layoutControlItem10.Location = new System.Drawing.Point(773, 172);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(388, 34);
            this.layoutControlItem10.Text = "收款人:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.缴费月数TextEdit;
            this.layoutControlItem20.CustomizationFormText = "缴费月数:";
            this.layoutControlItem20.Location = new System.Drawing.Point(580, 206);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(167, 24);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(167, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(167, 34);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.Text = "缴费月数:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.本次到期月DateEdit;
            this.layoutControlItem17.CustomizationFormText = "本次到期月:";
            this.layoutControlItem17.Location = new System.Drawing.Point(290, 206);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(290, 34);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "结束时间：";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.上次到期月DateEdit;
            this.layoutControlItem15.CustomizationFormText = "上次到期月:";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 206);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(290, 34);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "开始时间:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.备注MemoEdit;
            this.layoutControlItem14.CustomizationFormText = "备注:";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(1161, 579);
            this.layoutControlItem14.Text = "备注:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.月平均费TextEdit;
            this.layoutControlItem21.CustomizationFormText = "月平均费:";
            this.layoutControlItem21.Location = new System.Drawing.Point(747, 206);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(414, 34);
            this.layoutControlItem21.Text = "月平均费:";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.不收款CheckEdit;
            this.layoutControlItem3.CustomizationFormText = "不收款:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 819);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(290, 34);
            this.layoutControlItem3.Text = "不收款:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.零申报CheckEdit;
            this.layoutControlItem5.CustomizationFormText = "零申报:";
            this.layoutControlItem5.Location = new System.Drawing.Point(290, 819);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(290, 34);
            this.layoutControlItem5.Text = "零申报:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.操作人TextEdit;
            this.layoutControlItem16.CustomizationFormText = "操作人:";
            this.layoutControlItem16.Location = new System.Drawing.Point(580, 819);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(291, 34);
            this.layoutControlItem16.Text = "操作人:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.操作时间DateEdit;
            this.layoutControlItem18.CustomizationFormText = "操作时间:";
            this.layoutControlItem18.Location = new System.Drawing.Point(871, 819);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(290, 34);
            this.layoutControlItem18.Text = "操作时间:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1161, 853);
            this.layoutControlGroup4.Text = "拆分记录";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_PaymentGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1161, 853);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPaymentGeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 957);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPaymentGeneralView";
            this.Text = "常规收款";
            this.Load += new System.EventHandler(this.FrmPaymentGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.零申报CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentmainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.不收款CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.缴费月数TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款人TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.操作人TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位ButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月平均费TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.上次到期月DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付金额CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工本费CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.开票费CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.操作时间DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource tW_PaymentmainBindingSource;
        private ProceedsDataSet proceedsDataSet;
        private DevExpress.XtraEditors.TextEdit 收款人TextEdit;
        private DevExpress.XtraEditors.MemoEdit 备注MemoEdit;
        private DevExpress.XtraEditors.TextEdit 操作人TextEdit;
        private DevExpress.XtraEditors.TextEdit 支付单位ButtonEdit;
        private DevExpress.XtraEditors.TextEdit 做账会计TextEdit;
        private System.Windows.Forms.TextBox 总额TextBox;
        private Tiger.PdrCommon.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraEditors.TextEdit 缴费月数TextEdit;
        private DevExpress.XtraEditors.CalcEdit 月平均费TextEdit;
        private DevExpress.XtraEditors.TextEdit 本次到期月DateEdit;
        private DevExpress.XtraEditors.TextEdit 上次到期月DateEdit;
        private DevExpress.XtraEditors.TextEdit 支付日期DateEdit;
        private DevExpress.XtraEditors.TextEdit 支付方式ComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit 支付金额CalcEdit;
        private DevExpress.XtraEditors.TextEdit 工本费CalcEdit;
        private DevExpress.XtraEditors.TextEdit 开票费CalcEdit;
        private DevExpress.XtraEditors.TextEdit 操作时间DateEdit;
        private DevExpress.XtraEditors.CheckEdit 不收款CheckEdit;
        private DevExpress.XtraEditors.CheckEdit 零申报CheckEdit;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraGrid.GridControl tW_PaymentGridControl;
        private System.Windows.Forms.BindingSource tW_PaymentBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTW_PaymentID;
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
        private DevExpress.XtraGrid.Columns.GridColumn col本次到期月份;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col月平均费;
        private DevExpress.XtraGrid.Columns.GridColumn col不收款;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}