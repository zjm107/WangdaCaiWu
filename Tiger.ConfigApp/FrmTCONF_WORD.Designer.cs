namespace Tercel.BaseData
{
    partial class FrmTCONF_WORD
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.tCONF_WORDBindingSource = new System.Windows.Forms.BindingSource();
            this.dstTCONF_WORD = new Tiger.ConfigApp.DstTCONF_WORD();
            this.tCONF_WORDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbGroupName = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colGROUPLISTITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wORDTextBox = new DevExpress.XtraEditors.TextEdit();
            this.gROUPNAMEComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colAPPLICATIONID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCONF_WORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCONF_WORDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPNAMEComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(793, 529);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataNavigator1);
            this.layoutControl1.Controls.Add(this.tCONF_WORDGridControl);
            this.layoutControl1.Controls.Add(this.wORDTextBox);
            this.layoutControl1.Controls.Add(this.gROUPNAMEComboBoxEdit);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(789, 525);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.tCONF_WORDBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(5, 501);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(779, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 23;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // tCONF_WORDBindingSource
            // 
            this.tCONF_WORDBindingSource.DataMember = "TCONF_WORD";
            this.tCONF_WORDBindingSource.DataSource = this.dstTCONF_WORD;
            this.tCONF_WORDBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tCB_DEPTSTANDARDBindingSource_AddingNew);
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCONF_WORDGridControl
            // 
            this.tCONF_WORDGridControl.DataSource = this.tCONF_WORDBindingSource;
            this.tCONF_WORDGridControl.Location = new System.Drawing.Point(5, 30);
            this.tCONF_WORDGridControl.MainView = this.gridView1;
            this.tCONF_WORDGridControl.Name = "tCONF_WORDGridControl";
            this.tCONF_WORDGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbGroupName});
            this.tCONF_WORDGridControl.Size = new System.Drawing.Size(779, 467);
            this.tCONF_WORDGridControl.TabIndex = 22;
            this.tCONF_WORDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGROUPNAME,
            this.colGROUPLISTITEM,
            this.colAPPLICATIONID});
            this.gridView1.GridControl = this.tCONF_WORDGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colGROUPNAME
            // 
            this.colGROUPNAME.Caption = "编码分类";
            this.colGROUPNAME.ColumnEdit = this.cmbGroupName;
            this.colGROUPNAME.FieldName = "GROUPNAME";
            this.colGROUPNAME.Name = "colGROUPNAME";
            this.colGROUPNAME.Visible = true;
            this.colGROUPNAME.VisibleIndex = 0;
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.AutoHeight = false;
            this.cmbGroupName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGroupName.Name = "cmbGroupName";
            // 
            // colGROUPLISTITEM
            // 
            this.colGROUPLISTITEM.Caption = "编码";
            this.colGROUPLISTITEM.FieldName = "GROUPLISTITEM";
            this.colGROUPLISTITEM.Name = "colGROUPLISTITEM";
            this.colGROUPLISTITEM.SummaryItem.DisplayFormat = "数量：{0}";
            this.colGROUPLISTITEM.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colGROUPLISTITEM.Visible = true;
            this.colGROUPLISTITEM.VisibleIndex = 1;
            // 
            // wORDTextBox
            // 
            this.wORDTextBox.Location = new System.Drawing.Point(276, 5);
            this.wORDTextBox.Name = "wORDTextBox";
            this.wORDTextBox.Size = new System.Drawing.Size(142, 21);
            this.wORDTextBox.StyleController = this.layoutControl1;
            this.wORDTextBox.TabIndex = 22;
            // 
            // gROUPNAMEComboBoxEdit
            // 
            this.gROUPNAMEComboBoxEdit.Location = new System.Drawing.Point(69, 5);
            this.gROUPNAMEComboBoxEdit.Name = "gROUPNAMEComboBoxEdit";
            this.gROUPNAMEComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gROUPNAMEComboBoxEdit.Size = new System.Drawing.Size(139, 21);
            this.gROUPNAMEComboBoxEdit.StyleController = this.layoutControl1;
            this.gROUPNAMEComboBoxEdit.TabIndex = 21;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(422, 5);
            this.simpleButton1.MaximumSize = new System.Drawing.Size(40, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 20);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(466, 5);
            this.simpleButton2.MaximumSize = new System.Drawing.Size(40, 20);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(40, 20);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "清除";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(789, 525);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gROUPNAMEComboBoxEdit;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(207, 25);
            this.layoutControlItem7.Text = "编码类型：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.wORDTextBox;
            this.layoutControlItem8.CustomizationFormText = "编码：";
            this.layoutControlItem8.Location = new System.Drawing.Point(207, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(210, 25);
            this.layoutControlItem8.Text = "编码：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(505, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(278, 25);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.CustomizationFormText = "查询";
            this.layoutControlItem1.Location = new System.Drawing.Point(417, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(44, 25);
            this.layoutControlItem1.Text = "查询";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButton2;
            this.layoutControlItem9.CustomizationFormText = "清除";
            this.layoutControlItem9.Location = new System.Drawing.Point(461, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(44, 25);
            this.layoutControlItem9.Text = "清除";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tCONF_WORDGridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(783, 471);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dataNavigator1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 496);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 23);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(176, 23);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(783, 23);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // colAPPLICATIONID
            // 
            this.colAPPLICATIONID.Caption = "编码字典";
            this.colAPPLICATIONID.FieldName = "APPLICATIONID";
            this.colAPPLICATIONID.Name = "colAPPLICATIONID";
            this.colAPPLICATIONID.Visible = true;
            this.colAPPLICATIONID.VisibleIndex = 2;
            // 
            // FrmTCONF_WORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 529);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmTCONF_WORD";
            this.Text = "超声编码维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HyForm_FormClosing);
            this.Load += new System.EventHandler(this.HyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tCONF_WORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCONF_WORDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPNAMEComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit wORDTextBox;
        private System.Windows.Forms.BindingSource tCONF_WORDBindingSource;
        private Tiger.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraEditors.ComboBoxEdit gROUPNAMEComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl tCONF_WORDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGROUPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGROUPLISTITEM;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbGroupName;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPLICATIONID;

    }
}