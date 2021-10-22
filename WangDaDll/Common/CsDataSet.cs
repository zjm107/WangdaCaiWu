using System;
using System.Data;
using Tiger.Tools;
namespace WangDaDll.Common
{


    partial class CsDataSet
    {
        /// <summary>
        /// 更新业务员信息
        /// </summary>
        public void UpdateYWY()
        {
            DBHelper.WangDaSer.UpdateYWY();
        }

        public SysTools DBHelper = new SysTools();

        public void BuildSer()
        { }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="clientName">客户名称</param>
        /// <param name="clientType">客户类别</param>
        /// <param name="clientLevel">客户级别</param>
        /// <param name="clientPropety">客户性质</param>
        /// <param name="accountant">做账会计</param>
        /// <returns></returns>
        public void GetClientInfo(string clientName, string clientType, string clientLevel, string clientPropety, string accountant,string clientState)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetClientInfo(clientName, clientType, clientLevel, clientPropety, accountant, clientState);
                DataManager.ImpDataSet(dst.Tables[0], this.tableTW_Client);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 同步注册信息和客户信息
        /// </summary>
        public void UpdateClient()
        {
            try
            {
                DBHelper.WangDaSer.UpdateClient();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 做账费到期客户查询
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="clientType"></param>
        /// <param name="clientLevel"></param>
        /// <param name="clientPropety"></param>
        /// <param name="accountant"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public void GetEndDateClient(string clientName, string clientType, string clientLevel, string clientPropety, string accountant, string endDate)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetEndDateClient(clientName, clientType, clientLevel, clientPropety, accountant, endDate);
                DataManager.ImpDataSet(dst.Tables[0], this.tableTW_Client);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 根据客户名称查询出唯一客户信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public void GetSingleClient(string clientName)
        {
            try
            {
                tableTW_Client.Clear();
                DataSet dst = DBHelper.WangDaSer.GetSingleClient(clientName);
                if (dst.Tables[0].Rows.Count > 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        DataRow row = dst.Tables[0].Rows[i];
                        this.tableTW_Client.ImportRow(row);

                    }
                    this.tableTW_Client.AcceptChanges();
                }
                else
                    DataManager.ImpDataSet(dst.Tables[0], this.tableTW_Client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        public void SaveData()
        {
            DataTable tb = this.TW_Client.GetChanges();
            if (tb != null && tb.Rows.Count > 0)
            {
                DataSet dst = new DataSet();
                tb.TableName = "TW_Client";
                dst.Tables.Add(tb);
                DBHelper.BasicSer.SaveTable(dst, tb.TableName);
                TW_Client.AcceptChanges();
            }

        }


    }


}
