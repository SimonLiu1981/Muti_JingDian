using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace dx177_building.Model
{
    /// <summary>
    /// 静态页面的路径和代码
    /// </summary>
   [Serializable]
   public class ChildHtmlMod
   {
       /// <summary>
       /// 替换符
       /// </summary>
       private string m_RepalceCode = null;
       public string RepalceCode
       {
           get
           {
               return m_RepalceCode;
           }
           set
           {
               m_RepalceCode = value;
           }
       }

       /// <summary>
       /// 路径
       /// </summary>
       private string m_HtmlPath = null;
       public string HtmlPath
       {
           get
           {
               return  m_HtmlPath ;
           }
           set
           {
               m_HtmlPath = value;
           }
       }
   
   }
}
