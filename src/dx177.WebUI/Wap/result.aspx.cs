using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.Wap
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Request.QueryString["action"] == "load")
            {
                VerlOrder();
            }
            if (Request.QueryString["action"] == "onsubmit")
            {
                SubmitOrder();
            }
            
        }
        protected string OrderNO = "";
        protected string OrderSeqno = "";
        
        /// <summary>
        /// 提交订单
        /// </summary>
        private void SubmitOrder()
        {
          
            Hotelorder order = new Hotelorder();
            
            Hotel HT = new Hotel();
            Room RM = new Room();
            RM = RoomBLL.GetInstance().Get(new Room.Key(int.Parse(Request.QueryString["rid"])));
            HT = HotelBLL.GetInstance().GetHotelByGuid(RM.Pguid);
            order.Content = Request.QueryString["content"];

            order.Personname = Request.QueryString["name"];
            order.Personphone = Request.QueryString["tel"];
            order.Orderusername = Request.QueryString["name"];
            order.Orderuserphone = Request.QueryString["tel"];
            order.Begindate = DateTime.Parse(Request.QueryString["dateTime"]);
            order.Enddate = DateTime.Parse(Request.QueryString["dateTime"]).AddDays(1); ;

            order.Roomtitle = RM.Roomtitle;
            order.Roomseqno = RM.Seqno;
            order.Hotelname = HT.Name;
            //order.Referrall = Request.QueryString["jsr"];
            order.Hotelseqno = HT.Seqno;
            order.Reachdate = Request.QueryString["arrive"];
            order.Roomcount = int.Parse(Request.QueryString["n"]);
            order.Totalmoney = RM.Price1;
        
            order.Referrall = WapBasePage.GetInstance().GetUserName();
            order.Creator = WapBasePage.GetInstance().GetUserName();
            order.Ip = HttpContext.Current.Request.ServerVariables.Get("Remote_Addr").ToString();
            HotelorderBLL.GetInstance().SubmitOrder(order);
            OrderNO = order.Orderno;
            OrderSeqno = order.Seqno.ToString();
            Panel1.Visible = false;
            Panel2.Visible = true;
            
        }
        /// <summary>
        /// 验证订单
        /// </summary>
        /// <returns></returns>
        private string VerlOrder( )
        {
            string url = "";
            //验证
            if (Request.Form["dateTime"] == string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "订房日期没有输入，请重新填写！", true);
                url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                Response.Redirect(url);
            }
            else
            {
                try
                {
                    DateTime.Parse(Request.Form["dateTime"]);
                }
                catch (Exception ex)
                {
                    url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "订房日期格式输入有误，请重新填写！", true);
                    url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                    Response.Redirect(url);
                }
            }

            if (Request.Form["name"] == string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "姓名没有输入，请重新填写！", true);
                url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                Response.Redirect(url);
            }
            Session["client_user_name"] = Request.Form["name"];
            Session["client_user_phone"] = Request.Form["tel"];
            if (Request.Form["n"] == string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "订房数量没有输入，请重新填写！", true);
                url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                Response.Redirect(url);
            }
            else
            {
                try
                {
                    int.Parse(Request.Form["n"]);
                }
                catch (Exception ex)
                {
                    url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "订房数量输入有误，请重新填写！", true);
                    url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                    Response.Redirect(url);
                }
            }

            if (Request.Form["tel"] == string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "手机号码输入，请重新填写！", true);
                url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                Response.Redirect(url);
            }
            else
            {
                string pattern = @"^1[358]\d{9}$";
                if (!Regex.IsMatch(Request.Form["tel"], pattern))
                {
                    url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "手机号码格式有误，请重新填写！", true);
                    url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                    Response.Redirect(url);
                }
                else
                {
                   
                    IList<Hotelorder> res = HotelorderBLL.GetInstance().Search(new dx177.Model.Bus.QueryO.HotelOrderQuery { OrderPesonPhone = Request.Form["tel"] }, AppContext.JingQuCode);
                    if (res.Count > 0 && res[0].CreateDate > (DateTime.Now.AddMinutes(20)))
                    {
                        url = UrlUtility.AddOrReplaceParam("msg.aspx", "msg", "怀疑您是重复提交，注意20分种内，不能重复提交订单！", true);
                        url = UrlUtility.AddOrReplaceParam(url, "toUrl", "book.aspx?roomid=" + Request.Form["rid"], true);
                        Response.Redirect(url);
                    }

                }
            }
            
            //<meta http-equiv="Refresh" content="1;url=result.asp?action=dosubm&rid=28499&hid=7022&tm1=2011-04-11&tm2=2011-4-12&n=1&name=%E5%88%98%E5%BB%BA%E6%96%B0&tel=13798589604&arrive=18:00&content=&ntime=2011-4-11 10:47:14">

            HtmlMeta keywords = new HtmlMeta();
            keywords.Attributes.Add("http-equiv", "Refresh");
            string url1 = "1;url=result.aspx?action=onsubmit&rid={0}&tel={1}&name={2}&n={3}&arrive={4}&content={5}&datetime={6}";
            url1 = string.Format(url1, Request.Form["rid"], Request.Form["tel"], Page.Server.UrlEncode(Request.Form["name"]), Request.Form["n"], Page.Server.UrlEncode(Request.Form["arrive"]), 
                Page.Server.UrlEncode(Request.Form["content"]),
                Request.Form["datetime"]
                );
            keywords.Content = url1;
            Page.Header.Controls.Add(keywords);
            return url;
        }
    }
}
