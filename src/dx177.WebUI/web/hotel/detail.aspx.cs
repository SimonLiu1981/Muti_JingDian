using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using System.Data;
using dx177.Business.DictBus;
using dx177.FrameWork;
 

namespace dx177.WebUI.web.hotel
{
    public partial class detail : System.Web.UI.Page
    {
        public Hotel h = new Hotel()  ;
        public int Seqno
        {
            get
            {
                if (Request.QueryString["Seqno"] != null)
                {
                    return int.Parse(Request.QueryString["Seqno"]);
                }
                return 0;
            }
        }
        private Score m_myScore = new Score();
        protected Score myScore
        {
            get
            {
                return m_myScore;
            }
            set
            {
                m_myScore = value;
            }
        }
        protected class Score
        {
            public string CssScore1
            {
                get;
                set;
            }
            public string ScoreTitle1
            {
                get;
                set;

            }
            public string ShowScore1
            {
                get;
                set;
            }
            public string CssScore2
            {
                get;
                set;
            }
            public string ScoreTitle2
            {
                get;
                set;

            }
            public string ShowScore2
            {
                get;
                set;
            }
            public string CssScore3
            {
                get;
                set;
            }
            public string ScoreTitle3
            {
                get;
                set;

            }
            public string ShowScore3
            {
                get;
                set;
            }
            public string CssScore4
            {
                get;
                set;
            }
            public string ScoreTitle4
            {
                get;
                set;

            }
            public string ShowScore4
            {
                get;
                set;
            }
        }

        public string PicArr1 = string.Empty;
        public string PicArr2 = string.Empty;
        public string HotelTypeName = "";
        public string HotelTypeNameLink = "";
        public string AreaType = "";
        public string AreaTypeLink = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "hotel";
            IniData();


            Sumarycomment smscore = SumarycommentBLL.GetInstance().GetSumarycommentByPGuid(h.Guid);
            myScore.CssScore1 = smscore.Score1.ToString("0.0").Replace(".", "d");
            myScore.ScoreTitle1 = smscore.Score1.ToString("0.0") + "/5.0";
            myScore.ShowScore1 = smscore.Score1.ToString("0.0");
            myScore.CssScore2 = smscore.Score2.ToString("0.0").Replace(".", "d");
            myScore.ScoreTitle2 = smscore.Score2.ToString("0.0") + "/5.0";
            myScore.ShowScore2 = smscore.Score2.ToString("0.0");
            myScore.CssScore3 = smscore.Score3.ToString("0.0").Replace(".", "d");
            myScore.ScoreTitle3 = smscore.Score3.ToString("0.0") + "/5.0";
            myScore.ShowScore3 = smscore.Score3.ToString("0.0");
            myScore.CssScore4 = smscore.Score4.ToString("0.0").Replace(".", "d");
            myScore.ScoreTitle4 = smscore.Score4.ToString("0.0") + "/5.0";
            myScore.ShowScore4 = smscore.Score4.ToString("0.0");

            string area = Dict.Tag["Area", h.Area , 2052];
            string HotelType = Dict.Tag["HotelType",h.Hoteltype , 2052];
            
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "hoteldetail", new { Name = h.Name, Area = area, HotelType = HotelType });


        }
        public string GetIInst(object obj, string v)
        {
            if (obj.ToString().IndexOf(v) != -1)
            {
                return v + "1";
            }
            return v + "0";
        }

        private void GetPicList(string sGuid)
        {

            IList<Picturelist> lies = PicturelistBLL.GetInstance().GetPicsByGuid(sGuid);
            int i = 0;
            string addString = "";
            foreach (Picturelist tem in lies)
            {
                i++;
                if (i == 1)
                {
                    addString += "<div>";
                }
                addString += string.Format("<img src='{0}' bigImg='{1}' alt='{2}'/>", tem.Smallimgfile, tem.Bigimgfile, tem.Title);
                if (i == 5)
                {
                    i = 0;
                    addString += "</div>";
                }
            }

            if (i != 0)
            {
                addString += "</div>";
            }

            PicArr2 = addString;
        }

       
        public int AddViewTimes(Hotel Rest)
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                HotelBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
            }
        }


        private void Room(string Guid)
        { 
            RoomQuery r=new RoomQuery () ;
            r.PGuid=Guid ;
            DataTable dt =RoomBLL.GetInstance().GetRoom(r);
            rpRoom.DataSource = dt;
            rpRoom.DataBind();

          
        }

        private void IniData()
        {
            h = HotelBLL.GetInstance().Get(new Hotel.Key(this.Seqno));
            HotelTypeName= Dict.Tag["HotelType", h.Hoteltype, 2052];
            HotelTypeNameLink = UrlUtility.AddOrReplaceParam("/hotel/default.aspx", "HotelType", h.Hoteltype, true);
            AreaType = Dict.Tag["AREA", h.Area, 2052];
            AreaTypeLink = UrlUtility.AddOrReplaceParam("/hotel/default.aspx", "AREA", h.Hoteltype, true);
            Room(h.Guid);
            AddViewTimes(h);
            GetPicList(h.Guid);
        }
    }
}
