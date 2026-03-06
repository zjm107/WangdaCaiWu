using System;
using System.Data;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractSP : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractSP()
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

                if (Security.UserBusiness.Contains("总经理"))
                {
                    contractDataSet1.GetContract(clientName, accountant, endMonth, unpaidAmount, spState);
                }
                else if (Security.UserBusiness.Contains("注册主管"))
                {
                    // 调用contractDataSet1的查询方法
                    contractDataSet1.GetContract(clientName, accountant, endMonth, unpaidAmount, spState);
                }

                 

                // 绑定查询结果到界面（假设有gridControl1用于显示结果）
                //gridControl1.DataSource = contractDataSet1.TW_Contract;
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


        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmContract_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                //dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                //dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);

                WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
                //权限控制，总经理：终审；注册主管：审核；其他用户不显示审批按钮
                if (Security.UserBusiness.Contains("总经理"))
                {
                    layoutControl1.HideItem(TGlayoutControlItem);
                    审批状态comboBoxEdit.Text = "待终审";
                    
                }
                else if (Security.UserBusiness.Contains("注册主管"))
                {
                    layoutControl1.HideItem(ZSlayoutControlItem);
                    审批状态comboBoxEdit.Text = "待审批";
                }
                else if (Security.UserName.ToLower() != "admin")
                {
                    layoutControl1.HideItem(TGlayoutControlItem);
                    layoutControl1.HideItem(ZSlayoutControlItem);
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


        private void 做账会计Text_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计Text.Text = rv["UserName"].ToString();
                
            }

        }

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
        /// 合同审批，允许在表格中多选合同，进行批量审批，但是只能审批待审批状态的合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn审批_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridView1.SelectedRowsCount <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要审批的合同");
                    return;
                }
                var selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要审批的合同");
                    return;
                }
                splash.ShowWaitForm();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    string contractId = dr["ContractID"].ToString();
                    string contractNo = dr["合同编号"].ToString();
                    string spState = dr["审批状态"].ToString();
                    bool qx = bool.Parse(dr["续签"].ToString());
                    if (spState != "待审批")
                    {
                        UserMessages.ShowInfoBox($"合同{contractNo}的审批状态为{spState}，不能进行审批操作");
                        continue;
                    }
                    

                    dr.BeginEdit();
                    if (qx)
                        dr["审批状态"] = "已审批";
                    else
                        dr["审批状态"] = "待终审";
                    dr["审批人"] = Security.UserName;
                    dr["审批日期"] = DateTime.Now;
                    dr["审批意见"] = "同意";
                    dr.EndEdit();
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
        /// <summary>
        /// 驳回待审批合同，允许在表格中多选合同，进行批量驳回，但是只能驳回待审批状态的合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn驳回_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要驳回的合同");
                    return;
                }
                var selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要驳回的合同");
                    return;
                }
                //弹出驳回意见对话框，输入驳回意见
                string Rejecte = "";
                FrmRejected frmRejected = new FrmRejected();
                if (frmRejected.ShowDialog() == DialogResult.OK)
                {
                    Rejecte = frmRejected.Rejection;
                }
                else
                {
                    return;
                }
                splash.ShowWaitForm();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    string contractId = dr["ContractID"].ToString();
                    string contractNo = dr["合同编号"].ToString();
                    string spState = dr["审批状态"].ToString();
                    //if (spState != "待审批")
                    //{
                    //    UserMessages.ShowInfoBox($"合同{contractNo}的审批状态为{spState}，不能进行驳回操作");
                    //    continue;
                    //}
                    dr.BeginEdit();
                    dr["审批状态"] = "已驳回";
                    dr["审批人"] = Security.UserName;
                    dr["审批日期"] = DateTime.Now;
                    dr["审批意见"] = Rejecte;
                    dr.EndEdit();
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
   
        /// <summary>
        /// 查看客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void 客户信息HyperLinkEdit1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string clientName = dr["客户名称"].ToString();
                string clientId = dr["客户名称ID"].ToString();
                FrmClientView frmClientView = new FrmClientView();
                frmClientView.Text = clientName;
                frmClientView.ClientId=clientId;
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
        /// <summary>
        /// 查看合同信息
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
                    case "未提交":
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
        /// 终审
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZS_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要审批的合同");
                    return;
                }
                var selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length <= 0)
                {
                    UserMessages.ShowInfoBox("请先选择要审批的合同");
                    return;
                }
                splash.ShowWaitForm();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    string contractId = dr["ContractID"].ToString();
                    string contractNo = dr["合同编号"].ToString();
                    string spState = dr["审批状态"].ToString();
                    bool qx = bool.Parse(dr["续签"].ToString());
                    if (spState != "待审批")
                    {
                        UserMessages.ShowInfoBox($"合同{contractNo}的审批状态为{spState}，不能进行审批操作");
                        continue;
                    }

                    dr.BeginEdit();

                    dr["审批状态"] = "已审批";

                    dr["终审人"] = Security.UserName;
                    dr["终审时间"] = DateTime.Now;
                    dr["审批意见"] = "同意";
                    dr.EndEdit();
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
