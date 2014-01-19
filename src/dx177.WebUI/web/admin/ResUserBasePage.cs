using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dx177.Model;
using dx177.FrameWork;

namespace dx177.WebUI.web.admin
{
    public class ResUserBasePage : System.Web.UI.Page
    {
        protected string SesstionTimeOutMessage = "";


        protected override void OnInit(EventArgs e)
        {
            if (AppContext.CurrentResuser == null)
            {
                Logout();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(AppContext.CurrentResuser.Jingqucode))
                {
                    Logout();
                    return;
                }
            }
            base.OnInit(e);
        }

         

        protected void Logout()
        {
            string url = UrlUtility.AddOrReplaceParam("/login/default.aspx", "r", Request.RawUrl, true);
            AppContext.CurrentResuser = null;
            Response.Write("<script> top.location.href='" + url + "';</script>");
            Response.End();
        }
    }
}
