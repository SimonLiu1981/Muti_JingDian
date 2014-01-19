using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using dx177.Model;
using dx177.Model.Bus.QueryO;
using System.Collections.Generic;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.web.admin.Wap
{
    public partial class MyOrderList : ResUserBasePage
    {
        protected string UserName = "";
        protected string StatusType = "";
        protected string Historystatus = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            StatusType = Request.QueryString["status"] ;
            Historystatus = Request.QueryString["Historystatus"];
            InitDataSearch();
            UserName = AppContext.CurrentResuser.Username == string.Empty ? AppContext.CurrentResuser.Email : AppContext.CurrentResuser.Username;
        }

        private void InitDataSearch()
        {
            HotelOrderQuery query = new HotelOrderQuery();
            query.OrderStatus = StatusType;
            //表示全部
            if (StatusType == "9")
            {
                query.OrderStatus="";
            }
            if (!string.IsNullOrEmpty(Historystatus) && int.Parse(Historystatus) > 0)
            {
                query.Begindate = DateTime.Now.ToString("yyyy-MM-dd");
                query.Enddate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                UCLeftMenu1.CurrentMenuID = "menu_wap_ordermyhotel";
            }
            else
            {
                UCLeftMenu1.CurrentMenuID = "menu_wap_ordermyhotel_history";
            }
            query.referrall = AppContext.CurrentResuser.Username;
            IList<Hotelorder> res = HotelorderBLL.GetInstance().Search(query, AppContext.JingQuCode);
            this.lvOrder.DataSource = res;
            this.lvOrder.DataBind();
        }

        protected void lvOrder_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            InitDataSearch();
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
