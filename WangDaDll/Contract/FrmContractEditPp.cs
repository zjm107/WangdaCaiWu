using DevExpress.Utils.FormShadow;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractEditPp : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 页面状态
        /// </summary>
        public PageStatus FormStatus { get; set; }

        public FrmContractEditPp()
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
        /// <summary>
        /// 注册员
        /// </summary>
        public string Registrar="";
        /// <summary>
        /// 注册员Id
        /// </summary>
        public string RegistrarId="";
        /// <summary>
        /// 做账会计
        /// </summary>
        public string Accountant = "";
        /// <summary>
        /// 做账会计Id
        /// </summary>
        public string AccountantId = "";


        private void FrmContractEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                this.Text = "合同人员变更";
           
            
             
              
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
                SetControlReadOnly();
                if (ck周期性服务.Checked)
                {
                    infoLabelItem1.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else infoLabelItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                if (ck一次性服务.Checked)
                {
                    infoLabelItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }else infoLabelItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;


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
        /// <summary>
        /// 设置页面的控件属性为只读
        /// </summary>
        void SetControlReadOnly()
        {
            签约日期DateEdit.Properties.ReadOnly = true;
            客户名称ButtonEdit.Properties.ReadOnly = true;
            合同金额CalcEdit.ReadOnly = true;
         
            ck一次性服务.Properties.ReadOnly = true;
            ck周期性服务.Properties.ReadOnly = true;
            服务分类ComboBoxEdit.Properties.ReadOnly = true;
            服务类别ComboBoxEdit.Properties.ReadOnly = true;
            服务类型ComboBoxEdit.Properties.ReadOnly = true;
            服务项目ComboBoxEdit.Properties.ReadOnly = true;
            服务金额TextEdit.ReadOnly = true;
            服务期限月TextBox.ReadOnly = true;
            开始服务月DateEdit.Properties.ReadOnly = true;
            结束服务月DateEdit.Properties.ReadOnly = true;
            服务总时长月TextBox.ReadOnly = true;
            赠送时长月TextBox.ReadOnly = true;
            服务分类ComboBoxEdit1.Properties.ReadOnly = true;
            服务类别ComboBoxEdit1.Properties.ReadOnly = true;
            服务类型ComboBoxEdit1.Properties.ReadOnly = true;
            服务项目ComboBoxEdit1.Properties.ReadOnly = true;
            服务金额TextEdit1.ReadOnly = true;
            开票费TextEdit.ReadOnly = true;
            工本费TextEdit.ReadOnly = true;
            定金金额TextEdit.ReadOnly = true;   
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
                //取当前合同行，赋值做账会计和注册员
                this.AccountantId = ContractRow["做账会计ID"].ToString();
                this.Accountant = ContractRow["做账会计"].ToString();
                this.Registrar= ContractRow["注册员"].ToString();
                this.RegistrarId= ContractRow["注册员ID"].ToString();


                bool flowControl = checkInfo();
                if (!flowControl)
                {
                    return;
                }
                splash.ShowWaitForm();
                splash.SetWaitFormCaption("正在保存合同信息...");
                contractDataSet.SaveDataSet();
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
            //验证必填数据,注册会计不能为空
          if (ck周期性服务.Checked)
            {
                if (string.IsNullOrWhiteSpace(做账会计ButtonEdit.Text))
                {
                    MessageBox.Show("请选择做账会计!");
                    return false;
                }
            }

          if (ck一次性服务.Checked)
            {
                if (string.IsNullOrWhiteSpace(注册员ButtonEdit.Text))
                {
                    MessageBox.Show("请选择注册员!");
                    return false;
                }
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
           
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计ButtonEdit.Text = rv["UserName"].ToString();
                ContractRow["做账会计"] = rv["UserName"].ToString();
                ContractRow["做账会计ID"] = rv["UserID"].ToString();
                Accountant= rv["UserName"].ToString();
                AccountantId= rv["UserID"].ToString();
            }
        }
   
      

        private void 注册员ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                注册员ButtonEdit.Text = rv["UserName"].ToString();
                ContractRow["注册员"]= rv["UserName"].ToString();
                ContractRow["注册员ID"] = rv["UserID"].ToString();
                Registrar = rv["UserName"].ToString();
                RegistrarId = rv["UserID"].ToString();
            }
        }
        /// <summary>
        /// 设置做账会计为当前用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAccountant_Click(object sender, EventArgs e)
        {
            做账会计ButtonEdit.Text = Security.UserName;
            ContractRow["做账会计"] = Security.UserName;
            ContractRow["做账会计ID"] = Security.UserID;
            Accountant = Security.UserName;
            AccountantId = Security.UserID;

        }
        /// <summary>
        /// 设置注册员为当前用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetReg_Click(object sender, EventArgs e)
        {
            注册员ButtonEdit.Text = Security.UserName;
            ContractRow["注册员"] = Security.UserName;
            ContractRow["注册员ID"] = Security.UserID;
            Registrar = Security.UserName;
            RegistrarId = Security.UserID;
        }
    }
   
}

