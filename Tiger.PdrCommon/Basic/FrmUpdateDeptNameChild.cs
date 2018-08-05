using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Tiger.PdrCommon
{
    public partial class FrmUpdateDeptNameChild : DevExpress.XtraEditors.XtraForm
    {
        public FrmUpdateDeptNameChild()
        {
            InitializeComponent();
            this.Visible = false;
        }
        /// <summary>
        /// 工具栏保存方法
        /// </summary>
        private void DoSaveData()
        {
            
        }
        

        private void HyForm_Load(object sender, EventArgs e)
        {
            
            //保存表格默认样式
            //WindDataManager.SaveDefaltGridViewLayout(devGridView, this.Name);
            //恢复表格样式
            //WindDataManager.RestoreGridViewLayout(devGridView, this.Name);

            //绑定工具栏数据源
            //SetDataSource(ts_datasouce);
            this.DeptName = "";
            DataBinding();

            //保存默认布局样式
            //WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
            //恢复布局样式
            //WindDataManager.RestoreControlLayout(layoutControl1, this.Name);

        }
        private void DataBinding()
        {
            DataSet dst = dstEmployee.GetDeptName();
            if (dst != null && dst.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dst.Tables[0].Rows)
                {
                    if(!string.IsNullOrEmpty(row["DEPTNAME"].ToString()))
                        cmbDeptNameList.Properties.Items.Add(row["DEPTNAME"].ToString());
                }
            }
        }

        private void HyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存表格样式
            //WindDataManager.SaveGridViewLayout(devGridView, this.Name);
            //保存布局样式
            //WindDataManager.SaveControlLayout(layoutControl1, this.Name);
            this.DeptName = cmbDeptNameList.Text;
        }
        public string DeptName;
        

    }
}
