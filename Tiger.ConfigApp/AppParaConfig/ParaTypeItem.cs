using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.ConfigApp
{
    /// <summary>
    ///  Copyright (c) 2006-2007 *********Tiger
    /// ������: 
    /// �� ��:2006��6��15��
    ///
    /// �� ��:
    /// ��������ڵ�
    /// </summary>
    public class ParaTypeItem : ListViewItem
    {
       
        /// <summary>
        /// ��������ID
        /// </summary>
        public string TypeID
        {
            get { return mparaType; }
            set
            {
                mparaType = value;
            }
        }

        /// <summary>
        ///��������ID 
        /// </summary>
        private string mparaType = "";

        /// <summary>
        /// ������������
        /// </summary>
        public string TypeName
        {
            get
            {
                return mparaTypeName;
            }
            set
            {
                mparaTypeName = value;
                this.Text = value;
            }
        }
        /// <summary>
        /// ������������
        /// </summary>
        private string mparaTypeName = "";

        /// <summary>
        /// �������
        /// </summary>
        public string TypeMemo
        {
            get
            {
                return mparaTypeMemo;
            }
            set
            {
                mparaTypeMemo = value;
                this.SubItems.Add(value);
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        private string mparaTypeMemo = "";

        /// <summary>
        /// ������1
        /// </summary>
        public string paraName1 = "";
        /// <summary>
        /// ������2
        /// </summary>
        public string paraName2 = "";
        /// <summary>
        /// ������3
        /// </summary>
        public string paraName3 = "";
     

    }
}
