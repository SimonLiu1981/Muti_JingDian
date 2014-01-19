using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class TreeDataMod : XmlTableMod
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

        /// <summary>
        /// 
        /// </summary>
        private string m_Sql = null;
        public string Sql
        {
            get
            {
                return m_Sql;
            }
            set
            {
                m_Sql = value;
            }
        }

        /// <summary>
        /// 父
        /// </summary>
        private string m_ParentHasKey = null;
        public string ParentHasKey
        {
            get
            {
                return m_ParentHasKey;
            }
            set
            {
                m_ParentHasKey = value;
            }
        }

    }
}
