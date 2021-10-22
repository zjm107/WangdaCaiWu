using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmClientQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientQuery()
        {
            InitializeComponent();
        }

        private void FrmClientQuery_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);
                WindDataManager.RestoreGridViewLayout(this.gridView1, this.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            try
            {
                splash.SetWaitFormCaption("请等待");
                splash.SetWaitFormDescription("正在执行查询……");
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower()=="admin")
                {
                    csDataSet.GetClientInfo(客户名称TextEdit.Text, 公司类型ComboBoxEdit.Text
                    , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, 做账会计TextEdit.Text,"");
                }
                else
                {
                    csDataSet.GetClientInfo(客户名称TextEdit.Text, 公司类型ComboBoxEdit.Text
                    , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, Security.UserName,"");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                客户分级ComboBoxEdit.Text = "";
                客户名称TextEdit.Text = "";
                公司性质ComboBoxEdit.Text = "";
                公司类型ComboBoxEdit.Text = "";
                做账会计TextEdit.Text = "";
                csDataSet.TW_Client.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.SaveGridViewLayout(this.gridView1, this.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tF_FILEGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView aGrid = null;
                FileDataSet dataset = this.fileDataSet;
                int[] selIndexs;
                if (tabbedControlGroup1.SelectedTabPageIndex == 1)
                {
                    dataset = this.HTfileDataSet;
                    selIndexs = gridView2.GetSelectedRows();
                    aGrid = gridView2;
                }
                else
                {
                    dataset = this.fileDataSet;
                    selIndexs = gridView3.GetSelectedRows();
                    aGrid = gridView3;

                }
                
                foreach (int i in selIndexs)
                {
                    DataRowView rv = aGrid.GetRow(i) as DataRowView;
                    if (rv != null)
                    {
                        string fileID = rv["FILEID"].ToString();
                        saveFileDialog.DefaultExt = "图片文件 (*.jpg)|*.jpg,*.jpeg";
                        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string fileName = saveFileDialog.FileName;
                            byte[] bfile = dataset.GetImageByID(fileID);
                            File.WriteAllBytes(fileName, bfile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
        /// <summary>
        /// 合同查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tF_FILEGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = this.HTtF_FILEBindingSource.Current as DataRowView;
                string fileID = rv["FileID"].ToString();
                var image = HTfileDataSet.GetImageByID(fileID);
                FrmImageView frmImgView = new FrmImageView();
                frmImgView.ImageBytes = image;
                frmImgView.ShowDialog();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
        /// <summary>
        /// 档案查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tF_FILEGridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = this.tF_FILEBindingSource.Current as DataRowView;
                string fileID = rv["FileID"].ToString();
                var image = fileDataSet.GetImageByID(fileID);
                FrmImageView frmImgView = new FrmImageView();
                frmImgView.ImageBytes = image;
                frmImgView.ShowDialog();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void tW_ClientGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                DataRowView rv = tW_ClientBindingSource.Current as DataRowView;
                if (rv == null)
                    return;
                string fkID = rv["客户名称ID"].ToString();
                if (string.IsNullOrEmpty(fkID))
                {
                    UserMessages.ShowInfoBox("公司名称不存在客户信息中！");
                    return;
                }
                fileDataSet.GetImage(fkID);
                HTfileDataSet.GetImage(fkID, "合同");
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
