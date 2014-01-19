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
using System.Net;
using System.IO;
using System.Text;

namespace dx177.WebUI.js.ZhunaAPI
{
    public partial class hotelprice : System.Web.UI.Page
    {
        string jstring;
        private string hid
        {
            get
            {
                return Request.QueryString["hid"];
            }
        }

        private string tm2
        {
            get
            {
                return Request.QueryString["tm2"];
            }
        }

        private string tm1
        {
            get
            {
                return Request.QueryString["tm1"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string url = "http://www.api.zhuna.cn/e/json.php?hid={0}&tm1={1}&tm2={2}&orderfrom=0";

            try
            {
                url = string.Format(url, hid, tm1, tm2);
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                jstring = reader.ReadToEnd();
            }
            catch
            {
                jstring = "{Error:1}";
            }

            if (!string.IsNullOrEmpty(this.Request["callback"]))
            {
                this.Response.Write(this.Request["callback"] + "(" + jstring + ")");
            }

            else
            {
                this.Response.Write(jstring);
            }            

        }
    }
}
