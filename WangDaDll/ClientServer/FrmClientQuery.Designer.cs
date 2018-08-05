using WangDaDll;
using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmClientQuery
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.col预警生日 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.tF_FILEGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tF_FILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileDataSet = new WangDaDll.Common.FileDataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileByte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploader1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpload_Date1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tF_FILEGridControl = new DevExpress.XtraGrid.GridControl();
            this.HTtF_FILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HTfileDataSet = new WangDaDll.Common.FileDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileByte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpload_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.做账会计TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.公司类型ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.客户分级ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.公司性质ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.客户名称TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tW_ClientGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csDataSet = new WangDaDll.Common.CsDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col税号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开户行及账号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col成立时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司地址 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户姓名 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col出生日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col联系电话 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col年销售额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col初始做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收费标准 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户分级 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户名称ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col年龄 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col序号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col费用到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col合同编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col合同到期时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTtF_FILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTfileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司类型ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户分级ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司性质ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            this.SuspendLayout();
            // 
            // col预警生日
            // 
            this.col预警生日.FieldName = "预警生日";
            this.col预警生日.Name = "col预警生日";
            this.col预警生日.OptionsColumn.AllowEdit = false;
            this.col预警生日.OptionsColumn.ReadOnly = true;
            this.col预警生日.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col预警生日.Visible = true;
            this.col预警生日.VisibleIndex = 11;
            this.col预警生日.Width = 105;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDownload);
            this.layoutControl1.Controls.Add(this.tF_FILEGridControl1);
            this.layoutControl1.Controls.Add(this.tF_FILEGridControl);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.btnSaveLayout);
            this.layoutControl1.Controls.Add(this.做账会计TextEdit);
            this.layoutControl1.Controls.Add(this.公司类型ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.客户分级ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.公司性质ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.客户名称TextEdit);
            this.layoutControl1.Controls.Add(this.tW_ClientGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1082, 688);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(312, 36);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 22);
            this.btnDownload.StyleController = this.layoutControl1;
            this.btnDownload.TabIndex = 17;
            this.btnDownload.Text = "下载附件";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tF_FILEGridControl1
            // 
            this.tF_FILEGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tF_FILEGridControl1.DataSource = this.tF_FILEBindingSource;
            this.tF_FILEGridControl1.Location = new System.Drawing.Point(24, 97);
            this.tF_FILEGridControl1.MainView = this.gridView3;
            this.tF_FILEGridControl1.Name = "tF_FILEGridControl1";
            this.tF_FILEGridControl1.Size = new System.Drawing.Size(1034, 567);
            this.tF_FILEGridControl1.TabIndex = 16;
            this.tF_FILEGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.tF_FILEGridControl1.DoubleClick += new System.EventHandler(this.tF_FILEGridControl1_DoubleClick);
            // 
            // tF_FILEBindingSource
            // 
            this.tF_FILEBindingSource.DataMember = "TF_FILE";
            this.tF_FILEBindingSource.DataSource = this.fileDataSet;
            // 
            // fileDataSet
            // 
            this.fileDataSet.DataSetName = "FileDataSet";
            this.fileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView3.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView3.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView3.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileByte1,
            this.colFileName1,
            this.colUploader1,
            this.colUpload_Date1});
            this.gridView3.GridControl = this.tF_FILEGridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.PaintStyleName = "Flat";
            // 
            // colFileByte1
            // 
            this.colFileByte1.FieldName = "FileByte";
            this.colFileByte1.Name = "colFileByte1";
            this.colFileByte1.OptionsColumn.AllowEdit = false;
            this.colFileByte1.OptionsColumn.ReadOnly = true;
            this.colFileByte1.Visible = true;
            this.colFileByte1.VisibleIndex = 1;
            // 
            // colFileName1
            // 
            this.colFileName1.FieldName = "FileName";
            this.colFileName1.Name = "colFileName1";
            this.colFileName1.OptionsColumn.AllowEdit = false;
            this.colFileName1.OptionsColumn.ReadOnly = true;
            this.colFileName1.Visible = true;
            this.colFileName1.VisibleIndex = 2;
            // 
            // colUploader1
            // 
            this.colUploader1.FieldName = "Uploader";
            this.colUploader1.Name = "colUploader1";
            this.colUploader1.OptionsColumn.AllowEdit = false;
            this.colUploader1.OptionsColumn.ReadOnly = true;
            this.colUploader1.Visible = true;
            this.colUploader1.VisibleIndex = 3;
            // 
            // colUpload_Date1
            // 
            this.colUpload_Date1.FieldName = "Upload_Date";
            this.colUpload_Date1.Name = "colUpload_Date1";
            this.colUpload_Date1.OptionsColumn.AllowEdit = false;
            this.colUpload_Date1.OptionsColumn.ReadOnly = true;
            this.colUpload_Date1.Visible = true;
            this.colUpload_Date1.VisibleIndex = 4;
            // 
            // tF_FILEGridControl
            // 
            this.tF_FILEGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tF_FILEGridControl.DataSource = this.HTtF_FILEBindingSource;
            this.tF_FILEGridControl.Location = new System.Drawing.Point(24, 97);
            this.tF_FILEGridControl.MainView = this.gridView2;
            this.tF_FILEGridControl.Name = "tF_FILEGridControl";
            this.tF_FILEGridControl.Size = new System.Drawing.Size(1034, 567);
            this.tF_FILEGridControl.TabIndex = 16;
            this.tF_FILEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.tF_FILEGridControl.DoubleClick += new System.EventHandler(this.tF_FILEGridControl_DoubleClick);
            // 
            // HTtF_FILEBindingSource
            // 
            this.HTtF_FILEBindingSource.DataMember = "TF_FILE";
            this.HTtF_FILEBindingSource.DataSource = this.HTfileDataSet;
            // 
            // HTfileDataSet
            // 
            this.HTfileDataSet.DataSetName = "FileDataSet";
            this.HTfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileByte,
            this.colFileName,
            this.colUploader,
            this.colUpload_Date});
            this.gridView2.GridControl = this.tF_FILEGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.PaintStyleName = "Flat";
            // 
            // colFileByte
            // 
            this.colFileByte.FieldName = "FileByte";
            this.colFileByte.Name = "colFileByte";
            this.colFileByte.OptionsColumn.AllowEdit = false;
            this.colFileByte.OptionsColumn.ReadOnly = true;
            this.colFileByte.Visible = true;
            this.colFileByte.VisibleIndex = 1;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            this.colFileName.OptionsColumn.ReadOnly = true;
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 2;
            // 
            // colUploader
            // 
            this.colUploader.FieldName = "Uploader";
            this.colUploader.Name = "colUploader";
            this.colUploader.OptionsColumn.AllowEdit = false;
            this.colUploader.OptionsColumn.ReadOnly = true;
            this.colUploader.Visible = true;
            this.colUploader.VisibleIndex = 3;
            // 
            // colUpload_Date
            // 
            this.colUpload_Date.FieldName = "Upload_Date";
            this.colUpload_Date.Name = "colUpload_Date";
            this.colUpload_Date.OptionsColumn.AllowEdit = false;
            this.colUpload_Date.OptionsColumn.ReadOnly = true;
            this.colUpload_Date.Visible = true;
            this.colUpload_Date.VisibleIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 36);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(212, 36);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(96, 22);
            this.btnSaveLayout.StyleController = this.layoutControl1;
            this.btnSaveLayout.TabIndex = 11;
            this.btnSaveLayout.Text = "保存样式";
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // 做账会计TextEdit
            // 
            this.做账会计TextEdit.Location = new System.Drawing.Point(817, 12);
            this.做账会计TextEdit.Name = "做账会计TextEdit";
            this.做账会计TextEdit.Size = new System.Drawing.Size(91, 20);
            this.做账会计TextEdit.StyleController = this.layoutControl1;
            this.做账会计TextEdit.TabIndex = 10;
            // 
            // 公司类型ComboBoxEdit
            // 
            this.公司类型ComboBoxEdit.Location = new System.Drawing.Point(367, 12);
            this.公司类型ComboBoxEdit.Name = "公司类型ComboBoxEdit";
            this.公司类型ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.公司类型ComboBoxEdit.Size = new System.Drawing.Size(91, 20);
            this.公司类型ComboBoxEdit.StyleController = this.layoutControl1;
            this.公司类型ComboBoxEdit.TabIndex = 9;
            // 
            // 客户分级ComboBoxEdit
            // 
            this.客户分级ComboBoxEdit.Location = new System.Drawing.Point(667, 12);
            this.客户分级ComboBoxEdit.Name = "客户分级ComboBoxEdit";
            this.客户分级ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.客户分级ComboBoxEdit.Size = new System.Drawing.Size(91, 20);
            this.客户分级ComboBoxEdit.StyleController = this.layoutControl1;
            this.客户分级ComboBoxEdit.TabIndex = 8;
            // 
            // 公司性质ComboBoxEdit
            // 
            this.公司性质ComboBoxEdit.Location = new System.Drawing.Point(517, 12);
            this.公司性质ComboBoxEdit.Name = "公司性质ComboBoxEdit";
            this.公司性质ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.公司性质ComboBoxEdit.Size = new System.Drawing.Size(91, 20);
            this.公司性质ComboBoxEdit.StyleController = this.layoutControl1;
            this.公司性质ComboBoxEdit.TabIndex = 7;
            // 
            // 客户名称TextEdit
            // 
            this.客户名称TextEdit.Location = new System.Drawing.Point(67, 12);
            this.客户名称TextEdit.Name = "客户名称TextEdit";
            this.客户名称TextEdit.Size = new System.Drawing.Size(241, 20);
            this.客户名称TextEdit.StyleController = this.layoutControl1;
            this.客户名称TextEdit.TabIndex = 6;
            // 
            // tW_ClientGridControl
            // 
            this.tW_ClientGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_ClientGridControl.DataSource = this.tW_ClientBindingSource;
            this.tW_ClientGridControl.Location = new System.Drawing.Point(24, 97);
            this.tW_ClientGridControl.MainView = this.gridView1;
            this.tW_ClientGridControl.Name = "tW_ClientGridControl";
            this.tW_ClientGridControl.Size = new System.Drawing.Size(1034, 567);
            this.tW_ClientGridControl.TabIndex = 4;
            this.tW_ClientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.tW_ClientGridControl.DoubleClick += new System.EventHandler(this.tW_ClientGridControl_DoubleClick);
            // 
            // tW_ClientBindingSource
            // 
            this.tW_ClientBindingSource.DataMember = "TW_Client";
            this.tW_ClientBindingSource.DataSource = this.csDataSet;
            // 
            // csDataSet
            // 
            this.csDataSet.DataSetName = "CsDataSet";
            this.csDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.col客户名称,
            this.col税号,
            this.col开户行及账号,
            this.col成立时间,
            this.col公司性质,
            this.col公司类型,
            this.col公司地址,
            this.col客户姓名,
            this.col出生日期,
            this.col联系电话,
            this.col年销售额,
            this.col做账会计,
            this.col初始做账时间,
            this.col收费标准,
            this.col客户分级,
            this.col注册员,
            this.col业务员,
            this.col注册员ID,
            this.col业务员ID,
            this.col做账会计ID,
            this.col修改人,
            this.col修改时间,
            this.col客户名称ID,
            this.col做账时间,
            this.col年龄,
            this.col预警生日,
            this.col零申报,
            this.col序号,
            this.col费用到期月份,
            this.col合同编号,
            this.col合同到期时间});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.col预警生日;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "AddDays(LocalDateTimeToday(),10 ) >= [预警生日] And LocalDateTimeToday()  <=  [预警生日]";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.tW_ClientGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.AllowEdit = false;
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户名称.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "客户名称", "{0}")});
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 1;
            this.col客户名称.Width = 189;
            // 
            // col税号
            // 
            this.col税号.FieldName = "税号";
            this.col税号.Name = "col税号";
            this.col税号.OptionsColumn.AllowEdit = false;
            this.col税号.OptionsColumn.ReadOnly = true;
            this.col税号.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col税号.Visible = true;
            this.col税号.VisibleIndex = 2;
            this.col税号.Width = 59;
            // 
            // col开户行及账号
            // 
            this.col开户行及账号.FieldName = "开户行及账号";
            this.col开户行及账号.Name = "col开户行及账号";
            this.col开户行及账号.OptionsColumn.AllowEdit = false;
            this.col开户行及账号.OptionsColumn.ReadOnly = true;
            this.col开户行及账号.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col开户行及账号.Visible = true;
            this.col开户行及账号.VisibleIndex = 3;
            this.col开户行及账号.Width = 110;
            // 
            // col成立时间
            // 
            this.col成立时间.FieldName = "成立时间";
            this.col成立时间.Name = "col成立时间";
            this.col成立时间.OptionsColumn.AllowEdit = false;
            this.col成立时间.OptionsColumn.ReadOnly = true;
            this.col成立时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col成立时间.Visible = true;
            this.col成立时间.VisibleIndex = 4;
            this.col成立时间.Width = 66;
            // 
            // col公司性质
            // 
            this.col公司性质.FieldName = "公司性质";
            this.col公司性质.Name = "col公司性质";
            this.col公司性质.OptionsColumn.AllowEdit = false;
            this.col公司性质.OptionsColumn.ReadOnly = true;
            this.col公司性质.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司性质.Visible = true;
            this.col公司性质.VisibleIndex = 5;
            this.col公司性质.Width = 66;
            // 
            // col公司类型
            // 
            this.col公司类型.FieldName = "公司类型";
            this.col公司类型.Name = "col公司类型";
            this.col公司类型.OptionsColumn.AllowEdit = false;
            this.col公司类型.OptionsColumn.ReadOnly = true;
            this.col公司类型.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司类型.Visible = true;
            this.col公司类型.VisibleIndex = 6;
            this.col公司类型.Width = 66;
            // 
            // col公司地址
            // 
            this.col公司地址.FieldName = "公司地址";
            this.col公司地址.Name = "col公司地址";
            this.col公司地址.OptionsColumn.AllowEdit = false;
            this.col公司地址.OptionsColumn.ReadOnly = true;
            this.col公司地址.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col公司地址.Visible = true;
            this.col公司地址.VisibleIndex = 7;
            this.col公司地址.Width = 162;
            // 
            // col客户姓名
            // 
            this.col客户姓名.FieldName = "客户姓名";
            this.col客户姓名.Name = "col客户姓名";
            this.col客户姓名.OptionsColumn.AllowEdit = false;
            this.col客户姓名.OptionsColumn.ReadOnly = true;
            this.col客户姓名.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户姓名.Visible = true;
            this.col客户姓名.VisibleIndex = 8;
            this.col客户姓名.Width = 59;
            // 
            // col出生日期
            // 
            this.col出生日期.FieldName = "出生日期";
            this.col出生日期.Name = "col出生日期";
            this.col出生日期.OptionsColumn.AllowEdit = false;
            this.col出生日期.OptionsColumn.ReadOnly = true;
            this.col出生日期.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col出生日期.Visible = true;
            this.col出生日期.VisibleIndex = 9;
            this.col出生日期.Width = 59;
            // 
            // col联系电话
            // 
            this.col联系电话.FieldName = "联系电话";
            this.col联系电话.Name = "col联系电话";
            this.col联系电话.OptionsColumn.AllowEdit = false;
            this.col联系电话.OptionsColumn.ReadOnly = true;
            this.col联系电话.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col联系电话.Visible = true;
            this.col联系电话.VisibleIndex = 12;
            this.col联系电话.Width = 59;
            // 
            // col年销售额
            // 
            this.col年销售额.FieldName = "年销售额";
            this.col年销售额.Name = "col年销售额";
            this.col年销售额.OptionsColumn.AllowEdit = false;
            this.col年销售额.OptionsColumn.ReadOnly = true;
            this.col年销售额.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col年销售额.Visible = true;
            this.col年销售额.VisibleIndex = 13;
            this.col年销售额.Width = 96;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.AllowEdit = false;
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 14;
            this.col做账会计.Width = 67;
            // 
            // col初始做账时间
            // 
            this.col初始做账时间.FieldName = "初始做账时间";
            this.col初始做账时间.Name = "col初始做账时间";
            this.col初始做账时间.OptionsColumn.AllowEdit = false;
            this.col初始做账时间.OptionsColumn.ReadOnly = true;
            this.col初始做账时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col初始做账时间.Visible = true;
            this.col初始做账时间.VisibleIndex = 15;
            this.col初始做账时间.Width = 84;
            // 
            // col收费标准
            // 
            this.col收费标准.FieldName = "收费标准";
            this.col收费标准.Name = "col收费标准";
            this.col收费标准.OptionsColumn.AllowEdit = false;
            this.col收费标准.OptionsColumn.ReadOnly = true;
            this.col收费标准.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col收费标准.Visible = true;
            this.col收费标准.VisibleIndex = 17;
            this.col收费标准.Width = 71;
            // 
            // col客户分级
            // 
            this.col客户分级.FieldName = "客户分级";
            this.col客户分级.Name = "col客户分级";
            this.col客户分级.OptionsColumn.AllowEdit = false;
            this.col客户分级.OptionsColumn.ReadOnly = true;
            this.col客户分级.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户分级.Visible = true;
            this.col客户分级.VisibleIndex = 18;
            this.col客户分级.Width = 63;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.AllowEdit = false;
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 19;
            this.col注册员.Width = 57;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.AllowEdit = false;
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 20;
            this.col业务员.Width = 46;
            // 
            // col注册员ID
            // 
            this.col注册员ID.FieldName = "注册员ID";
            this.col注册员ID.Name = "col注册员ID";
            this.col注册员ID.OptionsColumn.AllowEdit = false;
            this.col注册员ID.OptionsColumn.ReadOnly = true;
            this.col注册员ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col注册员ID.Width = 59;
            // 
            // col业务员ID
            // 
            this.col业务员ID.FieldName = "业务员ID";
            this.col业务员ID.Name = "col业务员ID";
            this.col业务员ID.OptionsColumn.AllowEdit = false;
            this.col业务员ID.OptionsColumn.ReadOnly = true;
            this.col业务员ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col业务员ID.Width = 59;
            // 
            // col做账会计ID
            // 
            this.col做账会计ID.FieldName = "做账会计ID";
            this.col做账会计ID.Name = "col做账会计ID";
            this.col做账会计ID.OptionsColumn.AllowEdit = false;
            this.col做账会计ID.OptionsColumn.ReadOnly = true;
            this.col做账会计ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账会计ID.Width = 80;
            // 
            // col修改人
            // 
            this.col修改人.FieldName = "修改人";
            this.col修改人.Name = "col修改人";
            this.col修改人.OptionsColumn.AllowEdit = false;
            this.col修改人.OptionsColumn.ReadOnly = true;
            this.col修改人.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改人.Visible = true;
            this.col修改人.VisibleIndex = 22;
            this.col修改人.Width = 56;
            // 
            // col修改时间
            // 
            this.col修改时间.FieldName = "修改时间";
            this.col修改时间.Name = "col修改时间";
            this.col修改时间.OptionsColumn.AllowEdit = false;
            this.col修改时间.OptionsColumn.ReadOnly = true;
            this.col修改时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col修改时间.Visible = true;
            this.col修改时间.VisibleIndex = 23;
            this.col修改时间.Width = 68;
            // 
            // col客户名称ID
            // 
            this.col客户名称ID.FieldName = "客户名称ID";
            this.col客户名称ID.Name = "col客户名称ID";
            this.col客户名称ID.OptionsColumn.AllowEdit = false;
            this.col客户名称ID.OptionsColumn.ReadOnly = true;
            this.col客户名称ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col客户名称ID.Width = 80;
            // 
            // col做账时间
            // 
            this.col做账时间.FieldName = "做账时间";
            this.col做账时间.Name = "col做账时间";
            this.col做账时间.OptionsColumn.AllowEdit = false;
            this.col做账时间.OptionsColumn.ReadOnly = true;
            this.col做账时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账时间.Visible = true;
            this.col做账时间.VisibleIndex = 16;
            this.col做账时间.Width = 68;
            // 
            // col年龄
            // 
            this.col年龄.FieldName = "年龄";
            this.col年龄.Name = "col年龄";
            this.col年龄.OptionsColumn.AllowEdit = false;
            this.col年龄.OptionsColumn.ReadOnly = true;
            this.col年龄.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col年龄.Visible = true;
            this.col年龄.VisibleIndex = 10;
            this.col年龄.Width = 46;
            // 
            // col零申报
            // 
            this.col零申报.FieldName = "零申报";
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.AllowEdit = false;
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 21;
            // 
            // col序号
            // 
            this.col序号.FieldName = "序号";
            this.col序号.Name = "col序号";
            this.col序号.OptionsColumn.AllowEdit = false;
            this.col序号.OptionsColumn.ReadOnly = true;
            this.col序号.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col序号.Visible = true;
            this.col序号.VisibleIndex = 0;
            // 
            // col费用到期月份
            // 
            this.col费用到期月份.FieldName = "费用到期月份";
            this.col费用到期月份.Name = "col费用到期月份";
            this.col费用到期月份.OptionsColumn.AllowEdit = false;
            this.col费用到期月份.OptionsColumn.ReadOnly = true;
            this.col费用到期月份.Visible = true;
            this.col费用到期月份.VisibleIndex = 24;
            // 
            // col合同编号
            // 
            this.col合同编号.FieldName = "合同编号";
            this.col合同编号.Name = "col合同编号";
            this.col合同编号.OptionsColumn.AllowEdit = false;
            this.col合同编号.OptionsColumn.ReadOnly = true;
            this.col合同编号.Visible = true;
            this.col合同编号.VisibleIndex = 25;
            // 
            // col合同到期时间
            // 
            this.col合同到期时间.FieldName = "合同到期时间";
            this.col合同到期时间.Name = "col合同到期时间";
            this.col合同到期时间.OptionsColumn.AllowEdit = false;
            this.col合同到期时间.OptionsColumn.ReadOnly = true;
            this.col合同到期时间.Visible = true;
            this.col合同到期时间.VisibleIndex = 26;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.tabbedControlGroup1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1082, 688);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnQuery;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
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
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnClear;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(100, 24);
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
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.做账会计TextEdit;
            this.layoutControlItem7.CustomizationFormText = "做账会计:";
            this.layoutControlItem7.Location = new System.Drawing.Point(750, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "做账会计:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.公司类型ComboBoxEdit;
            this.layoutControlItem6.CustomizationFormText = "公司类型:";
            this.layoutControlItem6.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "公司类型:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(900, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(162, 24);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.客户分级ComboBoxEdit;
            this.layoutControlItem5.CustomizationFormText = "客户分级:";
            this.layoutControlItem5.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "客户分级:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.客户名称TextEdit;
            this.layoutControlItem3.CustomizationFormText = "客户名称:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "客户名称:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.公司性质ComboBoxEdit;
            this.layoutControlItem4.CustomizationFormText = "公司性质:";
            this.layoutControlItem4.Location = new System.Drawing.Point(450, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "公司性质:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 50);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1062, 618);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.tabbedControlGroup1.Text = "tabbedControlGroup1";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "客户信息";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlGroup2.Text = "客户信息";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_ClientGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "合同信息";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlGroup3.Text = "合同信息";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tF_FILEGridControl;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "档案信息";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlGroup4.Text = "档案信息";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.tF_FILEGridControl1;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1038, 571);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSaveLayout;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(393, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(669, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnDownload;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(300, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmClientQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 688);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmClientQuery";
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.FrmClientQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tF_FILEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTtF_FILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTfileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.做账会计TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司类型ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户分级ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司性质ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl tW_ClientGridControl;
        private CsDataSet csDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit 做账会计TextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 公司类型ComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 客户分级ComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 公司性质ComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit 客户名称TextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnSaveLayout;
        private System.Windows.Forms.BindingSource tW_ClientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col税号;
        private DevExpress.XtraGrid.Columns.GridColumn col开户行及账号;
        private DevExpress.XtraGrid.Columns.GridColumn col成立时间;
        private DevExpress.XtraGrid.Columns.GridColumn col公司性质;
        private DevExpress.XtraGrid.Columns.GridColumn col公司类型;
        private DevExpress.XtraGrid.Columns.GridColumn col公司地址;
        private DevExpress.XtraGrid.Columns.GridColumn col客户姓名;
        private DevExpress.XtraGrid.Columns.GridColumn col出生日期;
        private DevExpress.XtraGrid.Columns.GridColumn col联系电话;
        private DevExpress.XtraGrid.Columns.GridColumn col年销售额;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col初始做账时间;
        private DevExpress.XtraGrid.Columns.GridColumn col收费标准;
        private DevExpress.XtraGrid.Columns.GridColumn col客户分级;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员ID;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员ID;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计ID;
        private DevExpress.XtraGrid.Columns.GridColumn col修改人;
        private DevExpress.XtraGrid.Columns.GridColumn col修改时间;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称ID;
        private DevExpress.XtraGrid.Columns.GridColumn col做账时间;
        private DevExpress.XtraGrid.Columns.GridColumn col年龄;
        private DevExpress.XtraGrid.Columns.GridColumn col预警生日;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private Tiger.PdrCommon.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraGrid.Columns.GridColumn col序号;
        private DevExpress.XtraGrid.Columns.GridColumn col费用到期月份;
        private DevExpress.XtraGrid.Columns.GridColumn col合同编号;
        private DevExpress.XtraGrid.Columns.GridColumn col合同到期时间;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private System.Windows.Forms.BindingSource tF_FILEBindingSource;
        private FileDataSet fileDataSet;
        private DevExpress.XtraGrid.GridControl tF_FILEGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl tF_FILEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colFileByte;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colUploader;
        private DevExpress.XtraGrid.Columns.GridColumn colUpload_Date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colFileByte1;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName1;
        private DevExpress.XtraGrid.Columns.GridColumn colUploader1;
        private DevExpress.XtraGrid.Columns.GridColumn colUpload_Date1;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource HTtF_FILEBindingSource;
        private FileDataSet HTfileDataSet;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
    }
}