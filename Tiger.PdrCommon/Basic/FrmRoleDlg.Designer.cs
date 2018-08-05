namespace Tiger.PdrCommon
{
    partial class FrmRoleDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoleDlg));
            this.TCOM_ROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstUserRole = new Tiger.PdrCommon.DstUserRole();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSelectRole = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.TCOM_ROLEgridControl = new DevExpress.XtraGrid.GridControl();
            this.TCOM_ROLEgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.systemtree = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // TCOM_ROLEBindingSource
            // 
            this.TCOM_ROLEBindingSource.DataMember = "TCOM_ROLE";
            this.TCOM_ROLEBindingSource.DataSource = this.dstUserRole;
            this.TCOM_ROLEBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.TCOM_ROLEBindingSource_AddingNew);
            this.TCOM_ROLEBindingSource.PositionChanged += new System.EventHandler(this.TCOM_ROLEBindingSource_PositionChanged);
            // 
            // dstUserRole
            // 
            this.dstUserRole.DataSetName = "DstUserRole";
            this.dstUserRole.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.btnSelectRole);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnOk);
            this.layoutControl1.Controls.Add(this.TCOM_ROLEgridControl);
            this.layoutControl1.Controls.Add(this.systemtree);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(871, 678);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSelectRole
            // 
            this.btnSelectRole.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRole.Appearance.Options.UseFont = true;
            this.btnSelectRole.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectRole.Location = new System.Drawing.Point(12, 12);
            this.btnSelectRole.Name = "btnSelectRole";
            this.btnSelectRole.Size = new System.Drawing.Size(95, 24);
            this.btnSelectRole.StyleController = this.layoutControl1;
            this.btnSelectRole.TabIndex = 0;
            this.btnSelectRole.Text = "确定";
            this.btnSelectRole.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(111, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 24);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(105, 40);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 24);
            this.btnOk.StyleController = this.layoutControl1;
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "保存";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TCOM_ROLEgridControl
            // 
            this.TCOM_ROLEgridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TCOM_ROLEgridControl.DataSource = this.TCOM_ROLEBindingSource;
            this.TCOM_ROLEgridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TCOM_ROLEgridControl.Location = new System.Drawing.Point(12, 68);
            this.TCOM_ROLEgridControl.MainView = this.TCOM_ROLEgridView;
            this.TCOM_ROLEgridControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TCOM_ROLEgridControl.Name = "TCOM_ROLEgridControl";
            this.TCOM_ROLEgridControl.Size = new System.Drawing.Size(368, 598);
            this.TCOM_ROLEgridControl.TabIndex = 8;
            this.TCOM_ROLEgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TCOM_ROLEgridView});
            // 
            // TCOM_ROLEgridView
            // 
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.Empty.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.TCOM_ROLEgridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.TCOM_ROLEgridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.TCOM_ROLEgridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.TCOM_ROLEgridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.TCOM_ROLEgridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupButton.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.TCOM_ROLEgridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.TCOM_ROLEgridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.TCOM_ROLEgridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.GroupRow.Options.UseFont = true;
            this.TCOM_ROLEgridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.TCOM_ROLEgridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.TCOM_ROLEgridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.TCOM_ROLEgridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.TCOM_ROLEgridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.OddRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.OddRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.TCOM_ROLEgridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.TCOM_ROLEgridView.Appearance.Preview.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.Preview.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.TCOM_ROLEgridView.Appearance.Row.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.Row.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.TCOM_ROLEgridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.TCOM_ROLEgridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.TCOM_ROLEgridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.TCOM_ROLEgridView.Appearance.VertLine.Options.UseBackColor = true;
            this.TCOM_ROLEgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.TCOM_ROLEgridView.GridControl = this.TCOM_ROLEgridControl;
            this.TCOM_ROLEgridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "数量：{0}")});
            this.TCOM_ROLEgridView.Name = "TCOM_ROLEgridView";
            this.TCOM_ROLEgridView.NewItemRowText = "单击这里添加新角色";
            this.TCOM_ROLEgridView.OptionsView.ColumnAutoWidth = false;
            this.TCOM_ROLEgridView.OptionsView.EnableAppearanceEvenRow = true;
            this.TCOM_ROLEgridView.OptionsView.EnableAppearanceOddRow = true;
            this.TCOM_ROLEgridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.TCOM_ROLEgridView.OptionsView.RowAutoHeight = true;
            this.TCOM_ROLEgridView.OptionsView.ShowFooter = true;
            this.TCOM_ROLEgridView.OptionsView.ShowGroupPanel = false;
            this.TCOM_ROLEgridView.PaintStyleName = "Flat";
            this.TCOM_ROLEgridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.TCOM_ROLEgridView_RowUpdated);
            this.TCOM_ROLEgridView.RowCountChanged += new System.EventHandler(this.TCOM_ROLEgridView_RowCountChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "RoleID";
            this.gridColumn1.FieldName = "ROLEID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "角色描述";
            this.gridColumn2.FieldName = "ROLEDESCRIPTION";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "角色名称";
            this.gridColumn3.FieldName = "ROLENAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ROLENAME", "数量：{0}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 119;
            // 
            // systemtree
            // 
            this.systemtree.CheckBoxes = true;
            this.systemtree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.systemtree.ImageIndex = 0;
            this.systemtree.ImageList = this.imageList2;
            this.systemtree.Location = new System.Drawing.Point(389, 40);
            this.systemtree.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.systemtree.Name = "systemtree";
            this.systemtree.SelectedImageIndex = 0;
            this.systemtree.Size = new System.Drawing.Size(470, 626);
            this.systemtree.TabIndex = 1;
            this.systemtree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.systemtree_AfterCheck);
            this.systemtree.Click += new System.EventHandler(this.systemtree_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Empty;
            this.imageList2.Images.SetKeyName(0, "108.png");
            this.imageList2.Images.SetKeyName(1, "102.png");
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(871, 678);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.systemtree;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(377, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(474, 630);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TCOM_ROLEgridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(372, 602);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(372, 28);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 630);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnOk;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(93, 28);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(106, 28);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(106, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(106, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(99, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(99, 28);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(99, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 28);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSelectRole;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(99, 28);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(99, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 28);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(199, 28);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(173, 28);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(198, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(653, 28);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.layoutControl1);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(0, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(875, 682);
            this.panelControl7.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 24);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "删除";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton1;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(93, 28);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(93, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(93, 28);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // FrmRoleDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(875, 682);
            this.Controls.Add(this.panelControl7);
            this.Name = "FrmRoleDlg";
            this.Text = "系统角色";
            this.Load += new System.EventHandler(this.FrmRoleDlg_Load);
            this.Shown += new System.EventHandler(this.FrmRoleDlg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl TCOM_ROLEgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView TCOM_ROLEgridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource TCOM_ROLEBindingSource;
        private DstUserRole dstUserRole;
        private System.Windows.Forms.TreeView systemtree;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSelectRole;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}