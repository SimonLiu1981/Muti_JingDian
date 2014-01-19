using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;
using dx177.Business.DictBus;

namespace dx177.WebUI.web.restaurant
{
    
    public partial class comments : System.Web.UI.Page
    {
        public string seqno
        {
            get
            {
                  return ComSafe.SafeValue(  Request.QueryString["seqno"]);
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
        protected int CommentCount = 0;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "restaurant";
                 
            Rest = RestaurantBLL.GetInstance().Get(new Restaurant.Key(int.Parse(seqno)));
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
            txtUserName.Text = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "匿名用户";
            ShowListData();
            //SEO优化
            string className = Dict.Tag["RestaurantType", Rest.Restauranttype, 2052];
            string classNameArea = Dict.Tag["area", Rest.Area, 2052];
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "restaurantdetail", new { Title = m_rest.Title, Type = className, Area = classNameArea });
        }
       

        /// <summary>
        /// 提交评论
        /// </summary>
        /// <param name="score1">评分1</param>
        /// <param name="score2">评分2</param>
        /// <param name="score3">评分3</param>
        /// <param name="score4">评分4</param>
        /// <param name="content">评论内容</param>
        /// <returns></returns>
      
        public string SubmitComment(float score1, float score2, float score3, float score4, string content, string pguid, string creator)
        {
            Comment cs = new Comment();
             
            cs.Guid = System.Guid.NewGuid().ToString();
            cs.Score1 = decimal.Parse(score1.ToString("0.0"));
            cs.Score2 = decimal.Parse(score2.ToString("0.0"));
            cs.Score3 = decimal.Parse(score3.ToString("0.0"));
            cs.Score4 = decimal.Parse(score4.ToString("0.0"));
            cs.Content = content;
            cs.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : creator;
            cs.Pguid = pguid;            
            CommentBLL.GetInstance().Submit(cs);
            return "1";
        }


        private void ShowListData()
        {
            IList<Comment> lres = CommentBLL.GetInstance().SearchComment(new dx177.Model.Bus.QueryO.CommentQuery { IsShow = "1", pguid = Rest.Guid });
            CommentCount = lres.Count;
            this.lvComment.DataSource =lres;
            this.lvComment.DataBind();
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            pager.Controls.Clear();
            int count = pager.TotalRowCount;
            int pageSize = pager.PageSize;
            int pagesCount = count / pageSize + (count % pageSize == 0 ? 0 : 1);
            int pageSelected = pager.StartRowIndex / pageSize + 1;
            string pret = string.Format("<span class='page_up link01'><A title='上一页' href=\"/restaurantcomments_{0}.html?p={1}\">上一页</a></span>", Request.QueryString["seqno"], pageSelected - 1);
            string next = string.Format("<span class='page_down link01'><A title='下一页' href=\"/restaurantcomments_{0}.html?p={1}\">下一页</a></span>", Request.QueryString["seqno"], pageSelected + 1);
            if (pagesCount > 1)
            {
                if (pageSelected == 1)
                {
                    pret = "";
                }
                if (pageSelected == pagesCount)
                {
                    next = "";
                }
                string Res = "";

                for (int i = 1; i <= pagesCount; ++i)
                {
                    Res += GetPageLink(i, pageSelected);
                }
                Literal ltt = new Literal();
                ltt.Text = pret + Res + next;
                pager.Controls.Add(ltt);
            }
            
        }

        private string GetPageLink(int i, int pageSelected)
        {
            string startstr = "";
            if (pageSelected != i)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"/restaurantcomments_{0}.html?p={1}\">{1}</a>", seqno, i);
            }
            else
            {
                startstr += string.Format("<span class='current'>{0}</span>",i);
            }
            return startstr;
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

        protected void lvComment_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowListData();
        }
    }
}
