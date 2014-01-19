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
    public partial class order_info : System.Web.UI.Page
    {
        protected Hotel HT = new Hotel();
        protected Room RM = new Room();
        protected Hotelorder HO = new Hotelorder();

        protected void Page_Load(object sender, EventArgs e)
        {
            HO = HotelorderBLL.GetInstance().Get(new Hotelorder.Key(int.Parse(Request.QueryString["id"])));
            RM = RoomBLL.GetInstance().Get(new Room.Key(HO.Roomseqno));
            HT = HotelBLL.GetInstance().Get(new Hotel.Key(HO.Hotelseqno));
        }
    }
}
