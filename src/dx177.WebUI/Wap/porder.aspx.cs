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
using dx177.Business.Bus;

namespace dx177.WebUI.Wap
{
    public partial class porder : System.Web.UI.Page
    {
        protected Products p = new Products();

        protected string productid
        {
            get
            {
                return Request.QueryString["productid"];
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
             
            //if (Session["client_user_name"] != null)
            //{
            //    UserName = Session["client_user_name"].ToString();
            //}
            //if (Session["client_user_phone"] != null)
            //{
            //    UserPhone = Session["client_user_phone"].ToString();
            //}
            p = ProductsBLL.GetInstance().Get(new Products.Key(int.Parse(productid)));
          
          
        }
    }
}
