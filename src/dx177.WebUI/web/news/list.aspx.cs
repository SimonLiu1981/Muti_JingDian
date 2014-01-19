using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus.QueryO;
using dx177.Business.Bus;
using System.Data;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Model;

namespace dx177.WebUI.web.news
{
    public partial class list : System.Web.UI.Page
    {
        public string Code
        {
            get
            {
                if (Request.QueryString["Code"] != null)
                {
                     return ComSafe.SafeValue( Request.QueryString["Code"]);
                }
                return string.Empty;
            }
        }


        public string GetUrlByCode(string code)
        {
            string url = string.Format("/news/default.aspx");
            if (code != "")
            {
                url = string.Format("/news/list_{0}.aspx", code);
            }            
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.RemoveParam(url, "p");
            url = UrlUtility.RemoveParam(url, "code");
            return url;
        }
        private void ShowData()
        {
            
            
            IList<News>   il = NewsBLL.GetInstance().Font_Search("",this.Code ,0, AppContext.JingQuCode);
            LsQuestionList.DataSource = il;
            LsQuestionList.DataBind();
            DataPager1.Visible = (il.Count > DataPager1.PageSize);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "news";
            rpQtype.DataSource = NewstypeBLL.GetInstance().Select();
            rpQtype.DataBind();
            ShowData();

            Newstype type1 = NewstypeBLL.GetInstance().GetNewstypeBycode(Code, AppContext.JingQuCode);
            //SEO 优化
            string typename = type1 != null ? type1.Title : "";

            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "newslist", new { TypeName = typename });

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
        private string GetUrl(int page)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);
            url = UrlUtility.RemoveParam(url, "code");
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

        protected void LsQuestionList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Label lblType = e.Item.FindControl("lblType") as Label;
            lblType.Text = NewstypeBLL.GetInstance().GetNewstypeByguid(lblType.Text).Title;
        }
    }
}
