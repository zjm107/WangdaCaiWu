using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmContractChangedRc : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractChangedRc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 根据条件查询合同变更记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            contractDataSet.TW_ContractChanged.Clear();
            string contractNo = 合同编号textEdit.Text.Trim();
            string customerName = 客户名称textEdit.Text.Trim();
            string beginDate = 创建时间DateEdit.Text.Trim();    
            string endDate = 创建时间DateEdit1.Text.Trim();
            contractDataSet.GetTW_ContractChanged(contractNo, customerName, beginDate, endDate);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            合同编号textEdit.Text = "";
            客户名称textEdit.Text = "";
            创建时间DateEdit.Text = "";
            创建时间DateEdit1.Text = "";
            contractDataSet.TW_ContractChanged.Clear();
        }

        private void FrmContractChangedRc_Load(object sender, EventArgs e)
        {
            //查询条件，默认时间一个月
            创建时间DateEdit1.DateTime = DateTime.Now.AddDays(1);
            创建时间DateEdit.DateTime = DateTime.Now.AddMonths(-1);
            if (Security.UserBusiness.Contains("总经理"))   //管理员可以查看所有信息
            {
                layoutControl1.HideItem(编辑Item);
                layoutControl1.HideItem(审批Item);
            }
            else
                   if (Security.UserBusiness == "注册主管") //注册主管可以查看注册主管的信息
            {
                layoutControl1.HideItem(编辑Item);
                layoutControl1.HideItem(终身lItem);
            }
            else if ( Security.UserName!= "admin")
            {
                layoutControl1.HideItem(审批Item);
                layoutControl1.HideItem(终身lItem);

            }

        }


        /// <summary>
        /// 根据合同编号，打开合同查看界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 合同编号HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();

                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                frmContractEdit.FormStatus = PageStatus.View;
                frmContractEdit.ContractId = contractId;
                frmContractEdit.ShowDialog();

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
        /// 根据客户名称，打开客户查看界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 客户名称HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string clientName = dr["客户名称"].ToString();
                FrmClientView frmClientView = new FrmClientView();
                frmClientView.ClientName = clientName;
               // frmClientView.ClientId = dr["客户名称ID"].ToString();
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
        /// <summary>
        /// 审批合同变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApproval_Click(object sender, EventArgs e)
        {
            //获取当前选中合同变更行，根据合同ID，打开合同变更审批界面
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string contractNo = dr["合同编号"].ToString();
                FrmContractChangedEdit frmContractChangedEdit = new FrmContractChangedEdit();
                frmContractChangedEdit.isNew = false;
                frmContractChangedEdit.isApprove = true;
                frmContractChangedEdit.isEdit = false;
                frmContractChangedEdit.ContractId = contractId;
                frmContractChangedEdit.ContractNo = contractNo;
                if (frmContractChangedEdit.ShowDialog()== DialogResult.OK)
                {
                    btnQuery_Click(null, null);
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
        /// 编辑合同变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //获取当前选中合同变更行，根据合同ID，打开合同变更编辑界面
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string contractNo = dr["合同编号"].ToString();
                //判断创建人是否当前用户不是则不允许编辑
                if (dr["创建人"].ToString() != Security.UserName)
                {
                    UserMessages.ShowInfoBox("只能编辑自己创建的合同变更记录！");
                    return;
                }
                FrmContractChangedEdit frmContractChangedEdit = new FrmContractChangedEdit();
                frmContractChangedEdit.isNew = false;
                frmContractChangedEdit.isApprove = false;
                frmContractChangedEdit.isEdit = true;
                frmContractChangedEdit.ContractId = contractId;
                frmContractChangedEdit.ContractNo = contractNo;
                frmContractChangedEdit.ShowDialog();
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
        /// 公司主管终审
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZS_Click(object sender, EventArgs e)
        {
            //获取当前选中合同变更行，根据合同ID，打开合同变更审批界面
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string contractId = dr["ContractID"].ToString();
                string contractNo = dr["合同编号"].ToString();
                FrmContractChangedEdit frmContractChangedEdit = new FrmContractChangedEdit();
                frmContractChangedEdit.isNew = false;
                frmContractChangedEdit.isApprove = true;
                frmContractChangedEdit.isEdit = false;
                frmContractChangedEdit.ContractId = contractId;
                frmContractChangedEdit.ContractNo = contractNo;
                if (frmContractChangedEdit.ShowDialog() == DialogResult.OK)
                {
                    btnQuery_Click(null, null);
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
    }
}