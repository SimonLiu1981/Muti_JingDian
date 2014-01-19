using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace dx177.WebUI.Wap
{
    public class WapBasePage
    {
        private static volatile WapBasePage m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 WapBasePage 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static WapBasePage GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(WapBasePage))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new WapBasePage();
                    }
                }
            }
            // 返回业务逻辑对象
            return m_instance;
        }

        public string GetUserName()
        {
            string OriginalString = HttpContext.Current.Request.Url.OriginalString;
            OriginalString = OriginalString.Replace("http://", "");
            string[] strarr = OriginalString.Split('/');
            if (strarr.Length >= 2)
            {
                return strarr[1];
            }
            return string.Empty;
        }
    }
}
