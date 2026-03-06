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

namespace WangDaDll
{
    public partial class FrmNoSignCycleContract : DevExpress.XtraEditors.XtraForm
    {
        public FrmNoSignCycleContract()
        {
            InitializeComponent();
        }

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

        private void AccountingButtonEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 选择做账会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountingButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    做账会计ButtonEdit.Text = rv["UserName"].ToString();
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
        /// 根据查询条件查询周期性合同信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string accountant = 做账会计ButtonEdit.Text.Trim();
            string endDate = endDateEdit.DateTime.ToString("yyyy-MM-dd");
            contractDataSet.GetNoSignContract("", endDate, accountant);
        }
        /// <summary>
        /// 清除查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            做账会计ButtonEdit.Text = "";
            
            contractDataSet.VW_ContractServiceInfo.Clear();
            //开始时间是一年的1月1日，结束时间是一年的12月31日
            endDateEdit.DateTime =new DateTime(DateTime.Now.Year,DateTime.Now.AddMonths(1).Month,1);


        }

        private void FrmNoSignCycleContract_Load(object sender, EventArgs e)
        {
            endDateEdit.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, 1);
        }
        /// <summary>
        /// 转流失客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoss_Click(object sender, EventArgs e)
        {
            //提示用户是否将当前行客户转流失客户，打开转流失客户窗体


            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;

                string clientId = dr["客户名称ID"]?.ToString();
                string clientName = dr["客户名称"]?.ToString();

                // 确认对话框
                var msg = $"确认将客户 “{clientName}” 标记为流失客户吗？";
                var result = MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;

                // 打开流失客户窗体并传入信息
                FrmLossClientView frmLossClientView = new FrmLossClientView();
                // 如果 FrmLossClientView 定义了这些属性，则会接收；否则可在窗体中通过 Tag 读取
                try { frmLossClientView.ClientId = clientId; } catch { frmLossClientView.Tag = clientId; }
                try { frmLossClientView.ClientName = clientName; } catch { /* ignore if property not exist */ }

                frmLossClientView.Text = $"流失客户 - {clientName}";
                frmLossClientView.ShowDialog();
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