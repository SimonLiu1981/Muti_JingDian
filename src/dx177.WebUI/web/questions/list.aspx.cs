using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.FrameWork;
using dx177.Business.DictBus;
using dx177.Model.Bus;

namespace dx177.WebUI.web.questions
{
    public partial class list : System.Web.UI.Page
    {
        public string Qtype
        {
            get
            {
                if (Request.QueryString["Qtype"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Qtype"]);
                }
                return string.Empty;
            }
        }

        public string Status
        {
            get
            {
                if (Request.QueryString["Status"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Status"] );
                }
                return "";
            }
        }

        private void ShowData()
        {
            ((defaultMaster)Page.Master).NavId = "questions";
            QuestionsQuery h = new QuestionsQuery();
            h.Qtype = this.Qtype;
            h.QuestStatus = this.Status ;
            DataTable dt = QuestionsBLL.GetInstance().SearchData(h);
            LsQuestionList.DataSource = dt;
            LsQuestionList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            rpQtype.DataSource = Dict.Tag.GetViewByTypeName("QuestionType");
            rpQtype.DataBind();
            ShowData();

            //string[] s = new string[] { className, className, className };
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "questionslist", new { Type = Dict.Tag["QuestionType", Qtype, 2052] });

            
            //(Page.Master as defaultMaster).Title(className, false);
            //PageKeyWord pagekeyword = dx177.Business.Bus.CommonBLL.GetInstance().TitleByXmlCode("questionslist");
            //(Page.Master as defaultMaster).Title(pagekeyword.Title + " - " + className, false);
            //(Page.Master as defaultMaster).Keywords(pagekeyword.KeyWord + " - " + className, false);
            //(Page.Master as defaultMaster).Description(pagekeyword.Description + " - " + className, false);

        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            pager.Controls.Clear();
            int count = pager.TotalRowCount;
            int pageSize = pager.PageSize;
            int pagesCount = count / pageSize + (count % pageSize == 0 ? 0 : 1);
            int pageSelected = pager.StartRowIndex / pageSize + 1;
            string pret = string.Format("<span class='page_up link01'><A title='上一页' href=\"{0}\">上一页</a></span>", GetUrl(pageSelected - 1));
            string next = string.Format("<span class='page_down link01'><A title='下一页' href=\"{0}\">下一页</a></span>", GetUrl(pageSelected + 1));
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
        private string GetUrl(int page)
        {
            string url = "/questions/default.aspx";
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);
            return url;
        }
        private string GetPageLink(int page, int pageSelected)
        {
            string startstr = "";
            if (pageSelected != page)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"{1}\">{0}</a>", page, GetUrl(page));
            }
            else
            {
                startstr += string.Format("<span class='current'>{0}</span>", page);
            }
            return startstr;
        }

        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }
    }
}
