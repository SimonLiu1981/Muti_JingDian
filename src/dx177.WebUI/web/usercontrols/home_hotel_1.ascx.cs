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
    public partial class home_hotel_1 : System.Web.UI.UserControl
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
            List<Hotel> res1 = new List<Hotel>();
            for (int i = 0; i < (res.Count > 3 ? 3 : res.Count); i++)
            {
                res1.Add(res[i]);
            }
            Repeater1.DataSource = res1;
            Repeater1.DataBind();
            Repeater2.DataSource = res;
            Repeater2.DataBind();
        }
    }
}