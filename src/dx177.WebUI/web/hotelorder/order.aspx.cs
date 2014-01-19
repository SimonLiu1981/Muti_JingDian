using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.WebUI.web.admin;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;
using dx177.FrameWork;

namespace dx177.WebUI.web.hotelorder
{
    public partial class order : Page
    {
        private string roomid
        {
            get { 
                  return ComSafe.SafeValue(  Request .QueryString["roomid"]);
            }
        }

        protected Hotel HT = new Hotel();

        protected Room RM = new Room();

        protected Resuser RU = new Resuser();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            RM = RoomBLL.GetInstance().Get(new Room.Key(int.Parse(roomid)));
            HT = HotelBLL.GetInstance().GetHotelByGuid(RM.Pguid);
            RU = AppContext.CurrentResuser;

            

        }

        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="roomCount"></param>
        /// <param name="unitPrice"></param>
        /// <returns></returns>
        
        public Object GetCostList(string startdate, string enddate, int roomCount, float unitPrice, float fPrice)
        {
            DateTime s = DateTime.Parse(startdate);
            DateTime e = DateTime.Parse(enddate);
            List<RoomCost> res = new List<RoomCost>();
            float totalPrice = 0;
            int days = 0;
            while (((TimeSpan)(e - s)).Days > 0)
            {
                RoomCost tmp = new RoomCost();
                tmp.DateString = s.ToString("MM-dd");

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
                s = s.AddDays(1);
                days++;
                res.Add(tmp);
            }

            return new { RoomCostList = res, TotalPrice = totalPrice, Days = days };

        }

      
        public object SubmitHotelOrder(SubmitParam para)
        {
            Hotelorder order = new Hotelorder();
            order.Content = para.Content;
            order.Personname = para.order_person_name;
            order.Personphone = para.order_person_phone;
            order.Orderusername = para.order_username;
            order.Orderuserphone = para.order_phone;
            order.Begindate =DateTime.Parse(para.start_date);
            order.Enddate = DateTime.Parse(para.end_date);

            order.Roomtitle = para.Roomtitle;
            order.Roomseqno = para.RoomSeqno;
            order.Hotelname = para.Hoteltitle;
            order.Hotelseqno = para.HotelSeqno;
            order.Reachdate = para.ReachDate;
            order.Roomcount = para.order_room_count;
            order.Totalmoney = para.totalPrice;
            order.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "非注册用户";
            order.Ip = HttpContext.Current.Request.ServerVariables.Get("Remote_Addr").ToString();
            HotelorderBLL.GetInstance().SubmitOrder(order);
            return new { IsRegister = AppContext.CurrentResuser != null };
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


        }
    }

    

}

 