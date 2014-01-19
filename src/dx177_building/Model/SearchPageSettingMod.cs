using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.SessionState;

namespace dx177_building.Model
{
    [Serializable]
   public class SearchPageSettingMod
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
       string M_PageButtonXmlPath = null;
       public string PageButtonXmlPath
       {
           get
           {
               return M_PageButtonXmlPath;
           }
           set
           {
               M_PageButtonXmlPath = value;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       string M_PageButtonCode = null;
       public string PageButtonCode
       {
           get
           {
               return M_PageButtonCode;
           }
           set
           {
               M_PageButtonCode = value;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       string M_TableListPath = null;
       public string TableListPath
       {
           get
           {
               return M_TableListPath;
           }
           set
           {
               M_TableListPath = value;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       string M_TableListReplaceCode = null;
       public string TableListReplaceCode
       {
           get
           {
               return M_TableListReplaceCode;
           }
           set
           {
               M_TableListReplaceCode = value;
           }
       }

       /// <summary>
       /// 字段的值必须带{0} 如果c:\productsearch{0}.htm
       /// </summary>
       string M_SavePatch = null;
       public string SavePatch
       {
           get
           {
               return M_SavePatch;
           }
           set
           {
               M_SavePatch = value;
           }
       }
    }
}
