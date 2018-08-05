using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using Tiger.PdrCommon;
using Tiger.Tools;
using DevExpress.XtraBars;
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
        /// ���ش����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMDIX_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.Enabled = false;
                //new�������õ������ռ����κ�һ��ʵ����Ѱ�����ã�

                FrmEmployee frmemployee = new FrmEmployee();
                FrmBusinessReg frmReg = new FrmBusinessReg();
                ReflectionHelper.LoadUrlData();  //����webservice��ַ
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
        /// �ر�
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
        /// �˳�ϵͳ
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
        ///���ش���
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
                    //���ô��岼��
                    string strFileName = Application.ExecutablePath.ToUpper() + ".Style";
                  
                }
                catch
                {
                    Console.WriteLine("��ȡStyle�ļ�ʧ�ܣ�");
                }
                
                try
                {
                    #region �˵�����
                    SystemMenu = new MenuTree(this.tvNavigator);


                    if (Security.UserName.ToUpper() == "ADMIN")
                    {
                        SystemMenu.ShowSystemMenu();
                    }
                    else
                    SystemMenu.ShowSystemMenu(Security.UserID);

                    
               

                    lblDepartment.Caption ="���ţ�"+ Security.DeptName;
                    lblUser.Caption ="�û���"+ Security.UserName;

                    #endregion
                }
                catch (Exception ex)
                {
                    
                    this.Enabled = false;
                    Application.ExitThread();
                    throw new Exception("�˵�����ʧ�ܣ�" + ex.Message);
                }
                Application.Idle += new EventHandler(Application_Idle);




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
        ///���ش���
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

        void Application_Idle(object sender, EventArgs e)
        {
            try {
                if (ActiveMdiChild != null)
                {
                    Form bForm = ActiveMdiChild as Form;
                    if (bForm!=null)
                    {
                      
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ˢ�´������"+ex.Message);
            }
        }

        /// <summary>
        /// ϵͳ�˵���
        /// </summary>
       
        /// <summary>
        /// ϵͳ�˵���
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
        /// ���д���
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
                    Console.WriteLine("û��ѡ��Ҫ��ʾ�Ĵ��壡");
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
                if (!UserMessages.ShowQuestionBox("��ȷ��Ҫ�˳�ϵͳ��"))
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
                if (UserMessages.ShowQuestionBox("Ҫע����¼��"))
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