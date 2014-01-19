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

namespace dx177.WebUI.usercontrols
{
    public partial class SiteView : System.Web.UI.UserControl
    {
        public string jingqucode
        {
            get
            {
                if (ViewState["jingqucode"] != null)
                {
                    return ViewState["jingqucode"].ToString();
                }
                return string.Empty;
            }
            set
            {
                ViewState["jingqucode"] = value;
            }
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           DataTable dt = SitesBLL.GetInstance().GetHotSite(this.jingqucode);

        }
    }
}