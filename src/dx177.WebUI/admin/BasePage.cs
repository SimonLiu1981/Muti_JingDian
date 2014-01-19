using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dx177.Model;
using dx177.FrameWork;

namespace dx177.WebUI.admin
{
    public class BasePage : System.Web.UI.Page
    {
        public bool IsSupperAdmin()
        {
            if (AppContext.CurrentResuser == null)
            {
                return false;
            }
            else  
            {
                if (AppContext.CurrentResuser.Usertype == ResUserType.SupperAdmin.ToString("d"))
                {
                    //管理员才可以进入
                    return true;
                }
                else
                {                    
                    return false;
                }
            }
        }

        protected override void OnInit(EventArgs e)
        {

            if (AppContext.CurrentResuser == null)
            {
                Logout();
                return;
            }
            else
            {
                if (AppContext.CurrentResuser.Usertype == ResUserType.SupperJingQqAdmin.ToString("d")
                    || AppContext.CurrentResuser.Usertype == ResUserType.SupperAdmin.ToString("d"))
                {
                    //管理员才可以进入
                }
                else
                {
                    Logout();
                    return;
                }
            }

            base.OnInit(e);


        }
        protected void Logout()
        {
            AppContext.CurrentResuser = null;
            string url = Page.ResolveUrl("~/Admin/login.aspx");
            Response.Write(string.Format("<script> top.location.href='{0}';</script>", url));
            Response.End();
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Msg", string.Format("<script> top.location.href='{0}';</script>", url));

        }

        /// <summary>
        /// 判断权限 
        /// </summary>
        public void CheckRight()
        {
            if (AppContext.CurrentResuser == null)
            {
                string s = Page.ResolveUrl("~/Admin/login.aspx");
                Response.Write("<SCRIPT> top.location.href='" + s + "'; </SCRIPT>");
            }
        }

    }
}
