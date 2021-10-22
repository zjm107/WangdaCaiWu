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
    public partial class FrmClientManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientManager()
        {
            InitializeComponent();
        }

        private void FrmClientManager_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);

                WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
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
                    , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, 做账会计TextEdit.Text,客户状态ComboBoxEdit.Text);
                }
                else
                {
                    csDataSet.GetClientInfo(客户名称TextEdit.Text, 公司类型ComboBoxEdit.Text
                    , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, Security.UserName, 客户状态ComboBoxEdit.Text);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataRowView newRow = tW_ClientBindingSource.AddNew() as DataRowView;
                newRow["客户名称ID"] = Guid.NewGuid().ToString();
                newRow["修改时间"] = DateTime.Now;
                newRow["修改人"] = Tiger.Tools.Security.UserName;
                tW_ClientBindingSource.EndEdit();
                int position = tW_ClientBindingSource.Find("客户名称ID", newRow["客户名称ID"].ToString());
                tW_ClientBindingSource.Position = position;
                FrmClientEdit frmEdit = new FrmClientEdit();
                frmEdit.csDataSet = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataSource = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataMember = "TW_Client";
                frmEdit.tW_ClientBindingSource.Position = position;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    this.tW_ClientBindingSource.EndEdit();

                    csDataSet.SaveData();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Tiger.Tools.UserMessages.ShowQuestionBox("确定要删除记录么?"))
                {
                    tW_ClientBindingSource.RemoveCurrent();
                    csDataSet.SaveData();
                }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                int position = tW_ClientBindingSource.Position;
                FrmClientEdit frmEdit = new FrmClientEdit();
                frmEdit.csDataSet = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataSource = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataMember = "TW_Client";
                frmEdit.tW_ClientBindingSource.Position = position;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    this.tW_ClientBindingSource.EndEdit();
                    csDataSet.SaveData();
                    csDataSet.UpdateYWY();

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
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
                WindDataManager.SaveGridViewLayout(gridView1, this.Name);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                DevExpress.XtraGrid.Views.Grid.GridView aGrid = null;
                FileDataSet dataset = this.fileDataSet;
               // string fileType = "档案";
                int[] selIndexs;
                if (tabbedControlGroup1.SelectedTabPageIndex == 1)
                {
                   // fileType = "合同";
                    dataset = this.HTfileDataSet;
                    selIndexs = gridView3.GetSelectedRows();
                    aGrid = gridView3;
                }
                else
                {
                    dataset = this.fileDataSet;
                   // fileType = "档案";
                    selIndexs = gridView2.GetSelectedRows();
                    aGrid = gridView2;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                FileDataSet dataset = this.fileDataSet;
                string fileType = "档案";
                if (tabbedControlGroup1.SelectedTabPageIndex == 1)
                {
                    fileType = "合同";
                    dataset = this.HTfileDataSet;
                }
                else
                {
                    dataset = this.fileDataSet;
                    fileType = "档案";
                }
                DataRowView rv = tW_ClientBindingSource.Current as DataRowView;
                if (rv == null)
                    return;
                string fkID = rv["客户名称ID"].ToString();
                openFileDialog.DefaultExt = "图片文件 (*.jpg)|*.jpg;*.jpeg;*.png";
                openFileDialog.Filter = "图片文件 (*.jpg)|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string[] fileNames = openFileDialog.FileNames;
                    splash.ShowWaitForm();
                    foreach (string fileName in fileNames)
                    {
                        this.splash.SetWaitFormCaption("上传文件");
                        this.splash.SetWaitFormDescription("正在上传文件…");
                        FileStream fileStream = new FileStream(fileName, FileMode.Open);
                        fileStream.Seek(0, SeekOrigin.Begin);
                        Byte[] fileByte = new Byte[(int)fileStream.Length]; //转换字节流
                        fileStream.Read(fileByte, 0, fileByte.Length);
                        dataset.AddImage(fileByte, fileName, fileType,fkID);
                        dataset.SaveImage();
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }

        }

        private void btnDelFJ_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (tabbedControlGroup1.SelectedTabPageIndex == 1)
                {

                    if (HTtF_FILEBindingSource.Current != null)
                    {
                        HTtF_FILEBindingSource.RemoveCurrent();
                        this.HTfileDataSet.SaveImage();
                    }
                }
                else
                {
                    if (tF_FILEBindingSource.Current!=null )
                    {
                        tF_FILEBindingSource.RemoveCurrent();
                        this.fileDataSet.SaveImage();
                    }
                    
                }
               
                
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void tF_FILEGridControl_DoubleClick(object sender, EventArgs e)
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

        private void tF_FILEGridControl1_DoubleClick(object sender, EventArgs e)
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
                HTfileDataSet.GetImage(fkID,"合同");

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void btntb_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            try
            {
                splash.SetWaitFormCaption("请等待");
                splash.SetWaitFormDescription("正在执行客户信息同步……");

                csDataSet.UpdateClient();
                csDataSet.UpdateYWY();
                 
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
    }
}
