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
using dx177.Model.Bus.QueryO;
using CampanyCMS.Model.Bus;
using dx177.Model.Bus;
using dx177.Business.Bus;
using System.IO;
using dx177_building;
using dx177_building.Model;
using dx177.Business.DictBus;

namespace dx177.WebUI.web.hotel
{
    public partial class hotelsearch : System.Web.UI.Page
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
                    if (int.Parse(Request.QueryString["price"]) == 401 || int.Parse(Request.QueryString["price"]) == 0)
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
                    return ComSafe.SafeValue(Request.QueryString["price"]);
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
                    return ComSafe.SafeValue(Request.QueryString["Area"]);
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
                    return ComSafe.SafeValue(Request.QueryString["HotelType"]);
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
                    return ComSafe.SafeValue(Request.QueryString["Title"].Replace("'", ""));
                }
                return string.Empty;
            }
        }

        public int PageIndex
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["PageIndex"]))
                {
                    return int.Parse(Request.QueryString["PageIndex"]);
                }
                return 1;
            }
        }
        int _pagesize = 10;
        public int pagesize
        {
            get
            {
                return _pagesize;
            }
            set
            {
                _pagesize = value;
            }
        }


        public string Html ="";
        protected void Page_Load(object sender, EventArgs e)
        {
            Resuser a = new Resuser();
            a.Username = "admin";
            BuildPageBLL.GobalPara(this.Page, a);
            ShowData();

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
            PropertyMapper mp = new PropertyMapper(rep);
            PageKeyWord pk = CommonBLL.GetInstance().TitleByXmlCode("hotellist");
            string stitle = string.Format("丹霞山酒店预订_丹霞山住宿_丹霞山宾馆_{0}_{1}--游丹霞山", priceStri, area);
            string skeywords = string.Format("丹霞山酒店预订,丹霞山住宿,丹霞山宾馆,{0},{1}", priceStri, area);
            string sdescription = string.Format("丹霞山酒店预订,丹霞山住宿,丹霞山宾馆,{0},{1}", priceStri, area);
            Html = Html.Replace("|网站标题|", stitle).Replace("|网站关键字|", skeywords).Replace("|网站内容|", sdescription);
        }
        public void ShowData()
        {
            string XmlPath = Path.Combine("/Templates/xml/hotel/", "CallMethodArrMod.xml"); 
            string strlink = "/web/hotel/hotelsearch.aspx";
            HotelQuery query = new HotelQuery();
            if (!string.IsNullOrEmpty(this.HotelType) )
            {
                strlink = UrlUtility.AddOrReplaceParam(strlink, "HotelType", this.HotelType , true);
                query.HotelType = this.HotelType;
            }
            if (!string.IsNullOrEmpty(this.Area ))
            {
                strlink = UrlUtility.AddOrReplaceParam(strlink, "Area", this.Area, true);
                query.Area = this.Area;
            }
            if (!string.IsNullOrEmpty(this.price))
            {
                strlink = UrlUtility.AddOrReplaceParam(strlink, "price", this.price, true);
            }
            query.Price1 = this.MinPrice;
            query.Price2 = this.MaxPrice;
            strlink += "&PageIndex=";

            XmlPath = Path.Combine("/Templates/xml/hotel/", "searchhotelist.xml"); 
            DataTable dt = HotelBLL.GetInstance().Search(query, this.PageIndex, this.pagesize );
            int RecordCount = HotelBLL.GetInstance().SearchCount(query);
            Html = BuildingSearchListHtml.CreateSearchPage(dt, XmlPath, strlink, this.PageIndex, RecordCount);
            Hashtable hs = new Hashtable();
            hs.Add("PRICE", this.price);
            hs.Add("TYPE", this.HotelType);
            hs.Add("AREA", this.Area );

            Html = BuildCommon.GetHtmlByHash(hs, Html);

        }

        

    }
}
