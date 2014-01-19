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
using dx177.Model.Bus.QueryO;
using System.Collections.Generic;

namespace dx177.WebUI.Wap
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            decimal MinPrice = 110;
            decimal MaxPrice = 1000;
            Resuser aaa = new Resuser();
            if (Request.QueryString["jsr"] != null)
            {
                aaa = ResuserBLL.GetInstance().GetResuserByUserDomain(Request.QueryString["jsr"]);
            }
            if (aaa == null)
            {
                aaa = new Resuser();
            }
            DataTable dt = HotelBLL.GetInstance().SearchMoblieData(4,MinPrice, MaxPrice, aaa.Username);
            rphotel.DataSource = dt;
            rphotel.DataBind();
              MinPrice = 0;
              MaxPrice = 100;
              DataTable dt1 = HotelBLL.GetInstance().SearchMoblieData(4, MinPrice, MaxPrice, aaa.Username);

            rpcphotel.DataSource = dt1;
            rpcphotel.DataBind();


            HireCarQuery query = new HireCarQuery();
            IList<Hirecar> harr = HirecarBLL.GetInstance().Search(4,query);
            rphire.DataSource = harr;
            rphire.DataBind();

            DataTable dt2 = ProductsBLL.GetInstance().GetableByType(6);
            rplist.DataSource = dt2;
            rplist.DataBind();
            
          
        }
    }
}
