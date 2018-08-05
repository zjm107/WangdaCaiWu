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
using WangDaDll;
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmAccountExamine : DevExpress.XtraEditors.XtraForm
    {
        public FrmAccountExamine()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Security.UserBusiness.Contains("总经理"))
                {
                    businessDataSet.GetBusinessExamineData(做账会计TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, "", cmbPaiDan.Text, "",  是否审批comboBoxEdit.Text);
                }
                else
                if (Security.UserBusiness.Contains("主管"))
                {
                    businessDataSet.GetBusinessExamineData(做账会计TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, Security.DeptName, cmbPaiDan.Text, "", 是否审批comboBoxEdit.Text);
                }
                else
                {
                    businessDataSet.GetBusinessExamineData(Security.UserName, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, "", "", "", 是否审批comboBoxEdit.Text);
                }

                gridView1.UnselectRow(0);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                做账会计TextEdit.Text = "";
                登记日期DateEdit.Text = "";
                登记日期DateEdit1.Text = "";
                公司预核名称TextEdit.Text = "";
                是否审批comboBoxEdit.Text = "";
                注册进度ComboBox.Text = ""; 外勤进度ComboBox.Text = "";
                businessDataSet.TW_BusinessReg.Clear();
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.SaveGridViewLayout(this.gridView1, this.Name);
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

        private void FrmBusinessReg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.RestoreGridViewLayout(this.gridView1, this.Name);
                dstTCONF_WORD.FillComBoBox("注册进度", 注册进度ComboBox);
                dstTCONF_WORD.FillComBoBox("外勤进度", 外勤进度ComboBox);
                DataSet dst = dstTCONF_WORD.GetParaItems("外勤进度进出口");
                if (dst.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dst.Tables[0].Rows)
                    {
                        外勤进度ComboBox.Items.Add(row["GROUPLISTITEM"].ToString());
                    }
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



     

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("确定完成交接么？"))
                {
                    try
                    {
                        int[] rowindexs = gridView1.GetSelectedRows();
                        List<string> rowids = new List<string>();
                        if (rowindexs.Length > 0)
                        {
                            foreach (int rowIndex in rowindexs)
                            {
                                DataRowView selRow = gridView1.GetRow(rowIndex) as DataRowView;
                                rowids.Add(selRow["TW_BusinessRegID"].ToString());
                            }
                            foreach (string regID in rowids)
                            {
                                DataRow row = businessDataSet.TW_BusinessReg.FindByTW_BusinessRegID(regID);
                                row.BeginEdit();
                                row["外勤审批确认"] = true;
                                row["外勤审批完成时间"] = DateTime.Now;
                                row.EndEdit();
                            }
                            //保存数据
                            businessDataSet.SaveTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                FileDataSet dataset = this.fileDataSet;
                string fileType = "档案";


                DataRowView rv = tW_BusinessRegBindingSource.Current as DataRowView;
                if (rv == null)
                    return;
                bool wqSP = false;
                if (!string.IsNullOrEmpty(rv["外勤审批确认"].ToString()))
                { wqSP = bool.Parse(rv["外勤审批确认"].ToString()); }
                if (wqSP)
                {
                    UserMessages.ShowInfoBox("审批完成不能修改文件!");
                    return;
                }

                string clientName = rv["公司预核名称"].ToString();
                string fkID = businessDataSet.GetClientId(clientName);
                if (string.IsNullOrEmpty(fkID))
                {
                    UserMessages.ShowInfoBox("公司名称不存在客户信息中！");
                    return;
                }

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
                        dataset.AddImage(fileByte, fileName, fileType, fkID);
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FileDataSet dataset = this.fileDataSet;
                dataset = this.fileDataSet;
                // fileType = "档案";
                int[] selIndexs = gridView2.GetSelectedRows();

                foreach (int i in selIndexs)
                {
                    DataRowView rv = gridView2.GetRow(i) as DataRowView;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = tW_BusinessRegBindingSource.Current as DataRowView;
                if (rv == null)
                    return;
                bool wqSP = bool.Parse(rv["外勤审批确认"].ToString());
                if (wqSP)
                {
                    UserMessages.ShowInfoBox("审批完成不能修改文件!");
                    return;
                }

                if (tF_FILEBindingSource.Current != null)
                {
                    tF_FILEBindingSource.RemoveCurrent();
                    this.fileDataSet.SaveImage();
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void tW_BusinessRegGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                DataRowView rv = tW_BusinessRegBindingSource.Current as DataRowView;
                if (rv == null)
                    return;
                string clientName = rv["公司预核名称"].ToString();
                string fkID = businessDataSet.GetClientId(clientName);
                if (string.IsNullOrEmpty(fkID))
                {
                    UserMessages.ShowInfoBox("公司名称不存在客户信息中！");
                    return;
                }
                fileDataSet.GetImage(fkID);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
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
    }
}
