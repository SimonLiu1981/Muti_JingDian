using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dx177.WebUI.Wap
{
    public partial class srh_order : System.Web.UI.Page
    {
        protected string UserName = "";
        protected string UserPhone = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["client_user_name"] != null)
            {
                UserName = Session["client_user_name"].ToString();
            }
            if (Session["client_user_phone"] != null)
            {
                UserPhone = Session["client_user_phone"].ToString();
            }
        }
    }
}
