using DevExpress.Utils.FormShadow;
using DevExpress.XtraRichEdit.Fields;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractAssign : DevExpress.XtraEditors.XtraForm
    {
     

        public FrmContractAssign()
        {
            InitializeComponent();

        }
        public void AddContractRow()
        {

        }
        /// <summary>
        /// 合同Id
        /// </summary>
        public string ContractId
        {
            get;
            set;
        }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNo
        {
            get;
            set;
        }
        /// <summary>
        /// 当前合同行
        /// </summary>
        public DataRow ContractRow
        {
            get;
           
            set;
        }
        bool isFirstLoad = false;
        /// <summary>
        /// 最后一次服务结束日期，结束服务月
        /// </summary>
        string LastDate = string.Empty;
        private void FrmContractEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            isFirstLoad = true;
            try
            {


                dstTCONF_WORD.FillDevComboBox("服务类别", 服务类别ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务分类", 服务分类ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务类型", 服务类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务项目", 服务项目ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务类别", 服务类别ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务分类", 服务分类ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务类型", 服务类型ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务项目", 服务项目ComboBoxEdit1);
                string ClientId = "";
                this.Text = "指派做账会计";


                if (!string.IsNullOrWhiteSpace(ContractId))
                {
                    contractDataSet.GetContractByID(ContractId);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(ContractNo))
                    {
                        contractDataSet.GetContractByNo(ContractNo);
                        if (contractDataSet.TW_Contract.Rows.Count > 0)
                        {
                            ContractId = contractDataSet.TW_Contract.Rows[0]["ContractID"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("未找到合同信息");
                            this.Close();
                            return;
                        }
                    }
                }
                ContractRow = contractDataSet.TW_Contract.Rows[0];
                BindContractServiceInfo();
                fileDataSet.GetFileListByFkId(ContractId); //获取附件列表

                ClientId = ContractRow["客户名称ID"].ToString();
                contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);



                //查询合同付款记录
                if (!string.IsNullOrEmpty(ContractId))
                {
                    proceedsDataSet.GetPaymentMainByContractId(ContractId);
                }
                if (contractDataSet.TW_ContractServiceInfo.Rows.Count > 0)
                {
                    DataRow dataRow = contractDataSet.TW_ContractServiceInfo.Rows[0];

                    起始月dateEdit.Properties.MinDate = dataRow["开始服务月"].ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataRow["开始服务月"]);
                    起始月dateEdit.Properties.MaxDate = dataRow["结束服务月"].ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataRow["结束服务月"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                isFirstLoad = false;
                this.Cursor = Cursors.Default;
            }
        }
       

        /// <summary>
        /// 根据合同服务信息TW_ContractServiceInfo赋值控件
        /// </summary>
        private void BindContractServiceInfo()
        {
            var ContractServiceInfoRows = contractDataSet.TW_ContractServiceInfo.Select($"ContractID='{ContractId}' and 服务类别='周期性服务'");
            if (ContractServiceInfoRows.Length > 0)
            {
                ck周期性服务.Checked = true;
                服务分类ComboBoxEdit.Text = ContractServiceInfoRows[0]["服务分类"].ToString();
                服务类别ComboBoxEdit.Text = ContractServiceInfoRows[0]["服务类别"].ToString();
                服务类型ComboBoxEdit.Text = ContractServiceInfoRows[0]["服务类型"].ToString();
                服务项目ComboBoxEdit.Text = ContractServiceInfoRows[0]["服务项目"].ToString();
                服务金额TextEdit.Text = ContractServiceInfoRows[0]["服务金额"].ToString();
                服务期限月TextBox.Text = ContractServiceInfoRows[0]["服务期限月"].ToString();
                开始服务月DateEdit.DateTime = Convert.ToDateTime(ContractServiceInfoRows[0]["开始服务月"]);
                结束服务月DateEdit.DateTime = Convert.ToDateTime(ContractServiceInfoRows[0]["结束服务月"]);
                服务总时长月TextBox.Text = ContractServiceInfoRows[0]["服务总时长月"].ToString();
                赠送时长月TextBox.Text = ContractServiceInfoRows[0]["赠送时长月"].ToString();
            }
            else
            {
                //如果没有周期性服务记录，那么提示用户没有找到记录，关闭窗口
                UserMessages.ShowInfoBox( "未找到周期性服务的合同服务信息记录，无法进行指派操作！");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
                var ContractServiceInfoRows1 = contractDataSet.TW_ContractServiceInfo.Select($"ContractID='{ContractId}' and 服务类别='一次性服务'");
            if (ContractServiceInfoRows1.Length > 0)
            {
                ck一次性服务.Checked = true;
                服务分类ComboBoxEdit1.Text = ContractServiceInfoRows1[0]["服务分类"].ToString();
                服务类别ComboBoxEdit1.Text = ContractServiceInfoRows1[0]["服务类别"].ToString();
                服务类型ComboBoxEdit1.Text = ContractServiceInfoRows1[0]["服务类型"].ToString();
                服务项目ComboBoxEdit1.Text = ContractServiceInfoRows1[0]["服务项目"].ToString();
                服务金额TextEdit1.Text = ContractServiceInfoRows1[0]["服务金额"].ToString();
            }
        }

      
      

        /// <summary>
        /// 保存合同信息TW_Contract，TW_ContractServiceInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tW_ContractBindingSource.EndEdit();
                bool flowControl = checkInfo();
                if (!flowControl)
                {
                    return;
                }
                splash.ShowWaitForm();
                splash.SetWaitFormCaption("正在指派新的会计...");
              
                contractDataSet.SaveDataSet();

                //同步修改收款记录明细的做账会计和做账会计ID
                string startDate = 起始月dateEdit.DateTime.ToString("yyyy-MM")+"-1";
                string accountName = 做账会计ButtonEdit.Text;
                string accountId = ContractRow["做账会计ID"].ToString();
                string contractNo = ContractRow["合同编号"].ToString();
                string clientId= ContractRow["客户名称ID"].ToString();
                contractDataSet.UpdatePaymentAccount(startDate, accountName, accountId, contractNo, clientId);

                this.DialogResult = DialogResult.OK;
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
            }
        }

        private bool checkInfo()
        {
            //做账会计不能为空
            if (string.IsNullOrWhiteSpace(做账会计ButtonEdit.Text))
            {
                MessageBox.Show("请指派做账会计！");
                return false;
            }
            
            //起始月不能为空
            if (string.IsNullOrWhiteSpace( 起始月dateEdit.Text))
            {
                MessageBox.Show("请选择起始服务月！");
                return false;
            }
            //起始月不能小于开始服务月DateEdit
           if ( 起始月dateEdit.DateTime< 开始服务月DateEdit.DateTime )
            {
                MessageBox.Show("起始月不能小于开始服务月！");
                return false;
            }
            //起始月不能大于结束服务月
            if (起始月dateEdit.DateTime > 结束服务月DateEdit.DateTime)
            {
                MessageBox.Show("起始月不能大于结束服务月！");
                return false;
            }

            return true;
        }


       

        /// <summary>
        /// 选择用户信息
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();

        /// <summary>
        /// 选择做帐会计，赋值当前合同行的做帐会计和做账会计ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 做账会计ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.tW_ContractBindingSource.EndEdit();
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计ButtonEdit.Text = rv["UserName"].ToString();
                ContractRow.BeginEdit();
                ContractRow["做账会计ID"] = rv["UserID"].ToString();
                ContractRow["做账会计"] = rv["UserName"].ToString();
                ContractRow.EndEdit();
            }
        }
        
        /// <summary>
        /// 下载附件，打开附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView附件_Click(object sender, EventArgs e)
        {

            var row = fileDataSet.TF_FILE.Rows[gridView1.FocusedRowHandle];
            if (row != null)
            {
                string fileName = row["FileName"].ToString();
                string fileId = row["FileID"].ToString();
                byte[] filebyte = fileDataSet.GetFileByID(fileId);
                 string tempPath = System.IO.Path.GetTempPath();
                string fullPath = System.IO.Path.Combine(tempPath, fileName);
                System.IO.File.WriteAllBytes(fullPath, filebyte);
                System.Diagnostics.Process.Start(fullPath);
            }
        }

        private void 注册员ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            tW_ContractBindingSource.EndEdit();
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                注册员ButtonEdit.Text = rv["UserName"].ToString();
                ContractRow["注册员ID"] = rv["UserID"].ToString();
            }
        }
    }
    /// <summary>
    /// 页面状态:添加，编辑，待审批,查看,指派
    /// </summary>
   
}

