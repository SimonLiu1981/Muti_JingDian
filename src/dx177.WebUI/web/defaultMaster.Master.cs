using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Text;
using dx177.Model;

namespace dx177.WebUI.web
{
    public partial class defaultMaster : System.Web.UI.MasterPage
    {
        string _NavId = "index";
        public string NavId
        {
            get
            {
                return _NavId;
            }
            set
            {
                _NavId = value;
            }
        }
        string m_title = System.Configuration.ConfigurationManager.AppSettings["PageTitle"];

        public void Title(string title, bool rewrite)
        {
            if (rewrite)
            {
                m_title = title;
            }
            else
            {
                m_title = title + m_title;
            }
        }

        string m_description = System.Configuration.ConfigurationManager.AppSettings["PageKeywords"];
        public void  Description(string desc, bool rewrite)
        {
            if (rewrite)
            {
                m_description = desc;
            }
            else
            {
                m_description = desc + m_description;
            }
        }

        string m_keywords = System.Configuration.ConfigurationManager.AppSettings["PageDescription"];
        public void Keywords(string key,bool rewrite)
        {
            if (rewrite)
            {
                m_keywords = key;
            }
            else
            {
                m_keywords = key + m_keywords;
            }
        }
        public string strFriend = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.Header.Title = m_title;            

            //HtmlMeta keywords = new HtmlMeta();
            //keywords.Name = "keywords";            
            //keywords.Content = m_keywords;
            //Page.Header.Controls.Add(keywords);

            //HtmlMeta description = new HtmlMeta();
            //description.Name = "description";
            //description.Content = m_description;
            //Page.Header.Controls.Add(description);

            DataTable dt=  FriendlinkBLL.GetInstance().GetFriendlinkList("", AppContext.JingQuCode);
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("  <a  target='_blank' href='{0}'>{1}</a>", dr["link"].ToString(), dr["title"].ToString());
            }
            strFriend = sb.ToString();
        }
    }
}
