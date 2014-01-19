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
using dx177.Model.Bus;

namespace dx177.WebUI.Wapper.hotel
{
    public partial class orderhotel : System.Web.UI.Page
    {
        Hotel h;
        public string hid
        {
            get
            {
                return Request.QueryString["hid"];
            }
        }


        public string rid
        {
            get
            {
                return Request.QueryString["rid"];
            }
        }

        public string pid
        {
            get
            {
                return Request.QueryString["pid"];
            }
        }


        public string tm1
        {
            get
            {
                return Request.QueryString["tm1"];
            }
        }
        public string tm2
        {
            get
            {
                return Request.QueryString["tm2"];
            }
        }

        public string agent_id
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["agent_id"];
            }
        }

        public string agent_md
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["agent_md"];
            }
        }

        protected override void OnInit(System.EventArgs e)
        {            
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
