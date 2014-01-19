using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.web.usercontrols
{
    public partial class home_hotel_2 : System.Web.UI.UserControl
    {
        private string m_ModuleCode;
        public string ModuleCode
        {
            get
            {
                return m_ModuleCode;
            }
            set
            {
                m_ModuleCode = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Hotel> res = HotelBLL.GetInstance().Font_Search(this.ModuleCode);
            
            Repeater1.DataSource = res;
            Repeater1.DataBind();
        }
    }
}