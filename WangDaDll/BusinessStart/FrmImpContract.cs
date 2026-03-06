using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
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

namespace WangDaDll.BusinessStart
{
    public partial class FrmImpContract : DevExpress.XtraEditors.XtraForm
    {
        public FrmImpContract()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询合同注册信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            try
            {
                contractDataSet.GetNoRegContract(客户名称TextBox.Text, 签约日期DateEdit.Text, 签约日期DateEdit1.Text);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        /// <summary>
        /// 清除信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            客户名称TextBox.Text = "";
            签约日期DateEdit.Text = "";
            签约日期DateEdit1.Text = "";
            contractDataSet.VM_一次性服务合同明细.Clear(); 
        }

      
        /// <summary>
        /// 判断是否有选中行，有则赋值，返回，没有提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount <= 0)
                {
                    UserMessages.ShowInfoBox("请选择要导入的合同信息");
                    return;
                }
                var selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length <= 0)
                {
                    UserMessages.ShowInfoBox("请选择要导入的合同信息");
                    return;
                }
                splash.ShowWaitForm();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    DataRow dr = gridView1.GetDataRow(rowHandle);
                    if (dr == null) continue;
                    Contract.ContractDataSet.VM_一次性服务合同明细Row sRow = dr as Contract.ContractDataSet.VM_一次性服务合同明细Row;
                    var regRow = businessDataSet.TW_BusinessReg.NewTW_BusinessRegRow();
                    regRow.TW_BusinessRegID = sRow.ContractID;
                    //对赋值做非空判断
                    if (!sRow.Is客户名称IDNull())
                        regRow.公司预核名称 = sRow.客户名称;
                    if (!sRow.Is公司类型Null())
                        regRow.公司类型 = sRow.公司类型;
                    if (!sRow.Is服务金额Null())
                        regRow.注册费 = sRow.服务金额;
                    if (!sRow.Is月做账费Null())
                        regRow.月做账费 = sRow.月做账费;
                    regRow.工本费 = 0;
                    regRow.开票费 = 0;
                    regRow.图章 = 0;
                    regRow.银行 = 0;
                    regRow.其他 = 0;
                    regRow.零申报 = false;
                    if (!sRow.Is月做账费Null())
                        regRow.年做账费 = sRow.月做账费 * 12;
                    regRow.注册员 = Security.UserName;
                    regRow.注册员ID = Security.UserID;
                    regRow.修改人 = Security.UserName;
                    regRow.修改时间 = DateTime.Now;
                    regRow.登记日期 = businessDataSet.DBHelper.GetServerDateTime();
                    regRow.业务员 = Security.UserName;
                    regRow.业务员ID = Security.UserID;
                    regRow.部门 = Security.DeptName;
                    regRow.办理成本 = 0;
                    if (!sRow.Is服务项目Null())
                    regRow.注册类型 = sRow.服务项目;
                    businessDataSet.TW_BusinessReg.AddTW_BusinessRegRow(regRow);
                }
                businessDataSet.SaveTable();
                this.DialogResult = DialogResult.OK;

                this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}