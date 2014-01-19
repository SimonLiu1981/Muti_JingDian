using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.web.admin
{
    public partial class member_regediter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "1") {
                    lblTitle.Text = "普通用户注册";
                    lblDesc.Text = "酒店预订用户在此注册。";
                }
                if (Request.QueryString["type"] == "2")
                {
                    lblTitle.Text = "企业用户注册";
                    lblDesc.Text = "租车信息发布用户在此注册。";
                }
                if (Request.QueryString["type"] == "3")
                {
                    lblTitle.Text = "企业用户注册";
                    lblDesc.Text = "餐饮信息发布用户在此注册。";
                }
                if (Request.QueryString["type"] == "4")
                {
                    lblTitle.Text = "企业用户注册";
                    lblDesc.Text = "酒店信息发布用户在此注册。";
                }

                
            }
            Repeater1.DataSource = JingqusBLL.GetInstance().Select();
            Repeater1.DataBind();
        }
    }
}
