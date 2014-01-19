using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class CycleDataMod
    {
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
        /// 层
        /// </summary>
        private int m_Layer = 0;
        public int Layer
        {
            get
            {
                return m_Layer;
            }
            set
            {
                m_Layer = value;
            }
        }

        /// <summary>
        /// 层
        /// </summary>
        private int m_LastLayer = 0;
        public int LastLayer
        {
            get
            {
                return m_LastLayer;
            }
            set
            {
                m_LastLayer = value;
            }
        }

        /// <summary>
        /// 层
        /// </summary>
        private int m_FirstLayer = 0;
        public int FirstLayer
        {
            get
            {
                return m_FirstLayer;
            }
            set
            {
                m_FirstLayer = value;
            }
        }


        /// <summary>
        /// 元素的HTML
        /// </summary>
        private string m_CellHtml = null;
        public string CellHtml
        {
            get
            {
                return m_CellHtml;
            }
            set
            {
                m_CellHtml = value;
            }
        }

        /// <summary>
        /// 行的HTML
        /// </summary>
        private string m_RowHtml = null;
        public string RowHtml
        {
            get
            {
                return m_RowHtml;
            }
            set
            {
                m_RowHtml = value;
            }
        }


    }
}
