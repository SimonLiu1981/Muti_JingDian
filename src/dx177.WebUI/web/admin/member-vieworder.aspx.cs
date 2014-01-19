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
    public partial class member_vieworder : System.Web.UI.Page
    {
        private string seqno
        {
            get
            {
                return Request.QueryString["seqno"];
            }
        }
        Hotelorder _HOrder = new Hotelorder();
        protected Hotelorder HOrder
        {
            get { return _HOrder; }
            set { _HOrder = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!string.IsNullOrEmpty(seqno))
            {
                HOrder = HotelorderBLL.GetInstance().Get(new Hotelorder.Key(int.Parse(seqno)));
                
            }
                
 
        }
    }
}
