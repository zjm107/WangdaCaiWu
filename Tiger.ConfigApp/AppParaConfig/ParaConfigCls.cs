using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using System.Text;
using Tiger.ConfigApp.AppParaConfig;
using Tiger.Entities;
using Tiger.Tools;
//using Tiger.Config;
using Tiger.WinControl.Forms;


namespace Tiger.ConfigApp
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: 
    /// �� ��:2006��6��14��
    ///
    /// �� ��:
    /// ���ã��Դ������������������ϵͳ����е�����
    /// </summary>
    public class ParaConfigCls
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_dsParaConfig"></param>
        public ParaConfigCls(DsParaConfig p_dsParaConfig)
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
			dsParaConfig=p_dsParaConfig;
			GetAllParaType();
			

		}
		private DsParaConfig dsParaConfig;

		/// <summary>
		/// ��ȡȫ���������
		/// </summary>
		/// <returns></returns>
        public DsParaConfig GetAllParaType()
		{
            //ParaConfig pser = new ParaConfig();
           
                try
                {
                    DataSet ds = SysTools.config.GetAllParaType();
                    dsParaConfig.TCONF_WORD.Clear();
                    foreach (DataRow row in ds.Tables["TCONF_WORD"].Rows)
                    {
                        dsParaConfig.TCONF_WORD.ImportRow(row);
                    }
                    dsParaConfig.TCONF_WORD.AcceptChanges();
                    return dsParaConfig;

                }
                catch (Exception e)
                {
                    throw e;
                }
            
		}
	

		/// <summary>
		/// ��ȡ���������������ֵ
		/// </summary>
		/// <param name="strParaTypeID">�������ID</param>
		public void GetParaValue(string strParaTypeID)
		{
            //ParaConfig pser = new ParaConfig();
           
                try
                {
                    dsParaConfig.TCONF_WORD.Clear();
                    DataSet ds = SysTools.config.GetParaValue(strParaTypeID);
                    foreach (DataRow row in ds.Tables["TCONF_WORD"].Rows)
                    {
                        dsParaConfig.TCONF_WORD.ImportRow(row);
                    }
                    dsParaConfig.TCONF_WORD.AcceptChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
           
		}

		/// <summary>
		/// �����������
		/// </summary>
		public void SaveParaType()
		{
            //ParaConfig pser = new ParaConfig();
           
                try
                {
                    DataTable tb = dsParaConfig.TCONF_WORD.GetChanges();
                    if (tb != null)
                    {
                        DataSet dst = new DataSet();
                        dst.Tables.Add(tb);

                        SysTools.config.SaveAppConfig(dst);
                    }
                    dsParaConfig.TCONF_WORD.AcceptChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
		}
	
		/// <summary>
		/// ��������ֵ
		/// </summary>
		public void SaveParaValue()
		{
           // ParaConfig pser = new ParaConfig();
           
                try
                {
                    DataTable tb = dsParaConfig.TCONF_WORD.GetChanges();
                    if (tb != null)
                    {
                        DataSet dst = new DataSet();
                        dst.Tables.Add(tb);
                        SysTools.config.SaveAppConfig(dst);
                        dsParaConfig.TCONF_WORD.AcceptChanges();
                    }
                    dsParaConfig.TCONF_WORD.AcceptChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
           
		}


		/// <summary>
		/// ���ݲ���������ƻ�ȡ����ֵ
		/// </summary>
		/// <param name="strParaName"></param>
		/// <returns></returns>
		public static DataSet GetParaValueByName(string strParaName)
		{
         
                DataSet ds = null;
                try
                {
                    ds = SysTools.config.GetParaValueOfName(strParaName);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            
		}
    }

}
