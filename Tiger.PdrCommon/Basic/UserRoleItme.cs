using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006.08.07
    ///
    /// �� ��:
    /// ���ã��û���ɫ���
    /// ģ���ţ�
    /// </summary>
    public class UserRoleItme : TreeNode
    {
       /// <summary>
       /// �û���ɫ�ڵ�
       /// </summary>
       /// <param name="row"></param>
        public UserRoleItme(DataRow row)
        {
            ParentMenuName = row["PARENTMENUNAME"].ToString();
            MENUNAME = row["MENUNAME"].ToString();
            MENUID = row["MENUID"].ToString();

        }
        //string m_ParentFunctionID;
        /// <summary>
        /// ���˵�
        /// </summary>
        public string ParentMenuName
        {
            get;
            set;
        }
       
        /// <summary>
        /// �˵�����
        /// </summary>
        public string MENUNAME
        {
            get;
            set;
        }
       
       
        /// <summary>
        /// Ψһid
        /// </summary>
        public string MENUID
        {
            get;
            set;
        }
       
        /// <summary>
        /// ���ر��е�һ������
        /// </summary>
        public DataRow MenuTreeRowInfo
        {
            get;
            set;
        }

    }
}
