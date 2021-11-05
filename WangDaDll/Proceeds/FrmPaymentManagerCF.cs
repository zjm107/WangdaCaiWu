using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmPaymentManagerCF : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentManagerCF()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            isQuery = false;
            try
            {
                string beginDate = 支付日期DateEdit.DateTime.ToString("yyyy-MM-dd");
                string endDate = 支付日期DateEdit1.DateTime.ToString("yyyy-MM-dd");
                cfDataSet1.GetCFDataSet(beginDate,endDate);
                tW_PaymentBindingSource.MoveFirst();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                isQuery = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
            
                支付日期DateEdit.Text = "";
                支付日期DateEdit1.Text = "";
              
                cfDataSet1.TW_Payment.Clear();
               

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        
        bool isQuery = false;

        private void tW_PaymentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try {
               

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

      

     

       

        private void FrmPaymentManagerCF_Load(object sender, EventArgs e)
        {

            cfDataSet1.DBHelper.WangDaSer.UpdateUserID();
        }

   

  
        /// <summary>
        /// 拆分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCF_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int[] rowIndexs = gridView1.GetSelectedRows();
                if (rowIndexs.Length > 0)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("拆分中");
                    splash.SetWaitFormDescription("正在进行拆分……");
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv = gridView1.GetRow(i) as DataRowView;
                        int monthCount = int.Parse(rv["缴费月数"].ToString());
                        if(monthCount>1)
                        {
                            cfDataSet1.CFPayments(monthCount, rv.Row);
                        }
                    }
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv = gridView1.GetRow(i) as DataRowView;
                        int monthCount = int.Parse(rv["缴费月数"].ToString());
                        if (monthCount == 0 || monthCount==1)
                        {
                            gridView1.UnselectRow(i);
                        }
                    }
                    gridView1.DeleteSelectedRows();//删除选中行
                    cfDataSet1.SaveDataSet(); //保存
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

     
    }
}
