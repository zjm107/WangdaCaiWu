namespace WangDaDll.BusinessStart
{
    partial class FrmImpContract
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
            System.Windows.Forms.Label 客户名称Label;
            System.Windows.Forms.Label 签约日期Label;
            System.Windows.Forms.Label 签约日期Label1;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.签约日期DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.签约日期DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.客户名称TextBox = new System.Windows.Forms.TextBox();
            this.vM_一次性服务合同明细BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataSet = new WangDaDll.Contract.ContractDataSet();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.vM_一次性服务合同明细GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col所属行业 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col服务项目 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col签约日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司地址 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col纳税性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.businessDataSet = new WangDaDll.Common.BusinessDataSet();
            客户名称Label = new System.Windows.Forms.Label();
            签约日期Label = new System.Windows.Forms.Label();
            签约日期Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vM_一次性服务合同明细BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vM_一次性服务合同明细GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // 客户名称Label
            // 
            客户名称Label.AutoSize = true;
            客户名称Label.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            客户名称Label.Location = new System.Drawing.Point(46, 20);
            客户名称Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            客户名称Label.Name = "客户名称Label";
            客户名称Label.Size = new System.Drawing.Size(103, 25);
            客户名称Label.TabIndex = 0;
            客户名称Label.Text = "客户名称:";
            // 
            // 签约日期Label
            // 
            签约日期Label.AutoSize = true;
            签约日期Label.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            签约日期Label.Location = new System.Drawing.Point(691, 20);
            签约日期Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            签约日期Label.Name = "签约日期Label";
            签约日期Label.Size = new System.Drawing.Size(103, 25);
            签约日期Label.TabIndex = 2;
            签约日期Label.Text = "签约日期:";
            // 
            // 签约日期Label1
            // 
            签约日期Label1.AutoSize = true;
            签约日期Label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            签约日期Label1.Location = new System.Drawing.Point(956, 20);
            签约日期Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            签约日期Label1.Name = "签约日期Label1";
            签约日期Label1.Size = new System.Drawing.Size(33, 25);
            签约日期Label1.TabIndex = 4;
            签约日期Label1.Text = "到";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClear);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(签约日期Label1);
            this.panelControl1.Controls.Add(this.签约日期DateEdit1);
            this.panelControl1.Controls.Add(签约日期Label);
            this.panelControl1.Controls.Add(this.签约日期DateEdit);
            this.panelControl1.Controls.Add(客户名称Label);
            this.panelControl1.Controls.Add(this.客户名称TextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1544, 75);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(1333, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(1184, 14);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(140, 38);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // 签约日期DateEdit1
            // 
            this.签约日期DateEdit1.EditValue = null;
            this.签约日期DateEdit1.Location = new System.Drawing.Point(996, 14);
            this.签约日期DateEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.签约日期DateEdit1.Name = "签约日期DateEdit1";
            this.签约日期DateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.签约日期DateEdit1.Properties.Appearance.Options.UseFont = true;
            this.签约日期DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit1.Size = new System.Drawing.Size(156, 32);
            this.签约日期DateEdit1.TabIndex = 5;
            // 
            // 签约日期DateEdit
            // 
            this.签约日期DateEdit.EditValue = null;
            this.签约日期DateEdit.Location = new System.Drawing.Point(790, 14);
            this.签约日期DateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.签约日期DateEdit.Name = "签约日期DateEdit";
            this.签约日期DateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.签约日期DateEdit.Properties.Appearance.Options.UseFont = true;
            this.签约日期DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.签约日期DateEdit.Size = new System.Drawing.Size(156, 32);
            this.签约日期DateEdit.TabIndex = 3;
            // 
            // 客户名称TextBox
            // 
            this.客户名称TextBox.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.客户名称TextBox.Location = new System.Drawing.Point(153, 14);
            this.客户名称TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.客户名称TextBox.Name = "客户名称TextBox";
            this.客户名称TextBox.Size = new System.Drawing.Size(477, 33);
            this.客户名称TextBox.TabIndex = 1;
            // 
            // vM_一次性服务合同明细BindingSource
            // 
            this.vM_一次性服务合同明细BindingSource.DataMember = "VM_一次性服务合同明细";
            this.vM_一次性服务合同明细BindingSource.DataSource = this.contractDataSet;
            // 
            // contractDataSet
            // 
            this.contractDataSet.DataSetName = "ContractDataSet";
            this.contractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnOK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 968);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1544, 97);
            this.panelControl2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(229, 27);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 52);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(50, 27);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 52);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // vM_一次性服务合同明细GridControl
            // 
            this.vM_一次性服务合同明细GridControl.DataSource = this.vM_一次性服务合同明细BindingSource;
            this.vM_一次性服务合同明细GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vM_一次性服务合同明细GridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vM_一次性服务合同明细GridControl.Location = new System.Drawing.Point(0, 75);
            this.vM_一次性服务合同明细GridControl.MainView = this.gridView1;
            this.vM_一次性服务合同明细GridControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vM_一次性服务合同明细GridControl.Name = "vM_一次性服务合同明细GridControl";
            this.vM_一次性服务合同明细GridControl.Size = new System.Drawing.Size(1544, 893);
            this.vM_一次性服务合同明细GridControl.TabIndex = 2;
            this.vM_一次性服务合同明细GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.col客户名称,
            this.col所属行业,
            this.col服务类别,
            this.col服务金额,
            this.col服务项目,
            this.col签约日期,
            this.col公司性质,
            this.col公司地址,
            this.col公司类型,
            this.col纳税性质});
            this.gridView1.DetailHeight = 550;
            this.gridView1.GridControl = this.vM_一次性服务合同明细GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1143;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 43;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.PaintStyleName = "Style3D";
            // 
            // col合同编号
            // 
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.MinWidth = 29;
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.OptionsColumn.ReadOnly = true;
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 1;
            this.col合同编号.Width = 107;
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.MinWidth = 29;
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 2;
            this.col客户名称.Width = 439;
            // 
            // col所属行业
            // 
            this.col所属行业.FieldName = "所属行业";
            this.col所属行业.MinWidth = 29;
            this.col所属行业.Name = "col所属行业";
            this.col所属行业.OptionsColumn.ReadOnly = true;
            this.col所属行业.Visible = true;
            this.col所属行业.VisibleIndex = 7;
            this.col所属行业.Width = 107;
            // 
            // col服务类别
            // 
            this.col服务类别.FieldName = "服务类别";
            this.col服务类别.MinWidth = 29;
            this.col服务类别.Name = "col服务类别";
            this.col服务类别.OptionsColumn.ReadOnly = true;
            this.col服务类别.Visible = true;
            this.col服务类别.VisibleIndex = 4;
            this.col服务类别.Width = 107;
            // 
            // col服务金额
            // 
            this.col服务金额.FieldName = "服务金额";
            this.col服务金额.MinWidth = 29;
            this.col服务金额.Name = "col服务金额";
            this.col服务金额.OptionsColumn.ReadOnly = true;
            this.col服务金额.Visible = true;
            this.col服务金额.VisibleIndex = 6;
            this.col服务金额.Width = 190;
            // 
            // col服务项目
            // 
            this.col服务项目.FieldName = "服务项目";
            this.col服务项目.MinWidth = 29;
            this.col服务项目.Name = "col服务项目";
            this.col服务项目.OptionsColumn.ReadOnly = true;
            this.col服务项目.Visible = true;
            this.col服务项目.VisibleIndex = 5;
            this.col服务项目.Width = 107;
            // 
            // col签约日期
            // 
            this.col签约日期.FieldName = "签约日期";
            this.col签约日期.MinWidth = 29;
            this.col签约日期.Name = "col签约日期";
            this.col签约日期.OptionsColumn.ReadOnly = true;
            this.col签约日期.Visible = true;
            this.col签约日期.VisibleIndex = 3;
            this.col签约日期.Width = 107;
            // 
            // col公司性质
            // 
            this.col公司性质.FieldName = "公司性质";
            this.col公司性质.MinWidth = 29;
            this.col公司性质.Name = "col公司性质";
            this.col公司性质.OptionsColumn.ReadOnly = true;
            this.col公司性质.Visible = true;
            this.col公司性质.VisibleIndex = 9;
            this.col公司性质.Width = 107;
            // 
            // col公司地址
            // 
            this.col公司地址.FieldName = "公司地址";
            this.col公司地址.MinWidth = 29;
            this.col公司地址.Name = "col公司地址";
            this.col公司地址.OptionsColumn.ReadOnly = true;
            this.col公司地址.Visible = true;
            this.col公司地址.VisibleIndex = 10;
            this.col公司地址.Width = 107;
            // 
            // col公司类型
            // 
            this.col公司类型.FieldName = "公司类型";
            this.col公司类型.MinWidth = 29;
            this.col公司类型.Name = "col公司类型";
            this.col公司类型.OptionsColumn.ReadOnly = true;
            this.col公司类型.Visible = true;
            this.col公司类型.VisibleIndex = 8;
            this.col公司类型.Width = 107;
            // 
            // col纳税性质
            // 
            this.col纳税性质.FieldName = "纳税性质";
            this.col纳税性质.MinWidth = 29;
            this.col纳税性质.Name = "col纳税性质";
            this.col纳税性质.OptionsColumn.ReadOnly = true;
            this.col纳税性质.Visible = true;
            this.col纳税性质.VisibleIndex = 11;
            this.col纳税性质.Width = 107;
            // 
            // splash
            // 
            this.splash.ClosingDelay = 500;
            // 
            // businessDataSet
            // 
            this.businessDataSet.DataSetName = "BusinessDataSet";
            this.businessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmImpContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1065);
            this.Controls.Add(this.vM_一次性服务合同明细GridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmImpContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "从合同导入业务登记";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签约日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vM_一次性服务合同明细BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vM_一次性服务合同明细GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Contract.ContractDataSet contractDataSet;
        private System.Windows.Forms.BindingSource vM_一次性服务合同明细BindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox 客户名称TextBox;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit 签约日期DateEdit1;
        private DevExpress.XtraEditors.DateEdit 签约日期DateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl vM_一次性服务合同明细GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col所属行业;
        private DevExpress.XtraGrid.Columns.GridColumn col服务类别;
        private DevExpress.XtraGrid.Columns.GridColumn col服务金额;
        private DevExpress.XtraGrid.Columns.GridColumn col服务项目;
        private DevExpress.XtraGrid.Columns.GridColumn col签约日期;
        private DevExpress.XtraGrid.Columns.GridColumn col公司性质;
        private DevExpress.XtraGrid.Columns.GridColumn col公司地址;
        private DevExpress.XtraGrid.Columns.GridColumn col公司类型;
        private DevExpress.XtraGrid.Columns.GridColumn col纳税性质;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
        public Common.BusinessDataSet businessDataSet;
    }
}