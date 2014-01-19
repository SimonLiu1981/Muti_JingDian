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
using dx177_building;
using dx177.Business.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.web.hotelorder
{
    public partial class orderlist : System.Web.UI.Page
    {
        public string footer = "";
        public string top = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            top = BuildCommon.GetHTML("~/Templates/xml/hotel/s头部.html");
            footer = BuildCommon.GetHTML("~/Templates/xml/hotel/底部.html");

            top = top.Replace("|网站标题|", "旅游问答_攻略_交通_路线_饮食_酒店预订：游酷网是您最佳选择").Replace("|网站内容|", "旅游问答_攻略_交通_路线_饮食_酒店预订：游酷网是您最佳选择").Replace("|首页关键字|", "旅游问答_攻略_交通_路线_饮食_酒店预订：游酷网是您最佳选择");

        }

        protected void bntsearch_Click(object sender, EventArgs e)
        {
            Repeater1.DataSource = HotelorderBLL.GetInstance().Search(ComSafe.SafeValue( txtName.Text),ComSafe.SafeValue( txtMobile.Text));
            Repeater1.DataBind();
        }
    }
}
