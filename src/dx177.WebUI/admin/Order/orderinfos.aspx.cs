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
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.admin.Order
{
    public partial class orderinfos : BasePage
    {
        public string Order_Apply_ID
        {
            get
            {
                if (Request.QueryString["Order_Apply_ID"] != null)
                {
                    return Request.QueryString["Order_Apply_ID"];
                }
                return "0";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IniData();
        }

        private void IniData()
        {
            OrderApply o=OrderApplyBLL.GetInstance().Get(new dx177.Model.Bus.OrderApply.Key(int.Parse(this.Order_Apply_ID)));
            lbMailMoney.Text = o.MailMoney.ToString();
            lbMypayment.Text = o.Mypayment;
            lbOrderTitle.Text = o.OrderTitle;
            lbProductTMoney.Text=o.ProductTMoney.ToString();
            lbReceivePhone.Text=o.ReceivePhone ;
            lbReceiveTel.Text=o.ReceiveTel ;
            lbShipment.Text=o.Shipment ;
            lbTotalMoney.Text=o.TotalMoney.ToString() ;
            lbRemark.Text= o.Remark;
            lbReceiveAddress.Text= o.ReceiveAddress;
            DataTable dt=  OrderApplyItemBLL.GetInstance().GetData(o.OrderApplyId);
           dgNews.Data = dt;
           dgNews.DataBind();
        }
    }
}
