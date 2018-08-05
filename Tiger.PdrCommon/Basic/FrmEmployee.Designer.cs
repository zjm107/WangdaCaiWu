using Tiger.PdrCommon.Basic;

namespace Tiger.PdrCommon
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.tvEmployee = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.TCOM_USERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstEmployee = new Tiger.PdrCommon.Basic.DstEmployee();
            this.tB_EmployeeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTypeComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colEMPLOYEETYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMPLOYEETYPEComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTeacherID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeacherIDItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TCOM_USERNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfficialDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col预警生日 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChangeSNO = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetPassWord = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDeptName = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_EmployeeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTypeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEETYPEComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherIDItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USERNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            this.SuspendLayout();
            // 
            // tvEmployee
            // 
            this.tvEmployee.HideSelection = false;
            this.tvEmployee.ImageIndex = 0;
            this.tvEmployee.ImageList = this.imageList;
            this.tvEmployee.Location = new System.Drawing.Point(12, 12);
            this.tvEmployee.Name = "tvEmployee";
            this.tvEmployee.SelectedImageIndex = 0;
            this.tvEmployee.Size = new System.Drawing.Size(195, 647);
            this.tvEmployee.TabIndex = 1;
            this.toolTip.SetToolTip(this.tvEmployee, "员工信息树\r\n双击员工可在表格中查看员工信息\r\n双击部门可在表格中查看该部门所有员工信息\r\n单击工具栏刷新按钮查看企业所有员工信息");
            this.tvEmployee.DoubleClick += new System.EventHandler(this.tvEmployee_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "nEO_IMG_House.jpg");
            this.imageList.Images.SetKeyName(1, "nEO_IMG_User.jpg");
            // 
            // TCOM_USERBindingSource
            // 
            this.TCOM_USERBindingSource.DataMember = "TCOM_USER";
            this.TCOM_USERBindingSource.DataSource = this.dstEmployee;
            this.TCOM_USERBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.TCOM_USERBindingSource_AddingNew);
            // 
            // dstEmployee
            // 
            this.dstEmployee.DataSetName = "DstEmployee";
            this.dstEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_EmployeeGridControl
            // 
            this.tB_EmployeeGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_EmployeeGridControl.DataSource = this.TCOM_USERBindingSource;
            this.tB_EmployeeGridControl.Location = new System.Drawing.Point(216, 38);
            this.tB_EmployeeGridControl.MainView = this.gdvEmployee;
            this.tB_EmployeeGridControl.Name = "tB_EmployeeGridControl";
            this.tB_EmployeeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EMPLOYEETYPEComboBox,
            this.WorkTypeComboBox,
            this.TeacherIDItemLookUpEdit});
            this.tB_EmployeeGridControl.Size = new System.Drawing.Size(834, 621);
            this.tB_EmployeeGridControl.TabIndex = 4;
            this.toolTip.SetToolTip(this.tB_EmployeeGridControl, "添加员工必须选择该员工所属部门\r\n删除员工将该员工的离职状态至为选择状态\r\n增删改操作后，单击工具栏保存按钮");
            this.tB_EmployeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmployee});
            // 
            // gdvEmployee
            // 
            this.gdvEmployee.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gdvEmployee.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gdvEmployee.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.Empty.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.EvenRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.EvenRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gdvEmployee.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gdvEmployee.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gdvEmployee.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gdvEmployee.Appearance.FixedLine.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gdvEmployee.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gdvEmployee.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gdvEmployee.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.GroupButton.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.GroupButton.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gdvEmployee.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gdvEmployee.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gdvEmployee.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.GroupRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.GroupRow.Options.UseFont = true;
            this.gdvEmployee.Appearance.GroupRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gdvEmployee.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gdvEmployee.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gdvEmployee.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gdvEmployee.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gdvEmployee.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gdvEmployee.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gdvEmployee.Appearance.HorzLine.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.OddRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.OddRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gdvEmployee.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gdvEmployee.Appearance.Preview.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.Preview.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gdvEmployee.Appearance.Row.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.Row.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gdvEmployee.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gdvEmployee.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gdvEmployee.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gdvEmployee.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gdvEmployee.Appearance.VertLine.Options.UseBackColor = true;
            this.gdvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDeptName,
            this.colUserCode,
            this.colUserName,
            this.colSNO,
            this.colLOGNAME,
            this.colWorkType,
            this.colEMPLOYEETYPE,
            this.colTeacherID,
            this.colIDNO,
            this.colGender,
            this.colInDate,
            this.colOutDate,
            this.colOfficialDate,
            this.colPhoneNO,
            this.colBirthDay,
            this.col预警生日});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Coral;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.col预警生日;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "AddDays(LocalDateTimeToday(),10 ) >= [预警生日] And LocalDateTimeToday()  <=  [预警生日]";
            this.gdvEmployee.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gdvEmployee.GridControl = this.tB_EmployeeGridControl;
            this.gdvEmployee.GroupPanelText = "将列拖动到这里进行分组";
            this.gdvEmployee.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "数量：{0}")});
            this.gdvEmployee.Name = "gdvEmployee";
            this.gdvEmployee.NewItemRowText = "请选择部门，添加该部门员工";
            this.gdvEmployee.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvEmployee.OptionsSelection.MultiSelect = true;
            this.gdvEmployee.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gdvEmployee.OptionsView.AutoCalcPreviewLineCount = true;
            this.gdvEmployee.OptionsView.ColumnAutoWidth = false;
            this.gdvEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.gdvEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.gdvEmployee.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gdvEmployee.OptionsView.RowAutoHeight = true;
            this.gdvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.gdvEmployee.OptionsView.ShowFooter = true;
            this.gdvEmployee.PaintStyleName = "Flat";
            // 
            // colDeptName
            // 
            this.colDeptName.Caption = "部门名称";
            this.colDeptName.FieldName = "DEPTNAME";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.OptionsColumn.AllowEdit = false;
            this.colDeptName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 2;
            this.colDeptName.Width = 74;
            // 
            // colUserCode
            // 
            this.colUserCode.Caption = "员工编号";
            this.colUserCode.FieldName = "USERCODE";
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUserCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "UserCode", "人数:{0}")});
            this.colUserCode.Width = 74;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "姓名";
            this.colUserName.FieldName = "USERNAME";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 4;
            this.colUserName.Width = 70;
            // 
            // colSNO
            // 
            this.colSNO.Caption = "序号";
            this.colSNO.FieldName = "SEQNO";
            this.colSNO.Name = "colSNO";
            this.colSNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSNO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SEQNO", "数量：{0}")});
            this.colSNO.Visible = true;
            this.colSNO.VisibleIndex = 1;
            this.colSNO.Width = 48;
            // 
            // colLOGNAME
            // 
            this.colLOGNAME.Caption = "登录名(编号)";
            this.colLOGNAME.FieldName = "LOGNAME";
            this.colLOGNAME.Name = "colLOGNAME";
            this.colLOGNAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colLOGNAME.Visible = true;
            this.colLOGNAME.VisibleIndex = 6;
            this.colLOGNAME.Width = 83;
            // 
            // colWorkType
            // 
            this.colWorkType.Caption = "职务";
            this.colWorkType.ColumnEdit = this.WorkTypeComboBox;
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colWorkType.Visible = true;
            this.colWorkType.VisibleIndex = 7;
            this.colWorkType.Width = 118;
            // 
            // WorkTypeComboBox
            // 
            this.WorkTypeComboBox.AutoHeight = false;
            this.WorkTypeComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkTypeComboBox.Name = "WorkTypeComboBox";
            // 
            // colEMPLOYEETYPE
            // 
            this.colEMPLOYEETYPE.Caption = "关系";
            this.colEMPLOYEETYPE.ColumnEdit = this.EMPLOYEETYPEComboBox;
            this.colEMPLOYEETYPE.FieldName = "EMPLOYEETYPE";
            this.colEMPLOYEETYPE.Name = "colEMPLOYEETYPE";
            this.colEMPLOYEETYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEMPLOYEETYPE.Visible = true;
            this.colEMPLOYEETYPE.VisibleIndex = 9;
            this.colEMPLOYEETYPE.Width = 119;
            // 
            // EMPLOYEETYPEComboBox
            // 
            this.EMPLOYEETYPEComboBox.AutoHeight = false;
            this.EMPLOYEETYPEComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EMPLOYEETYPEComboBox.Name = "EMPLOYEETYPEComboBox";
            // 
            // colTeacherID
            // 
            this.colTeacherID.Caption = "师父";
            this.colTeacherID.ColumnEdit = this.TeacherIDItemLookUpEdit;
            this.colTeacherID.FieldName = "TeacherID";
            this.colTeacherID.Name = "colTeacherID";
            this.colTeacherID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTeacherID.Visible = true;
            this.colTeacherID.VisibleIndex = 10;
            // 
            // TeacherIDItemLookUpEdit
            // 
            this.TeacherIDItemLookUpEdit.AutoHeight = false;
            this.TeacherIDItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TeacherIDItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "姓名")});
            this.TeacherIDItemLookUpEdit.DataSource = this.TCOM_USERNameBindingSource;
            this.TeacherIDItemLookUpEdit.DisplayMember = "USERNAME";
            this.TeacherIDItemLookUpEdit.Name = "TeacherIDItemLookUpEdit";
            this.TeacherIDItemLookUpEdit.NullText = "";
            this.TeacherIDItemLookUpEdit.ValueMember = "USERID";
            // 
            // TCOM_USERNameBindingSource
            // 
            this.TCOM_USERNameBindingSource.DataMember = "TCOM_USERName";
            this.TCOM_USERNameBindingSource.DataSource = this.dstEmployee;
            // 
            // colIDNO
            // 
            this.colIDNO.FieldName = "IDNO";
            this.colIDNO.Name = "colIDNO";
            this.colIDNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIDNO.Visible = true;
            this.colIDNO.VisibleIndex = 3;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            // 
            // colInDate
            // 
            this.colInDate.FieldName = "InDate";
            this.colInDate.Name = "colInDate";
            this.colInDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInDate.Visible = true;
            this.colInDate.VisibleIndex = 11;
            // 
            // colOutDate
            // 
            this.colOutDate.FieldName = "OutDate";
            this.colOutDate.Name = "colOutDate";
            this.colOutDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutDate.Visible = true;
            this.colOutDate.VisibleIndex = 13;
            // 
            // colOfficialDate
            // 
            this.colOfficialDate.FieldName = "OfficialDate";
            this.colOfficialDate.Name = "colOfficialDate";
            this.colOfficialDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOfficialDate.Visible = true;
            this.colOfficialDate.VisibleIndex = 12;
            // 
            // colPhoneNO
            // 
            this.colPhoneNO.FieldName = "PhoneNO";
            this.colPhoneNO.Name = "colPhoneNO";
            this.colPhoneNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhoneNO.Visible = true;
            this.colPhoneNO.VisibleIndex = 8;
            // 
            // colBirthDay
            // 
            this.colBirthDay.FieldName = "BirthDay";
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 15;
            // 
            // col预警生日
            // 
            this.col预警生日.FieldName = "预警生日";
            this.col预警生日.Name = "col预警生日";
            this.col预警生日.OptionsColumn.ReadOnly = true;
            this.col预警生日.Visible = true;
            this.col预警生日.VisibleIndex = 14;
            // 
            // btnChangeSNO
            // 
            this.btnChangeSNO.Location = new System.Drawing.Point(402, 12);
            this.btnChangeSNO.Name = "btnChangeSNO";
            this.btnChangeSNO.Size = new System.Drawing.Size(96, 22);
            this.btnChangeSNO.StyleController = this.layoutControl1;
            this.btnChangeSNO.TabIndex = 0;
            this.btnChangeSNO.Text = "重新排序";
            this.toolTip.SetToolTip(this.btnChangeSNO, "可对员工序号重新进行排序");
            this.btnChangeSNO.Click += new System.EventHandler(this.btnChangeSNO_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnDel);
            this.layoutControl1.Controls.Add(this.btnSetPassWord);
            this.layoutControl1.Controls.Add(this.btnUpdateDeptName);
            this.layoutControl1.Controls.Add(this.btnChangeSNO);
            this.layoutControl1.Controls.Add(this.tB_EmployeeGridControl);
            this.layoutControl1.Controls.Add(this.tvEmployee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1062, 671);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(309, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(89, 22);
            this.btnDel.StyleController = this.layoutControl1;
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSetPassWord
            // 
            this.btnSetPassWord.Location = new System.Drawing.Point(502, 12);
            this.btnSetPassWord.Name = "btnSetPassWord";
            this.btnSetPassWord.Size = new System.Drawing.Size(111, 22);
            this.btnSetPassWord.StyleController = this.layoutControl1;
            this.btnSetPassWord.TabIndex = 8;
            this.btnSetPassWord.Text = "重置密码(123456)";
            this.btnSetPassWord.Click += new System.EventHandler(this.btnSetPassWord_Click);
            // 
            // btnUpdateDeptName
            // 
            this.btnUpdateDeptName.Location = new System.Drawing.Point(402, 12);
            this.btnUpdateDeptName.Name = "btnUpdateDeptName";
            this.btnUpdateDeptName.Size = new System.Drawing.Size(96, 22);
            this.btnUpdateDeptName.StyleController = this.layoutControl1;
            this.btnUpdateDeptName.TabIndex = 7;
            this.btnUpdateDeptName.Text = "重置部门";
            this.btnUpdateDeptName.Click += new System.EventHandler(this.btnUpdateDeptName_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnChangeSNO;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
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
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1062, 671);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tvEmployee;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 651);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tB_EmployeeGridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(204, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(838, 625);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(199, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 651);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(605, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnUpdateDeptName;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSetPassWord;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(490, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(115, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(115, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(115, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDel;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(297, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(204, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
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
            this.panelControl3.Size = new System.Drawing.Size(1066, 675);
            this.panelControl3.TabIndex = 7;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmEmployee
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1066, 675);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmEmployee";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.TigerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_EmployeeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTypeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEETYPEComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherIDItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCOM_USERNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvEmployee;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.BindingSource TCOM_USERBindingSource;
        private DstEmployee dstEmployee;
        private DevExpress.XtraGrid.GridControl tB_EmployeeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colSNO;
        private DevExpress.XtraEditors.SimpleButton btnChangeSNO;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGNAME;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDeptName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEETYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn colTeacherID;
        private DevExpress.XtraEditors.SimpleButton btnSetPassWord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox EMPLOYEETYPEComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox WorkTypeComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TeacherIDItemLookUpEdit;
        private System.Windows.Forms.BindingSource TCOM_USERNameBindingSource;
        private ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colInDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOutDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficialDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDay;
        private DevExpress.XtraGrid.Columns.GridColumn col预警生日;
    }
}
