using WangDaDll;
using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmBusinessReg
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
            this.FEnddateEdit = new DevExpress.XtraEditors.DateEdit();
            this.FBegindateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cmbRegWC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnWC = new DevExpress.XtraEditors.SimpleButton();
            this.外勤进度ComboBox = new System.Windows.Forms.ComboBox();
            this.注册进度ComboBox = new System.Windows.Forms.ComboBox();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.公司预核名称TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.登记日期DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.登记日期DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.业务员TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tW_BusinessRegGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_BusinessRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessDataSet = new WangDaDll.Common.BusinessDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col公司预核名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col图章 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col银行 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col其他 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册利润 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开始时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col预计注册完成时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col备注 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col登记日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col办理成本 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col年做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册进度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col外勤进度 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册完成时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FEnddateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEnddateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBegindateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBegindateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRegWC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司预核名称TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业务员TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_BusinessRegGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_BusinessRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.FEnddateEdit);
            this.layoutControl1.Controls.Add(this.FBegindateEdit);
            this.layoutControl1.Controls.Add(this.cmbRegWC);
            this.layoutControl1.Controls.Add(this.btnWC);
            this.layoutControl1.Controls.Add(this.外勤进度ComboBox);
            this.layoutControl1.Controls.Add(this.注册进度ComboBox);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnDel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.公司预核名称TextEdit);
            this.layoutControl1.Controls.Add(this.登记日期DateEdit1);
            this.layoutControl1.Controls.Add(this.登记日期DateEdit);
            this.layoutControl1.Controls.Add(this.业务员TextEdit);
            this.layoutControl1.Controls.Add(this.tW_BusinessRegGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1258, 688);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // FEnddateEdit
            // 
            this.FEnddateEdit.EditValue = null;
            this.FEnddateEdit.Location = new System.Drawing.Point(819, 36);
            this.FEnddateEdit.Name = "FEnddateEdit";
            this.FEnddateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FEnddateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FEnddateEdit.Size = new System.Drawing.Size(118, 20);
            this.FEnddateEdit.StyleController = this.layoutControl1;
            this.FEnddateEdit.TabIndex = 26;
            // 
            // FBegindateEdit
            // 
            this.FBegindateEdit.EditValue = null;
            this.FBegindateEdit.Location = new System.Drawing.Point(614, 36);
            this.FBegindateEdit.Name = "FBegindateEdit";
            this.FBegindateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FBegindateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FBegindateEdit.Size = new System.Drawing.Size(122, 20);
            this.FBegindateEdit.StyleController = this.layoutControl1;
            this.FBegindateEdit.TabIndex = 10;
            // 
            // cmbRegWC
            // 
            this.cmbRegWC.EditValue = "未完成";
            this.cmbRegWC.Location = new System.Drawing.Point(450, 36);
            this.cmbRegWC.Name = "cmbRegWC";
            this.cmbRegWC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRegWC.Properties.Items.AddRange(new object[] {
            "未完成",
            "已完成"});
            this.cmbRegWC.Size = new System.Drawing.Size(81, 20);
            this.cmbRegWC.StyleController = this.layoutControl1;
            this.cmbRegWC.TabIndex = 25;
            // 
            // btnWC
            // 
            this.btnWC.Location = new System.Drawing.Point(512, 61);
            this.btnWC.Name = "btnWC";
            this.btnWC.Size = new System.Drawing.Size(89, 22);
            this.btnWC.StyleController = this.layoutControl1;
            this.btnWC.TabIndex = 19;
            this.btnWC.Text = "完成";
            this.btnWC.Click += new System.EventHandler(this.btnWC_Click);
            // 
            // 外勤进度ComboBox
            // 
            this.外勤进度ComboBox.FormattingEnabled = true;
            this.外勤进度ComboBox.Location = new System.Drawing.Point(273, 36);
            this.外勤进度ComboBox.Name = "外勤进度ComboBox";
            this.外勤进度ComboBox.Size = new System.Drawing.Size(94, 22);
            this.外勤进度ComboBox.TabIndex = 18;
            // 
            // 注册进度ComboBox
            // 
            this.注册进度ComboBox.FormattingEnabled = true;
            this.注册进度ComboBox.Location = new System.Drawing.Point(91, 36);
            this.注册进度ComboBox.Name = "注册进度ComboBox";
            this.注册进度ComboBox.Size = new System.Drawing.Size(99, 22);
            this.注册进度ComboBox.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 61);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 61);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 61);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(412, 61);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 22);
            this.btnDel.StyleController = this.layoutControl1;
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(605, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存样式";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(212, 61);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // 公司预核名称TextEdit
            // 
            this.公司预核名称TextEdit.Location = new System.Drawing.Point(236, 12);
            this.公司预核名称TextEdit.Name = "公司预核名称TextEdit";
            this.公司预核名称TextEdit.Size = new System.Drawing.Size(227, 20);
            this.公司预核名称TextEdit.StyleController = this.layoutControl1;
            this.公司预核名称TextEdit.TabIndex = 10;
            // 
            // 登记日期DateEdit1
            // 
            this.登记日期DateEdit1.EditValue = null;
            this.登记日期DateEdit1.Location = new System.Drawing.Point(725, 12);
            this.登记日期DateEdit1.Name = "登记日期DateEdit1";
            this.登记日期DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.登记日期DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.登记日期DateEdit1.Size = new System.Drawing.Size(96, 20);
            this.登记日期DateEdit1.StyleController = this.layoutControl1;
            this.登记日期DateEdit1.TabIndex = 9;
            // 
            // 登记日期DateEdit
            // 
            this.登记日期DateEdit.EditValue = null;
            this.登记日期DateEdit.Location = new System.Drawing.Point(546, 12);
            this.登记日期DateEdit.Name = "登记日期DateEdit";
            this.登记日期DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.登记日期DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.登记日期DateEdit.Size = new System.Drawing.Size(96, 20);
            this.登记日期DateEdit.StyleController = this.layoutControl1;
            this.登记日期DateEdit.TabIndex = 8;
            // 
            // 业务员TextEdit
            // 
            this.业务员TextEdit.Location = new System.Drawing.Point(91, 12);
            this.业务员TextEdit.Name = "业务员TextEdit";
            this.业务员TextEdit.Size = new System.Drawing.Size(62, 20);
            this.业务员TextEdit.StyleController = this.layoutControl1;
            this.业务员TextEdit.TabIndex = 6;
            // 
            // tW_BusinessRegGridControl
            // 
            this.tW_BusinessRegGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_BusinessRegGridControl.DataSource = this.tW_BusinessRegBindingSource;
            this.tW_BusinessRegGridControl.Location = new System.Drawing.Point(12, 87);
            this.tW_BusinessRegGridControl.MainView = this.gridView1;
            this.tW_BusinessRegGridControl.Name = "tW_BusinessRegGridControl";
            this.tW_BusinessRegGridControl.Size = new System.Drawing.Size(1234, 589);
            this.tW_BusinessRegGridControl.TabIndex = 4;
            this.tW_BusinessRegGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tW_BusinessRegBindingSource
            // 
            this.tW_BusinessRegBindingSource.DataMember = "TW_BusinessReg";
            this.tW_BusinessRegBindingSource.DataSource = this.businessDataSet;
            // 
            // businessDataSet
            // 
            this.businessDataSet.DataSetName = "BusinessDataSet";
            this.businessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.col公司预核名称,
            this.col业务员,
            this.col注册费,
            this.col图章,
            this.col银行,
            this.col其他,
            this.col注册利润,
            this.col月做账费,
            this.col工本费,
            this.col开票费,
            this.col开始时间,
            this.col预计注册完成时间,
            this.col备注,
            this.col登记日期,
            this.col修改人,
            this.col修改时间,
            this.col办理成本,
            this.col年做账费,
            this.col注册进度,
            this.col外勤进度,
            this.col公司类型,
            this.col注册员,
            this.col零申报,
            this.col注册类型,
            this.col注册完成时间});
            this.gridView1.GridControl = this.tW_BusinessRegGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册费", this.col注册费, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", this.col工本费, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "图章", this.col图章, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "银行", this.col银行, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", this.col开票费, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "年做账费", this.col年做账费, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "其他", this.col其他, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册利润", this.col注册利润, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "办理成本", this.col办理成本, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col公司预核名称
            // 
            this.col公司预核名称.FieldName = "公司预核名称";
            this.col公司预核名称.Name = "col公司预核名称";
            this.col公司预核名称.OptionsColumn.ReadOnly = true;
            this.col公司预核名称.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司预核名称.Visible = true;
            this.col公司预核名称.VisibleIndex = 3;
            this.col公司预核名称.Width = 183;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col业务员.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "业务员", "{0}")});
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 2;
            // 
            // col注册费
            // 
            this.col注册费.FieldName = "注册费";
            this.col注册费.Name = "col注册费";
            this.col注册费.OptionsColumn.ReadOnly = true;
            this.col注册费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册费", "{0:0.##}")});
            this.col注册费.Visible = true;
            this.col注册费.VisibleIndex = 5;
            // 
            // col图章
            // 
            this.col图章.FieldName = "图章";
            this.col图章.Name = "col图章";
            this.col图章.OptionsColumn.ReadOnly = true;
            this.col图章.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col图章.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "图章", "{0:0.##}")});
            this.col图章.Visible = true;
            this.col图章.VisibleIndex = 7;
            // 
            // col银行
            // 
            this.col银行.FieldName = "银行";
            this.col银行.Name = "col银行";
            this.col银行.OptionsColumn.ReadOnly = true;
            this.col银行.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col银行.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "银行", "{0:0.##}")});
            this.col银行.Visible = true;
            this.col银行.VisibleIndex = 8;
            // 
            // col其他
            // 
            this.col其他.FieldName = "其他";
            this.col其他.Name = "col其他";
            this.col其他.OptionsColumn.ReadOnly = true;
            this.col其他.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col其他.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "其他", "{0:0.##}")});
            this.col其他.Visible = true;
            this.col其他.VisibleIndex = 9;
            // 
            // col注册利润
            // 
            this.col注册利润.FieldName = "注册利润";
            this.col注册利润.Name = "col注册利润";
            this.col注册利润.OptionsColumn.ReadOnly = true;
            this.col注册利润.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册利润.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册利润", "{0:0.##}")});
            this.col注册利润.Visible = true;
            this.col注册利润.VisibleIndex = 11;
            // 
            // col月做账费
            // 
            this.col月做账费.FieldName = "月做账费";
            this.col月做账费.Name = "col月做账费";
            this.col月做账费.OptionsColumn.ReadOnly = true;
            this.col月做账费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col月做账费.Visible = true;
            this.col月做账费.VisibleIndex = 12;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.Name = "col工本费";
            this.col工本费.OptionsColumn.ReadOnly = true;
            this.col工本费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col工本费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", "{0:0.##}")});
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 14;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.Name = "col开票费";
            this.col开票费.OptionsColumn.ReadOnly = true;
            this.col开票费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col开票费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", "{0:0.##}")});
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 15;
            // 
            // col开始时间
            // 
            this.col开始时间.FieldName = "开始时间";
            this.col开始时间.Name = "col开始时间";
            this.col开始时间.OptionsColumn.ReadOnly = true;
            this.col开始时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col开始时间.Visible = true;
            this.col开始时间.VisibleIndex = 17;
            // 
            // col预计注册完成时间
            // 
            this.col预计注册完成时间.FieldName = "预计注册完成时间";
            this.col预计注册完成时间.Name = "col预计注册完成时间";
            this.col预计注册完成时间.OptionsColumn.ReadOnly = true;
            this.col预计注册完成时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col预计注册完成时间.Visible = true;
            this.col预计注册完成时间.VisibleIndex = 18;
            this.col预计注册完成时间.Width = 122;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.Name = "col备注";
            this.col备注.OptionsColumn.ReadOnly = true;
            this.col备注.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 19;
            // 
            // col登记日期
            // 
            this.col登记日期.FieldName = "登记日期";
            this.col登记日期.Name = "col登记日期";
            this.col登记日期.OptionsColumn.ReadOnly = true;
            this.col登记日期.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col登记日期.Visible = true;
            this.col登记日期.VisibleIndex = 16;
            // 
            // col修改人
            // 
            this.col修改人.FieldName = "修改人";
            this.col修改人.Name = "col修改人";
            this.col修改人.OptionsColumn.ReadOnly = true;
            this.col修改人.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改人.Visible = true;
            this.col修改人.VisibleIndex = 20;
            // 
            // col修改时间
            // 
            this.col修改时间.FieldName = "修改时间";
            this.col修改时间.Name = "col修改时间";
            this.col修改时间.OptionsColumn.ReadOnly = true;
            this.col修改时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改时间.Visible = true;
            this.col修改时间.VisibleIndex = 21;
            // 
            // col办理成本
            // 
            this.col办理成本.FieldName = "办理成本";
            this.col办理成本.Name = "col办理成本";
            this.col办理成本.OptionsColumn.ReadOnly = true;
            this.col办理成本.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col办理成本.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "办理成本", "{0:0.##}")});
            this.col办理成本.Visible = true;
            this.col办理成本.VisibleIndex = 10;
            // 
            // col年做账费
            // 
            this.col年做账费.FieldName = "年做账费";
            this.col年做账费.Name = "col年做账费";
            this.col年做账费.OptionsColumn.ReadOnly = true;
            this.col年做账费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col年做账费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "年做账费", "{0:0.##}")});
            this.col年做账费.Visible = true;
            this.col年做账费.VisibleIndex = 13;
            // 
            // col注册进度
            // 
            this.col注册进度.FieldName = "注册进度";
            this.col注册进度.Name = "col注册进度";
            this.col注册进度.OptionsColumn.ReadOnly = true;
            this.col注册进度.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册进度.Visible = true;
            this.col注册进度.VisibleIndex = 0;
            // 
            // col外勤进度
            // 
            this.col外勤进度.FieldName = "外勤进度";
            this.col外勤进度.Name = "col外勤进度";
            this.col外勤进度.OptionsColumn.ReadOnly = true;
            this.col外勤进度.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col外勤进度.Visible = true;
            this.col外勤进度.VisibleIndex = 1;
            // 
            // col公司类型
            // 
            this.col公司类型.FieldName = "公司类型";
            this.col公司类型.Name = "col公司类型";
            this.col公司类型.OptionsColumn.ReadOnly = true;
            this.col公司类型.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司类型.Visible = true;
            this.col公司类型.VisibleIndex = 4;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 22;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 23;
            // 
            // col注册类型
            // 
            this.col注册类型.FieldName = "注册类型";
            this.col注册类型.Name = "col注册类型";
            this.col注册类型.OptionsColumn.ReadOnly = true;
            this.col注册类型.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册类型.Visible = true;
            this.col注册类型.VisibleIndex = 24;
            // 
            // col注册完成时间
            // 
            this.col注册完成时间.FieldName = "注册完成时间";
            this.col注册完成时间.Name = "col注册完成时间";
            this.col注册完成时间.Visible = true;
            this.col注册完成时间.VisibleIndex = 6;
            this.col注册完成时间.Width = 115;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem2,
            this.layoutControlItem13,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1258, 688);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_BusinessRegGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1238, 593);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnNew;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 49);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnEdit;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(300, 49);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "layoutControlItem10";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextToControlDistance = 0;
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnQuery;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnClear;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(100, 49);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(693, 49);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(545, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.业务员TextEdit;
            this.layoutControlItem3.CustomizationFormText = "业务员:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(145, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(145, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(145, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "员工:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.公司预核名称TextEdit;
            this.layoutControlItem7.CustomizationFormText = "预核名称:";
            this.layoutControlItem7.Location = new System.Drawing.Point(145, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(310, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(310, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(310, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "预核名称:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.登记日期DateEdit;
            this.layoutControlItem5.CustomizationFormText = "登记日期:";
            this.layoutControlItem5.Location = new System.Drawing.Point(455, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "登记日期:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.登记日期DateEdit1;
            this.layoutControlItem6.CustomizationFormText = "到:";
            this.layoutControlItem6.Location = new System.Drawing.Point(634, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "到:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(593, 49);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnDel;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(400, 49);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.注册进度ComboBox;
            this.layoutControlItem14.CustomizationFormText = "注册进度:";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(182, 25);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(182, 25);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(182, 25);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "注册进度:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.外勤进度ComboBox;
            this.layoutControlItem15.CustomizationFormText = "外勤进度:";
            this.layoutControlItem15.Location = new System.Drawing.Point(182, 24);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(177, 25);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(177, 25);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(177, 25);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "外勤进度:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnWC;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(500, 49);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cmbRegWC;
            this.layoutControlItem13.CustomizationFormText = "注册完成状态:";
            this.layoutControlItem13.Location = new System.Drawing.Point(359, 24);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(164, 25);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(164, 25);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(164, 25);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "注册完成状态:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.FBegindateEdit;
            this.layoutControlItem18.CustomizationFormText = "完成时间:";
            this.layoutControlItem18.Location = new System.Drawing.Point(523, 24);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(205, 25);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(205, 25);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(205, 25);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.Text = "完成时间:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.FEnddateEdit;
            this.layoutControlItem19.CustomizationFormText = "到:";
            this.layoutControlItem19.Location = new System.Drawing.Point(728, 24);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(201, 25);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(201, 25);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(201, 25);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "到:";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(76, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(929, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(309, 25);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(813, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(425, 24);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.FBegindateEdit;
            this.layoutControlItem16.CustomizationFormText = "到:";
            this.layoutControlItem16.Location = new System.Drawing.Point(634, 0);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem16.Name = "layoutControlItem6";
            this.layoutControlItem16.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.Text = "到:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(95, 18);
            this.layoutControlItem16.TextToControlDistance = 5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.登记日期DateEdit;
            this.layoutControlItem17.CustomizationFormText = "登记日期:";
            this.layoutControlItem17.Location = new System.Drawing.Point(455, 0);
            this.layoutControlItem17.MaxSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(179, 24);
            this.layoutControlItem17.Name = "layoutControlItem5";
            this.layoutControlItem17.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "登记日期:";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(95, 18);
            this.layoutControlItem17.TextToControlDistance = 5;
            // 
            // FrmBusinessReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 688);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmBusinessReg";
            this.Text = "业务登记";
            this.Load += new System.EventHandler(this.FrmBusinessReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FEnddateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEnddateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBegindateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBegindateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRegWC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司预核名称TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.登记日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业务员TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_BusinessRegGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_BusinessRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit 公司预核名称TextEdit;
        private System.Windows.Forms.BindingSource tW_BusinessRegBindingSource;
        private BusinessDataSet businessDataSet;
        private DevExpress.XtraEditors.DateEdit 登记日期DateEdit1;
        private DevExpress.XtraEditors.DateEdit 登记日期DateEdit;
        private DevExpress.XtraEditors.TextEdit 业务员TextEdit;
        private DevExpress.XtraGrid.GridControl tW_BusinessRegGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col公司预核名称;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册费;
        private DevExpress.XtraGrid.Columns.GridColumn col图章;
        private DevExpress.XtraGrid.Columns.GridColumn col银行;
        private DevExpress.XtraGrid.Columns.GridColumn col其他;
        private DevExpress.XtraGrid.Columns.GridColumn col注册利润;
        private DevExpress.XtraGrid.Columns.GridColumn col月做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费;
        private DevExpress.XtraGrid.Columns.GridColumn col开始时间;
        private DevExpress.XtraGrid.Columns.GridColumn col预计注册完成时间;
        private DevExpress.XtraGrid.Columns.GridColumn col备注;
        private DevExpress.XtraGrid.Columns.GridColumn col登记日期;
        private DevExpress.XtraGrid.Columns.GridColumn col修改人;
        private DevExpress.XtraGrid.Columns.GridColumn col修改时间;
        private DevExpress.XtraGrid.Columns.GridColumn col办理成本;
        private DevExpress.XtraGrid.Columns.GridColumn col年做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col注册进度;
        private DevExpress.XtraGrid.Columns.GridColumn col外勤进度;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.ComboBox 外勤进度ComboBox;
        private System.Windows.Forms.ComboBox 注册进度ComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private Tiger.PdrCommon.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraGrid.Columns.GridColumn col公司类型;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraGrid.Columns.GridColumn col注册类型;
        private DevExpress.XtraEditors.SimpleButton btnWC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRegWC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraGrid.Columns.GridColumn col注册完成时间;
        private DevExpress.XtraEditors.DateEdit FEnddateEdit;
        private DevExpress.XtraEditors.DateEdit FBegindateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}