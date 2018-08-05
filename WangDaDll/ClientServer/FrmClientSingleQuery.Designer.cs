using WangDaDll;
using WangDaDll.Common;

namespace WangDaDll
{
    partial class FrmClientSingleQuery
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
            this.tW_ClientGridControl = new DevExpress.XtraGrid.GridControl();
            this.tW_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csDataSet = new WangDaDll.Common.CsDataSet();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.col客户名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col税号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col开户行及账号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col成立时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司性质 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col公司地址 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col出生日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col年销售额 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账会计 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col初始做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col收费标准 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col客户分级 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col注册员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col业务员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改人 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col修改时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col做账时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.客户名称TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tW_ClientGridControl);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.客户名称TextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(593, 459);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tW_ClientGridControl
            // 
            this.tW_ClientGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tW_ClientGridControl.DataSource = this.tW_ClientBindingSource;
            this.tW_ClientGridControl.Location = new System.Drawing.Point(12, 38);
            this.tW_ClientGridControl.MainView = this.cardView1;
            this.tW_ClientGridControl.Name = "tW_ClientGridControl";
            this.tW_ClientGridControl.Size = new System.Drawing.Size(569, 409);
            this.tW_ClientGridControl.TabIndex = 7;
            this.tW_ClientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
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
            // cardView1
            // 
            this.cardView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.CardCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldValue.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.cardView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.cardView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.cardView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardView1.CardWidth = 450;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col客户名称,
            this.col税号,
            this.col开户行及账号,
            this.col成立时间,
            this.col公司性质,
            this.col公司类型,
            this.col公司地址,
            this.col出生日期,
            this.col年销售额,
            this.col做账会计,
            this.col初始做账时间,
            this.col收费标准,
            this.col客户分级,
            this.col注册员,
            this.col业务员,
            this.col修改人,
            this.col修改时间,
            this.col做账时间});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.tW_ClientGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.PaintStyleName = "Style3D";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // col客户名称
            // 
            this.col客户名称.FieldName = "客户名称";
            this.col客户名称.Name = "col客户名称";
            this.col客户名称.OptionsColumn.ReadOnly = true;
            this.col客户名称.Visible = true;
            this.col客户名称.VisibleIndex = 0;
            // 
            // col税号
            // 
            this.col税号.FieldName = "税号";
            this.col税号.Name = "col税号";
            this.col税号.OptionsColumn.ReadOnly = true;
            this.col税号.Visible = true;
            this.col税号.VisibleIndex = 1;
            // 
            // col开户行及账号
            // 
            this.col开户行及账号.FieldName = "开户行及账号";
            this.col开户行及账号.Name = "col开户行及账号";
            this.col开户行及账号.OptionsColumn.ReadOnly = true;
            this.col开户行及账号.Visible = true;
            this.col开户行及账号.VisibleIndex = 2;
            // 
            // col成立时间
            // 
            this.col成立时间.FieldName = "成立时间";
            this.col成立时间.Name = "col成立时间";
            this.col成立时间.OptionsColumn.ReadOnly = true;
            this.col成立时间.Visible = true;
            this.col成立时间.VisibleIndex = 3;
            // 
            // col公司性质
            // 
            this.col公司性质.FieldName = "公司性质";
            this.col公司性质.Name = "col公司性质";
            this.col公司性质.OptionsColumn.ReadOnly = true;
            this.col公司性质.Visible = true;
            this.col公司性质.VisibleIndex = 4;
            // 
            // col公司类型
            // 
            this.col公司类型.FieldName = "公司类型";
            this.col公司类型.Name = "col公司类型";
            this.col公司类型.OptionsColumn.ReadOnly = true;
            this.col公司类型.Visible = true;
            this.col公司类型.VisibleIndex = 5;
            // 
            // col公司地址
            // 
            this.col公司地址.FieldName = "公司地址";
            this.col公司地址.Name = "col公司地址";
            this.col公司地址.OptionsColumn.ReadOnly = true;
            this.col公司地址.Visible = true;
            this.col公司地址.VisibleIndex = 6;
            // 
            // col出生日期
            // 
            this.col出生日期.FieldName = "出生日期";
            this.col出生日期.Name = "col出生日期";
            this.col出生日期.OptionsColumn.ReadOnly = true;
            this.col出生日期.Visible = true;
            this.col出生日期.VisibleIndex = 7;
            // 
            // col年销售额
            // 
            this.col年销售额.FieldName = "年销售额";
            this.col年销售额.Name = "col年销售额";
            this.col年销售额.OptionsColumn.ReadOnly = true;
            this.col年销售额.Visible = true;
            this.col年销售额.VisibleIndex = 8;
            // 
            // col做账会计
            // 
            this.col做账会计.FieldName = "做账会计";
            this.col做账会计.Name = "col做账会计";
            this.col做账会计.OptionsColumn.ReadOnly = true;
            this.col做账会计.Visible = true;
            this.col做账会计.VisibleIndex = 9;
            // 
            // col初始做账时间
            // 
            this.col初始做账时间.FieldName = "初始做账时间";
            this.col初始做账时间.Name = "col初始做账时间";
            this.col初始做账时间.OptionsColumn.ReadOnly = true;
            this.col初始做账时间.Visible = true;
            this.col初始做账时间.VisibleIndex = 10;
            // 
            // col收费标准
            // 
            this.col收费标准.FieldName = "收费标准";
            this.col收费标准.Name = "col收费标准";
            this.col收费标准.OptionsColumn.ReadOnly = true;
            this.col收费标准.Visible = true;
            this.col收费标准.VisibleIndex = 11;
            // 
            // col客户分级
            // 
            this.col客户分级.FieldName = "客户分级";
            this.col客户分级.Name = "col客户分级";
            this.col客户分级.OptionsColumn.ReadOnly = true;
            this.col客户分级.Visible = true;
            this.col客户分级.VisibleIndex = 12;
            // 
            // col注册员
            // 
            this.col注册员.FieldName = "注册员";
            this.col注册员.Name = "col注册员";
            this.col注册员.OptionsColumn.ReadOnly = true;
            this.col注册员.Visible = true;
            this.col注册员.VisibleIndex = 13;
            // 
            // col业务员
            // 
            this.col业务员.FieldName = "业务员";
            this.col业务员.Name = "col业务员";
            this.col业务员.OptionsColumn.ReadOnly = true;
            this.col业务员.Visible = true;
            this.col业务员.VisibleIndex = 14;
            // 
            // col修改人
            // 
            this.col修改人.FieldName = "修改人";
            this.col修改人.Name = "col修改人";
            this.col修改人.OptionsColumn.ReadOnly = true;
            this.col修改人.Visible = true;
            this.col修改人.VisibleIndex = 15;
            // 
            // col修改时间
            // 
            this.col修改时间.FieldName = "修改时间";
            this.col修改时间.Name = "col修改时间";
            this.col修改时间.OptionsColumn.ReadOnly = true;
            this.col修改时间.Visible = true;
            this.col修改时间.VisibleIndex = 16;
            // 
            // col做账时间
            // 
            this.col做账时间.FieldName = "做账时间";
            this.col做账时间.Name = "col做账时间";
            this.col做账时间.OptionsColumn.ReadOnly = true;
            this.col做账时间.Visible = true;
            this.col做账时间.VisibleIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(322, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // 客户名称TextEdit
            // 
            this.客户名称TextEdit.Location = new System.Drawing.Point(67, 12);
            this.客户名称TextEdit.Name = "客户名称TextEdit";
            this.客户名称TextEdit.Size = new System.Drawing.Size(251, 20);
            this.客户名称TextEdit.StyleController = this.layoutControl1;
            this.客户名称TextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(593, 459);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.客户名称TextEdit;
            this.layoutControlItem2.CustomizationFormText = "客户名称:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(310, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(310, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(310, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "客户名称:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnQuery;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(310, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnClear;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(410, 0);
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
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(510, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(63, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tW_ClientGridControl;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(573, 413);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmClientSingleQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 459);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmClientSingleQuery";
            this.Text = "客户信息单一查询";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tW_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户名称TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit 客户名称TextEdit;
        private System.Windows.Forms.BindingSource tW_ClientBindingSource;
        private CsDataSet csDataSet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl tW_ClientGridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn col客户名称;
        private DevExpress.XtraGrid.Columns.GridColumn col税号;
        private DevExpress.XtraGrid.Columns.GridColumn col开户行及账号;
        private DevExpress.XtraGrid.Columns.GridColumn col成立时间;
        private DevExpress.XtraGrid.Columns.GridColumn col公司性质;
        private DevExpress.XtraGrid.Columns.GridColumn col公司类型;
        private DevExpress.XtraGrid.Columns.GridColumn col公司地址;
        private DevExpress.XtraGrid.Columns.GridColumn col出生日期;
        private DevExpress.XtraGrid.Columns.GridColumn col年销售额;
        private DevExpress.XtraGrid.Columns.GridColumn col做账会计;
        private DevExpress.XtraGrid.Columns.GridColumn col初始做账时间;
        private DevExpress.XtraGrid.Columns.GridColumn col收费标准;
        private DevExpress.XtraGrid.Columns.GridColumn col客户分级;
        private DevExpress.XtraGrid.Columns.GridColumn col注册员;
        private DevExpress.XtraGrid.Columns.GridColumn col业务员;
        private DevExpress.XtraGrid.Columns.GridColumn col修改人;
        private DevExpress.XtraGrid.Columns.GridColumn col修改时间;
        private DevExpress.XtraGrid.Columns.GridColumn col做账时间;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}