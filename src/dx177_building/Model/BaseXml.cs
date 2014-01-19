using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class BaseXml
    {
        /// <summary>
        /// 缓存存储的值
        /// </summary>
        private string m_SaveHashKeyCode = null;
        public string SaveHashKeyCode
        {
            get
            {
                return m_SaveHashKeyCode;
            }
            set
            {
                m_SaveHashKeyCode = value;
            }
        }

        /// <summary>
        /// 路径
        /// </summary>
        private string m_XmlPath = null;
        public string XmlPath
        {
            get
            {
                return m_XmlPath;
            }
            set
            {
                m_XmlPath = value;
            }
        }
    }
}
