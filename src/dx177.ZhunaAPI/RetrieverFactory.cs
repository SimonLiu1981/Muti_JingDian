using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.ZhuNaAPI.Utility;
using System.Collections.Specialized;
using dx177.ZhuNaAPI.ZhunaEntities;

namespace dx177.ZhuNaAPI
{
    public static class RetrieverStaticFactory
    {

        
       static ISerializer serJson = new JsonHelper();
       static ISerializer serXml = new XmlHelper();

        public static T GetResponse<T>(NameValueCollection nameValueColl)
        {
            T res = default(T);
           
            switch (typeof(T).Name)
            {
                case "City":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_city", nameValueColl)));                    
                    break;
                case "Area":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_area", nameValueColl)));
                    break;
                case "CenterBinessDistrct":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_area", nameValueColl)));
                    break;
                case "Chain":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_chain", nameValueColl)));
                    break;
                case "HotelUpdateInfoList":
                    res = serXml.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_hotelupdateinfo", nameValueColl)));
                    break;
                case "HotelSearch":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_hotelretrieve", nameValueColl)));
                    break;
                case "HotelPics":
                    HotelPics hp = RegParseTools.GetHotelPics(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_hotelpicture", nameValueColl)));
                    res = (T)(object)hp;
                    break;
                case "ZNHotel":
                    res = serJson.Deserialize<T>(HttpHelper.GetHttpUrlData(UrlBuilder.GetUrlByConfiguration("url_hotelinfo", nameValueColl)));
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
