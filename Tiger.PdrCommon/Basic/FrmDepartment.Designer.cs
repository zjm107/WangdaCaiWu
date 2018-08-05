namespace Tiger.PdrCommon
{
    partial class FrmDepartment
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        private void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DepartmentTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDepartmentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPTCATEGORY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tB_DepartmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.TCOM_DEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstDepartment1 = new Tiger.PdrCommon.DstDepartment();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_DepartmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_DEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstDepartment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.btnShow);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "部门信息";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DepartmentTree);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 22);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(209, 428);
            this.panelControl2.TabIndex = 3;
            // 
            // DepartmentTree
            // 
            this.DepartmentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentTree.ImageIndex = 0;
            this.DepartmentTree.ImageList = this.imageList1;
            this.DepartmentTree.Location = new System.Drawing.Point(2, 2);
            this.DepartmentTree.Name = "DepartmentTree";
            this.DepartmentTree.SelectedImageIndex = 0;
            this.DepartmentTree.Size = new System.Drawing.Size(205, 424);
            this.DepartmentTree.TabIndex = 1;
            this.toolTip.SetToolTip(this.DepartmentTree, "单击部门，可查看该部门信息\r\n双击部门，可查看该部门下级部门信息");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Home.ico");
            this.imageList1.Images.SetKeyName(1, "node3.ico");
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShow.Location = new System.Drawing.Point(2, 450);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(209, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "刷新";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(213, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 475);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentID,
            this.colDepartmentName,
            this.colRemarks,
            this.colPDepartmentName,
            this.colPDepartmentNo,
            this.colDEPTCATEGORY});
            this.gridView1.GridControl = this.tB_DepartmentGridControl;
            this.gridView1.GroupPanelText = "拖动列到这里进行分组";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "数量：{0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "选中一个部门添加子部门";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.Caption = "DepartmentID";
            this.colDepartmentID.FieldName = "DEPTID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.Width = 94;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "部门名称";
            this.colDepartmentName.FieldName = "DEPTNAME";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DepartmentName", "有{0}个部门")});
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 0;
            this.colDepartmentName.Width = 74;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "REMARK";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Width = 48;
            // 
            // colPDepartmentName
            // 
            this.colPDepartmentName.Caption = "所属部门名称";
            this.colPDepartmentName.FieldName = "PDEPARTMENTNAME";
            this.colPDepartmentName.Name = "colPDepartmentName";
            this.colPDepartmentName.OptionsColumn.AllowEdit = false;
            this.colPDepartmentName.OptionsColumn.AllowFocus = false;
            this.colPDepartmentName.OptionsColumn.ReadOnly = true;
            this.colPDepartmentName.Visible = true;
            this.colPDepartmentName.VisibleIndex = 1;
            this.colPDepartmentName.Width = 100;
            // 
            // colPDepartmentNo
            // 
            this.colPDepartmentNo.Caption = "所属部门编码";
            this.colPDepartmentNo.FieldName = "PDEPARTMENTNO";
            this.colPDepartmentNo.Name = "colPDepartmentNo";
            this.colPDepartmentNo.OptionsColumn.AllowEdit = false;
            this.colPDepartmentNo.OptionsColumn.AllowFocus = false;
            this.colPDepartmentNo.OptionsColumn.ReadOnly = true;
            this.colPDepartmentNo.Visible = true;
            this.colPDepartmentNo.VisibleIndex = 2;
            this.colPDepartmentNo.Width = 100;
            // 
            // colDEPTCATEGORY
            // 
            this.colDEPTCATEGORY.Caption = "部门类型";
            this.colDEPTCATEGORY.FieldName = "DEPTCATEGORY";
            this.colDEPTCATEGORY.Name = "colDEPTCATEGORY";
            this.colDEPTCATEGORY.Visible = true;
            this.colDEPTCATEGORY.VisibleIndex = 3;
            // 
            // tB_DepartmentGridControl
            // 
            this.tB_DepartmentGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_DepartmentGridControl.DataSource = this.TCOM_DEPTBindingSource;
            this.tB_DepartmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_DepartmentGridControl.Location = new System.Drawing.Point(2, 2);
            this.tB_DepartmentGridControl.MainView = this.gridView1;
            this.tB_DepartmentGridControl.Name = "tB_DepartmentGridControl";
            this.tB_DepartmentGridControl.Size = new System.Drawing.Size(741, 435);
            this.tB_DepartmentGridControl.TabIndex = 5;
            this.toolTip.SetToolTip(this.tB_DepartmentGridControl, "添加部门必须要选择一个所属部门\r\n添加删除修改完成后，单击工具栏保存按钮");
            this.tB_DepartmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TCOM_DEPTBindingSource
            // 
            this.TCOM_DEPTBindingSource.DataMember = "TCOM_DEPT";
            this.TCOM_DEPTBindingSource.DataSource = this.dstDepartment1;
            this.TCOM_DEPTBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.TCOM_DEPTBindingSource_AddingNew);
            // 
            // dstDepartment1
            // 
            this.dstDepartment1.DataSetName = "DstDepartment";
            this.dstDepartment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(218, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(749, 475);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnDel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(745, 32);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.tB_DepartmentGridControl);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 34);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(745, 439);
            this.panelControl4.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(6, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmDepartment
            // 
            this.ClientSize = new System.Drawing.Size(967, 475);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDepartment";
            this.Text = "部门信息";
            this.Activated += new System.EventHandler(this.FrmDepartment_Activated);
            this.Deactivate += new System.EventHandler(this.FrmDepartment_Deactivate);
            this.Load += new System.EventHandler(this.TigerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_DepartmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_DEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstDepartment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TreeView DepartmentTree;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colPDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colPDepartmentNo;
        private DevExpress.XtraGrid.GridControl tB_DepartmentGridControl;
        private System.Windows.Forms.ImageList imageList1;
        private DstDepartment dstDepartment1;
        private System.Windows.Forms.BindingSource TCOM_DEPTBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPTCATEGORY;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}
