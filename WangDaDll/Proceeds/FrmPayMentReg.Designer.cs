﻿using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmPayMentReg
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.不收款CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tW_PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsDataSet = new WangDaDll.Common.ProceedsDataSet();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayhalf = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectClient = new DevExpress.XtraEditors.SimpleButton();
            this.tW_PaymentDetailGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_PaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月做账费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账到期月 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工本费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开票费收款额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col总额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col缴费月数 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col月平均费 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.支付金额CalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.支付日期DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.支付方式ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.收款人TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.备注TextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.支付单位TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WangDaDll.CWaitForm), true, true);
            this.dstTCONF_WORD = new Tiger.PdrCommon.ConfigApp.DstTCONF_WORD();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.不收款CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付金额CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款人TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.不收款CheckEdit);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnOK);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnPayAll);
            this.layoutControl1.Controls.Add(this.btnPayhalf);
            this.layoutControl1.Controls.Add(this.btnSelectClient);
            this.layoutControl1.Controls.Add(this.tW_PaymentDetailGridControl);
            this.layoutControl1.Controls.Add(this.支付金额CalcEdit);
            this.layoutControl1.Controls.Add(this.支付日期DateEdit);
            this.layoutControl1.Controls.Add(this.支付方式ComboBoxEdit);
            this.layoutControl1.Controls.Add(this.收款人TextEdit);
            this.layoutControl1.Controls.Add(this.备注TextEdit);
            this.layoutControl1.Controls.Add(this.支付单位TextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(872, 579);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // 不收款CheckEdit
            // 
            this.不收款CheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "不收款", true));
            this.不收款CheckEdit.Location = new System.Drawing.Point(12, 380);
            this.不收款CheckEdit.Name = "不收款CheckEdit";
            this.不收款CheckEdit.Properties.Caption = "不收款";
            this.不收款CheckEdit.Size = new System.Drawing.Size(65, 19);
            this.不收款CheckEdit.StyleController = this.layoutControl1;
            this.不收款CheckEdit.TabIndex = 24;
            // 
            // tW_PaymentBindingSource
            // 
            this.tW_PaymentBindingSource.DataMember = "TW_Payment";
            this.tW_PaymentBindingSource.DataSource = this.proceedsDataSet;
            // 
            // proceedsDataSet
            // 
            this.proceedsDataSet.DataSetName = "ProceedsDataSet";
            this.proceedsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 404);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "计算";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 545);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 22);
            this.btnOK.StyleController = this.layoutControl1;
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定收款";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 545);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消收款";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPayAll
            // 
            this.btnPayAll.Location = new System.Drawing.Point(198, 12);
            this.btnPayAll.Name = "btnPayAll";
            this.btnPayAll.Size = new System.Drawing.Size(89, 22);
            this.btnPayAll.StyleController = this.layoutControl1;
            this.btnPayAll.TabIndex = 20;
            this.btnPayAll.Text = "全部支付";
            this.btnPayAll.Click += new System.EventHandler(this.btnPayAll_Click);
            // 
            // btnPayhalf
            // 
            this.btnPayhalf.Location = new System.Drawing.Point(105, 12);
            this.btnPayhalf.Name = "btnPayhalf";
            this.btnPayhalf.Size = new System.Drawing.Size(89, 22);
            this.btnPayhalf.StyleController = this.layoutControl1;
            this.btnPayhalf.TabIndex = 19;
            this.btnPayhalf.Text = "支付一半";
            this.btnPayhalf.Click += new System.EventHandler(this.btnPayhalf_Click);
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(12, 12);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(89, 22);
            this.btnSelectClient.StyleController = this.layoutControl1;
            this.btnSelectClient.TabIndex = 18;
            this.btnSelectClient.Text = "选择注册单位";
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // tW_PaymentDetailGridControl
            // 
            this.tW_PaymentDetailGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_PaymentDetailGridControl.DataSource = this.tW_PaymentDetailBindingSource;
            this.tW_PaymentDetailGridControl.Location = new System.Drawing.Point(12, 38);
            this.tW_PaymentDetailGridControl.MainView = this.gridView1;
            this.tW_PaymentDetailGridControl.Name = "tW_PaymentDetailGridControl";
            this.tW_PaymentDetailGridControl.Size = new System.Drawing.Size(848, 338);
            this.tW_PaymentDetailGridControl.TabIndex = 17;
            this.tW_PaymentDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tW_PaymentDetailBindingSource
            // 
            this.tW_PaymentDetailBindingSource.DataMember = "TW_PaymentDetail";
            this.tW_PaymentDetailBindingSource.DataSource = this.proceedsDataSet;
            this.tW_PaymentDetailBindingSource.CurrentChanged += new System.EventHandler(this.tW_PaymentDetailBindingSource_CurrentChanged);
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
            this.col业务员,
            this.col注册员,
            this.col做账会计,
            this.col注册费,
            this.col注册费收款额,
            this.col月做账费,
            this.col做账费收款额,
            this.col做账到期月,
            this.col工本费,
            this.col工本费收款额,
            this.col开票费,
            this.col开票费收款额,
            this.col总额,
            this.col缴费月数,
            this.col月平均费});
            this.gridView1.GridControl = this.tW_PaymentDetailGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 0;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 13;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 14;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 15;
            // 
            // col注册费
            // 
            this.col注册费.FieldName = "注册费";
            this.col注册费.Name = "col注册费";
            this.col注册费.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册费", "{0:0.##}")});
            this.col注册费.Visible = true;
            this.col注册费.VisibleIndex = 1;
            // 
            // col注册费收款额
            // 
            this.col注册费收款额.FieldName = "注册费收款额";
            this.col注册费收款额.Name = "col注册费收款额";
            this.col注册费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "注册费收款额", "{0:0.##}")});
            this.col注册费收款额.Visible = true;
            this.col注册费收款额.VisibleIndex = 2;
            this.col注册费收款额.Width = 92;
            // 
            // col月做账费
            // 
            this.col月做账费.FieldName = "月做账费";
            this.col月做账费.Name = "col月做账费";
            this.col月做账费.Visible = true;
            this.col月做账费.VisibleIndex = 3;
            // 
            // col做账费收款额
            // 
            this.col做账费收款额.FieldName = "做账费收款额";
            this.col做账费收款额.Name = "col做账费收款额";
            this.col做账费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "做账费收款额", "{0:0.##}")});
            this.col做账费收款额.Visible = true;
            this.col做账费收款额.VisibleIndex = 4;
            this.col做账费收款额.Width = 92;
            // 
            // col做账到期月
            // 
            this.col做账到期月.FieldName = "做账到期月";
            this.col做账到期月.Name = "col做账到期月";
            this.col做账到期月.Visible = true;
            this.col做账到期月.VisibleIndex = 5;
            this.col做账到期月.Width = 80;
            // 
            // col工本费
            // 
            this.col工本费.FieldName = "工本费";
            this.col工本费.Name = "col工本费";
            this.col工本费.Visible = true;
            this.col工本费.VisibleIndex = 8;
            // 
            // col工本费收款额
            // 
            this.col工本费收款额.FieldName = "工本费收款额";
            this.col工本费收款额.Name = "col工本费收款额";
            this.col工本费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "工本费收款额", "{0:0.##}")});
            this.col工本费收款额.Visible = true;
            this.col工本费收款额.VisibleIndex = 9;
            this.col工本费收款额.Width = 92;
            // 
            // col开票费
            // 
            this.col开票费.FieldName = "开票费";
            this.col开票费.Name = "col开票费";
            this.col开票费.Visible = true;
            this.col开票费.VisibleIndex = 10;
            // 
            // col开票费收款额
            // 
            this.col开票费收款额.FieldName = "开票费收款额";
            this.col开票费收款额.Name = "col开票费收款额";
            this.col开票费收款额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "开票费收款额", "{0:0.##}")});
            this.col开票费收款额.Visible = true;
            this.col开票费收款额.VisibleIndex = 11;
            this.col开票费收款额.Width = 90;
            // 
            // col总额
            // 
            this.col总额.FieldName = "总额";
            this.col总额.Name = "col总额";
            this.col总额.OptionsColumn.ReadOnly = true;
            this.col总额.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "总额", "{0:0.##}")});
            this.col总额.Visible = true;
            this.col总额.VisibleIndex = 12;
            // 
            // col缴费月数
            // 
            this.col缴费月数.FieldName = "缴费月数";
            this.col缴费月数.Name = "col缴费月数";
            this.col缴费月数.Visible = true;
            this.col缴费月数.VisibleIndex = 6;
            // 
            // col月平均费
            // 
            this.col月平均费.FieldName = "月平均费";
            this.col月平均费.Name = "col月平均费";
            this.col月平均费.Visible = true;
            this.col月平均费.VisibleIndex = 7;
            // 
            // 支付金额CalcEdit
            // 
            this.支付金额CalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "支付金额", true));
            this.支付金额CalcEdit.Location = new System.Drawing.Point(106, 404);
            this.支付金额CalcEdit.Name = "支付金额CalcEdit";
            this.支付金额CalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付金额CalcEdit.Properties.ReadOnly = true;
            this.支付金额CalcEdit.Size = new System.Drawing.Size(305, 20);
            this.支付金额CalcEdit.StyleController = this.layoutControl1;
            this.支付金额CalcEdit.TabIndex = 7;
            // 
            // 支付日期DateEdit
            // 
            this.支付日期DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "支付日期", true));
            this.支付日期DateEdit.EditValue = null;
            this.支付日期DateEdit.Location = new System.Drawing.Point(67, 430);
            this.支付日期DateEdit.Name = "支付日期DateEdit";
            this.支付日期DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付日期DateEdit.Size = new System.Drawing.Size(344, 20);
            this.支付日期DateEdit.StyleController = this.layoutControl1;
            this.支付日期DateEdit.TabIndex = 9;
            // 
            // 支付方式ComboBoxEdit
            // 
            this.支付方式ComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "支付方式", true));
            this.支付方式ComboBoxEdit.Location = new System.Drawing.Point(470, 404);
            this.支付方式ComboBoxEdit.Name = "支付方式ComboBoxEdit";
            this.支付方式ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.支付方式ComboBoxEdit.Size = new System.Drawing.Size(300, 20);
            this.支付方式ComboBoxEdit.StyleController = this.layoutControl1;
            this.支付方式ComboBoxEdit.TabIndex = 11;
            // 
            // 收款人TextEdit
            // 
            this.收款人TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "收款人", true));
            this.收款人TextEdit.Location = new System.Drawing.Point(470, 430);
            this.收款人TextEdit.Name = "收款人TextEdit";
            this.收款人TextEdit.Size = new System.Drawing.Size(300, 20);
            this.收款人TextEdit.StyleController = this.layoutControl1;
            this.收款人TextEdit.TabIndex = 13;
            // 
            // 备注TextEdit
            // 
            this.备注TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "备注", true));
            this.备注TextEdit.Location = new System.Drawing.Point(67, 454);
            this.备注TextEdit.Name = "备注TextEdit";
            this.备注TextEdit.Size = new System.Drawing.Size(703, 87);
            this.备注TextEdit.StyleController = this.layoutControl1;
            this.备注TextEdit.TabIndex = 17;
            this.备注TextEdit.UseOptimizedRendering = true;
            // 
            // 支付单位TextEdit
            // 
            this.支付单位TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tW_PaymentBindingSource, "支付单位", true));
            this.支付单位TextEdit.Location = new System.Drawing.Point(136, 380);
            this.支付单位TextEdit.Name = "支付单位TextEdit";
            this.支付单位TextEdit.Size = new System.Drawing.Size(635, 20);
            this.支付单位TextEdit.StyleController = this.layoutControl1;
            this.支付单位TextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem14,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem10,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.emptySpaceItem2,
            this.layoutControlItem12,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem15});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(872, 579);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.支付单位TextEdit;
            this.layoutControlItem2.CustomizationFormText = "支付单位:";
            this.layoutControlItem2.Location = new System.Drawing.Point(69, 368);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(694, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(694, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(694, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "支付单位:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.支付金额CalcEdit;
            this.layoutControlItem4.CustomizationFormText = "支付金额:";
            this.layoutControlItem4.Location = new System.Drawing.Point(39, 392);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(364, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(364, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(364, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "支付金额:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.支付日期DateEdit;
            this.layoutControlItem6.CustomizationFormText = "支付日期:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 418);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(403, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(403, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(403, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "支付日期:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.备注TextEdit;
            this.layoutControlItem14.CustomizationFormText = "备注:";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 442);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(762, 91);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(762, 91);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(762, 91);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "备注:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tW_PaymentDetailGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(852, 342);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSelectClient;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnPayhalf;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(93, 0);
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
            this.layoutControlItem7.Control = this.btnPayAll;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(186, 0);
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
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(279, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(573, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.收款人TextEdit;
            this.layoutControlItem10.CustomizationFormText = "收款人:";
            this.layoutControlItem10.Location = new System.Drawing.Point(403, 418);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(359, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(359, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "收款人:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.支付方式ComboBoxEdit;
            this.layoutControlItem8.CustomizationFormText = "支付方式:";
            this.layoutControlItem8.Location = new System.Drawing.Point(403, 392);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(359, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(359, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "支付方式:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCancel;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(93, 533);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnOK;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 533);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(93, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(186, 533);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(666, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnRefresh;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 392);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(39, 26);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(39, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(39, 26);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(762, 442);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(90, 91);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(762, 392);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(90, 26);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(763, 368);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(89, 24);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(762, 418);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(90, 24);
            this.emptySpaceItem6.Text = "emptySpaceItem6";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.不收款CheckEdit;
            this.layoutControlItem15.CustomizationFormText = "不收款:";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 368);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(69, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(69, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(69, 24);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "不收款:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextToControlDistance = 0;
            this.layoutControlItem15.TextVisible = false;
            // 
            // dstTCONF_WORD
            // 
            this.dstTCONF_WORD.DataSetName = "DstTCONF_WORD";
            this.dstTCONF_WORD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPayMentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 579);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPayMentReg";
            this.Text = "注册收款";
            this.Load += new System.EventHandler(this.FrmPayMentReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.不收款CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_PaymentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付金额CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付日期DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付方式ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.收款人TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.备注TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.支付单位TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstTCONF_WORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.BindingSource tW_PaymentBindingSource;
        private ProceedsDataSet proceedsDataSet;
        private DevExpress.XtraEditors.CalcEdit 支付金额CalcEdit;
        private DevExpress.XtraEditors.DateEdit 支付日期DateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit 支付方式ComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit 收款人TextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.MemoEdit 备注TextEdit;
        private DevExpress.XtraEditors.TextEdit 支付单位TextEdit;
        private DevExpress.XtraGrid.GridControl tW_PaymentDetailGridControl;
        private System.Windows.Forms.BindingSource tW_PaymentDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col注册费;
        private DevExpress.XtraGrid.Columns.GridColumn col注册费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col月做账费;
        private DevExpress.XtraGrid.Columns.GridColumn col做账费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col做账到期月;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费;
        private DevExpress.XtraGrid.Columns.GridColumn col工本费收款额;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费;
        private DevExpress.XtraGrid.Columns.GridColumn col开票费收款额;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnPayAll;
        private DevExpress.XtraEditors.SimpleButton btnPayhalf;
        private DevExpress.XtraEditors.SimpleButton btnSelectClient;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col总额;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private Tiger.PdrCommon.ConfigApp.DstTCONF_WORD dstTCONF_WORD;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraGrid.Columns.GridColumn col缴费月数;
        private DevExpress.XtraGrid.Columns.GridColumn col月平均费;
        private DevExpress.XtraEditors.CheckEdit 不收款CheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
    }
}