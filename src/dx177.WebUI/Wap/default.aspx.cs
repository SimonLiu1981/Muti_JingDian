using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using dx177.Model.Bus.QueryO;
using dx177.Business.Bus;
using dx177.FrameWork;
using System.Data;
using System.Text;
using dx177.Model.Bus;

namespace dx177.WebUI.Wap
{
    public partial class _default : System.Web.UI.Page
    {

        public decimal MinPrice
        {
            get
            {
                if (Request.QueryString["price"] != null)
                {
                    if (int.Parse(Request.QueryString["price"]) == 100)
                    {
                        return 0;
                    }
                    return decimal.Parse(Request.QueryString["price"]);
                }
                return 0;
            }
        }


        public decimal MaxPrice
        {
            get
            {

                if (Request.QueryString["price"] != null)
                {
                    if (int.Parse(Request.QueryString["price"]) == 301 || int.Parse(Request.QueryString["price"]) == 0)
                    {
                        return 10000;
                    }
                    return decimal.Parse(Request.QueryString["price"]);
                }
                return 10000;
            }
        }

        public string price
        {
            get
            {
                if (Request.QueryString["price"] != null)
                {
                    return Request.QueryString["price"];
                }
                return "0";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        protected string TotalCount = "0";
        private void ShowData()
        {
            Resuser aaa = new Resuser();            
            if (Request.QueryString["jsr"] != null)
            {
                aaa = ResuserBLL.GetInstance().GetResuserByUserDomain(Request.QueryString["jsr"]);    
            }
            if (aaa == null)
            {
                aaa = new Resuser();
            }
            DataTable dt = HotelBLL.GetInstance().SearchMoblieData(MinPrice, MaxPrice, aaa.Username);
            TotalCount = dt.Rows.Count.ToString();
            LsHotelList.DataSource = dt;
            LsHotelList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);

        }

        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                
                //lbHotelnst
            }
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            pager.Controls.Clear();
            int count = pager.TotalRowCount;
            int pageSize = pager.PageSize;
            int pagesCount = count / pageSize + (count % pageSize == 0 ? 0 : 1);
            int pageSelected = pager.StartRowIndex / pageSize + 1;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("共 <strong>{0}</strong> 家酒店 当前第 <strong>{1}</strong> 页<br />", count, pageSelected);
 
            if (pagesCount > 1)
            {
                if (pageSelected == 1)
                {

                    sb.AppendFormat("首页 &nbsp;");
                    sb.AppendFormat("上一页 &nbsp;");
                }
                else
                {
                    sb.AppendFormat("<a href='{0}'>首页</a>&nbsp;", GetUrl(1));
                    sb.AppendFormat("<a href='{0}'>上一页</a>&nbsp;", GetUrl(pageSelected-1));
                }
                if (pageSelected == pagesCount)
                {
                    sb.AppendFormat("下一页 &nbsp;");
                    sb.AppendFormat("尾页 &nbsp;");
                }
                else
                {
                    sb.AppendFormat("<a href='{0}'>下一页</a>&nbsp;", GetUrl(pageSelected+1));
                    sb.AppendFormat("<a href='{0}'>尾页</a>&nbsp;", GetUrl(pagesCount));                    
                }                
                Literal ltt = new Literal();
                ltt.Text = sb.ToString();
                pager.Controls.Add(ltt);
            }
        }
        private string GetUrl(int page)
        {
            string url = "default.aspx";
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);
            url = UrlUtility.RemoveParam(url, "jsr"); 
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
        public string GetPriceUrl(string price)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "price", price, true);
            url = UrlUtility.RemoveParam(url, "jsr");
            url = UrlUtility.RemoveParam(url, "p"); 
            return url;
        }
    }
}
