using Tiger.PdrCommon.Basic;

namespace Tiger.PdrCommon
{
    partial class FrmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManager));
            this.UserTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDeleteUserRole = new DevExpress.XtraEditors.SimpleButton();
            this.TCOM_ROLE1GridControl = new DevExpress.XtraGrid.GridControl();
            this.TCOM_ROLE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstUserRole1 = new Tiger.PdrCommon.DstUserRole();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCOM_USER_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstEmployee = new DstEmployee();
            this.btnAddUserRole = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLongName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.TCOM_ROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLE1GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstUserRole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USER_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTree
            // 
            this.UserTree.HideSelection = false;
            this.UserTree.ImageIndex = 0;
            this.UserTree.ImageList = this.imageList1;
            this.UserTree.Location = new System.Drawing.Point(12, 12);
            this.UserTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTree.Name = "UserTree";
            this.UserTree.SelectedImageIndex = 0;
            this.UserTree.Size = new System.Drawing.Size(155, 732);
            this.UserTree.TabIndex = 0;
            this.UserTree.Click += new System.EventHandler(this.UserTree_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Empty;
            this.imageList1.Images.SetKeyName(0, "189.png");
            this.imageList1.Images.SetKeyName(1, "94.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDeleteUserRole);
            this.layoutControl1.Controls.Add(this.TCOM_ROLE1GridControl);
            this.layoutControl1.Controls.Add(this.btnAddUserRole);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.UserTree);
            this.layoutControl1.Controls.Add(this.txtDepartment);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Controls.Add(this.txtNewPassword);
            this.layoutControl1.Controls.Add(this.txtLongName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(870, 756);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDeleteUserRole
            // 
            this.btnDeleteUserRole.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUserRole.Appearance.Options.UseFont = true;
            this.btnDeleteUserRole.Location = new System.Drawing.Point(305, 720);
            this.btnDeleteUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteUserRole.Name = "btnDeleteUserRole";
            this.btnDeleteUserRole.Size = new System.Drawing.Size(139, 24);
            this.btnDeleteUserRole.StyleController = this.layoutControl1;
            this.btnDeleteUserRole.TabIndex = 1;
            this.btnDeleteUserRole.Text = "删除用户角色";
            this.toolTip.SetToolTip(this.btnDeleteUserRole, "1、双击员工信息，可查看该员工已有角色。\r\n2、选择该员工已有角色，单击删除按钮可删除该员工已有角色。\r\n");
            this.btnDeleteUserRole.Click += new System.EventHandler(this.btnDeleteUserRole_Click);
            // 
            // TCOM_ROLE1GridControl
            // 
            this.TCOM_ROLE1GridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TCOM_ROLE1GridControl.DataSource = this.TCOM_ROLE1BindingSource;
            this.TCOM_ROLE1GridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TCOM_ROLE1GridControl.Location = new System.Drawing.Point(176, 88);
            this.TCOM_ROLE1GridControl.MainView = this.gridView2;
            this.TCOM_ROLE1GridControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TCOM_ROLE1GridControl.Name = "TCOM_ROLE1GridControl";
            this.TCOM_ROLE1GridControl.Size = new System.Drawing.Size(682, 628);
            this.TCOM_ROLE1GridControl.TabIndex = 12;
            this.TCOM_ROLE1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.TCOM_ROLE1GridControl.DoubleClick += new System.EventHandler(this.TCOM_ROLE1GridControl_DoubleClick);
            // 
            // TCOM_ROLE1BindingSource
            // 
            this.TCOM_ROLE1BindingSource.DataMember = "TCOM_ROLE1";
            this.TCOM_ROLE1BindingSource.DataSource = this.dstUserRole1;
            // 
            // dstUserRole1
            // 
            this.dstUserRole1.DataSetName = "DstUserRole";
            this.dstUserRole1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleID1,
            this.colRoleDescription1,
            this.colRoleName1});
            this.gridView2.GridControl = this.TCOM_ROLE1GridControl;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "数量：{0}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colRoleID1
            // 
            this.colRoleID1.Caption = "RoleID";
            this.colRoleID1.FieldName = "ROLEID";
            this.colRoleID1.Name = "colRoleID1";
            this.colRoleID1.Width = 44;
            // 
            // colRoleDescription1
            // 
            this.colRoleDescription1.Caption = "角色描述";
            this.colRoleDescription1.FieldName = "ROLEDESCRIPTION";
            this.colRoleDescription1.Name = "colRoleDescription1";
            this.colRoleDescription1.OptionsColumn.AllowEdit = false;
            this.colRoleDescription1.OptionsColumn.AllowFocus = false;
            this.colRoleDescription1.Visible = true;
            this.colRoleDescription1.VisibleIndex = 1;
            this.colRoleDescription1.Width = 234;
            // 
            // colRoleName1
            // 
            this.colRoleName1.Caption = "角色名称";
            this.colRoleName1.FieldName = "ROLENAME";
            this.colRoleName1.Name = "colRoleName1";
            this.colRoleName1.OptionsColumn.AllowEdit = false;
            this.colRoleName1.OptionsColumn.AllowFocus = false;
            this.colRoleName1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ROLENAME", "数量：{0}")});
            this.colRoleName1.Visible = true;
            this.colRoleName1.VisibleIndex = 0;
            this.colRoleName1.Width = 232;
            // 
            // TCOM_USER_bindingSource
            // 
            this.TCOM_USER_bindingSource.DataMember = "TCOM_USER";
            this.TCOM_USER_bindingSource.DataSource = this.dstEmployee;
            // 
            // dstEmployee
            // 
            this.dstEmployee.DataSetName = "DstEmployee";
            this.dstEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddUserRole
            // 
            this.btnAddUserRole.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserRole.Appearance.Options.UseFont = true;
            this.btnAddUserRole.Location = new System.Drawing.Point(176, 720);
            this.btnAddUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUserRole.Name = "btnAddUserRole";
            this.btnAddUserRole.Size = new System.Drawing.Size(125, 24);
            this.btnAddUserRole.StyleController = this.layoutControl1;
            this.btnAddUserRole.TabIndex = 0;
            this.btnAddUserRole.Text = "添加用户角色";
            this.toolTip.SetToolTip(this.btnAddUserRole, "1、双击员工信息，可查看该员工已有角色。\r\n2、在系统角色中选择角色，单击添加按钮，可给该员工分配角色\r\n");
            this.btnAddUserRole.Click += new System.EventHandler(this.btnAddUserRole_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(176, 60);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 24);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "保存";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TCOM_USER_bindingSource, "DeptName", true));
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Location = new System.Drawing.Point(239, 12);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(287, 20);
            this.txtDepartment.StyleController = this.layoutControl1;
            this.txtDepartment.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TCOM_USER_bindingSource, "UserName", true));
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(239, 36);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 20);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TCOM_USER_bindingSource, "LogPassword", true));
            this.txtNewPassword.Location = new System.Drawing.Point(474, 36);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(384, 20);
            this.txtNewPassword.StyleController = this.layoutControl1;
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtLongName
            // 
            this.txtLongName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TCOM_USER_bindingSource, "LogName", true));
            this.txtLongName.Location = new System.Drawing.Point(593, 12);
            this.txtLongName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLongName.Name = "txtLongName";
            this.txtLongName.Size = new System.Drawing.Size(265, 20);
            this.txtLongName.StyleController = this.layoutControl1;
            this.txtLongName.TabIndex = 3;
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
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem12,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(870, 756);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.UserTree;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(159, 736);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TCOM_ROLE1GridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(164, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(686, 632);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(159, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 736);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAddUserRole;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(164, 708);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(99, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDeleteUserRole;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(293, 708);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(143, 28);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(143, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(143, 28);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDepartment;
            this.layoutControlItem5.CustomizationFormText = "部门名称：";
            this.layoutControlItem5.Location = new System.Drawing.Point(164, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(354, 24);
            this.layoutControlItem5.Text = "部门名称：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtUserName;
            this.layoutControlItem6.CustomizationFormText = "用户名称：";
            this.layoutControlItem6.Location = new System.Drawing.Point(164, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(235, 24);
            this.layoutControlItem6.Text = "用户名称：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtLongName;
            this.layoutControlItem7.CustomizationFormText = "登录名称：";
            this.layoutControlItem7.Location = new System.Drawing.Point(518, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem7.Text = "登录名称：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNewPassword;
            this.layoutControlItem8.CustomizationFormText = "新密码：";
            this.layoutControlItem8.Location = new System.Drawing.Point(399, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(451, 24);
            this.layoutControlItem8.Text = "密码：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnSave;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(164, 48);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(111, 28);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(111, 28);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(111, 28);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(275, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(575, 28);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(436, 708);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(414, 28);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TCOM_ROLEBindingSource
            // 
            this.TCOM_ROLEBindingSource.DataMember = "TCOM_ROLE";
            this.TCOM_ROLEBindingSource.DataSource = this.dstUserRole1;
            this.TCOM_ROLEBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.TCOM_ROLEBindingSource_AddingNew);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Empty;
            this.imageList2.Images.SetKeyName(0, "108.png");
            this.imageList2.Images.SetKeyName(1, "102.png");
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Empty;
            this.imglist.Images.SetKeyName(0, "153.png");
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.layoutControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(874, 760);
            this.panelControl3.TabIndex = 3;
            // 
            // FrmUserManager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(874, 760);
            this.Controls.Add(this.panelControl3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserManager";
            this.Text = "权限管理";
            this.Load += new System.EventHandler(this.TigerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLE1GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstUserRole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USER_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_ROLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView UserTree;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.TextEdit txtLongName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imglist;
        private DevExpress.XtraGrid.GridControl TCOM_ROLE1GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUserRole;
        private DevExpress.XtraEditors.SimpleButton btnAddUserRole;
        private System.Windows.Forms.ImageList imageList2;
        private DstEmployee dstEmployee;
        private System.Windows.Forms.BindingSource TCOM_ROLEBindingSource;
        private DstUserRole dstUserRole1;
        private System.Windows.Forms.BindingSource TCOM_ROLE1BindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource TCOM_USER_bindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
