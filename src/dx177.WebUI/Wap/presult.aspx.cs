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
using dx177.WebUI.web.shopcar;
using dx177.Business.Bus;
using System.Collections.Generic;

namespace dx177.WebUI.Wap
{
    public partial class presult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SubmitOrder();
        }

        public string GetQueryFromvalue(string name)
        {
            string val = Request.QueryString[name] != null ? Request.QueryString[name] : Request.Form[name];
            return val;
        }

        public void SubmitOrder( )
        {
            ShoppingCarHelper.ModifyProducts(GetQueryFromvalue("txtproductid"), int.Parse(GetQueryFromvalue("txtcount")));

            OrderApply obj = new OrderApply();
            //obj.ResUserNo = AppContext.CurrentResUser.UserNo;//注册账号
            obj.ReceiveName =GetQueryFromvalue("txtReceiveName");
            obj.ReceivePhone =GetQueryFromvalue("txtReceivePhone");
            obj.ReceiveTel =GetQueryFromvalue("txtReceivePhone");  
            obj.CreateDate = DateTime.Now;
            obj.Remark ="手机预订："+ GetQueryFromvalue("txtRemark");  
            obj.ReceiveEmail ="";
            // obj.State = ShoppingCarHelper.MyUseraddressinfoEn.State;
            // Paymentapi p = PaymentapiBLL.GetInstance().Get(new Paymentapi.Key(PaymentId));
            obj.Shipment = "送到景点";
            obj.Mypayment = "货到付款"; ;
        
            //obj.Remark = txtRemark.Text;
            obj.ProductSeller = WapBasePage.GetInstance().GetUserName();
            obj.OrderStatus = 1;
            obj.ProductTMoney = Convert.ToDouble(ShoppingCarHelper.TotalAmount);
            obj.MailMoney = 0;
            obj.TotalMoney =double.Parse( ShoppingCarHelper.TotalAmount.ToString()  ) ;
            obj.ReceiveAddress1 = "";// "ip:" + HttpContext.Current.Request.UserHostAddress;
            obj.ReceiveAddress = GetQueryFromvalue("txtReceiveAddress");
            OrderApplyBLL.GetInstance().Submit(obj, ShoppingCarHelper.MyChoseProducts);
            ShoppingCarHelper.MyChoseProducts = new List<ShoppingCarEntriy>();//提交后清购物车列表
            
        }

    }
}
