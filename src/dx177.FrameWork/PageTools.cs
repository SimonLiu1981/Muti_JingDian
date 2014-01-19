

// 系统引用
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Mail;
using System.IO;
using System.Text;
using System.Xml;



namespace dx177.FrameWork
{
    public class PageTools
    {
        private System.Web.UI.Page ThisPage;
        public readonly static Color g_clrError = Color.SkyBlue;
        public readonly static Color g_clrNormal = Color.White;

        public PageTools(System.Web.UI.Page thispage)
        {
            ThisPage = thispage;
        }


        public static  void AddTitle(System.Web.UI.Page page,string code, string title,string keyword,string  descr)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(Path.Combine(page.Server.MapPath("/"), "Keyword.xml"));
            XmlNode nls = xd.SelectSingleNode(string.Format("//KeywordItems//Keyword[@code='{0}']", code));
            if (nls != null)
            {
                page.Title = nls.Attributes["title"].Value.ToString();
                //HtmlMeta metaKeywords = new HtmlMeta();
                //metaKeywords.Name = xmlnode.Attributes["title"].ToString();
                //metaKeywords.Content = xmlnode.Attributes["descrion"].ToString();
                HtmlMeta sdescription = new HtmlMeta();
                sdescription.Name = "description";
                sdescription.Content = nls.Attributes["descrion"].Value.ToString();
                HtmlHead head = page.Header;
                //head.Controls.Add(metaKeywords);
                head.Controls.Add(sdescription);
            }       
        }

		//以弹出式显示窗体
        //修改记录1
		public static string OpenWin(string url)
		{
			string urlOpen  = "<script>window.open('" + url + "','','resizable=yes,scrollbars=yes,status=yes,toolbar=no,menubar=no,location=no,width=800,height=600,left=60,top=60'); </script>";
			return urlOpen;
		}

		//以弹出式显示窗体
        //修改记录1
		public static string OpenWin(string url,int width, int height)
		{
			string urlOpen  = "<script>var win = window.open('" + url + "','window','resizable=yes,scrollbars=yes,status=yes,toolbar=no,menubar=no,location=no,width=" + width + ",height="+height+",left=60,top=60'); win.focus();</script>";
			return urlOpen;
		}

        public void SavePageScrollPosition()
        {
            StringBuilder saveScrollPosition = new StringBuilder();
            StringBuilder setScrollPosition = new StringBuilder();

            ThisPage.RegisterHiddenField("__SCROLLPOS", "0");

            saveScrollPosition.Append("<script language='javascript'>"); 
            saveScrollPosition.Append("function saveScrollPosition() {");   
            saveScrollPosition.Append(" document.forms[0].__SCROLLPOS.value = thebody.scrollTop;");
            saveScrollPosition.Append("}");
            saveScrollPosition.Append("thebody.onscroll=saveScrollPosition;");
            saveScrollPosition.Append("</script>");

            ThisPage.RegisterStartupScript("saveScroll", saveScrollPosition.ToString());

            if (ThisPage.IsPostBack)
            {
                setScrollPosition.Append("<script language='javascript'>");   
                setScrollPosition.Append("function setScrollPosition() {");   
                setScrollPosition.Append(" thebody.scrollTop = " + ThisPage.Request["__SCROLLPOS"] + ";");   
                setScrollPosition.Append("}");   
                setScrollPosition.Append("thebody.onload=setScrollPosition;");   
                setScrollPosition.Append("</script>");   
				 
                ThisPage.RegisterStartupScript("setScroll", setScrollPosition.ToString());   
            }  
        }
		
		/// <summary>
		/// 弹出消息窗口
		/// </summary>
		/// <param name="page">页面</param>
		/// <param name="message">消息</param>
		public static void ShowMessage(System.Web.UI.Page page, string message)
		{
			StringBuilder strMessage = new StringBuilder();
			strMessage.Append("<script language='javascript'>");
			//strMessage.Append("msg ='"+message+"';\n");
			strMessage.Append("alert('"+message+"');");		
			strMessage.Append("</script>");

			page.RegisterStartupScript("ShowMessage" + DateTime.Now.Ticks.ToString(), strMessage.ToString());
		}

        /// <summary>
        /// 弹出消息窗口
        /// </summary>
        /// <param name="page">页面</param>
        public static void CloseWindow(System.Web.UI.Page page)
        {
            StringBuilder strCommand = new StringBuilder();
            strCommand.Append("<script language='javascript'>\n");
            strCommand.Append("window.close();\n");		
            strCommand.Append("</script>");

            page.RegisterStartupScript("closeWindow" + DateTime.Now.Ticks.ToString(), strCommand.ToString());
        }

		/// <summary>
		/// 确认窗口
		/// </summary>
		/// <param name="url">页面</param>
		/// <param name="message">消息</param>
		public static string ConfirmMessage(string message,string url)
		{
			StringBuilder strMessage = new StringBuilder();
			strMessage.Append("<script>");
			strMessage.Append("msg ='"+message);
			strMessage.Append("';\nfunction GoUrl(){location.href = '");
			strMessage.Append(url + "';}");
			strMessage.Append("if (confirm(msg)) window.setTimeout(GoUrl,500);" );	
			strMessage.Append("</script>");	
			return strMessage.ToString();
		}

		/// <summary>
		/// 对给定的值在列表控件ListControl中进行定位.
		/// </summary>
		static public void SetListControl(ListControl ddlst, string selectedValue)
		{
			ListItem oListItem = ddlst.Items.FindByValue(selectedValue);
			if (oListItem != null)
			{
				ddlst.SelectedValue = selectedValue;
			}
		}

		/// <summary>
		/// 对给定的值在列表控件ListControl中进行定位.
		/// </summary>
		static public void SetListControl(HtmlSelect ddlst, string selectedValue)
		{
			ListItem oListItem = ddlst.Items.FindByValue(selectedValue);
			if (oListItem != null)
			{
				oListItem.Selected = true;
			}
		}
    }
}
