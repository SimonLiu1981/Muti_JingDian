using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class DataHtmlMod : XmlTableMod
    {
        /// <summary>
        /// 数据集的HAS代码
        /// </summary>
        private string m_HasKey = null;
        public string HasKey
        {
            get
            {
                return m_HasKey;
            }
            set
            {
                m_HasKey = value;
            }
        }


        public string m_ReplaceCode = null;
        /// <summary>
        /// 页面上替换的串
        /// </summary>
        public string ReplaceCode
        {
            get
            {
                return m_ReplaceCode;
            }
            set
            {
                m_ReplaceCode = value;
            }
        }



    }
}
