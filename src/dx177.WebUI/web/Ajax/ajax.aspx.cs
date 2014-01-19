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
using dx177.WebUI.web.shopcar;
using dx177.Model.Bus;
using dx177.Business.Bus;
using System.Collections.Generic;

namespace dx177.WebUI.web.Ajax
{
    public partial class ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(ajax));
          
        }

        [AjaxPro.AjaxMethod]
        public object ModifyProducts(string productid, int count)
        {

            ShoppingCarHelper.ModifyProducts(productid, count);
            return new { totalamout = ShoppingCarHelper.TotalAmount.ToString() };
        }

        [AjaxPro.AjaxMethod]
        public bool RemoveProducts(string productid)
        {
            return ShoppingCarHelper.RemoveProducts(productid);
        }


        [AjaxPro.AjaxMethod]
        public object SubmitOrder(OrderApply para)
        {
             
            OrderApply obj = new OrderApply();
            //obj.ResUserNo = AppContext.CurrentResUser.UserNo;//注册账号
            obj.ReceiveName = para.ReceiveName;
            obj.ReceivePhone = para.ReceivePhone;
            obj.ReceiveTel = para.ReceiveTel;
            obj.CreateDate = DateTime.Now;
            obj.Remark = para.Remark;
            obj.ReceiveEmail = para.ReceiveEmail;
            // obj.State = ShoppingCarHelper.MyUseraddressinfoEn.State;
            // Paymentapi p = PaymentapiBLL.GetInstance().Get(new Paymentapi.Key(PaymentId));
            obj.Shipment = "送到景点";
            obj.Mypayment = "货到付款"; ;

            //obj.Remark = txtRemark.Text;
            obj.ProductSeller = "temp";
            obj.OrderStatus = 1;
            obj.ProductTMoney = Convert.ToDouble(ShoppingCarHelper.TotalAmount);
            obj.MailMoney = obj.MailMoney;
            obj.TotalMoney = obj.ProductTMoney + obj.MailMoney;
            obj.ReceiveAddress1 = "ip:" + HttpContext.Current.Request.UserHostAddress;
            obj.ReceiveAddress = obj.ReceiveAddress;

            OrderApplyBLL.GetInstance().Submit(obj, ShoppingCarHelper.MyChoseProducts);
            ShoppingCarHelper.MyChoseProducts = new List<ShoppingCarEntriy>();//提交后清购物车列表
            return "{OrderSeqno:2,Success:true,MypaymentId:1}";
        }

    }
}
