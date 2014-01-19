using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Business.DictBus;

namespace dx177.WebUI.web.restaurant
{
    public partial class detail : System.Web.UI.Page
    {
        public string seqno
        {
            get
            {
                return ComSafe.SafeValue( Request.QueryString["seqno"]);
            }
        }
        private string _pics = "";
        protected string Pics
        {
            get
            {
                return _pics;
            }
            set
            {
                _pics = value;
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

        Restaurant m_rest = new Restaurant();
        public Restaurant Rest
        {
            get
            {
                return m_rest;
            }
            set
            {
                m_rest = value; 
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "restaurant";
            //AjaxPro.Utility.RegisterTypeForAjax(this.GetType());
            Rest = RestaurantBLL.GetInstance().Get(new Restaurant.Key(int.Parse(seqno)));
            AddViewTimes(Rest);
            Sumarycomment smscore = SumarycommentBLL.GetInstance().GetSumarycommentByPGuid(Rest.Guid);
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
            GetRestPics();

            rptTsjd.DataSource = CookbookBLL.GetInstance().GetCookBookByPGuid(Rest.Guid);
            rptTsjd.DataBind();

            string className = Dict.Tag["RestaurantType", Rest.Restauranttype, 2052];             
            string classNameArea =  Dict.Tag["area", Rest.Area, 2052];
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "restaurantdetail", new { Title = m_rest.Title, Type = className, Area = classNameArea });
        }

        public int AddViewTimes(Restaurant Rest )
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                RestaurantBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
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

        private void GetRestPics()
        {
            
            IList<Picturelist> lies = PicturelistBLL.GetInstance().GetPicsByGuid(Rest.Guid);
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

            Pics = addString;
        }
        
    }

   

}
