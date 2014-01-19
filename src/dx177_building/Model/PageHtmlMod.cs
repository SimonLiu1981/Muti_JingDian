using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI ;
using System.Web.SessionState;
namespace dx177_building.Model
{
    [Serializable]
    public class PageHtmlMod
    {
        string m_BaseXmlPath = "";
        public string BaseXmlPath
        {
            get
            {
                return m_BaseXmlPath;
            }
            set
            {
                m_BaseXmlPath = value;
            }
        }
        /// <summary>
        /// 静态页面的路径和替换代码数
        /// </summary>
        ChildHtmlMod[] M_ChildHtml = null;
        public ChildHtmlMod[] ChildHtmls
        {
            get
            {
                return M_ChildHtml;
            }
            set
            {
                M_ChildHtml = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        DataHtmlMod[] M_DataHtmlMod = null;
        public DataHtmlMod[] DataHtmlMods
        {
            get
            {
                return M_DataHtmlMod;
            }
            set
            {
                M_DataHtmlMod = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        HashDataMod[] M_HashDataMod = null;
        public HashDataMod[] HashDataMods
        {
            get
            {
                return M_HashDataMod;
            }
            set
            {
                M_HashDataMod = value;
            }
        }


        /// <summary>
        /// 继承基础XML
        /// </summary>
        BaseXml[] M_BaseXmls = null;
        public BaseXml[] BaseXmls
        {
            get
            {
                return M_BaseXmls;
            }
            set
            {
                M_BaseXmls = value;
            }
        }


        /// <summary>
        /// 循环XML
        /// </summary>
        PageCycleMod[] M_CycleMod = null;
        public PageCycleMod[] PageCycleMods
        {
            get
            {
                return M_CycleMod;
            }
            set
            {
                M_CycleMod = value;
            }
        }

        /// <summary>
        /// 树形
        /// </summary>
        PageCycleMod[] M_TreeMod = null;
        public PageCycleMod[] TreeMods
        {
            get
            {
                return M_TreeMod;
            }
            set
            {
                M_TreeMod = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        string m_MainPageHtml = "";
        public string MainPageHtml
        {
            get
            {
                return m_MainPageHtml;
            }
            set
            {
                m_MainPageHtml = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        string m_SavePath = "";
        public string SavePath
        {
            get
            {
                return m_SavePath;
            }
            set
            {
                m_SavePath = value;
            }
        }

    }
}
