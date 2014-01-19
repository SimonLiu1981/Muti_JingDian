using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model;
using System.Data;
using dx177.FrameWork;

namespace dx177.WebUI.web.admin
{
    public partial class member_publish_hotellist : ResUserBasePage
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            InitDataSearch();
        }
        protected void lvHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            InitDataSearch();
        }

        private void InitDataSearch()
        {
            HotelQuery query = new HotelQuery();
            query.Creator = AppContext.CurrentResuser.Username;
            DataTable dt  = HotelBLL.GetInstance().Search(query);
            this.lvHotelList.DataSource = dt;
            this.lvHotelList.DataBind();
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
            string url = Request.RawUrl;

            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);

            return url;
        }

        private string GetPageLink(int i, int pageSelected)
        {
            string startstr = "";
            if (pageSelected != i)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"{0}\">{1}</a>", GetUrl(i), i);
            }
            else
            {
                startstr += string.Format("<span class='current'>{0}</span>", i);
            }
            return startstr;
        }
	}
}
