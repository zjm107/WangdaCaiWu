namespace WangDaApp
{
    partial class FrmMDIX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDIX));
            this.dockManagerSysBar = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPlSysMenu = new DevExpress.XtraBars.Docking.DockPanel();
            this.SysMenuContainer = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tvNavigator = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.Closebutton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.lblDepartment = new DevExpress.XtraBars.BarStaticItem();
            this.lblUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.biTabbedMDI = new DevExpress.XtraBars.BarButtonItem();
            this.iCascade = new DevExpress.XtraBars.BarButtonItem();
            this.iTileHorizontal = new DevExpress.XtraBars.BarButtonItem();
            this.iTileVertical = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerSysBar)).BeginInit();
            this.dockPlSysMenu.SuspendLayout();
            this.SysMenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManagerSysBar
            // 
            this.dockManagerSysBar.DockingOptions.ShowCloseButton = false;
            this.dockManagerSysBar.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.Standard;
            this.dockManagerSysBar.Form = this;
            this.dockManagerSysBar.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPlSysMenu});
            this.dockManagerSysBar.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPlSysMenu
            // 
            this.dockPlSysMenu.Controls.Add(this.SysMenuContainer);
            this.dockPlSysMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPlSysMenu.Hint = "菜单";
            this.dockPlSysMenu.ID = new System.Guid("48ffc232-a8e3-4abf-9f36-980d80f37919");
            this.dockPlSysMenu.Location = new System.Drawing.Point(0, 46);
            this.dockPlSysMenu.Name = "dockPlSysMenu";
            this.dockPlSysMenu.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPlSysMenu.Size = new System.Drawing.Size(200, 713);
            this.dockPlSysMenu.Text = "菜单";
            // 
            // SysMenuContainer
            // 
            this.SysMenuContainer.Controls.Add(this.tvNavigator);
            this.SysMenuContainer.Location = new System.Drawing.Point(6, 35);
            this.SysMenuContainer.Name = "SysMenuContainer";
            this.SysMenuContainer.Size = new System.Drawing.Size(185, 672);
            this.SysMenuContainer.TabIndex = 0;
            // 
            // tvNavigator
            // 
            this.tvNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNavigator.FullRowSelect = true;
            this.tvNavigator.HideSelection = false;
            this.tvNavigator.HotTracking = true;
            this.tvNavigator.ImageIndex = 0;
            this.tvNavigator.ImageList = this.imageList2;
            this.tvNavigator.Location = new System.Drawing.Point(0, 0);
            this.tvNavigator.Name = "tvNavigator";
            this.tvNavigator.SelectedImageIndex = 0;
            this.tvNavigator.Size = new System.Drawing.Size(185, 672);
            this.tvNavigator.StateImageList = this.imageList2;
            this.tvNavigator.TabIndex = 0;
            this.tvNavigator.DoubleClick += new System.EventHandler(this.tvNavigator_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            this.ribbonPageGroup11.Text = "Skins";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Skins";
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Closebutton
            // 
            this.Closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebutton.Location = new System.Drawing.Point(993, 747);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(19, 10);
            this.Closebutton.TabIndex = 4;
            this.Closebutton.Text = "退出";
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(-85, 371);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblDepartment,
            this.lblUser,
            this.btnLogOut,
            this.btnChangePassword,
            this.barSubItem1,
            this.iCascade,
            this.iTileHorizontal,
            this.iTileVertical,
            this.biTabbedMDI,
            this.barMdiChildrenListItem2,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 18;
            // 
            // bar1
            // 
            this.bar1.BarName = "系统";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblDepartment),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblUser),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChangePassword, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.bar1.OptionsBar.AllowRename = true;
            this.bar1.Text = "系统";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Caption = "部门:";
            this.lblDepartment.Id = 3;
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblUser
            // 
            this.lblUser.Caption = "用户:";
            this.lblUser.Id = 4;
            this.lblUser.Name = "lblUser";
            this.lblUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "注销";
            this.btnLogOut.Id = 5;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick_1);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "修改密码";
            this.btnChangePassword.Id = 6;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick_1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "锁定";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "窗口";
            this.barSubItem1.Id = 7;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biTabbedMDI),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCascade),
            new DevExpress.XtraBars.LinkPersistInfo(this.iTileHorizontal),
            new DevExpress.XtraBars.LinkPersistInfo(this.iTileVertical),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // biTabbedMDI
            // 
            this.biTabbedMDI.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.biTabbedMDI.Caption = "多页显示";
            this.biTabbedMDI.Down = true;
            this.biTabbedMDI.Id = 15;
            this.biTabbedMDI.Name = "biTabbedMDI";
            this.biTabbedMDI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biTabbedMDI_ItemClick);
            // 
            // iCascade
            // 
            this.iCascade.Caption = "层叠";
            this.iCascade.Id = 12;
            this.iCascade.ImageOptions.ImageIndex = 5;
            this.iCascade.Name = "iCascade";
            this.iCascade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // iTileHorizontal
            // 
            this.iTileHorizontal.Caption = "水平";
            this.iTileHorizontal.Id = 13;
            this.iTileHorizontal.ImageOptions.ImageIndex = 6;
            this.iTileHorizontal.Name = "iTileHorizontal";
            this.iTileHorizontal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // iTileVertical
            // 
            this.iTileVertical.Caption = "垂直";
            this.iTileVertical.Id = 14;
            this.iTileVertical.ImageOptions.ImageIndex = 7;
            this.iTileVertical.Name = "iTileVertical";
            this.iTileVertical.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "列表";
            this.barMdiChildrenListItem2.Id = 16;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1012, 46);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 759);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1012, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 713);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1012, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 713);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            // 
            // FrmMDIX
            // 
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1012, 759);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.dockPlSysMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Enabled = false;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMDIX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "旺达财务信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMDIX_FormClosing);
            this.Load += new System.EventHandler(this.FrmMDIX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerSysBar)).EndInit();
            this.dockPlSysMenu.ResumeLayout(false);
            this.SysMenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManagerSysBar;
        private DevExpress.XtraBars.Docking.DockPanel dockPlSysMenu;
        private DevExpress.XtraBars.Docking.ControlContainer SysMenuContainer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.Utils.ImageCollection imageSmall;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TreeView tvNavigator;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.SimpleButton Closebutton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem lblDepartment;
        private DevExpress.XtraBars.BarStaticItem lblUser;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem biTabbedMDI;
        private DevExpress.XtraBars.BarButtonItem iCascade;
        private DevExpress.XtraBars.BarButtonItem iTileHorizontal;
        private DevExpress.XtraBars.BarButtonItem iTileVertical;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
