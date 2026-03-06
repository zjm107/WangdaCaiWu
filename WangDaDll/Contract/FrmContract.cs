using System;
using System.Data;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContract : DevExpress.XtraEditors.XtraForm
    {
        public FrmContract()
        {
            InitializeComponent();

        }

       /// <summary>
       /// 根据查询条件查询合同信息
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            // this.Cursor = Cursors.WaitCursor;
            if (!splash.IsSplashFormVisible)
                splash.ShowWaitForm(); 
            try
            {
                // 假设界面有如下控件用于输入查询条件
                string clientName = 公司名称Text.Text.Trim();
                string accountant = 做账会计Text.Text.Trim();
                int endMonth = int.Parse(合同到期月spinEdit.Text);
                string spState = 审批状态comboBoxEdit.Text.Trim();
                string unpaidAmount = 未付款金额comboBoxEdit.Text.Trim(); 
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
                {
                    // 调用contractDataSet1的查询方法
                    contractDataSet1.GetContract(clientName, accountant, endMonth, unpaidAmount, spState);
                }
                else
                {
                    // 普通用户只能查询自己的合同
                    contractDataSet1.GetContract(clientName, Security.UserName,  endMonth, unpaidAmount, spState);
                }
               

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
             //   this.Cursor = Cursors.Default;
            }
        }


        /// <summary>
        /// 清楚界面输入条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                公司名称Text.Text = "";
                做账会计Text.Text = "";
                合同到期月spinEdit.Text = "";
                审批状态comboBoxEdit.Text = "";
                未付款金额comboBoxEdit.Text = "";
                contractDataSet1.TW_Contract.Clear();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmContractEdit frmContractEdit = new FrmContractEdit())
                {
                    frmContractEdit.FormStatus = PageStatus.New;
                    //如果对话框OK，刷新查询
                    if (frmContractEdit.ShowDialog() == DialogResult.OK)
                    {
                        btnQuery_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {

            }
        }


        private void FrmContract_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
             
                WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
                {
                    做账会计Text.Enabled = true;
                }
                else
                {
                    做账会计Text.Text = Security.UserName;
                    做账会计Text.Enabled = false;
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
       

        /// <summary>
        /// 选择用户信息
        /// </summary>
        FrmClientSelectDlg frmclientDlg = new FrmClientSelectDlg();
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();



        private void 公司名称Text_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmclientDlg.ShowDialog() == DialogResult.OK)
            {
                
                var dst = frmclientDlg.selCsDataSet;
                var row = dst.TW_Client.Rows[0];

                公司名称Text.Text = row["客户名称"].ToString();
            }
        }

        /// <summary>
        /// 删除合同，允许删除未提交的合同，已驳回的合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string spState = dr["审批状态"].ToString();
                if (spState != "未提交" && spState != "已驳回")
                {
                    UserMessages.ShowInfoBox("只能删除未提交或已驳回的合同");
                    return;
                }
                if (UserMessages.ShowQuestionBox("确认删除该合同吗？"))
                {
                    splash.ShowWaitForm();
                    contractDataSet1.DeleteTW_ContractRow(contractId); //删除合同
                    contractDataSet1.SaveDataSet();
                    fileDataSet.DeleteFile(contractId); //删除合同相关的附件
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
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
        /// 合同变更，对选中合同行进行变更操作，合同的审批状态必须是已审批合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContractChanged_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0)
                {
                    UserMessages.ShowInfoBox("请先选择一条合同记录！");
                    return;
                }
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string spState = dr["审批状态"].ToString();
                string contractNo = dr["合同编号"].ToString();
                if (spState != "已审批")
                {
                    UserMessages.ShowInfoBox("只能对已审批的合同进行变更操作！");
                    return;
                }
                using (FrmContractChangedEdit frmContractChanged = new FrmContractChangedEdit())
                {
                    frmContractChanged.ContractId = contractId;         
                    frmContractChanged.ContractNo = contractNo;
                    if (frmContractChanged.ShowDialog() == DialogResult.OK)
                    {
                        UserMessages.ShowInfoBox("变更记录已经提交审批，审批通过后会在合同信息中显示...");
                        btnQuery_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }

        }



        /// <summary>
        /// 双击查看合同，根据合同审批状态，打开不同的合同页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string spState = dr["审批状态"].ToString();

                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                switch (spState)
                {
                    case "未提交":
                    case "已驳回":
                        {

                            frmContractEdit.FormStatus = PageStatus.Edit;
                            frmContractEdit.ContractId = contractId;
                            if (frmContractEdit.ShowDialog() == DialogResult.OK)
                            {
                                btnQuery_Click(null, null);
                            }
                        }
                        return;
                    case "待审批":
                        {

                            frmContractEdit.FormStatus = PageStatus.Approve;
                            frmContractEdit.ContractId = contractId;
                            if (frmContractEdit.ShowDialog() == DialogResult.OK)
                            {
                                btnQuery_Click(null, null);
                            }
                        }

                        return;
                    case "已审批":
                        {

                            frmContractEdit.FormStatus = PageStatus.View;
                            frmContractEdit.ContractId = contractId;
                            frmContractEdit.ShowDialog();
                        }

                        return;
                    default:
                        UserMessages.ShowErrorBox("未知的合同审批状态，无法打开合同页面");
                        return;
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }
        }

        private void 客户信息HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string clientName = dr["客户名称"].ToString();
                FrmClientView frmClientView = new FrmClientView();
                frmClientView.ClientName = clientName;
                frmClientView.ClientId = dr["客户名称ID"].ToString();
                frmClientView.Text = clientName;
                frmClientView.ShowDialog();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }
        }

        private void 做账会计Text_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计Text.Text = rv["UserName"].ToString();

            }
        }

        /// <summary>
        /// 合同续签，允许多选合同续签
        /// 续签操作将选中的旧合同复制为一个新的合同，合同服务信息的服务期限自动顺延一年，其他信息保持不变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn续签_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridView1.SelectedRowsCount == 0)
                {
                    UserMessages.ShowInfoBox("请先选择要续签的合同记录！");
                    return;
                }
                if (!UserMessages.ShowQuestionBox("确认续签选中的合同吗？"))
                {
                    return;
                }
                splash.ShowWaitForm();
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    int rowHandle = gridView1.GetSelectedRows()[i];
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    string contractId = dr["ContractID"].ToString();
                    string spState = dr["审批状态"].ToString();
                    if (spState != "已审批")
                    {
                        UserMessages.ShowInfoBox("只能对已审批的合同进行续签操作！");
                        continue;
                    }
                    //开始合同续签
                    contractDataSet1.RenewContract(contractId);
                }
                contractDataSet1.SaveDataSet();
                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
            }
        }

        private void 合同编号HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string spState = dr["审批状态"].ToString();

                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                switch (spState)
                {
                    case "未提交":
                    case "已驳回":
                        {

                            frmContractEdit.FormStatus = PageStatus.Edit;
                            frmContractEdit.ContractId = contractId;
                            if (frmContractEdit.ShowDialog() == DialogResult.OK)
                            {
                                btnQuery_Click(null, null);
                            }
                        }
                        return;
                    case "待审批":
                        {

                            frmContractEdit.FormStatus = PageStatus.Approve;
                            frmContractEdit.ContractId = contractId;
                            if (frmContractEdit.ShowDialog() == DialogResult.OK)
                            {
                                btnQuery_Click(null, null);
                            }
                        }

                        return;
                    case "已审批":
                        {

                            frmContractEdit.FormStatus = PageStatus.View;
                            frmContractEdit.ContractId = contractId;
                            frmContractEdit.ShowDialog();
                        }

                        return;
                    default:
                        UserMessages.ShowErrorBox("未知的合同审批状态，无法打开合同页面");
                        return;
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }
        }
        /// <summary>
        /// 指派合同的做账会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssign_Click(object sender, EventArgs e)
        {
            //获取表格当前行，打开合同指派界面，初始化合同信息
            if (gridView1.FocusedRowHandle < 0)
            {
                UserMessages.ShowInfoBox("请先选择一条合同记录！");
                return;
            }
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null) return;
            string contractId = dr["ContractID"].ToString();
            string contractNo = dr["合同编号"].ToString();
            string clientName = dr["客户名称"].ToString();
            //打开合同指派界面
            FrmContractAssign frmAssign = new FrmContractAssign();
            frmAssign.Text = $"指派合同[{contractNo}]的做账会计，客户名称：{clientName}";
            frmAssign.ContractId = contractId;
            frmAssign.ContractNo = contractNo;
            if (frmAssign.ShowDialog() == DialogResult.OK)
            {
                //获取指派完成的和同行，同步当前表格行的做账会计信息
                DataRow row = frmAssign.ContractRow;

                dr["做账会计ID"] = row["做账会计ID"];
                dr["做账会计"] = row["做账会计"];
                dr.EndEdit();
                dr.AcceptChanges();


            }
        }
        /// <summary>
        /// 生成补贴合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount == 0)
                {
                    UserMessages.ShowInfoBox("请先选择要补贴的合同记录！");
                    return;
                }
                if (!UserMessages.ShowQuestionBox("确认补贴选中的合同吗？"))
                {
                    return;
                }
                splash.ShowWaitForm();
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    int rowHandle = gridView1.GetSelectedRows()[i];
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    string contractId = dr["ContractID"].ToString();
                    
                    //补贴合同
                    contractDataSet1.BTContract(contractId);
                }
                contractDataSet1.SaveDataSet();
                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
            }
        }
    }
}
