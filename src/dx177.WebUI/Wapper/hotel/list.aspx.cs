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
using dx177.Business.DictBus;
using dx177.Model;
using dx177.Model.Bus.QueryO;
using dx177.Business.Bus;

namespace dx177.WebUI.Wapper.hotel
{
    public partial class list :BaseWebPage
    {


        public string tm1
        {
            get
            {
                if (Request.QueryString["tm1"] == null)
                {
                    if (Request.Cookies["tm1"] != null)
                    {
                        return Request.Cookies["tm1"].Value;
                    }
                    return DateTime.Now.ToString("yyyy-MM-dd");
                }
                return Request.QueryString["tm1"];
            }
        }

        public string tm2
        {
            get
            {
                if (Request.QueryString["tm2"] == null)
                {
                    if (Request.Cookies["tm2"] != null)
                    {
                        return Request.Cookies["tm2"].Value;
                    }
                    return DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                }
                return Request.QueryString["tm2"];
            }
        }


        private string GetCurrentPriceDesc()
        { 
            string res = string.Empty;
            if (Request.QueryString["price"] != null)
            {
                if (Request.QueryString["price"] == "100")
                {
                    res = "100元以下_";
                }
                if (Request.QueryString["price"] == "200")
                {
                    res = "100元-200元_";
                }
                if (Request.QueryString["price"] == "300")
                {
                    res = "200元-300元_";
                }

                if (Request.QueryString["price"] == "400")
                {
                    res = "300元-400元_";
                }
                
                if (Request.QueryString["price"] == "401")
                {
                    res = "400元以上_";
                }
            }
            return res;
        }

        public decimal MinPrice
        {
            get
            {
                if (Request.QueryString["price"] != null)
                {
                    try
                    {
                        if (int.Parse(Request.QueryString["price"]) == 100)
                        {
                            return 0;
                        }
                        if (int.Parse(Request.QueryString["price"]) == 200
                            || int.Parse(Request.QueryString["price"]) == 300
                            || int.Parse(Request.QueryString["price"]) == 100
                            || int.Parse(Request.QueryString["price"]) == 400)
                        {
                            return decimal.Parse(Request.QueryString["price"]);
                        }
                        else
                        {
                            return 0;
                        }   
                    }
                    catch
                    {
                        return 0;
                    }
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
                    try
                    {
                        if (int.Parse(Request.QueryString["price"]) == 401 || int.Parse(Request.QueryString["price"]) == 0)
                        {
                            return 10000;
                        }
                        if (int.Parse(Request.QueryString["price"]) == 200
                            || int.Parse(Request.QueryString["price"]) == 300
                            || int.Parse(Request.QueryString["price"]) == 100
                            || int.Parse(Request.QueryString["price"]) == 400)
                        {
                            return decimal.Parse(Request.QueryString["price"]);
                        }
                        else
                        {
                            return 10000;
                        }                        
                    }
                    catch
                    {
                        return 10000;    
                    }
                    
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
                if (Request.QueryString["area"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["area"]);
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

        private string JqCode
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

        public string GetNewUrl(string parm, string parmvalue)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, parm, parmvalue, true);
            url = UrlUtility.RemoveParam(url, "p");
            url = UrlUtility.AddOrReplaceParam(url, "tm1", tm1, true);
            url = UrlUtility.AddOrReplaceParam(url, "tm2", tm2, true);
            if (url.IndexOf(ConstantElements.JingQuPrefix) != -1)
            {
                url = UrlUtility.RemoveParam(url, ConstantElements.QueryStringNameJQ);
            }
            return url;
        }

        public string GetUrlWithOutTm1Tm2()
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.RemoveParam(url, "tm1");
            url = UrlUtility.RemoveParam(url, "tm2");
            if (url.IndexOf(ConstantElements.JingQuPrefix) != -1)
            {
                url = UrlUtility.RemoveParam(url, ConstantElements.QueryStringNameJQ);
            }
            return url;
        }
 
 
        


        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        private void ShowData()
        {
            
            HotelQuery h = new HotelQuery();
            h.HotelType = this.HotelType;
            h.Name = string.Empty;
            h.Price1 = this.MinPrice;
            h.Price2 = this.MaxPrice;
            h.Area = this.Area;
            h.JingQuCode = this.JqCode;
            DataTable dt = HotelBLL.GetInstance().SearchHotel(h);

            LsHotelList.DataSource = dt;
            LsHotelList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);
                    
        }


        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                // txtGuid.Value
                HtmlInputHidden txtGuid = e.Item.FindControl("txtGuid") as HtmlInputHidden;
                RoomQuery r = new RoomQuery();
                r.PGuid = txtGuid.Value;
                //Repeater RpRoom = e.Item.FindControl("RpRoom") as Repeater;
                //RpRoom.DataSource = RoomBLL.GetInstance().GetRoom(r);
                //RpRoom.DataBind();

                //BaseDictTagBLL.GetInstance().GetDictTag("HoteInst");
                ////lbHotelnst
            }
        }

        public string jingquName = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            jingquName = JingqusBLL.GetInstance().GetNameByJingqucode(this.JqCode); ;
            string strTpename = BaseDictTagBLL.GetInstance().GetDictagName("HotelType", this.HotelType);
            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", GetCurrentPriceDesc()+ jingquName + strTpename);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "hotel", hs);



            rpHotelType.DataSource = Dict.Tag.GetViewByTypeName("HotelType");
            rpHotelType.DataBind();
            if (!string.IsNullOrEmpty(this.JqCode))
            {
                this.dlArea.Visible = true;
                DataTable dt = JingquAreaBLL.GetInstance().GetByJingqucode(this.JqCode);
                rpAddress.DataSource = dt;
                rpAddress.DataBind();
            }
            else
            {
                this.dlArea.Visible = false;
            }
            ShowData();
        }


        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        } 
    }
}
