using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WangDaDll
{
    public partial class FrmUserSelectDlg : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserSelectDlg()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataRowView rv = tCOM_USERBindingSource.Current as DataRowView;
            if (rv!=null )
            {
                this.SelectRow = rv;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /// <summary>
        /// 选择行
        /// </summary>
        public DataRowView SelectRow
        {
            get;set;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        ///部门名称
        /// </summary>
        public string DeptName
        {
            get;set;
        }

        private void FrmUserSelectDlg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (!string.IsNullOrEmpty(DeptName))
                {
                    userDataSet.GetUserByDeptName(DeptName);
                }
                else
                {
                    userDataSet.GetUserAll();
                }
            
            
                dstTCONF_WORD.FillComBoBox("员工类型", eMPLOYEETYPEComboBox);
                dstTCONF_WORD.FillDevComboBox("薪资类型", workTypeComboBoxEdit);
                DataSet dst = userDataSet.DBHelper.UserSer.GetDeptAll();
                dEPTNAMEComboBox.Items.Clear();
                foreach (DataRow row in dst.Tables[0].Rows)
                {
                    string deptName = row["DEPTNAME"].ToString();
                    dEPTNAMEComboBox.Items.Add(deptName);
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                userDataSet.GetUserByType("", workTypeComboBoxEdit.Text, eMPLOYEETYPEComboBox.Text, uSERNAMETextBox.Text, dEPTNAMEComboBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
