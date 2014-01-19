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
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model;
namespace dx177.WebUI.web.hotel
{
    public partial class list : System.Web.UI.Page
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
                        return ComSafe.SafeValue( Request.QueryString["price"]);
                }
                return "0";
            }
        }
        public string Area
        {
            get
            {
                if (Request.QueryString["Area"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Area"]);
                }
                return string.Empty;
            }
        }

        public string HotelType
        {
            get
            {
                if (Request.QueryString["HotelType"] != null)
                {
                    if (Request.QueryString["HotelType"] == "0")
                    {
                        return "";
                    }
                      return ComSafe.SafeValue(  Request.QueryString["HotelType"]);
                }
                return string.Empty;
            }
        }

        public string sTitle
        {
            get
            {
                if (Request.QueryString["Title"] != null)
                {
                      return ComSafe.SafeValue(  Request.QueryString["Title"].Replace("'", ""));
                }
                return string.Empty;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "hotel";
            if (!IsPostBack)
            {
                rpHotelType.DataSource = Dict.Tag.GetViewByTypeName("HotelType");
                rpHotelType.DataBind();
                rpAddress.DataSource = Dict.Tag.GetViewByTypeName("Area");
                rpAddress.DataBind();
                ShowData();
            }
            MyHtmlMeta();
        }

        private void MyHtmlMeta()
        {
            
            string priceStri = "";
            if (price == "100")
            {
                priceStri = "100元以下";
            }
            if (price == "200")
            {
                priceStri = "100-200元";
            }
            if (price == "300")
            {
                priceStri = "200-300元";
            }
            if (price == "301")
            {
                priceStri = "300元以上";
            }
            string area = Dict.Tag["Area", this.Area, 2052];
            string HotelType = Dict.Tag["HotelType", this.HotelType, 2052];
            object rep = new { Area = area, HotelType = HotelType, Price = priceStri };
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "hotellist", rep);
        }

        private void ShowData()
        {
            HotelQuery h = new HotelQuery();
            h.HotelType = this.HotelType;
            h.Name = this.sTitle;
            h.Price1 = this.MinPrice;
            h.Price2 = this.MaxPrice;
            h.Area = this.Area;
            h.JingQuCode = AppContext.JingQuCode;
            DataTable dt = HotelBLL.GetInstance().SearchHotel(h);

            LsHotelList.DataSource = dt;
            LsHotelList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);


        }

        //protected void ListView1_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        //{
        //    DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

        //    ShowData();
        //}


        /// <summary>
        /// 分数传样式
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public string SocreToCssStr(object score)
        {
            decimal s = decimal.Parse(score.ToString());
            return s.ToString("0.0").Replace(".", "d");
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
                // txtGuid.Value
                HtmlInputHidden txtGuid = e.Item.FindControl("txtGuid") as HtmlInputHidden;
                RoomQuery r = new RoomQuery();
                r.PGuid = txtGuid.Value;
                Repeater RpRoom = e.Item.FindControl("RpRoom") as Repeater;
                RpRoom.DataSource = RoomBLL.GetInstance().GetRoom(r);
                RpRoom.DataBind();

                BaseDictTagBLL.GetInstance().GetDictTag("HoteInst");
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
            string url = "/hotel/default.aspx";
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

        public string GetIInst(object obj, string v)
        {
            if (obj.ToString().IndexOf(v) != -1)
            {
                return v + "1";
            }
            return v + "0";
        }

        public string GetAddressUrl(string areaCode)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "area", areaCode, true);
            url = UrlUtility.RemoveParam(url, "p");
            return url;
        }

        public string GetPriceUrl(string price)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "price", price, true);
            url = UrlUtility.RemoveParam(url, "p");
            return url;
        }

        public string GetHotelTypeUrl(string hotelType)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "HotelType", hotelType, true);
            url = UrlUtility.RemoveParam(url, "p");
            return url;
        }
    }
}
