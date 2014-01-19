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
using dx177.Business.Bus;

namespace dx177.WebUI.Control
{
    public partial class SiteLeft : System.Web.UI.UserControl
    {
        public string jingqucode
        {
            get
            {
                if (Request["jingqucode"] != null)
                {
                    return Request["jingqucode"].ToString();
                }
                return string.Empty;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = SitesBLL.GetInstance().GetLeftSite(this.jingqucode);
            rpt.DataSource = dt;
            rpt.DataBind();
        }
    }
}