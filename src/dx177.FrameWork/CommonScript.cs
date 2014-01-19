using System;
using System.Collections.Generic;
using System.Text;
namespace dx177.FrameWork
{
    public class CommonScript
    {

        public static void AlertMessage(System.Web.UI.Page page,string Msg)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Append("<script language='javascript'>");
            strMessage.Append("alert('" + Msg + "');");
            strMessage.Append("</script>");
            page.RegisterStartupScript("ShowMessage" + DateTime.Now.Ticks.ToString(), strMessage.ToString());
        }

        public static void ServiceScript(System.Web.UI.Page page, string JavaScript)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Append("<script language='javascript'>");
            strMessage.Append(JavaScript);
            strMessage.Append("</script>");
            page.RegisterStartupScript("ShowMessage" + DateTime.Now.Ticks.ToString(), strMessage.ToString());
        }

        public static void ResonseScript(System.Web.UI.Page page, string JavaScript)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Append("<script >");
            strMessage.Append(JavaScript);
            strMessage.Append("</script>");
            page.Response.Write(strMessage.ToString());
        }
    }
}
