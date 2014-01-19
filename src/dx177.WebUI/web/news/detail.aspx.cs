using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.web.news
{
    public partial class detail : System.Web.UI.Page
    {

        public News n = new News();
        public int Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] != null)
                {
                    return int.Parse(Request.QueryString["seqno"]);
                }
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            ((defaultMaster)Page.Master).NavId = "news";
            
            IniData();

            Newstype type1 = NewstypeBLL.GetInstance().GetNewstypeByguid(n.Tguid);
            //SEO 优化
            string typename = type1 != null ? type1.Title : "";

            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "newsdetail", new { TypeName = typename,Title = n.Title });
        }

        private void IniData()
        {
            n = NewsBLL.GetInstance().Get(new News.Key(this.Seqno));
            AddViewTimes(n);
        }

        public int AddViewTimes(News Rest)
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                NewsBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
            }
        }


       

    }
}
