using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dx177.WebUI.Wap
{
    public partial class msg : System.Web.UI.Page
    {
        public string BackUrl = "default.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["tourl"] != "")
            {
                BackUrl = Request.QueryString["tourl"];
            }
        }
    }
}
