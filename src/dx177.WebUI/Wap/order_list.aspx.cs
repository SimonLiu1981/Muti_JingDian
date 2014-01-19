using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model;

namespace dx177.WebUI.Wap
{
    public partial class order_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelOrderQuery query = new HotelOrderQuery();
            query.OrderPesonName = Request.Form["name"];
            query.OrderPesonPhone = Request.Form["tel"];

            IList < Hotelorder > res = HotelorderBLL.GetInstance().Search(query, AppContext.JingQuCode);
            rtOrder.DataSource = res;
            rtOrder.DataBind();
        }
    }
}
