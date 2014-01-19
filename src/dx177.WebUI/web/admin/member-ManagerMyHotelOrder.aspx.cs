using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.DictBus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_ManagerMyHotelOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dict.Tag.BindListControl(this.rbtStatus, "HotelOrderStatus", AppContext.JingQuCode);
                InitData();
            }
        }

        private void InitData()
        {
            if (!String.IsNullOrEmpty(Request.QueryString["seqno"]))
            {
                Hotelorder order = HotelorderBLL.GetInstance().Get(new Hotelorder.Key(int.Parse(Request.QueryString["seqno"])));
                if (order != null)
                {

                    lblBegin.Text = order.Begindate.ToString("yyyy-MM-dd");
                    lblContent.Text = order.Content;
                    lblCreatedate.Text = order.CreateDate.ToString("yyyy-MM-dd");
                    lblEnd.Text = order.Enddate.ToString("yyyy-MM-dd");
                    lblHoteltiel.Text = order.Hotelname;
                    lblNights.Text = (order.Enddate - order.Begindate).Days.ToString();
                    lblOrderno.Text = order.Orderno;
                    lblOrderusername.Text = order.Orderusername;
                    lblOrderuserphone.Text = order.Orderuserphone;
                    lblPersonName.Text = order.Personname;
                    lblPersonPhone.Text = order.Orderuserphone;
                    lblReachDate.Text = order.Reachdate;
                    lblRoomCount.Text = order.Roomcount.ToString();
                    lblRoomtitle.Text = order.Roomtitle;
                    rbtStatus.SelectedValue = order.Status.ToString();
                    lblTotalMoney.Text = order.Totalmoney.ToString();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            Hotelorder order = HotelorderBLL.GetInstance().Get(new Hotelorder.Key(int.Parse(Request.QueryString["seqno"])));
            if (order != null)
            {
                order.Status = int.Parse(rbtStatus.SelectedValue);
                HotelorderBLL.GetInstance().SubmitOrder(order);
            }
            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefashData();parent.tb_remove();});</script>");
        }
    }
}
