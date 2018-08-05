using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.PdrCommon
{
    /// <summary>
    ///  Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006-06-28
    ///
    /// �� ��:
    /// ���ã�ϵͳ���˵�
    /// ģ����
    /// </summary>
    public class MenuNode:TreeNode
    {

        bool m_AllowQuery = true;
        /// <summary>
        /// �����ѯ
        /// </summary>
        public bool AllowQuery
        {
            get
            {
                return m_AllowQuery;
            }
            set
            {
                m_AllowQuery = value;
            }
        }
        bool m_AllowSave = true;
        /// <summary>
        /// ������
        /// </summary>
        public bool AllowSave
        {
            get
            {
                return m_AllowSave;
            }
            set
            {
                m_AllowSave = value;
            }
        }

        bool m_AllowAdd=true;
        /// <summary>
        /// �������
        /// </summary>
        public bool AllowAdd
        {
            get {
                return m_AllowAdd;
            }
            set
            {
                m_AllowAdd = value;
            }
        }


        bool m_AllowDelete = true;
        /// <summary>
        /// ����ɾ��
        /// </summary>
        public bool AllowDelete
        {
            get
            {
                return m_AllowDelete;
            }
            set
            {
                m_AllowDelete = value;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string ClassName
        {
            get;
            set;
        }


        Dictionary<string, bool> m_OtherOperation = new Dictionary<string, bool>();
        /// <summary>
        /// ��������Ȩ��
        /// </summary>
        public Dictionary<string, bool> OtherOperation
        {
            get
            {
                return m_OtherOperation;
            }
        }
    }
}
