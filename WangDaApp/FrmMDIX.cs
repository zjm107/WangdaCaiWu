using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;
using WangDaDll;

namespace WangDaApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmMDIX : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmMDIX()
        {
            InitializeComponent();
         }




        /// <summary>
        /// 加载窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMDIX_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.Enabled = false;
                //new上面引用的命名空间中任何一个实例（寻找作用）

                FrmEmployee frmemployee = new FrmEmployee();
                FrmBusinessReg frmReg = new FrmBusinessReg();
                ReflectionHelper.LoadUrlData();  //加载webservice地址
                LoadForm();
             }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
                this.Enabled = false;
                Application.ExitThread();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
         
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        /// <summary>
        ///加载窗体
        /// </summary>
        private void LoadForm()
        {
          
           
            this.Cursor = Cursors.WaitCursor;
           

            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
            if (frmlogin.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = false;
                Application.ExitThread();
            }
            else
            {
                this.Enabled = true;
                //this.WindowState = FormWindowState.Maximized;
               
            }
           
          
            try
            {
                try
                {
                    //设置窗体布局
                    string strFileName = Application.ExecutablePath.ToUpper() + ".Style";
                  
                }
                catch
                {
                    Console.WriteLine("读取Style文件失败！");
                }
                
                try
                {
                    #region 菜单配置
                    SystemMenu = new MenuTree(this.tvNavigator);


                    if (Security.UserName.ToUpper() == "ADMIN")
                    {
                        SystemMenu.ShowSystemMenu();
                    }
                    else
                    SystemMenu.ShowSystemMenu(Security.UserID);

                    
               

                    lblDepartment.Caption ="部门："+ Security.DeptName;
                    lblUser.Caption ="用户："+ Security.UserName;

                    #endregion
                }
                catch (Exception ex)
                {
                    
                    this.Enabled = false;
                    Application.ExitThread();
                    throw new Exception("菜单配置失败：" + ex.Message);
                }
                //Application.Idle += new EventHandler(Application_Idle);




            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {

                this.Cursor = Cursors.Default;
            }
        }


        /// <summary>
        ///加载窗体
        /// </summary>
        private void LockForm()
        {
            this.Enabled = false;
            
            this.Cursor = Cursors.WaitCursor;
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.cmbUserName.Text = Security.CorporationName;
            frmlogin.cmbUserName.Enabled = false;
            frmlogin.ShowDialog();
            if (frmlogin.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
            {
                this.Enabled = true;
                //this.WindowState = FormWindowState.Maximized;

            }
           
        }

        //void Application_Idle(object sender, EventArgs e)
        //{
        //    try {
        //        if (ActiveMdiChild != null)
        //        {
        //            Form bForm = ActiveMdiChild as Form;
        //            if (bForm!=null)
        //            {
                      
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("刷新窗体出错："+ex.Message);
        //    }
        //}

        /// <summary>
        /// 系统菜单树
        /// </summary>
       
        /// <summary>
        /// 系统菜单树
        /// </summary>
        public MenuTree SystemMenu
        {
            get
            {
                return Tiger.PdrCommon.SysTools.m_SystemMenu;
            }
            set
            {
                Tiger.PdrCommon.SysTools.m_SystemMenu = value;
            }
        }

   

        /// <summary>
        /// 运行窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvNavigator_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                TreeNode node = tvNavigator.SelectedNode;
                if (node != null)
                {

                    string strModleName = node.Text;
                    //if (node.Parent != null)
                    //    strModleName = node.Parent.Text + "@" + node.Text;
                    MenuNode mNode = node as MenuNode;
                    if (!string.IsNullOrEmpty(mNode.ClassName))
                        Tiger.PdrCommon.SysTools.showAppForm(mNode.ClassName, mNode.Text, this);
                }
                else
                {
                    Console.WriteLine("没有选中要显示的窗体！");
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
      
        
        private void FrmMDIX_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!UserMessages.ShowQuestionBox("你确定要退出系统吗？"))
                {
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
                Application.Exit();
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Form frmActiveChild = this.ActiveMdiChild as Form;
                if (frmActiveChild != null)
                {
                    frmActiveChild.Close();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default ;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcon"></param>
        /// <param name="frm"></param>
        public void RestoreGridStyle(Control pcon,Form frm)
        {
            try
            {
                foreach (Control con in pcon.Controls)
                {
                    DevExpress.XtraGrid.GridControl view = con as DevExpress.XtraGrid.GridControl;
                    if (view != null)
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView gview = view.Views[0] as DevExpress.XtraGrid.Views.Grid.GridView;
                        WindDataManager.RestoreDefaltGridViewLayout(gview, frm.Name);
                    }
                    RestoreGridStyle(con,frm);
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        private void btnDefaltStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Form frmActiveChild = this.ActiveMdiChild as Form;
                if (frmActiveChild != null)
                {
                    foreach (Control con in frmActiveChild.Controls)
                    {
                        //if (con.Focused)
                        //{
                        
                            DevExpress.XtraGrid.GridControl view = con as DevExpress.XtraGrid.GridControl;
                            if (view != null)
                            {
                                DevExpress.XtraGrid.Views.Grid.GridView gview = view.Views[0] as DevExpress.XtraGrid.Views.Grid.GridView;
                                WindDataManager.RestoreDefaltGridViewLayout(gview, frmActiveChild.Name);
                            }
                            RestoreGridStyle(con,frmActiveChild);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLock_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                LockForm();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLogOut_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("要注销登录吗？"))
                {
                    foreach (Form frm in this.MdiChildren)
                    {
                        frm.Close();
                    }
                    LoadForm();
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnChangePassword_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                FrmRePassWord frmRePassWord = new FrmRePassWord();
                frmRePassWord.ShowDialog();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LockForm();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        bool IsTabbedMdi { get { return biTabbedMDI.Down; } }

        void InitTabbedMDI()
        {
            xtraTabbedMdiManager1.MdiParent = IsTabbedMdi ? this : null;
            iCascade.Visibility = iTileHorizontal.Visibility = iTileVertical.Visibility = IsTabbedMdi ? BarItemVisibility.Never : BarItemVisibility.Always;
        }

        private void biTabbedMDI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitTabbedMDI();
        }
    }
}