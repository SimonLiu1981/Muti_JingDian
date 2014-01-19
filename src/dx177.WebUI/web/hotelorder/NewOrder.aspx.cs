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
using dx177.Model;
using dx177.FrameWork;
using System.Collections.Generic;
using CampanyCMS.Business.Bus;
using dx177_building;

namespace dx177.WebUI.web.hotelorder
{
    public partial class NewOrder : System.Web.UI.Page
    {
        private string roomid
        {
            get
            {
                return ComSafe.SafeValue(Request.QueryString["roomid"]);
            }
        }

        protected Hotel HT = new Hotel();

        protected Room RM = new Room();

        protected Resuser RU = new Resuser();

        public string OrderAlertDescr = "酒店预定成功。稍后客服人员将会和你确认信息。";
        public  string OrderButtonDescr = "";

        public string ButtonStyle = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            RM = RoomBLL.GetInstance().Get(new Room.Key(int.Parse(roomid)));
            HT = HotelBLL.GetInstance().GetHotelByGuid(RM.Pguid);
            RU = AppContext.CurrentResuser;
             

            notes n = new notes();
            n = XmlData.XmlDeserialize(n.GetType(), "~/notes.xml") as notes;
            if (n != null)
            {
                OrderAlertDescr = n.OrderAlertDescr;
                OrderButtonDescr = n.OrderButtonDescr;
                if (n.orderButtonIsShow <= 0)
                {
                    ButtonStyle = "none";
                }
            }

        }

        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="roomCount"></param>
        /// <param name="unitPrice"></param>
        /// <returns></returns>
        
        public Object GetCostList(string startdate, string enddate, int roomCount, float unitPrice, float fPrice, string HGuid)
        {
            
            DateTime s = DateTime.Parse(startdate);
            DateTime e = DateTime.Parse(enddate);
            List<RoomCost> res = new List<RoomCost>();
            float totalPrice = 0;
            int days = 0;
            List<Roomprice> rli= RoompriceBLL.GetInstance().GetRoomprice(HGuid,startdate,enddate );
           
            while (((TimeSpan)(e - s)).Days > 0)
            {
                RoomCost tmp = new RoomCost();
                tmp.DateString = s.ToString("MM-dd");
                float spprice=  GetSpPrice(rli, s);//特殊价格
                if (spprice > 0)
                {
                    tmp.MoneyString = (spprice * roomCount).ToString();
                    totalPrice += spprice * roomCount;
                }
                else
                {
                    if (s.DayOfWeek == DayOfWeek.Friday || s.DayOfWeek == DayOfWeek.Saturday)
                    {
                        tmp.MoneyString = (fPrice * roomCount).ToString();
                        totalPrice += fPrice * roomCount;

                    }
                    else
                    {
                        tmp.MoneyString = (unitPrice * roomCount).ToString();
                        totalPrice += unitPrice * roomCount;
                    }
                }
                s = s.AddDays(1);
                days++;
                res.Add(tmp);
            }
            return new { RoomCostList = res, TotalPrice = totalPrice, Days = days };
        }

        private float GetSpPrice( List<Roomprice> il ,DateTime  MdDate)
        {
            if (il == null && il.Count <= 0) return -1;
            foreach (Roomprice r in il)
            {
                if (r.Sdate <= MdDate && r.Edate >= MdDate)
                {
                    return float.Parse ( r.Price.ToString());
                }
            }
            return -1;
        }
        
        public object SubmitHotelOrder(SubmitParam para)
        {
            Hotelorder order = new Hotelorder();
            order.Content = para.Content;
            order.Personname = para.order_person_name;
            order.Personphone = para.order_person_phone;
            order.Orderusername = para.order_username;
            order.Orderuserphone = para.order_phone;
            order.Begindate = DateTime.Parse(para.start_date);
            order.Enddate = DateTime.Parse(para.end_date);

            order.Roomtitle = para.Roomtitle;
            order.Roomseqno = para.RoomSeqno;
            order.Hotelname = para.Hoteltitle;
            order.Hotelseqno = para.HotelSeqno;
            order.Reachdate = para.ReachDate;
            order.Roomcount = para.order_room_count;
            order.Price = para.unitPrice;
            order.Totalmoney = para.totalPrice;
            order.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "非注册用户";
            order.Ip = HttpContext.Current.Request.UserHostAddress;
            HotelorderBLL.GetInstance().SubmitOrder(order);

            MailSetting r = new MailSetting();
            r = XmlData.XmlDeserialize(r.GetType(), "~/MailSetting.xml") as MailSetting;

            SendMailhotelorder soder = new SendMailhotelorder();
            soder.mailsetting = r;
            soder.order = order;
            soder.Issendorderemail = para.Issendorderemail;
            soder.Email = para.Email ;

            SendmailDelegate myMethod3 = new SendmailDelegate(SendMailBLL.GetInstance().SendMail);
            myMethod3.BeginInvoke(soder, new AsyncCallback(AfterMyMothod3), null);

          //  SendMailBLL.GetInstance().SendMail(order);
            return new { IsRegister = AppContext.CurrentResuser != null };
        }
        delegate void SendmailDelegate(SendMailhotelorder sorder);


        public void AfterMyMothod3(IAsyncResult result)
        {
           
        } 

        public class RoomCost
        {
            public string DateString;
            public string MoneyString;
        }

        public class SubmitParam
        {
            public int RoomSeqno = 0;
            public string Roomtitle = "";
            public int HotelSeqno = 0;
            public string Hoteltitle = "";
            public string ReachDate = "";
            public string end_date = "";
            public string start_date = "";
            public string order_person_name = "";
            public string order_person_phone = "";
            public string order_username = "";
            public string order_phone = "";
            public string Content = "";
            public double totalPrice = 0;
            public double unitPrice = 0;
            public int order_room_count = 0;
            public int Issendorderemail = 0;
            public string Email = "";

        }
    }
}
