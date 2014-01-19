using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using dx177.FrameWork;
using dx177.Business.Bus;
using System.Text;

namespace dx177.WebUI.Wap
{
    public partial class mplist : System.Web.UI.Page
    {
        public string  pguid
        {
            get
            {
                if (Request.QueryString["pguid"] != null)
                {

                    return  Request.QueryString["pguid"] ;
                }
                return string.Empty ;
            }
        }

 
        protected void Page_Load(object sender, EventArgs e)
        {
            tyrpt.DataSource = ProductstypeBLL.GetInstance().GetTreeALL() ;
            tyrpt.DataBind();
            ShowData();
        }
        protected string TotalCount = "0";
        private void ShowData()
        {
            DataTable dt = ProductsBLL.GetInstance().GetableByType(this.pguid);
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
                    sb.AppendFormat("<a href='{0}'>上一页</a>&nbsp;", GetUrl(pageSelected - 1));
                }
                if (pageSelected == pagesCount)
                {
                    sb.AppendFormat("下一页 &nbsp;");
                    sb.AppendFormat("尾页 &nbsp;");
                }
                else
                {
                    sb.AppendFormat("<a href='{0}'>下一页</a>&nbsp;", GetUrl(pageSelected + 1));
                    sb.AppendFormat("<a href='{0}'>尾页</a>&nbsp;", GetUrl(pagesCount));
                }
                Literal ltt = new Literal();
                ltt.Text = sb.ToString();
                pager.Controls.Add(ltt);
            }
        }
        private string GetUrl(int page)
        {
            string url = "mplist.aspx";
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
    }
}
