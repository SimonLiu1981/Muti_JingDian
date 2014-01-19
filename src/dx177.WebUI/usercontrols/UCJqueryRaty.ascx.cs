using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dx177.WebUI.usercontrols
{
    public partial class UCJqueryRaty : System.Web.UI.UserControl
    {
        public decimal Score
        {
            get
            {
                if (Scv.Value == "")
                {
                    Scv.Value = DefaultValue.ToString("0.0");
                }
                return decimal.Parse(Scv.Value);
            }
            set
            {
                Scv.Value = value.ToString("0.0");
            }
        }

        public decimal DefaultValue
        {
            get
            {
                if (ViewState["DefaultValue"] == null)
                    return 4;
                else
                {
                    return (decimal)ViewState["DefaultValue"];
                }
            }
            set
            {
                ViewState["DefaultValue"] = value;
            }
        }
        public bool ReadOnly
        {
            get
            {
                if (ViewState["ReadOnly"] == null)
                    return false;
                else
                {
                    return (bool)ViewState["ReadOnly"];
                }
            }
            set
            {
                ViewState["ReadOnly"] = value;
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UCJqueryRaty", "<script type=\"text/javascript\" src=\"" + this.ResolveUrl("~/Plugin/jquery.raty-1.3.2/js/jquery.raty.min.js") + "\"></script>");            
            
        
        }
    }
}