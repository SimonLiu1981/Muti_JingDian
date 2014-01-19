using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.Wap
{
    public partial class book : System.Web.UI.Page
    {
        protected Hotel HT = new Hotel();
        protected Room RM = new Room();

        protected string RoomID
        {
            get
            {
                return Request.QueryString["roomid"];
            }
        }
        protected string TodayString = "";
        protected string UserName = "";
        protected string UserPhone = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            TodayString = DateTime.Now.ToString("yyyy-MM-dd");
            if (Session["client_user_name"] != null)
            {
                UserName = Session["client_user_name"].ToString();
            }
            if (Session["client_user_phone"] != null)
            {
                UserPhone = Session["client_user_phone"].ToString();
            }
            RM = RoomBLL.GetInstance().Get(new Room.Key(int.Parse(RoomID)));
            HT = HotelBLL.GetInstance().GetHotelByGuid(RM.Pguid);
        }
    }
}
