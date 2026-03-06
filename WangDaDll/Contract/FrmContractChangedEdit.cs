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
    public partial class FrmContractChangedEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractChangedEdit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是添加还是编辑
        /// </summary>
        public bool isNew = true;
        /// <summary>
        /// 审批
        /// </summary>
        public bool isApprove = false;
        /// <summary>
        /// 编辑
        /// </summary>
        public bool isEdit = false;

        /// <summary>
        /// 合同Id
        /// </summary>
        public string ContractId;
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNo;
        /// <summary>
        /// 可最大调整月数
        /// </summary>
        public int maxMonths = 12;
        public void GetContractChangedInfo(string contractId, string contractNo)
        {
            contractDataSet.GetContractByID(contractId);//获取合同信息
            tW_ContractServiceInfoBindingSource.Filter = "服务类别='周期性服务'";
            int changeCount = contractDataSet.GetContractChanged(contractId);//获取合同变更记录

            
            if (changeCount == 0&& isNew) //添加
            {
                //添加新的变更记录
                contractDataSet.NewContractChangedRow(contractId, contractNo);
                maxMonths = contractDataSet.TW_ContractChanged[0].变更月数;
                变更月数SpinEdit.Properties.MaxValue = maxMonths;
                layoutControl1.HideItem(同意lItem);
                layoutControl1.HideItem(驳回lItem);

            }
            else if (changeCount > 0 )
            {
                if (isApprove) //审批
                {
                    //审批界面
                    tW_ContractChangedBindingSource.Position = 0;
                    layoutControl1.HideItem(提交lItem);
                    变更原因及说明memoEdit.Properties.ReadOnly = true;
                    变更月数SpinEdit.Properties.ReadOnly = true;
                    新单价SpinEdit.Properties.ReadOnly = true;
                    起始变更月DateEdit.Properties.ReadOnly = true;

                    if (Security.UserBusiness.Contains("总经理"))   //管理员可以查看所有信息
                    {
                        layoutControl1.HideItem(同意lItem);
                    }
                    else
                   if (Security.UserBusiness == "注册主管") //注册主管可以查看注册主管的信息
                    {
                        layoutControl1.HideItem(终审lItem);
                    }
                    else if (Security.UserName != "admin")
                    {
                       

                    }
                }
                else if (isEdit) //编辑
                {
                    //编辑界面，默认显示最后一条变更记录
                    tW_ContractChangedBindingSource.Position = 0;
                    maxMonths = contractDataSet.TW_ContractChanged[0].变更月数;
                    变更月数SpinEdit.Properties.MaxValue = maxMonths;
                    layoutControl1.HideItem(同意lItem);
                    layoutControl1.HideItem(驳回lItem);
                    layoutControl1.HideItem(终审lItem);

                }
                else //查看
                {
                    tW_ContractChangedBindingSource.Position = 0;
                    layoutControl1.HideItem(提交lItem);
                    layoutControl1.HideItem(同意lItem);
                    layoutControl1.HideItem(驳回lItem);
                    layoutControl1.HideItem(终审lItem);
                    变更原因及说明memoEdit.Properties.ReadOnly = true;
                    变更月数SpinEdit.Properties.ReadOnly = true;
                    新单价SpinEdit.Properties.ReadOnly = true;
                    起始变更月DateEdit.Properties.ReadOnly = true;
                }
            }
                

        }

        /// <summary>
        /// 提交合同变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            tW_ContractChangedBindingSource.EndEdit();
            if (string.IsNullOrEmpty(变更原因及说明memoEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请输入变更原因！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                变更原因及说明memoEdit.Focus();
                return;
            }
            //变更月数必须大于0

            if (变更月数SpinEdit.EditValue == null || Convert.ToInt32(变更月数SpinEdit.EditValue) <= 0)
            {
                XtraMessageBox.Show("变更月数必须大于0！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                变更月数SpinEdit.Focus();
                return;
            }
            //涨价必须大于0
            if (新单价SpinEdit.Text == null || Convert.ToDecimal(新单价SpinEdit.Text) <= 0)
            {
                XtraMessageBox.Show("新的单价必须大于0！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                新单价SpinEdit.Focus();
                return;
            }
            //变更月数不能大于可调整月数
            if (变更月数SpinEdit.EditValue != null && Convert.ToInt32(变更月数SpinEdit.EditValue) > maxMonths)
            {
                XtraMessageBox.Show("变更月数不能大于可调整月数！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                变更月数SpinEdit.Focus();
                return;
            }

           

            if (XtraMessageBox.Show("是否确认提交合同变更？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            splash.ShowWaitForm();
            try
            { 
            //保存变更信息
            contractDataSet.PostChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("提交合同变更失败！" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                splash.CloseWaitForm();
            }
        }

        
        /// <summary>
        /// 取消合同变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        bool isFirstLoad = false;
        private void FrmContractChangedEdit_Load(object sender, EventArgs e)
        {
            isFirstLoad = true;
            try
            {
                //获取变更信息
                GetContractChangedInfo(this.ContractId, this.ContractNo);
                //变更起始月的最小时间为原始开始月
                起始变更月DateEdit.Properties.MinValue = 原开始服务月DateEdit.DateTime;
                起始变更月DateEdit.Properties.MaxValue = 原结束服务月DateEdit.DateTime;



            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("获取合同变更信息失败！" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            finally
            {
                isFirstLoad = false;
            }
        }




        private void 新单价SpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;
            //涨价等于新单价减去原单价
            if (新单价SpinEdit.EditValue != null && 原单价TextBox.Text != null)
            {
                decimal beforePrice = Convert.ToDecimal(原单价TextBox.Text);
                decimal afterPrice = Convert.ToDecimal(新单价SpinEdit.EditValue);
                decimal changePrice = afterPrice - beforePrice;
                涨价TextBox.Text = changePrice.ToString();
            }
            //补款金额=原服务期限*原单价-已收款额+涨价*变更月数
            if (变更月数SpinEdit.EditValue != null && 涨价TextBox.Text != null && 原服务期限SpinEdit.Text != null && 已收款额TextBox.Text != null)
            {
                decimal originalTerm = Convert.ToDecimal(原服务期限SpinEdit.Text);
                decimal beforePrice = Convert.ToDecimal(原单价TextBox.Text);
                decimal receivedAmount = Convert.ToDecimal(已收款额TextBox.Text);
                decimal changePrice = Convert.ToDecimal(涨价TextBox.Text);
                int changeMonths = Convert.ToInt32(变更月数SpinEdit.EditValue);
                decimal makeUpAmount = originalTerm * beforePrice - receivedAmount + changePrice * changeMonths;
                补款金额TextBox.Text = makeUpAmount.ToString();
            }
        }
        /// <summary>
        /// 审批通过同意
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgree_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("是否确认审批通过？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            splash.ShowWaitForm();
            try
            {
                contractDataSet.ApprovalChanges("同意");
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("审批通过失败！" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                splash.CloseWaitForm();

            }
            
        }
        /// <summary>
        /// 审批驳回，拒绝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("是否确认审批驳回？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
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
            //修改当前合同变更行审批状态为驳回，保存驳回意见
            splash.ShowWaitForm();
            try
            {
                var rv = tW_ContractChangedBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    rv["审批状态"] = "驳回";
                    rv["审批意见"] = Rejecte;
                    rv.EndEdit();
                }
                this.contractDataSet.SaveChanges();



                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("审批驳回失败！" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                splash.CloseWaitForm();
            }
        }

        private void 起始变更月DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            //起始变更月必须是每月1号
            if (起始变更月DateEdit.DateTime.Day>1)
            {
                //XtraMessageBox.Show("起始变更月必须是每月1号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                起始变更月DateEdit.DateTime = new DateTime(起始变更月DateEdit.DateTime.Year, 起始变更月DateEdit.DateTime.Month, 1);
                return;

            }

            //变更月数SpinEdit.Value = ((newRow.原结束服务月.Year - newRow.起始变更月.Year) * 12 + newRow.原结束服务月.Month - newRow.起始变更月.Month) + 1;
            变更月数SpinEdit.Value = ((原结束服务月DateEdit.DateTime.Year - 起始变更月DateEdit.DateTime.Year) * 12 + 原结束服务月DateEdit.DateTime.Month - 起始变更月DateEdit.DateTime.Month) + 1;


        }
        /// <summary>
        /// 终审
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("是否确认审批通过？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            splash.ShowWaitForm();
            try
            {
                contractDataSet.ZSApprovalChanges("同意");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("审批通过失败！" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                splash.CloseWaitForm();

            }
        }
    }
}