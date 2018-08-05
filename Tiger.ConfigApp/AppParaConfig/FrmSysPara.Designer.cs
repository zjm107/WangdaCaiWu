
namespace Tiger.ConfigApp
{
    partial class FrmSysPara
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSysPara));
            this.lvParaType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TCONF_WORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsParaConfig = new Tiger.ConfigApp.AppParaConfig.DsParaConfig();
            this.colInformation3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInformation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInformation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tS_SystemConfigDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCONF_WORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParaConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_SystemConfigDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvParaType
            // 
            this.lvParaType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvParaType.ContextMenuStrip = this.contextMenuStrip1;
            this.lvParaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvParaType.FullRowSelect = true;
            this.lvParaType.GridLines = true;
            this.lvParaType.Location = new System.Drawing.Point(0, 0);
            this.lvParaType.Name = "lvParaType";
            this.lvParaType.Size = new System.Drawing.Size(207, 435);
            this.lvParaType.SmallImageList = this.imageList1;
            this.lvParaType.TabIndex = 0;
            this.lvParaType.UseCompatibleStateImageBehavior = false;
            this.lvParaType.View = System.Windows.Forms.View.Details;
            this.lvParaType.DoubleClick += new System.EventHandler(this.mItemShow_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "说明";
            this.columnHeader2.Width = 147;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemRefresh,
            this.mItemShow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // mItemRefresh
            // 
            this.mItemRefresh.Name = "mItemRefresh";
            this.mItemRefresh.Size = new System.Drawing.Size(118, 22);
            this.mItemRefresh.Text = "刷新";
            this.mItemRefresh.Click += new System.EventHandler(this.mItemRefresh_Click);
            // 
            // mItemShow
            // 
            this.mItemShow.Name = "mItemShow";
            this.mItemShow.Size = new System.Drawing.Size(118, 22);
            this.mItemShow.Text = "查看参数";
            this.mItemShow.Click += new System.EventHandler(this.mItemShow_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CobaltaIcon7718.ico");
            // 
            // TCONF_WORDBindingSource
            // 
            this.TCONF_WORDBindingSource.DataMember = "TCONF_WORD";
            this.TCONF_WORDBindingSource.DataSource = this.dsParaConfig;
            this.TCONF_WORDBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tS_SystemConfigBindingSource_AddingNew);
            // 
            // dsParaConfig
            // 
            this.dsParaConfig.DataSetName = "DsParaConfig";
            this.dsParaConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colInformation3
            // 
            this.colInformation3.DataPropertyName = "Information3";
            this.colInformation3.HeaderText = "信息3";
            this.colInformation3.Name = "colInformation3";
            // 
            // colInformation2
            // 
            this.colInformation2.DataPropertyName = "Information2";
            this.colInformation2.HeaderText = "信息2";
            this.colInformation2.Name = "colInformation2";
            // 
            // colInformation1
            // 
            this.colInformation1.DataPropertyName = "Information1";
            this.colInformation1.HeaderText = "信息1";
            this.colInformation1.Name = "colInformation1";
            // 
            // tS_SystemConfigDataGridView
            // 
            this.tS_SystemConfigDataGridView.AutoGenerateColumns = false;
            this.tS_SystemConfigDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInformation1,
            this.colInformation2,
            this.colInformation3});
            this.tS_SystemConfigDataGridView.DataSource = this.TCONF_WORDBindingSource;
            this.tS_SystemConfigDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tS_SystemConfigDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tS_SystemConfigDataGridView.Name = "tS_SystemConfigDataGridView";
            this.tS_SystemConfigDataGridView.RowTemplate.Height = 23;
            this.tS_SystemConfigDataGridView.Size = new System.Drawing.Size(572, 435);
            this.tS_SystemConfigDataGridView.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 467);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "参数定义";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvParaType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tS_SystemConfigDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(783, 435);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 467);
            this.panel2.TabIndex = 4;
            // 
            // FrmSysPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(797, 467);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSysPara";
            this.Text = "系统参数配置";
            this.Load += new System.EventHandler(this.TigerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCONF_WORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParaConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_SystemConfigDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvParaType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem mItemShow;
        private System.Windows.Forms.BindingSource TCONF_WORDBindingSource;
        private Tiger.ConfigApp.AppParaConfig.DsParaConfig dsParaConfig;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView tS_SystemConfigDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformation3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
    }
}
