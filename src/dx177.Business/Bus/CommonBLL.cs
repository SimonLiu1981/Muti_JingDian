using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using dx177.Model.Bus;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using dx177.FrameWork;
using System.Collections;

namespace dx177.Business.Bus
{
    public class CommonBLL
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: CommentBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected CommonBLL()
        {
        }
        private static volatile CommonBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 CommentBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static CommonBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(CommonBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new CommonBLL();
                    }
                }
            }

            // 返回业务逻辑对象
            return m_instance;
        }

        #endregion

        public DataTable GetSyscodeMap(string type)
        {
            string sql =string.Format(" select * from SysCodeMap  where type='{0}'" ,type) ;
            DataTable dt = CommentBLL.GetInstance().GetDataTable(sql);
            return dt;
        }


        private PageKeyWord TitleByXmlCode(string xmlpath, string code)
        {
            PageKeyWord k = new PageKeyWord();
            XmlDocument xd = new XmlDocument();
            xd.Load(xmlpath);
            XmlNode nls = xd.SelectSingleNode(string.Format("//KeywordItems//Keyword[@code='{0}']", code));
            if (nls != null)
            {
                k.Title = nls.Attributes["title"].Value.ToString();
                k.KeyWord = nls.Attributes["keyword"].Value.ToString();
                k.Description = nls.Attributes["descrion"].Value.ToString();

            }            
            return k;
        }

        public  PageKeyWord TitleByXmlCode(string code)
        {
            string p = HttpContext.Current.Server.MapPath("~/Keyword.xml");
            return TitleByXmlCode(p, code);
        }



        /// <summary>
        /// 利用正规表达示提花标题里的属性字段
        /// </summary>
        /// <param name="p"></param>
        /// <param name="code"></param>
        /// <param name="replaceObject">参数new {属性字段=""}</param>
        public void IniPageKeyWord(Page p, string code, Hashtable has)
        {
            PageKeyWord pk = TitleByXmlCode(code);

            foreach (DictionaryEntry item in has)
            {
                pk.Title = pk.Title.Replace("#?" + item.Key.ToString() + "?#", item.Value.ToString());
                pk.KeyWord = pk.KeyWord.Replace("#?" + item.Key.ToString() + "?#", item.Value.ToString());
                pk.Description = pk.Description.Replace("#?" + item.Key.ToString() + "?#", item.Value.ToString());
            }

            
            p.Header.Title = pk.Title;
            HtmlMeta keywords = new HtmlMeta();
            keywords.Name = "keywords";
            keywords.Content = pk.KeyWord;
            p.Header.Controls.Add(keywords);
            HtmlMeta description = new HtmlMeta();
            description.Name = "description";
            description.Content = pk.Description;
            p.Header.Controls.Add(description);
        }


 
        /// <summary>
        /// 利用正规表达示提花标题里的属性字段
        /// </summary>
        /// <param name="p"></param>
        /// <param name="code"></param>
        /// <param name="replaceObject">参数new {属性字段=""}</param>
        public void IniPageKeyWord(Page p, string code, object replaceObject)
        {
           
            PropertyMapper mp = new PropertyMapper(replaceObject);
            PageKeyWord pk = TitleByXmlCode(code);
            string stitle = mp.MapContent(pk.Title);
            string skeywords = mp.MapContent(pk.KeyWord);
            string sdescription = mp.MapContent(pk.Description);
            p.Header.Title = stitle;
            HtmlMeta keywords = new HtmlMeta();
            keywords.Name = "keywords";
            keywords.Content = skeywords;
            p.Header.Controls.Add(keywords);
            HtmlMeta description = new HtmlMeta();
            description.Name = "description";
            description.Content = sdescription;
            p.Header.Controls.Add(description);
        }
    }
}
