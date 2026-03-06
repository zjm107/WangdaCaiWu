using WangDaDll.Contract;
namespace WangDaDll
{
    partial class FrmCycleContract
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.EndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.续签状态ComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.做账会计ButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.vW_ContractServiceInfoGridControl = new DevExpress.XtraGrid.GridControl();
            this.vW_ContractServiceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.合同编号HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.客户名称HyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col合同金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开始服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col结束服务月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col签约日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务总时长月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务项目 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col续签 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.续签状态ComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计ButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_ContractServiceInfoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_ContractServiceInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.EndDateEdit);
            this.panelControl1.Controls.Add(this.startDateEdit);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.续签状态ComboBoxEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.做账会计ButtonEdit);
            this.panelControl1.Controls.Add(this.btnClear);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1221, 96);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(915, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 25);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "-";
            // 
            // EndDateEdit
            // 
            this.EndDateEdit.EditValue = null;
            this.EndDateEdit.Location = new System.Drawing.Point(929, 9);
            this.EndDateEdit.Name = "EndDateEdit";
            this.EndDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateEdit.Properties.Appearance.Options.UseFont = true;
            this.EndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateEdit.Size = new System.Drawing.Size(150, 32);
            this.EndDateEdit.TabIndex = 8;
            // 
            // startDateEdit
            // 
            this.startDateEdit.EditValue = null;
            this.startDateEdit.Location = new System.Drawing.Point(759, 9);
            this.startDateEdit.Name = "startDateEdit";
            this.startDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateEdit.Properties.Appearance.Options.UseFont = true;
            this.startDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateEdit.Size = new System.Drawing.Size(150, 32);
            this.startDateEdit.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(648, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "签订日期：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(327, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "续签/新签：";
            // 
            // 续签状态ComboBoxEdit1
            // 
            this.续签状态ComboBoxEdit1.EditValue = "全部";
            this.续签状态ComboBoxEdit1.Location = new System.Drawing.Point(452, 9);
            this.续签状态ComboBoxEdit1.Name = "续签状态ComboBoxEdit1";
            this.续签状态ComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.续签状态ComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.续签状态ComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.续签状态ComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "续签",
            "新签",
            "全部"});
            this.续签状态ComboBoxEdit1.Size = new System.Drawing.Size(150, 32);
            this.续签状态ComboBoxEdit1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 25);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "做账会计：";
            // 
            // 做账会计ButtonEdit
            // 
            this.做账会计ButtonEdit.Location = new System.Drawing.Point(136, 9);
            this.做账会计ButtonEdit.Name = "做账会计ButtonEdit";
            this.做账会计ButtonEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.做账会计ButtonEdit.Properties.Appearance.Options.UseFont = true;
            this.做账会计ButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.做账会计ButtonEdit.Size = new System.Drawing.Size(150, 32);
            this.做账会计ButtonEdit.TabIndex = 2;
            this.做账会计ButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.AccountingButtonEdit_ButtonClick);
            this.做账会计ButtonEdit.EditValueChanged += new System.EventHandler(this.AccountingButtonEdit_EditValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(173, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(23, 51);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 34);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.vW_ContractServiceInfoGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 96);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1221, 659);
            this.panelControl2.TabIndex = 1;
            // 
            // vW_ContractServiceInfoGridControl
            // 
            this.vW_ContractServiceInfoGridControl.DataSource = this.vW_ContractServiceInfoBindingSource;
            this.vW_ContractServiceInfoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vW_ContractServiceInfoGridControl.Location = new System.Drawing.Point(2, 2);
            this.vW_ContractServiceInfoGridControl.MainView = this.gridView1;
            this.vW_ContractServiceInfoGridControl.Name = "vW_ContractServiceInfoGridControl";
            this.vW_ContractServiceInfoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.合同编号HyperLinkEdit,
            this.客户名称HyperLinkEdit});
            this.vW_ContractServiceInfoGridControl.Size = new System.Drawing.Size(1217, 655);
            this.vW_ContractServiceInfoGridControl.TabIndex = 0;
            this.vW_ContractServiceInfoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vW_ContractServiceInfoBindingSource
            // 
            this.vW_ContractServiceInfoBindingSource.DataMember = "VW_ContractServiceInfo";
            this.vW_ContractServiceInfoBindingSource.DataSource = this.contractDataSet;
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
            this.col合同编号,
            this.col客户名称,
            this.col做账会计,
            this.col合同金额,
            this.col开始服务月,
            this.col结束服务月,
            this.col签约日期,
            this.col服务总时长月,
            this.col服务金额,
            this.col服务项目,
            this.col续签});
            this.gridView1.GridControl = this.vW_ContractServiceInfoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col合同编号
            // 
            this.col合同编号.ColumnEdit = this.合同编号HyperLinkEdit;
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.MinWidth = 30;
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "合同编号", "{0}")});
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 0;
            this.col合同编号.Width = 120;
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
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 1;
            this.col客户名称.Width = 120;
            // 
            // 客户名称HyperLinkEdit
            // 
            this.客户名称HyperLinkEdit.AutoHeight = false;
            this.客户名称HyperLinkEdit.Name = "客户名称HyperLinkEdit";
            this.客户名称HyperLinkEdit.DoubleClick += new System.EventHandler(this.客户名称HyperLinkEdit_DoubleClick);
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.MinWidth = 30;
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 2;
            this.col做账会计.Width = 120;
            // 
            // col合同金额
            // 
            this.col合同金额.FieldName = "合同金额";
            this.col合同金额.MinWidth = 30;
            this.col合同金额.Name = "col合同金额";
            this.col合同金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "合同金额", "{0:0.##}")});
            this.col合同金额.Visible = true;
            this.col合同金额.VisibleIndex = 3;
            this.col合同金额.Width = 120;
            // 
            // col开始服务月
            // 
            this.col开始服务月.FieldName = "开始服务月";
            this.col开始服务月.MinWidth = 30;
            this.col开始服务月.Name = "col开始服务月";
            this.col开始服务月.Visible = true;
            this.col开始服务月.VisibleIndex = 4;
            this.col开始服务月.Width = 142;
            // 
            // col结束服务月
            // 
            this.col结束服务月.FieldName = "结束服务月";
            this.col结束服务月.MinWidth = 30;
            this.col结束服务月.Name = "col结束服务月";
            this.col结束服务月.Visible = true;
            this.col结束服务月.VisibleIndex = 5;
            this.col结束服务月.Width = 142;
            // 
            // col签约日期
            // 
            this.col签约日期.FieldName = "签约日期";
            this.col签约日期.MinWidth = 30;
            this.col签约日期.Name = "col签约日期";
            this.col签约日期.Visible = true;
            this.col签约日期.VisibleIndex = 9;
            this.col签约日期.Width = 120;
            // 
            // col服务总时长月
            // 
            this.col服务总时长月.FieldName = "服务总时长月";
            this.col服务总时长月.MinWidth = 30;
            this.col服务总时长月.Name = "col服务总时长月";
            this.col服务总时长月.Visible = true;
            this.col服务总时长月.VisibleIndex = 6;
            this.col服务总时长月.Width = 164;
            // 
            // col服务金额
            // 
            this.col服务金额.FieldName = "服务金额";
            this.col服务金额.MinWidth = 30;
            this.col服务金额.Name = "col服务金额";
            this.col服务金额.Visible = true;
            this.col服务金额.VisibleIndex = 8;
            this.col服务金额.Width = 120;
            // 
            // col服务项目
            // 
            this.col服务项目.FieldName = "服务项目";
            this.col服务项目.MinWidth = 30;
            this.col服务项目.Name = "col服务项目";
            this.col服务项目.Visible = true;
            this.col服务项目.VisibleIndex = 7;
            this.col服务项目.Width = 120;
            // 
            // col续签
            // 
            this.col续签.FieldName = "续签";
            this.col续签.MinWidth = 30;
            this.col续签.Name = "col续签";
            this.col续签.OptionsColumn.ReadOnly = true;
            this.col续签.Visible = true;
            this.col续签.VisibleIndex = 10;
            this.col续签.Width = 112;
            // 
            // FrmCycleContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 755);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCycleContract";
            this.Text = "周期合同查询";
            this.Load += new System.EventHandler(this.FrmCycleContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.续签状态ComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计ButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vW_ContractServiceInfoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_ContractServiceInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.合同编号HyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称HyperLinkEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl vW_ContractServiceInfoGridControl;
        private System.Windows.Forms.BindingSource vW_ContractServiceInfoBindingSource;
        private ContractDataSet contractDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col合同金额;
        private DevExpress.XtraGrid.Columns.GridColumn col开始服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col结束服务月;
        private DevExpress.XtraGrid.Columns.GridColumn col签约日期;
        private DevExpress.XtraGrid.Columns.GridColumn col服务总时长月;
        private DevExpress.XtraGrid.Columns.GridColumn col服务金额;
        private DevExpress.XtraGrid.Columns.GridColumn col服务项目;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit 续签状态ComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit 做账会计ButtonEdit;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 合同编号HyperLinkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit 客户名称HyperLinkEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit EndDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn col续签;
    }
}