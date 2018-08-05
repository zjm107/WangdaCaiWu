using System.Data;
using Tiger.Entities;
using Tiger.Tools;
namespace Tiger.PdrCommon.Entities.Basic {


    partial class DstDepartment
    {
        public void Save()
        {
            
            DataTable tb = this.TCOM_DEPT.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                SysTools.basicSer.SaveTable(dst, "TCOM_DEPT");
                TCOM_DEPT.AcceptChanges();
            }
            

            
            
        }
        public void GetAllData()
        {
            DataSet ds = SysTools.basicService.GetAllDepartment();
            TCOM_DEPT.Clear();
            DataManager.ImpDataSet(ds.Tables[0], this.TCOM_DEPT);
            TCOM_DEPT.AcceptChanges();
        }


        public void GetDeptByName(string deptName)
        {
            DataSet ds = SysTools.basicService.GetDepartmentByCodeName(deptName);
            DataManager.ImpDataSet(ds.Tables[0], TCOM_DEPT);
        }
    }
}
