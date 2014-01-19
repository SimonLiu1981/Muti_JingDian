using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.web
{
    public partial class Issue : System.Web.UI.Page
    {
        public string  strCode
        {
            get
            {
                if (Request.QueryString["code"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["code"]) ;
                }
                return "";
            }
        }
       public   BusIssueInfo IssueInfo = new BusIssueInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            IniData();
        }

        private void IniData()
        {
           IssueInfo = BusIssueInfoBLL.GetInstance().GetBusIssueInfo(this.strCode, AppContext.CurrentMgtJingQuCode);
        }
    }
}
