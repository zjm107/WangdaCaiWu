using DevExpress.Utils.FormShadow;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractEdit : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 页面状态
        /// </summary>
        public PageStatus FormStatus { get; set; }

        public FrmContractEdit()
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
                周期性服务Group.Enabled = false;
                一次性服务Group.Enabled = false;

                dstTCONF_WORD.FillDevComboBox("服务类别", 服务类别ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务分类", 服务分类ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务类型", 服务类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务项目", 服务项目ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("服务类别", 服务类别ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务分类", 服务分类ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务类型", 服务类型ComboBoxEdit1);
                dstTCONF_WORD.FillDevComboBox("服务项目", 服务项目ComboBoxEdit1);
                string ClientId = "";
                switch (FormStatus)
                {
                    case PageStatus.New:
                        this.Text = "新增合同";
                        ContractRow = contractDataSet.AddTW_ContractRow();
                        //layoutControl1.HideItem(itemPost);
                        layoutControl1.HideItem(itemApproval);
                        layoutControl1.HideItem(itemReject);
                        btnPost.Visible = true;
                        btnApproval.Visible = false;
                        btnReject.Visible = false;
                      
                        break;
                    case PageStatus.Edit:
                        this.Text = "修改合同";
                       // layoutControl1.HideItem(itemPost);
                        layoutControl1.HideItem(itemApproval);
                        layoutControl1.HideItem(itemReject);
                        btnPost.Visible = true;
                        btnApproval.Visible = false;
                        btnReject.Visible = false;
                        contractDataSet.GetContractByID(ContractId);
                        ContractRow = contractDataSet.TW_Contract.Rows[0];
                        fileDataSet.GetFileListByFkId(ContractId); //获取附件列表
                        BindContractServiceInfo();
                        ClientId = ContractRow["客户名称ID"].ToString();
                        ContractNo= ContractRow["合同编号"].ToString();
                        contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);
                        

                        if(!ContractNo.Contains("补贴") && !ContractNo.Contains("变更"))
                        {
                            LastDate = contractDataSetView.GetLastDate();
                            if (LastDate != string.Empty)
                                开始服务月DateEdit.Properties.MinValue = Convert.ToDateTime(LastDate);
                        }

                        
                        break;
                    case PageStatus.View:
                        this.Text = "查看合同";
                        layoutControl1.HideItem(itemPost);
                        layoutControl1.HideItem(itemApproval);
                        layoutControl1.HideItem(itemReject);
                        layoutControl1.HideItem(itemSave);
                        layoutControl1.HideItem(delFilelayoutControlItem3);
                        btnPost.Visible = false;
                        btnApproval.Visible = false;
                        btnReject.Visible = false;
                        btnAdd附件.Enabled = false;
                        btnDel附件.Enabled = false;
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
                        ClientId= ContractRow["客户名称ID"].ToString();
                        contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);
                        break;
                    case PageStatus.Approve:
                        this.Text = "合同审批";
                        layoutControl1.HideItem(itemPost);
                        layoutControl1.HideItem(itemApproval);
                        layoutControl1.HideItem(itemReject);
                        layoutControl1.HideItem(itemSave);
                        btnApproval.Visible = true;
                        btnPost.Visible = false;
                        btnReject.Visible = true;
                        contractDataSet.GetContractByID(ContractId);
                        ContractRow = contractDataSet.TW_Contract.Rows[0];
                        fileDataSet.GetFileListByFkId(ContractId); //获取附件列表
                        BindContractServiceInfo();
                        SetControlReadOnly();
                        ClientId = ContractRow["客户名称ID"].ToString();
                        contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);
                        break;
                    case PageStatus.Assign:
                        this.Text = "指派做账会计";
                        layoutControl1.HideItem(itemPost);
                        layoutControl1.HideItem(itemApproval);
                        layoutControl1.HideItem(itemReject);
                     //   layoutControl1.HideItem(itemSave);
                        layoutControl1.HideItem(delFilelayoutControlItem3);
                        btnAdd附件.Enabled= false;
                        btnDel附件.Enabled = false;
                        btnPost.Visible = false;
                        btnApproval.Visible = false;
                        btnReject.Visible = false;
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
                        ClientId = ContractRow["客户名称ID"].ToString();
                        contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);
                        break;
                    default:
                        break;
                }
                


                //查询合同付款记录
                if (!string.IsNullOrEmpty(ContractId))
                    {
                    proceedsDataSet.GetPaymentMainByContractId(ContractId);
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
        /// 设置页面的控件属性为只读
        /// </summary>
        void SetControlReadOnly()
        {
            签约日期DateEdit.Properties.ReadOnly = true;
            客户名称ButtonEdit.Properties.ReadOnly = true;
            做账会计ButtonEdit.Properties.ReadOnly = true;
            合同金额CalcEdit.ReadOnly = true;
          //  已付款金额TextEdit.ReadOnly = true;
            备注MemoEdit.Properties.ReadOnly = true;
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

        private void ck一次性服务_CheckedChanged(object sender, EventArgs e)
        {
            if (ck一次性服务.Checked)
            {
                一次性服务Group.Enabled = true;
                //添加默认值
                if (string.IsNullOrWhiteSpace(服务类别ComboBoxEdit1.Text))
                    服务类别ComboBoxEdit1.Text = "一次性服务";
                if (string.IsNullOrWhiteSpace(服务分类ComboBoxEdit1.Text))
                    服务分类ComboBoxEdit1.Text = "财税";
                if (string.IsNullOrWhiteSpace(服务类型ComboBoxEdit1.Text))
                    服务类型ComboBoxEdit1.Text = "工商-注册";
                if (string.IsNullOrWhiteSpace(服务项目ComboBoxEdit1.Text))
                    服务项目ComboBoxEdit1.Text = "注册公司";


            }
            else
            {
                一次性服务Group.Enabled = false;
            }
        }

        private void ck周期性服务_CheckedChanged(object sender, EventArgs e)
        {
            if (ck周期性服务.Checked)
            {
                周期性服务Group.Enabled = true;
                //添加默认值,如果Text有值，不赋值
                if (string.IsNullOrWhiteSpace(服务类别ComboBoxEdit.Text))
                    服务类别ComboBoxEdit.Text = "周期性服务";
                if (string.IsNullOrWhiteSpace(服务分类ComboBoxEdit.Text))
                    服务分类ComboBoxEdit.Text = "财税";
                if (string.IsNullOrWhiteSpace(服务类型ComboBoxEdit.Text))
                    服务类型ComboBoxEdit.Text = "代理记账";
                if (string.IsNullOrWhiteSpace(服务项目ComboBoxEdit.Text))
                    服务项目ComboBoxEdit.Text = "代理记账";
                if (string.IsNullOrWhiteSpace(服务金额TextEdit.Text))
                    服务金额TextEdit.Text = "0";
                //服务期限月下个月的1号开始
                if (string.IsNullOrWhiteSpace(服务期限月TextBox.Text))
                    开始服务月DateEdit.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1);
                if (string.IsNullOrWhiteSpace(服务期限月TextBox.Text))
                    服务期限月TextBox.Text = "12";
                if (string.IsNullOrWhiteSpace(赠送时长月TextBox.Text))
                    赠送时长月TextBox.Text = "0";
                if (string.IsNullOrWhiteSpace(服务总时长月TextBox.Text))
                    服务总时长月TextBox.Text = "12";
                //周期是12个月，到最后一个月的31号
                if (!string.IsNullOrWhiteSpace(开始服务月DateEdit.Text))
                {
                    DateTime endDate = 开始服务月DateEdit.DateTime.AddMonths(12).AddDays(-1);
                    结束服务月DateEdit.DateTime = endDate;
                }
                    
            }
            else
            {
                周期性服务Group.Enabled = false;

            }
        }
        /// <summary>
        /// 合同审批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApproval_Click(object sender, EventArgs e)
        {
            try
            {
                //审批通过，更新合同状态为已审批
                if (MessageBox.Show("确认审批通过？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("正在保存合同信息...");

                    ContractRow["审批状态"] = "已审批";
                    tW_ContractBindingSource.EndEdit();
                    contractDataSet.SaveDataSet();
                    this.DialogResult = DialogResult.OK;
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

            }

        }
        /// <summary>
        /// 驳回合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                //审批通过，更新合同状态为已审批
                if (MessageBox.Show("确认驳回该合同？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("正在保存合同信息...");
                    ContractRow["审批状态"] = "已驳回";
                    tW_ContractBindingSource.EndEdit();
                    contractDataSet.SaveDataSet();
                    this.DialogResult = DialogResult.OK;
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
            }

        }
        /// <summary>
        /// 服务总时长月=服务期限月+赠送时长月
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 服务期限月TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;
            int 服务期限月 = 0;
            int 赠送时长月 = 0;
            int.TryParse(服务期限月TextBox.Text.Trim(), out 服务期限月);
            int.TryParse(赠送时长月TextBox.Text.Trim(), out 赠送时长月);
            服务总时长月TextBox.Text = (服务期限月 + 赠送时长月).ToString();
            if (服务期限月 > 0)
            {
                DateTime endDate = 开始服务月DateEdit.DateTime.AddMonths(服务期限月 + 赠送时长月);
                endDate =new DateTime(endDate.Year, endDate.Month, 1).AddDays(-1);
                结束服务月DateEdit.DateTime = endDate;
                CalPrice();
            }
            
        }

        private void 赠送时长月TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;
            int 服务期限月 = 0;
            int 赠送时长月 = 0;
            int.TryParse(服务期限月TextBox.Text.Trim(), out 服务期限月);
            int.TryParse(赠送时长月TextBox.Text.Trim(), out 赠送时长月);
            服务总时长月TextBox.Text = (服务期限月 + 赠送时长月).ToString();
            if (服务期限月 > 0)
            {
                DateTime endDate = 开始服务月DateEdit.DateTime.AddMonths(服务期限月 + 赠送时长月);
                endDate = new DateTime(endDate.Year, endDate.Month, 1).AddDays(-1);
                结束服务月DateEdit.DateTime = endDate;
            }

        }

        private void 开始服务月DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;
            int 服务期限月 = 0;
            int 赠送时长月 = 0;
            int.TryParse(服务期限月TextBox.Text.Trim(), out 服务期限月);
            int.TryParse(赠送时长月TextBox.Text.Trim(), out 赠送时长月);
            服务总时长月TextBox.Text = (服务期限月 + 赠送时长月).ToString();
            if (服务期限月 > 0)
            {
                DateTime endDate = 开始服务月DateEdit.DateTime.AddMonths(服务期限月 + 赠送时长月);
                endDate = new DateTime(endDate.Year, endDate.Month, 1).AddDays(-1);
                结束服务月DateEdit.DateTime = endDate;
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
                splash.SetWaitFormCaption("正在保存合同信息...");
                AddOrEditServiceRow();
                if (ck一次性服务.Checked != true)
                {
                    var rows = contractDataSet.TW_ContractServiceInfo.Select($"ContractID='{ContractId}' and 服务类别='一次性服务'");
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                    }
                   
                }
                contractDataSet.SaveDataSet();
                fileDataSet.SaveFileInfo();
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

        private void AddOrEditServiceRow()
        {
            //添加服务记录TW_ContractServiceInfo
            if (ck周期性服务.Checked)
            {
                decimal 服务金额 = 0;
                decimal 服务期限月 = 0;
                DateTime 开始服务月;
                DateTime 结束服务月;

                开始服务月 = 开始服务月DateEdit.DateTime;
                结束服务月 = 结束服务月DateEdit.DateTime;
                decimal 服务总时长月 = 0;
                decimal 赠送时长月 = 0;
                decimal.TryParse(服务金额TextEdit.Text.Trim(), out 服务金额);
                decimal.TryParse(服务期限月TextBox.Text.Trim(), out 服务期限月);
                decimal.TryParse(服务总时长月TextBox.Text.Trim(), out 服务总时长月);
                decimal.TryParse(赠送时长月TextBox.Text.Trim(), out 赠送时长月);

                contractDataSet.AddTW_ContractServiceInfoRow(contractDataSet.TW_Contract[0].ContractID, contractDataSet.TW_Contract[0].客户名称ID,
                    服务分类ComboBoxEdit.Text.Trim(), 服务类别ComboBoxEdit.Text.Trim(), 服务类型ComboBoxEdit.Text.Trim(), 服务项目ComboBoxEdit.Text.Trim(),
                    服务金额, 服务期限月, 开始服务月, 结束服务月, 服务总时长月, 赠送时长月);
            }
            if (ck一次性服务.Checked)
            {
                decimal 服务金额 = 0;

                decimal.TryParse(服务金额TextEdit1.Text.Trim(), out 服务金额);

                contractDataSet.AddTW_ContractServiceInfoRow(contractDataSet.TW_Contract[0].ContractID, contractDataSet.TW_Contract[0].客户名称ID,
                    服务分类ComboBoxEdit1.Text.Trim(), 服务类别ComboBoxEdit1.Text.Trim(), 服务类型ComboBoxEdit1.Text.Trim(), 服务项目ComboBoxEdit1.Text.Trim(),
                    服务金额);
            }
        }

        private bool checkInfo()
        {
            //验证必填数据
            if (客户名称ButtonEdit.EditValue == null || string.IsNullOrWhiteSpace(客户名称ButtonEdit.Text))
            {
                MessageBox.Show("请填写客户名称");
                return false;
            }
            if (签约日期DateEdit.EditValue == null || string.IsNullOrWhiteSpace(签约日期DateEdit.Text))
            {
                MessageBox.Show("请填写签约日期");
                return false;
            }
            //验证合同金额,必须大于0
            //decimal contractAmount = 0;
            //decimal.TryParse(合同金额CalcEdit.Text.Trim(), out contractAmount);
            //if (contractAmount <= 0)
            //{
            //    MessageBox.Show("合同金额必须大于0");
            //    return false;
            //}
            //已付款金额必须大于等于0  
            //decimal paidAmount = 0;
            //decimal.TryParse(已付款金额TextEdit.Text.Trim(), out paidAmount);
            //if (paidAmount < 0)
            //{
            //    MessageBox.Show("已付款金额必须大于等于0");
            //    return false;
            //}

            return true;
        }


        /// <summary>
        /// 弹出选择客户对话框，然后赋值客户相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 客户名称ButtonEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            using (FrmClientSelectDlg frm = new FrmClientSelectDlg())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var dst = frm.selCsDataSet;
                    var row = dst.TW_Client.Rows[0];
                    客户名称ButtonEdit.EditValue = row["客户名称"].ToString();
                    客户名称ButtonEdit.Text = row["客户名称"].ToString();
                    //如果做账会计不是空，赋值做账会计
                    if (row["做账会计"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["做账会计"].ToString()))
                    {
                        做账会计ButtonEdit.EditValue = row["做账会计"].ToString();
                        做账会计ButtonEdit.Text = row["做账会计"].ToString();
                    }
                    ContractRow["客户名称ID"] = row["客户名称ID"];
                    ContractRow["客户名称"] = row["客户名称"];
                    ContractRow["做账会计"] = row["做账会计"];
                    ContractRow["做账会计ID"] = row["做账会计ID"];
                    ContractRow["注册员"]= row["注册员"];
                    ContractRow["注册员ID"] = row["注册员ID"];
                    ContractRow["客户来源"] = row["客户来源"];
                    ContractRow["纳税性质"] = row["纳税性质"];
                    ContractRow["公司性质"] = row["公司性质"];
                    ContractRow["所属行业"] = row["所属行业"];
                    ContractRow["注册资金万元"] = row["注册资金万元"];
                    ContractRow["法人"] = row["法人"];
                    ContractRow["联系方式"] = row["单位联系方式"];//普通联系方式
                    ContractRow["身份证号"] = row["身份证号"];
                    ContractRow["生日"] = row["出生日期"];
                    ContractRow["联系人"] = row["客户姓名"];
                    ContractRow["联系人联系方式"] = row["联系电话"]; //联系人联系方式
                   // ContractRow["职位"] = row["职位"];
                    ContractRow["成立时间"] = row["成立时间"];
                    ContractRow["所属区域"] = row["所属区域"];
                    ContractRow["详细地址"] = row["公司地址"];
                    string ClientId = ContractRow["客户名称ID"].ToString();

                    contractDataSetView.GetContractInfoByClientId(ClientId, ContractId);
                    //获取该客户最后一次服务结束日期，赋值开始服务月的最小值
                    LastDate = contractDataSetView.GetLastDate();
                    if (!string.IsNullOrEmpty( LastDate))
                        开始服务月DateEdit.Properties.MinValue = Convert.ToDateTime(LastDate);

                    //如果开始服务月和结束服务月为空，赋值开始服务月为最后一次服务结束日期的下个月1号，
                    //结束服务月为下一个年的最后一次服务结束日期的月份和日期
                    if (string.IsNullOrWhiteSpace( 结束服务月DateEdit.Text)&& string.IsNullOrWhiteSpace(开始服务月DateEdit.Text) && !string.IsNullOrEmpty(LastDate))
                    {
                        DateTime endDate = Convert.ToDateTime(LastDate);
                        结束服务月DateEdit.DateTime = new DateTime(DateTime.Today.Year + 1, endDate.Month, endDate.Day);
                        开始服务月DateEdit.DateTime = new DateTime(DateTime.Today.Year, endDate.AddMonths(1).Month, 1);
                    }
                    //如果合同金额Edit大于0，赋值合同金额
                    if (合同金额CalcEdit.Value>0)
                    {
                        ContractRow["合同金额"] = 合同金额CalcEdit.Value;
                    }




                    ContractRow.EndEdit();

                }
            }
        }
        /// <summary>
        /// 提交合同，审批状态为待审批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPost_Click(object sender, EventArgs e)
        {
            try { 
            tW_ContractBindingSource.EndEdit();
            bool flowControl = checkInfo();
            if (!flowControl)
            {
                return;
            }
                if (ck一次性服务.Checked != true)
                {
                    var rows = contractDataSet.TW_ContractServiceInfo.Select($"ContractID='{ContractId}' and 服务类别='一次性服务'");
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                    }
                }
                splash.ShowWaitForm();
            splash.SetWaitFormCaption("正在保存合同信息...");

            AddOrEditServiceRow();
            if (MessageBox.Show("确认提交合同？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ContractRow["审批状态"] = "待审批";
                tW_ContractBindingSource.EndEdit();
                contractDataSet.SaveDataSet();
                this.DialogResult = DialogResult.OK;
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
            }

        }
        /// <summary>
        /// 合同金额 = 服务金额*服务期限月+服务金额1+开票费+工本费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 服务金额TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalPrice();
        }
        /// <summary>
        /// 计算合同金额，合同金额 = 服务金额*服务期限月+服务金额1+开票费+工本费
        /// </summary>
        private void CalPrice()
        {
            if(isFirstLoad) return;

            decimal 服务金额 = 0;
            decimal 服务期限月 = 0;
            decimal 服务金额1 = 0;
            decimal 开票费 = 0;
            decimal 工本费 = 0;
            decimal 补充金额 = 0;
            decimal.TryParse(服务金额TextEdit.Text.Trim(), out 服务金额);
            decimal.TryParse(服务期限月TextBox.Text.Trim(), out 服务期限月);
            decimal.TryParse(服务金额TextEdit1.Text.Trim(), out 服务金额1);
            decimal.TryParse(开票费TextEdit.Text.Trim(), out 开票费);
            decimal.TryParse(工本费TextEdit.Text.Trim(), out 工本费);
            decimal.TryParse(补充金额textEdit.Text.Trim(), out 补充金额);

            合同金额CalcEdit.Value = 服务金额 * 服务期限月 + 服务金额1 + 开票费 + 工本费+补充金额;
        }

        private void 工本费TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalPrice();

        }

        private void 开票费TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalPrice();
        }

        private void 服务金额TextEdit1_EditValueChanged(object sender, EventArgs e)
        {
            CalPrice();
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
        /// 弹出文件选择对话框，选择文件，添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd附件_Click(object sender, EventArgs e)
        {
            try
            {
                //保存合同信息
                contractDataSet.SaveDataSet();
                //弹出文件选择对话框，选择文件，添加文件
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    splash.ShowWaitForm();
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        string fileType = System.IO.Path.GetExtension(fileName);
                        byte[] filebyte = System.IO.File.ReadAllBytes(fileName);
                        string fkID = ContractRow["ContractID"].ToString();
                        //添加文件到附件列表
                        //TODO
                        fileDataSet.AddFile(filebyte, fileName, fileType, fkID);
                    }
                }
            }catch(Exception ex)
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
        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel附件_Click(object sender, EventArgs e)
        {
            try
            {
                var row = fileDataSet.TF_FILE.Rows[gridView1.FocusedRowHandle];
                if (row != null)
                {
                    if (MessageBox.Show("确认删除该附件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        row.Delete();
                        fileDataSet.SaveFile();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// <summary>
        /// 添加一个新客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewClient_Click(object sender, EventArgs e)
        {
           
        }

        private void 补充金额textEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalPrice();
        }

    }
    /// <summary>
    /// 页面状态:添加，编辑，待审批,查看,指派
    /// </summary>
    public enum PageStatus
    {
        New,
        Edit,
        Approve,
        View,
        Assign
    }
}

