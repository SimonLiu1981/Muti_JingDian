using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Business.DictBus;
using dx177.FrameWork;
using System.Data;
using dx177.Model.Bus;

namespace dx177.WebUI.web.restaurant
{
    public partial class list : System.Web.UI.Page
    {

        public string Area
        {
            get
            {
                if (Request.QueryString["Area"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Area"]);
                }
                return string.Empty ; 
            }
        }


        public string Rtype
        {
            get
            {
                if (Request.QueryString["Rtype"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Rtype"]);
                }
                return string.Empty;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "restaurant";
            IniData();
            ShowData();
            string classNameType = string.IsNullOrEmpty(Rtype) ? "" : Dict.Tag["RestaurantType", Rtype, 2052];
            string classNameArea = string.IsNullOrEmpty(Area) ? "" : Dict.Tag["area", Area, 2052];
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "restaurantlist", new { Type = classNameType, Area = classNameArea });
        }

        private void IniData()
        {
            rpArea.DataSource = Dict.Tag.GetViewByTypeName("area");
            rpArea.DataBind();
            rpRtype.DataSource = Dict.Tag.GetViewByTypeName("RestaurantType");
            rpRtype.DataBind();
        }

        private void ShowData()
        {
            DataTable dt = RestaurantBLL.GetInstance().GetResData(this.Area, this.Rtype);
            LsRestaurantList.DataSource = dt;
            LsRestaurantList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);
        }

        protected void LsRestaurantList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
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
            string url = "/restaurant/default.aspx";
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

        
    }
}
