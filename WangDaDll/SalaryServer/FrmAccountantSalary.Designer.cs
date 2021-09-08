using WangDaDll.SalaryServer;

namespace WangDaDll
{
    partial class FrmAccountantSalary
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
            this.btnSCYJ = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.accountantBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.yearSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.monthComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.vW_AllAccountantSalaryGridControl = new DevExpress.XtraGrid.GridControl();
            this.vW_AllAccountantSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet = new WangDaDll.SalaryServer.SalaryDataSet();
            this.vW_AllAccountantSalaryGridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col员工 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本收款费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票收款费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费开票费提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col团队提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col学徒提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col实习工资 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col提成汇总 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务提成 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.tW_SalarySumBindingSourceYW = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSetYW = new WangDaDll.SalaryServer.SalaryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_SalarySumBindingSourceYW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetYW)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSCYJ);
            this.layoutControl1.Controls.Add(this.btnSaveLayout);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnViewDetail);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.accountantBtn);
            this.layoutControl1.Controls.Add(this.yearSpinEdit);
            this.layoutControl1.Controls.Add(this.monthComboBoxEdit);
            this.layoutControl1.Controls.Add(this.vW_AllAccountantSalaryGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(870, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSCYJ
            // 
            this.btnSCYJ.Location = new System.Drawing.Point(291, 36);
            this.btnSCYJ.Name = "btnSCYJ";
            this.btnSCYJ.Size = new System.Drawing.Size(89, 22);
            this.btnSCYJ.StyleController = this.layoutControl1;
            this.btnSCYJ.TabIndex = 12;
            this.btnSCYJ.Text = "生成业绩";
            this.btnSCYJ.Click += new System.EventHandler(this.btnSCYJ_Click);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(291, 36);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(89, 22);
            this.btnSaveLayout.StyleController = this.layoutControl1;
            this.btnSaveLayout.TabIndex = 11;
            this.btnSaveLayout.Text = "保存样式";
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(198, 36);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(89, 22);
            this.btnViewDetail.StyleController = this.layoutControl1;
            this.btnViewDetail.TabIndex = 9;
            this.btnViewDetail.Text = "查看明细";
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 36);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // accountantBtn
            // 
            this.accountantBtn.Location = new System.Drawing.Point(344, 12);
            this.accountantBtn.Name = "accountantBtn";
            this.accountantBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.accountantBtn.Properties.ReadOnly = true;
            this.accountantBtn.Size = new System.Drawing.Size(97, 20);
            this.accountantBtn.StyleController = this.layoutControl1;
            this.accountantBtn.TabIndex = 7;
            this.accountantBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.accountantBtn_ButtonClick);
            // 
            // yearSpinEdit
            // 
            this.yearSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yearSpinEdit.Location = new System.Drawing.Point(67, 12);
            this.yearSpinEdit.Name = "yearSpinEdit";
            this.yearSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yearSpinEdit.Size = new System.Drawing.Size(83, 20);
            this.yearSpinEdit.StyleController = this.layoutControl1;
            this.yearSpinEdit.TabIndex = 6;
            // 
            // monthComboBoxEdit
            // 
            this.monthComboBoxEdit.Location = new System.Drawing.Point(209, 12);
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
            this.monthComboBoxEdit.Size = new System.Drawing.Size(76, 20);
            this.monthComboBoxEdit.StyleController = this.layoutControl1;
            this.monthComboBoxEdit.TabIndex = 5;
            // 
            // vW_AllAccountantSalaryGridControl
            // 
            this.vW_AllAccountantSalaryGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.vW_AllAccountantSalaryGridControl.DataSource = this.vW_AllAccountantSalaryBindingSource;
            this.vW_AllAccountantSalaryGridControl.Location = new System.Drawing.Point(12, 62);
            this.vW_AllAccountantSalaryGridControl.MainView = this.vW_AllAccountantSalaryGridview;
            this.vW_AllAccountantSalaryGridControl.Name = "vW_AllAccountantSalaryGridControl";
            this.vW_AllAccountantSalaryGridControl.Size = new System.Drawing.Size(846, 488);
            this.vW_AllAccountantSalaryGridControl.TabIndex = 4;
            this.vW_AllAccountantSalaryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vW_AllAccountantSalaryGridview});
            this.vW_AllAccountantSalaryGridControl.DoubleClick += new System.EventHandler(this.vW_AllAccountantSalaryGridControl_DoubleClick);
            // 
            // vW_AllAccountantSalaryBindingSource
            // 
            this.vW_AllAccountantSalaryBindingSource.DataMember = "VW_AllAccountantSalary";
            this.vW_AllAccountantSalaryBindingSource.DataSource = this.salaryDataSet;
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "SalaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_AllAccountantSalaryGridview
            // 
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.Empty.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.EvenRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.EvenRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterPanel.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FilterPanel.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FixedLine.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedCell.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedCell.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FocusedRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.FooterPanel.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupButton.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupFooter.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupPanel.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupPanel.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.Options.UseFont = true;
            this.vW_AllAccountantSalaryGridview.Appearance.GroupRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.vW_AllAccountantSalaryGridview.Appearance.HorzLine.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.OddRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.OddRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.vW_AllAccountantSalaryGridview.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.vW_AllAccountantSalaryGridview.Appearance.Preview.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.Preview.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vW_AllAccountantSalaryGridview.Appearance.Row.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.Row.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.RowSeparator.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.vW_AllAccountantSalaryGridview.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.vW_AllAccountantSalaryGridview.Appearance.SelectedRow.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.SelectedRow.Options.UseForeColor = true;
            this.vW_AllAccountantSalaryGridview.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.vW_AllAccountantSalaryGridview.Appearance.VertLine.Options.UseBackColor = true;
            this.vW_AllAccountantSalaryGridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col员工,
            this.col做账收款额,
            this.col月做账费,
            this.col做账提成,
            this.col工本收款费,
            this.col开票收款费,
            this.col工本费开票费提成,
            this.col团队提成,
            this.col学徒提成,
            this.col实习工资,
            this.col提成汇总,
            this.col业务提成});
            this.vW_AllAccountantSalaryGridview.GridControl = this.vW_AllAccountantSalaryGridControl;
            this.vW_AllAccountantSalaryGridview.Name = "vW_AllAccountantSalaryGridview";
            this.vW_AllAccountantSalaryGridview.OptionsView.ColumnAutoWidth = false;
            this.vW_AllAccountantSalaryGridview.OptionsView.EnableAppearanceEvenRow = true;
            this.vW_AllAccountantSalaryGridview.OptionsView.EnableAppearanceOddRow = true;
            this.vW_AllAccountantSalaryGridview.OptionsView.ShowAutoFilterRow = true;
            this.vW_AllAccountantSalaryGridview.OptionsView.ShowFooter = true;
            this.vW_AllAccountantSalaryGridview.PaintStyleName = "Flat";
            // 
            // col员工
            // 
            this.col员工.FieldName = "员工";
            this.col员工.Name = "col员工";
            this.col员工.OptionsColumn.ReadOnly = true;
            this.col员工.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col员工.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "员工", "{0}")});
            this.col员工.Visible = true;
            this.col员工.VisibleIndex = 0;
            // 
            // col做账收款额
            // 
            this.col做账收款额.FieldName = "做账收款额";
            this.col做账收款额.Name = "col做账收款额";
            this.col做账收款额.OptionsColumn.ReadOnly = true;
            this.col做账收款额.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账收款额", "{0:0.##}")});
            this.col做账收款额.Visible = true;
            this.col做账收款额.VisibleIndex = 1;
            this.col做账收款额.Width = 80;
            // 
            // col月做账费
            // 
            this.col月做账费.FieldName = "月做账费";
            this.col月做账费.Name = "col月做账费";
            this.col月做账费.OptionsColumn.ReadOnly = true;
            this.col月做账费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "月做账费", "{0:0.##}")});
            this.col月做账费.Visible = true;
            this.col月做账费.VisibleIndex = 2;
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
            this.col做账提成.VisibleIndex = 3;
            // 
            // col工本收款费
            // 
            this.col工本收款费.FieldName = "工本收款费";
            this.col工本收款费.Name = "col工本收款费";
            this.col工本收款费.OptionsColumn.ReadOnly = true;
            this.col工本收款费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col工本收款费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本收款费", "{0:0.##}")});
            this.col工本收款费.Visible = true;
            this.col工本收款费.VisibleIndex = 4;
            this.col工本收款费.Width = 80;
            // 
            // col开票收款费
            // 
            this.col开票收款费.FieldName = "开票收款费";
            this.col开票收款费.Name = "col开票收款费";
            this.col开票收款费.OptionsColumn.ReadOnly = true;
            this.col开票收款费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col开票收款费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票收款费", "{0:0.##}")});
            this.col开票收款费.Visible = true;
            this.col开票收款费.VisibleIndex = 5;
            this.col开票收款费.Width = 80;
            // 
            // col工本费开票费提成
            // 
            this.col工本费开票费提成.FieldName = "工本费开票费提成";
            this.col工本费开票费提成.Name = "col工本费开票费提成";
            this.col工本费开票费提成.OptionsColumn.ReadOnly = true;
            this.col工本费开票费提成.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col工本费开票费提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费开票费提成", "{0:0.##}")});
            this.col工本费开票费提成.Visible = true;
            this.col工本费开票费提成.VisibleIndex = 6;
            this.col工本费开票费提成.Width = 116;
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
            this.col团队提成.VisibleIndex = 8;
            // 
            // col学徒提成
            // 
            this.col学徒提成.FieldName = "学徒提成";
            this.col学徒提成.Name = "col学徒提成";
            this.col学徒提成.OptionsColumn.ReadOnly = true;
            this.col学徒提成.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col学徒提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "学徒提成", "{0:0.##}")});
            // 
            // col实习工资
            // 
            this.col实习工资.FieldName = "实习工资";
            this.col实习工资.Name = "col实习工资";
            this.col实习工资.OptionsColumn.ReadOnly = true;
            this.col实习工资.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col实习工资.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "实习工资", "{0:0.##}")});
            this.col实习工资.Visible = true;
            this.col实习工资.VisibleIndex = 7;
            // 
            // col提成汇总
            // 
            this.col提成汇总.FieldName = "提成汇总";
            this.col提成汇总.Name = "col提成汇总";
            this.col提成汇总.OptionsColumn.ReadOnly = true;
            this.col提成汇总.Visible = true;
            this.col提成汇总.VisibleIndex = 10;
            // 
            // col业务提成
            // 
            this.col业务提成.FieldName = "业务提成";
            this.col业务提成.Name = "col业务提成";
            this.col业务提成.OptionsColumn.ReadOnly = true;
            this.col业务提成.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "业务提成", "{0:0.##}")});
            this.col业务提成.Visible = true;
            this.col业务提成.VisibleIndex = 9;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSCYJ;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(279, 24);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
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
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(870, 562);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vW_AllAccountantSalaryGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(850, 492);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.monthComboBoxEdit;
            this.layoutControlItem2.CustomizationFormText = "月:";
            this.layoutControlItem2.Location = new System.Drawing.Point(142, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(135, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(135, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(135, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "月:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.yearSpinEdit;
            this.layoutControlItem3.CustomizationFormText = "年:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(142, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(142, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(142, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "年:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.accountantBtn;
            this.layoutControlItem4.CustomizationFormText = "做账会计:";
            this.layoutControlItem4.Location = new System.Drawing.Point(277, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(156, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(156, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "做账会计:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(433, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(417, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnViewDetail;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(186, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnClear;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(93, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(372, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(478, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSaveLayout;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(279, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
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
            // FrmAccountantSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 562);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmAccountantSalary";
            this.Text = "做账会计业绩统计";
            this.Load += new System.EventHandler(this.FrmAccountantSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountantBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_AllAccountantSalaryGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_SalarySumBindingSourceYW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetYW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ButtonEdit accountantBtn;
        private DevExpress.XtraEditors.SpinEdit yearSpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit monthComboBoxEdit;
        private DevExpress.XtraGrid.GridControl vW_AllAccountantSalaryGridControl;
        private System.Windows.Forms.BindingSource vW_AllAccountantSalaryBindingSource;
        private SalaryDataSet salaryDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView vW_AllAccountantSalaryGridview;
        private DevExpress.XtraGrid.Columns.GridColumn col员工;
        private DevExpress.XtraGrid.Columns.GridColumn col做账收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col做账提成;
        private DevExpress.XtraGrid.Columns.GridColumn col工本收款费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票收款费;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费开票费提成;
        private DevExpress.XtraGrid.Columns.GridColumn col团队提成;
        private DevExpress.XtraGrid.Columns.GridColumn col学徒提成;
        private DevExpress.XtraGrid.Columns.GridColumn col实习工资;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnViewDetail;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnSaveLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn col提成汇总;
        private DevExpress.XtraGrid.Columns.GridColumn col月做账费;
        private DevExpress.XtraEditors.SimpleButton btnSCYJ;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource tW_SalarySumBindingSourceYW;
        private SalaryDataSet salaryDataSetYW;
        private DevExpress.XtraGrid.Columns.GridColumn col业务提成;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
    }
}