using System.Data;
using Tiger.Entities;
using Tiger.Tools;
namespace Tiger.PdrCommon.Entities.Basic {

    /// <summary>
    /// 
    /// </summary>
    partial class DstUserRole
    {
        /// <summary>
        /// 获取用户角色
        /// </summary>
        /// <param name="userid"></param>
        public void GetUserRole(string userid)
        {
            DataSet ds = SysTools.basicService.GetUserRole(userid);
            DataManager.ImpDataSet(ds.Tables[0], this.TCOM_ROLE1);
            this.TCOM_ROLE1.AcceptChanges();
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void SaveRole()
        {
            DataTable tb = TCOM_ROLE.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                SysTools.basicSer.SaveTable(dst, "TCOM_ROLE");
                TCOM_ROLE.AcceptChanges();
            }
        }
        /// <summary>
        /// 保存角色菜单
        /// </summary>
        public void SaveRoleToMenu()
        {
            DataTable tb = TCOM_ROLESMENU.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                SysTools.basicSer.SaveTable(dst, "TCOM_ROLESMENU");
            }
        }
        /// <summary>
        /// 获取全部角色
        /// </summary>
        public void GetAllUserRole()
        {
            DataSet ds = SysTools.basicService.GetAllUserRole();
            TCOM_ROLE.Rows.Clear();
            DataManager.ImpDataSet(ds.Tables[0], TCOM_ROLE);
            TCOM_ROLE.AcceptChanges();
        }
    }
}
