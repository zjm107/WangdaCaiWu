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
    public partial class FrmStateList : DevExpress.XtraEditors.XtraForm
    {
        public FrmStateList(string stateName,string wmStateName)
        {
            this.StateName = stateName;

            //外勤进度进出口
            InitializeComponent();
        }
        /// <summary>
        /// 外贸进度状态
        /// </summary>
        public string WmStateName {
            get;set;
        }
        /// <summary>
        /// 进度状态名称
        /// </summary>
        public string StateName
        {
            get;set;
        }
        /// <summary>
        /// 选中的状态
        /// </summary>
        public string SelectState {
            get;set;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataRowView rv = dstTCONF_WORDBindingSource.Current as DataRowView;
            if (rv!=null )
            {
                SelectState =  rv["GROUPLISTITEM"].ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmStateList_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                DataSet dst = dstTCONF_WORD.GetParaItems(this.StateName);
                DataManager.ImpDataSet(dst.Tables[0], this.dstTCONF_WORD.TCONF_WORD);
                if (!string.IsNullOrEmpty(WmStateName))
                {
                    DataSet dstwm = dstTCONF_WORD.GetParaItems(this.WmStateName);
                    foreach (DataRow row in dstwm.Tables[0].Rows)
                    {
                        dstTCONF_WORD.TCONF_WORD.ImportRow(row);
                    }
                    dstTCONF_WORD.TCONF_WORD.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
