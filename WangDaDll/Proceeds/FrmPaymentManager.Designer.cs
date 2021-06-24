using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmPaymentManager
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
            this.col不收款 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.不收款ItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditLSB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditBSK = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.本次到期月DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tW_PaymentDetailGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_PaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsDataSet = new WangDaDll.Common.ProceedsDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col总额1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRegPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeneralPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.支付日期DateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.收款类别ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.支付方式ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.支付日期DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.支付单位TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tW_PaymentGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col支付单位 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付金额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col支付方式 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收款类别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col备注 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col操作人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col操作时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col上次到期月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col本次到期月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col总额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审核人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col审核时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col是否审批 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.是否审批CheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col业务员1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col补缴款 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.补缴款ItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col零申报 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col上次到期月份 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col缴费月数 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月平均费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col首年提成结束期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col初始做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRY = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            ((System.ComponentModel.ISupportInitialize)(this.不收款ItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLSB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBSK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款类别ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.是否审批CheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.补缴款ItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            this.SuspendLayout();
            // 
            // col不收款
            // 
            this.col不收款.ColumnEdit = this.不收款ItemCheckEdit1;
            this.col不收款.FieldName = "不收款";
            this.col不收款.Name = "col不收款";
            this.col不收款.OptionsColumn.ReadOnly = true;
            this.col不收款.Visible = true;
            this.col不收款.VisibleIndex = 17;
            // 
            // 不收款ItemCheckEdit1
            // 
            this.不收款ItemCheckEdit1.AutoHeight = false;
            this.不收款ItemCheckEdit1.Caption = "Check";
            this.不收款ItemCheckEdit1.Name = "不收款ItemCheckEdit1";
            this.不收款ItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.不收款ItemCheckEdit1.NullText = "False";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.comboBoxEditLSB);
            this.layoutControl1.Controls.Add(this.comboBoxEditBSK);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.本次到期月DateEdit);
            this.layoutControl1.Controls.Add(this.tW_PaymentDetailGridControl);
            this.layoutControl1.Controls.Add(this.btnRegPay);
            this.layoutControl1.Controls.Add(this.btnGeneralPay);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.支付日期DateEdit1);
            this.layoutControl1.Controls.Add(this.收款类别ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.支付方式ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.支付日期DateEdit);
            this.layoutControl1.Controls.Add(this.支付单位TextEdit);
            this.layoutControl1.Controls.Add(this.tW_PaymentGridControl);
            this.layoutControl1.Controls.Add(this.txtRY);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(973, 470, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(984, 700);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(528, 62);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 29);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "无业绩收款";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboBoxEditLSB
            // 
            this.comboBoxEditLSB.Location = new System.Drawing.Point(387, 36);
            this.comboBoxEditLSB.Name = "comboBoxEditLSB";
            this.comboBoxEditLSB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLSB.Properties.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBoxEditLSB.Size = new System.Drawing.Size(64, 20);
            this.comboBoxEditLSB.StyleController = this.layoutControl1;
            this.comboBoxEditLSB.TabIndex = 27;
            // 
            // comboBoxEditBSK
            // 
            this.comboBoxEditBSK.Location = new System.Drawing.Point(510, 36);
            this.comboBoxEditBSK.Name = "comboBoxEditBSK";
            this.comboBoxEditBSK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBSK.Properties.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBoxEditBSK.Size = new System.Drawing.Size(59, 20);
            this.comboBoxEditBSK.StyleController = this.layoutControl1;
            this.comboBoxEditBSK.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(100, 62);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 17;
            this.btnView.Text = "查看";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // 本次到期月DateEdit
            // 
            this.本次到期月DateEdit.EditValue = null;
            this.本次到期月DateEdit.Location = new System.Drawing.Point(821, 12);
            this.本次到期月DateEdit.Name = "本次到期月DateEdit";
            this.本次到期月DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.本次到期月DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.本次到期月DateEdit.Properties.DisplayFormat.FormatString = "yyyy年MM月";
            this.本次到期月DateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.本次到期月DateEdit.Properties.EditFormat.FormatString = "yyyy年MM月";
            this.本次到期月DateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.本次到期月DateEdit.Size = new System.Drawing.Size(121, 20);
            this.本次到期月DateEdit.StyleController = this.layoutControl1;
            this.本次到期月DateEdit.TabIndex = 16;
            // 
            // tW_PaymentDetailGridControl
            // 
            this.tW_PaymentDetailGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_PaymentDetailGridControl.DataSource = this.tW_PaymentDetailBindingSource;
            this.tW_PaymentDetailGridControl.Location = new System.Drawing.Point(696, 95);
            this.tW_PaymentDetailGridControl.MainView = this.gridView2;
            this.tW_PaymentDetailGridControl.Name = "tW_PaymentDetailGridControl";
            this.tW_PaymentDetailGridControl.Size = new System.Drawing.Size(276, 593);
            this.tW_PaymentDetailGridControl.TabIndex = 15;
            this.tW_PaymentDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tW_PaymentDetailBindingSource
            // 
            this.tW_PaymentDetailBindingSource.DataMember = "TW_PaymentDetail";
            this.tW_PaymentDetailBindingSource.DataSource = this.proceedsDataSet;
            // 
            // proceedsDataSet
            // 
            this.proceedsDataSet.DataSetName = "ProceedsDataSet";
            this.proceedsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.col客户名称,
            this.col业务员,
            this.col注册员,
            this.col做账会计1,
            this.col注册费收款额,
            this.col做账费收款额,
            this.col收款日期,
            this.col工本费收款额,
            this.col开票费收款额,
            this.col总额1});
            this.gridView2.GridControl = this.tW_PaymentDetailGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PaintStyleName = "Flat";
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 0;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 2;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 3;
            // 
            // col做账会计1
            // 
            this.col做账会计1.FieldName = "做账会计";
            this.col做账会计1.Name = "col做账会计1";
            this.col做账会计1.OptionsColumn.ReadOnly = true;
            this.col做账会计1.Visible = true;
            this.col做账会计1.VisibleIndex = 4;
            // 
            // col注册费收款额
            // 
            this.col注册费收款额.Caption = "注册/一次性业务收款额";
            this.col注册费收款额.FieldName = "注册费收款额";
            this.col注册费收款额.Name = "col注册费收款额";
            this.col注册费收款额.OptionsColumn.ReadOnly = true;
            this.col注册费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册费收款额", "{0:0.##}")});
            this.col注册费收款额.Visible = true;
            this.col注册费收款额.VisibleIndex = 5;
            this.col注册费收款额.Width = 92;
            // 
            // col做账费收款额
            // 
            this.col做账费收款额.FieldName = "做账费收款额";
            this.col做账费收款额.Name = "col做账费收款额";
            this.col做账费收款额.OptionsColumn.ReadOnly = true;
            this.col做账费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账费收款额", "{0:0.##}")});
            this.col做账费收款额.Visible = true;
            this.col做账费收款额.VisibleIndex = 6;
            this.col做账费收款额.Width = 92;
            // 
            // col收款日期
            // 
            this.col收款日期.FieldName = "收款日期";
            this.col收款日期.Name = "col收款日期";
            this.col收款日期.OptionsColumn.ReadOnly = true;
            this.col收款日期.Visible = true;
            this.col收款日期.VisibleIndex = 9;
            // 
            // col工本费收款额
            // 
            this.col工本费收款额.FieldName = "工本费收款额";
            this.col工本费收款额.Name = "col工本费收款额";
            this.col工本费收款额.OptionsColumn.ReadOnly = true;
            this.col工本费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费收款额", "{0:0.##}")});
            this.col工本费收款额.Visible = true;
            this.col工本费收款额.VisibleIndex = 7;
            this.col工本费收款额.Width = 92;
            // 
            // col开票费收款额
            // 
            this.col开票费收款额.FieldName = "开票费收款额";
            this.col开票费收款额.Name = "col开票费收款额";
            this.col开票费收款额.OptionsColumn.ReadOnly = true;
            this.col开票费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费收款额", "{0:0.##}")});
            this.col开票费收款额.Visible = true;
            this.col开票费收款额.VisibleIndex = 8;
            this.col开票费收款额.Width = 92;
            // 
            // col总额1
            // 
            this.col总额1.FieldName = "总额";
            this.col总额1.Name = "col总额1";
            this.col总额1.OptionsColumn.ReadOnly = true;
            this.col总额1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "总额", "{0:0.##}")});
            this.col总额1.Visible = true;
            this.col总额1.VisibleIndex = 1;
            // 
            // btnRegPay
            // 
            this.btnRegPay.Location = new System.Drawing.Point(379, 62);
            this.btnRegPay.Name = "btnRegPay";
            this.btnRegPay.Size = new System.Drawing.Size(145, 29);
            this.btnRegPay.StyleController = this.layoutControl1;
            this.btnRegPay.TabIndex = 15;
            this.btnRegPay.Text = "注册/一次性业务收款";
            this.btnRegPay.Click += new System.EventHandler(this.btnRegPay_Click);
            // 
            // btnGeneralPay
            // 
            this.btnGeneralPay.Location = new System.Drawing.Point(286, 62);
            this.btnGeneralPay.Name = "btnGeneralPay";
            this.btnGeneralPay.Size = new System.Drawing.Size(89, 22);
            this.btnGeneralPay.StyleController = this.layoutControl1;
            this.btnGeneralPay.TabIndex = 14;
            this.btnGeneralPay.Text = "常规收款";
            this.btnGeneralPay.Click += new System.EventHandler(this.btnGeneralPay_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(573, 36);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(666, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // 支付日期DateEdit1
            // 
            this.支付日期DateEdit1.EditValue = null;
            this.支付日期DateEdit1.Location = new System.Drawing.Point(227, 36);
            this.支付日期DateEdit1.Name = "支付日期DateEdit1";
            this.支付日期DateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit1.Size = new System.Drawing.Size(101, 20);
            this.支付日期DateEdit1.StyleController = this.layoutControl1;
            this.支付日期DateEdit1.TabIndex = 11;
            // 
            // 收款类别ComboBoxEdit
            // 
            this.收款类别ComboBoxEdit.Location = new System.Drawing.Point(474, 12);
            this.收款类别ComboBoxEdit.Name = "收款类别ComboBoxEdit";
            this.收款类别ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.收款类别ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "常规收款",
            "注册收款",
            "成长版收款",
            "其他一次性业务收款"});
            this.收款类别ComboBoxEdit.Size = new System.Drawing.Size(114, 20);
            this.收款类别ComboBoxEdit.StyleController = this.layoutControl1;
            this.收款类别ComboBoxEdit.TabIndex = 10;
            // 
            // 支付方式ComboBoxEdit
            // 
            this.支付方式ComboBoxEdit.Location = new System.Drawing.Point(647, 12);
            this.支付方式ComboBoxEdit.Name = "支付方式ComboBoxEdit";
            this.支付方式ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付方式ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "常规收款",
            "注册收款"});
            this.支付方式ComboBoxEdit.Size = new System.Drawing.Size(115, 20);
            this.支付方式ComboBoxEdit.StyleController = this.layoutControl1;
            this.支付方式ComboBoxEdit.TabIndex = 9;
            // 
            // 支付日期DateEdit
            // 
            this.支付日期DateEdit.EditValue = null;
            this.支付日期DateEdit.Location = new System.Drawing.Point(67, 36);
            this.支付日期DateEdit.Name = "支付日期DateEdit";
            this.支付日期DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit.Size = new System.Drawing.Size(101, 20);
            this.支付日期DateEdit.StyleController = this.layoutControl1;
            this.支付日期DateEdit.TabIndex = 7;
            // 
            // 支付单位TextEdit
            // 
            this.支付单位TextEdit.Location = new System.Drawing.Point(67, 12);
            this.支付单位TextEdit.Name = "支付单位TextEdit";
            this.支付单位TextEdit.Size = new System.Drawing.Size(195, 20);
            this.支付单位TextEdit.StyleController = this.layoutControl1;
            this.支付单位TextEdit.TabIndex = 6;
            // 
            // tW_PaymentGridControl
            // 
            this.tW_PaymentGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_PaymentGridControl.DataSource = this.tW_PaymentBindingSource;
            this.tW_PaymentGridControl.Location = new System.Drawing.Point(12, 95);
            this.tW_PaymentGridControl.MainView = this.gridView1;
            this.tW_PaymentGridControl.Name = "tW_PaymentGridControl";
            this.tW_PaymentGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.是否审批CheckEdit1,
            this.不收款ItemCheckEdit1,
            this.补缴款ItemCheckEdit1,
            this.repositoryItemCheckEdit1});
            this.tW_PaymentGridControl.Size = new System.Drawing.Size(680, 593);
            this.tW_PaymentGridControl.TabIndex = 4;
            this.tW_PaymentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tW_PaymentBindingSource
            // 
            this.tW_PaymentBindingSource.DataMember = "TW_Payment";
            this.tW_PaymentBindingSource.DataSource = this.proceedsDataSet;
            this.tW_PaymentBindingSource.PositionChanged += new System.EventHandler(this.tW_PaymentBindingSource_PositionChanged);
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
            this.col支付单位,
            this.col支付金额,
            this.col支付日期,
            this.col支付方式,
            this.col收款人,
            this.col收款类别,
            this.col备注,
            this.col操作人,
            this.col操作时间,
            this.col工本费,
            this.col开票费,
            this.col做账会计,
            this.col上次到期月,
            this.col本次到期月,
            this.col总额,
            this.col审核人,
            this.col审核时间,
            this.col是否审批,
            this.col业务员1,
            this.col注册员1,
            this.col不收款,
            this.col补缴款,
            this.col零申报,
            this.col上次到期月份,
            this.col缴费月数,
            this.col月平均费,
            this.col首年提成结束期,
            this.col初始做账时间});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.col不收款;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.tW_PaymentGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col支付单位
            // 
            this.col支付单位.FieldName = "支付单位";
            this.col支付单位.Name = "col支付单位";
            this.col支付单位.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col支付单位.Visible = true;
            this.col支付单位.VisibleIndex = 0;
            this.col支付单位.Width = 80;
            // 
            // col支付金额
            // 
            this.col支付金额.Caption = "做账费";
            this.col支付金额.FieldName = "支付金额";
            this.col支付金额.Name = "col支付金额";
            this.col支付金额.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col支付金额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "支付金额", "{0:0.##}")});
            // 
            // col支付日期
            // 
            this.col支付日期.FieldName = "支付日期";
            this.col支付日期.Name = "col支付日期";
            this.col支付日期.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col支付日期.Visible = true;
            this.col支付日期.VisibleIndex = 3;
            this.col支付日期.Width = 80;
            // 
            // col支付方式
            // 
            this.col支付方式.FieldName = "支付方式";
            this.col支付方式.Name = "col支付方式";
            this.col支付方式.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col支付方式.Visible = true;
            this.col支付方式.VisibleIndex = 4;
            this.col支付方式.Width = 80;
            // 
            // col收款人
            // 
            this.col收款人.FieldName = "收款人";
            this.col收款人.Name = "col收款人";
            this.col收款人.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col收款人.Visible = true;
            this.col收款人.VisibleIndex = 5;
            // 
            // col收款类别
            // 
            this.col收款类别.FieldName = "收款类别";
            this.col收款类别.Name = "col收款类别";
            this.col收款类别.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col收款类别.Visible = true;
            this.col收款类别.VisibleIndex = 20;
            this.col收款类别.Width = 80;
            // 
            // col备注
            // 
            this.col备注.FieldName = "备注";
            this.col备注.Name = "col备注";
            this.col备注.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col备注.Visible = true;
            this.col备注.VisibleIndex = 25;
            // 
            // col操作人
            // 
            this.col操作人.FieldName = "操作人";
            this.col操作人.Name = "col操作人";
            this.col操作人.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col操作人.Visible = true;
            this.col操作人.VisibleIndex = 23;
            // 
            // col操作时间
            // 
            this.col操作时间.FieldName = "操作时间";
            this.col操作时间.Name = "col操作时间";
            this.col操作时间.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col操作时间.Visible = true;
            this.col操作时间.VisibleIndex = 24;
            this.col操作时间.Width = 80;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.Name = "col工本费";
            this.col工本费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col工本费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费", "{0:0.##}")});
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 6;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.Name = "col开票费";
            this.col开票费.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col开票费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费", "{0:0.##}")});
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 7;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 2;
            this.col做账会计.Width = 80;
            // 
            // col上次到期月
            // 
            this.col上次到期月.FieldName = "上次到期月";
            this.col上次到期月.Name = "col上次到期月";
            this.col上次到期月.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // col本次到期月
            // 
            this.col本次到期月.FieldName = "本次到期月份";
            this.col本次到期月.Name = "col本次到期月";
            this.col本次到期月.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col本次到期月.Visible = true;
            this.col本次到期月.VisibleIndex = 10;
            this.col本次到期月.Width = 80;
            // 
            // col总额
            // 
            this.col总额.Caption = "支付总额";
            this.col总额.FieldName = "总额";
            this.col总额.Name = "col总额";
            this.col总额.OptionsColumn.ReadOnly = true;
            this.col总额.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col总额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "总额", "{0:0.##}")});
            this.col总额.Visible = true;
            this.col总额.VisibleIndex = 1;
            this.col总额.Width = 80;
            // 
            // col审核人
            // 
            this.col审核人.FieldName = "审核人";
            this.col审核人.Name = "col审核人";
            this.col审核人.OptionsColumn.ReadOnly = true;
            this.col审核人.Visible = true;
            this.col审核人.VisibleIndex = 15;
            // 
            // col审核时间
            // 
            this.col审核时间.FieldName = "审核时间";
            this.col审核时间.Name = "col审核时间";
            this.col审核时间.OptionsColumn.ReadOnly = true;
            this.col审核时间.Visible = true;
            this.col审核时间.VisibleIndex = 16;
            this.col审核时间.Width = 80;
            // 
            // col是否审批
            // 
            this.col是否审批.ColumnEdit = this.是否审批CheckEdit1;
            this.col是否审批.FieldName = "是否审批";
            this.col是否审批.Name = "col是否审批";
            this.col是否审批.OptionsColumn.ReadOnly = true;
            this.col是否审批.Visible = true;
            this.col是否审批.VisibleIndex = 14;
            this.col是否审批.Width = 80;
            // 
            // 是否审批CheckEdit1
            // 
            this.是否审批CheckEdit1.AutoHeight = false;
            this.是否审批CheckEdit1.Caption = "Check";
            this.是否审批CheckEdit1.Name = "是否审批CheckEdit1";
            this.是否审批CheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.是否审批CheckEdit1.NullText = "False";
            // 
            // col业务员1
            // 
            this.col业务员1.FieldName = "业务员";
            this.col业务员1.Name = "col业务员1";
            this.col业务员1.OptionsColumn.ReadOnly = true;
            this.col业务员1.Visible = true;
            this.col业务员1.VisibleIndex = 12;
            // 
            // col注册员1
            // 
            this.col注册员1.FieldName = "注册员";
            this.col注册员1.Name = "col注册员1";
            this.col注册员1.OptionsColumn.ReadOnly = true;
            this.col注册员1.Visible = true;
            this.col注册员1.VisibleIndex = 13;
            // 
            // col补缴款
            // 
            this.col补缴款.ColumnEdit = this.补缴款ItemCheckEdit1;
            this.col补缴款.FieldName = "补缴款";
            this.col补缴款.Name = "col补缴款";
            this.col补缴款.OptionsColumn.ReadOnly = true;
            this.col补缴款.Visible = true;
            this.col补缴款.VisibleIndex = 18;
            // 
            // 补缴款ItemCheckEdit1
            // 
            this.补缴款ItemCheckEdit1.AutoHeight = false;
            this.补缴款ItemCheckEdit1.Caption = "Check";
            this.补缴款ItemCheckEdit1.Name = "补缴款ItemCheckEdit1";
            this.补缴款ItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.补缴款ItemCheckEdit1.NullText = "False";
            // 
            // col零申报
            // 
            this.col零申报.ColumnEdit = this.repositoryItemCheckEdit1;
            this.col零申报.FieldName = "零申报";
            this.col零申报.Name = "col零申报";
            this.col零申报.OptionsColumn.ReadOnly = true;
            this.col零申报.Visible = true;
            this.col零申报.VisibleIndex = 19;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // col上次到期月份
            // 
            this.col上次到期月份.FieldName = "上次到期月份";
            this.col上次到期月份.Name = "col上次到期月份";
            this.col上次到期月份.OptionsColumn.ReadOnly = true;
            this.col上次到期月份.Visible = true;
            this.col上次到期月份.VisibleIndex = 9;
            this.col上次到期月份.Width = 80;
            // 
            // col缴费月数
            // 
            this.col缴费月数.FieldName = "缴费月数";
            this.col缴费月数.Name = "col缴费月数";
            this.col缴费月数.OptionsColumn.ReadOnly = true;
            this.col缴费月数.Visible = true;
            this.col缴费月数.VisibleIndex = 11;
            this.col缴费月数.Width = 80;
            // 
            // col月平均费
            // 
            this.col月平均费.FieldName = "月平均费";
            this.col月平均费.Name = "col月平均费";
            this.col月平均费.OptionsColumn.ReadOnly = true;
            this.col月平均费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "月平均费", "{0:0.##}")});
            this.col月平均费.Visible = true;
            this.col月平均费.VisibleIndex = 8;
            this.col月平均费.Width = 80;
            // 
            // col首年提成结束期
            // 
            this.col首年提成结束期.FieldName = "首年提成结束期";
            this.col首年提成结束期.Name = "col首年提成结束期";
            this.col首年提成结束期.OptionsColumn.ReadOnly = true;
            this.col首年提成结束期.Visible = true;
            this.col首年提成结束期.VisibleIndex = 21;
            this.col首年提成结束期.Width = 125;
            // 
            // col初始做账时间
            // 
            this.col初始做账时间.FieldName = "初始做账时间";
            this.col初始做账时间.Name = "col初始做账时间";
            this.col初始做账时间.OptionsColumn.ReadOnly = true;
            this.col初始做账时间.Visible = true;
            this.col初始做账时间.VisibleIndex = 22;
            this.col初始做账时间.Width = 110;
            // 
            // txtRY
            // 
            this.txtRY.Location = new System.Drawing.Point(321, 12);
            this.txtRY.Name = "txtRY";
            this.txtRY.Size = new System.Drawing.Size(94, 20);
            this.txtRY.StyleController = this.layoutControl1;
            this.txtRY.TabIndex = 24;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem13,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem14,
            this.layoutControlItem12,
            this.layoutControlItem18,
            this.layoutControlItem11,
            this.layoutControlItem19,
            this.layoutControlItem20,
            this.layoutControlItem17,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem15});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(984, 700);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_PaymentGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 83);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(684, 597);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.支付单位TextEdit;
            this.layoutControlItem3.CustomizationFormText = "支付单位:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(254, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(254, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(254, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "支付单位:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.支付方式ComboBoxEdit;
            this.layoutControlItem6.CustomizationFormText = "支付方式:";
            this.layoutControlItem6.Location = new System.Drawing.Point(580, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(174, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(174, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(174, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "支付方式:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.收款类别ComboBoxEdit;
            this.layoutControlItem5.CustomizationFormText = "收款类别:";
            this.layoutControlItem5.Location = new System.Drawing.Point(407, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(173, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(173, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(173, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "收款类别:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnClear;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(654, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnQuery;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(561, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(747, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(217, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.支付日期DateEdit1;
            this.layoutControlItem7.CustomizationFormText = "支付日期:";
            this.layoutControlItem7.Location = new System.Drawing.Point(160, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(160, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(160, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "到:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.支付日期DateEdit;
            this.layoutControlItem4.CustomizationFormText = "支付日期:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(160, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(160, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "支付日期:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.本次到期月DateEdit;
            this.layoutControlItem13.CustomizationFormText = "到期月:";
            this.layoutControlItem13.Location = new System.Drawing.Point(754, 0);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(180, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(180, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "到期月:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(52, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(934, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(30, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(624, 50);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(340, 33);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnEdit;
            this.layoutControlItem14.CustomizationFormText = "layoutControlItem14";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(88, 26);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(88, 26);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(88, 33);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnView;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(88, 50);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(93, 33);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.btnDelete;
            this.layoutControlItem18.CustomizationFormText = "layoutControlItem18";
            this.layoutControlItem18.Location = new System.Drawing.Point(181, 50);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(93, 33);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.tW_PaymentDetailGridControl;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(684, 83);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(280, 597);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.comboBoxEditLSB;
            this.layoutControlItem19.CustomizationFormText = "零申报:";
            this.layoutControlItem19.Location = new System.Drawing.Point(320, 24);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(123, 26);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(123, 26);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(123, 26);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "零申报:";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.comboBoxEditBSK;
            this.layoutControlItem20.CustomizationFormText = "不收款:";
            this.layoutControlItem20.Location = new System.Drawing.Point(443, 24);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(118, 26);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(118, 26);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(118, 26);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.Text = "不收款:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtRY;
            this.layoutControlItem17.CustomizationFormText = "会计/业务员/注册员";
            this.layoutControlItem17.Location = new System.Drawing.Point(254, 0);
            this.layoutControlItem17.MaxSize = new System.Drawing.Size(153, 24);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(153, 24);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(153, 24);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "会计";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnGeneralPay;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(274, 50);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(93, 33);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnRegPay;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(367, 50);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(149, 33);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(149, 33);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(149, 33);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.simpleButton1;
            this.layoutControlItem15.Location = new System.Drawing.Point(516, 50);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(108, 33);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(108, 33);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(108, 33);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPaymentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 700);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPaymentManager";
            this.Text = "收款管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaymentManager_FormClosing);
            this.Load += new System.EventHandler(this.FrmPaymentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.不收款ItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLSB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBSK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.本次到期月DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款类别ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.是否审批CheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.补缴款ItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl tW_PaymentGridControl;
        private System.Windows.Forms.BindingSource tW_PaymentBindingSource;
        private ProceedsDataSet proceedsDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col支付单位;
        private DevExpress.XtraGrid.Columns.GridColumn col支付金额;
        private DevExpress.XtraGrid.Columns.GridColumn col支付日期;
        private DevExpress.XtraGrid.Columns.GridColumn col支付方式;
        private DevExpress.XtraGrid.Columns.GridColumn col收款人;
        private DevExpress.XtraGrid.Columns.GridColumn col收款类别;
        private DevExpress.XtraGrid.Columns.GridColumn col备注;
        private DevExpress.XtraGrid.Columns.GridColumn col操作人;
        private DevExpress.XtraGrid.Columns.GridColumn col操作时间;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col上次到期月;
        private DevExpress.XtraGrid.Columns.GridColumn col本次到期月;
        private DevExpress.XtraGrid.Columns.GridColumn col总额;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.DateEdit 支付日期DateEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit 收款类别ComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 支付方式ComboBoxEdit;
        private DevExpress.XtraEditors.DateEdit 支付日期DateEdit;
        private DevExpress.XtraEditors.TextEdit 支付单位TextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnRegPay;
        private DevExpress.XtraEditors.SimpleButton btnGeneralPay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.GridControl tW_PaymentDetailGridControl;
        private System.Windows.Forms.BindingSource tW_PaymentDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计1;
        private DevExpress.XtraGrid.Columns.GridColumn col注册费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col做账费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col收款日期;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col总额1;
        private DevExpress.XtraEditors.DateEdit 本次到期月DateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraGrid.Columns.GridColumn col审核人;
        private DevExpress.XtraGrid.Columns.GridColumn col审核时间;
        private DevExpress.XtraGrid.Columns.GridColumn col是否审批;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员1;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员1;
        private DevExpress.XtraGrid.Columns.GridColumn col不收款;
        private DevExpress.XtraGrid.Columns.GridColumn col补缴款;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit 不收款ItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit 是否审批CheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit 补缴款ItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col零申报;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col上次到期月份;
        private DevExpress.XtraEditors.TextEdit txtRY;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraGrid.Columns.GridColumn col缴费月数;
        private DevExpress.XtraGrid.Columns.GridColumn col月平均费;
        private Tiger.PdrCommon.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLSB;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBSK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraGrid.Columns.GridColumn col首年提成结束期;
        private DevExpress.XtraGrid.Columns.GridColumn col初始做账时间;
    }
}