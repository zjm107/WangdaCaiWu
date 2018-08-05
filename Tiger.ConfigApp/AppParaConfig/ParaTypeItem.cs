using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.ConfigApp
{
    /// <summary>
    ///  Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 
    /// 日 期:2006年6月15日
    ///
    /// 版 本:
    /// 参数分类节点
    /// </summary>
    public class ParaTypeItem : ListViewItem
    {
       
        /// <summary>
        /// 参数分类ID
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
        ///参数分类ID 
        /// </summary>
        private string mparaType = "";

        /// <summary>
        /// 参数分类名称
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
        /// 参数分类名称
        /// </summary>
        private string mparaTypeName = "";

        /// <summary>
        /// 类别描述
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
        /// 类别描述
        /// </summary>
        private string mparaTypeMemo = "";

        /// <summary>
        /// 参数名1
        /// </summary>
        public string paraName1 = "";
        /// <summary>
        /// 参数名2
        /// </summary>
        public string paraName2 = "";
        /// <summary>
        /// 参数名3
        /// </summary>
        public string paraName3 = "";
     

    }
}
