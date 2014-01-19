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
using System.Xml.Linq;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;


namespace dx177.WebUI.master.sites
{
    public partial class _default : System.Web.UI.Page
    {
        private string jingqucode
        {
            get
            {
                if (Request.QueryString[ConstantElements.QueryStringNameJQ] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString[ConstantElements.QueryStringNameJQ]);
                }
                return string.Empty;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            string strjqname = JingqusBLL.GetInstance().GetNameByJingqucode(this.jingqucode); ;

            Hashtable hs = new Hashtable();
            hs.Add("siteName", strjqname);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "site", hs);


            ShowData();
        }

        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        private void ShowData()
        {
            this.lsQuestion.DataSource = SitesBLL.GetInstance().Font_Search("", 0, string.Empty);
            this.lsQuestion.DataBind();
        }


        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

            }
        }

        protected string GetQuestionURL(string questionType)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            if (questionType != string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam(url, "type", questionType, true);
            }
            else
            {
                url = UrlUtility.RemoveParam(url, "type");
            }

            if (url.ToUpper().IndexOf("JQ_") != -1)
            {
                url = UrlUtility.RemoveParam(url, ConstantElements.QueryStringNameJQ);
            }

            return url;
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        }

    }
}