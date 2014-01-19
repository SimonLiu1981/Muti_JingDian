using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using dx177.WebUI.HotelInfoImport;
using dx177.Model.Bus;
using dx177.FrameWork;
using System.Xml;
using Newtonsoft.Json;
using dx177.Business.Bus;
using dx177.ZhuNaAPI.ZhunaEntities;
using dx177.ZhuNaAPI;
using System.Collections.Specialized;
using System.Threading;

namespace dx177.WebUI.ImportTool
{
    public partial class Syncupzhuna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RefHotelId) && !string.IsNullOrEmpty(JingQuCode))
            {
                SyncUp();
            }
        }

        private string RefHotelId
        {
            get
            {
                return Request.QueryString["hid"];
            }
        }
        private string JingQuCode
        {
            get
            {
                return Request.QueryString["jqcode"];
            }
        }
        protected void SyncUp()
        {
            NameValueCollection myCol = new NameValueCollection();
            myCol.Add("hid", RefHotelId);
            ZNHotel ht = RetrieverStaticFactory.GetResponse<ZNHotel>(myCol);
            HotelPics hps = RetrieverStaticFactory.GetResponse<HotelPics>(myCol);
            bool isnew = true;

            Hotel h = HotelBLL.GetInstance().GetByHotelRefInfo(HotelRefType.ZhuNa, RefHotelId);
            if (h != null)
            {
                isnew = false;
            }
            else
            {
                h = new Hotel();
                h.Guid = StringUtil.getGuid();
                h.Status = 1;
                h.Area = "0";               
            }

            h.Hoteltype = ConvertXinJi(ht.Detail.xingji);
            h.Address = ht.Detail.Address;
            h.Descr = ht.Detail.content;
            h.Name = ht.Detail.HotelName;            
            h.Biz = ht.Detail.jianshu;                        
            h.Logo = SaveImg(ht.Detail.Picture, h); 
            h.Jingqucode = JingQuCode;
            if (ht.Detail.min_jiage != null)
            {
                h.Minprice = ht.Detail.min_jiage.Value;
            }
            if (ht.Detail.max_jiangjin != null)
            {
                h.Maxprice = ht.Detail.max_jiangjin.Value;
            }
            else
            {
                h.Maxprice = h.Minprice;
            }
            h.Reftype = (int)HotelRefType.ZhuNa;
            h.Refhotelid = int.Parse(RefHotelId);
            HotelBLL.GetInstance().Submit(h);
            if (!isnew)
            {
                PicturelistBLL.GetInstance().DeleteByPGuid(h.Guid);
            }

            int idx = 0;
            foreach (HotelPicEntity pic in hps.Pics)
            {
                idx++;
                Picturelist plis = new Picturelist();
                plis.Pguid = h.Guid;
                plis.Showidx = idx;
                plis.Smallimgfile = SaveImg(pic.pic160, h); ;
                plis.Bigimgfile = SaveImg(pic.Pic500, h); ;
                plis.Title = pic.Title;
                plis.Jingqucode = JingQuCode;
                PicturelistBLL.GetInstance().Submit(plis);
            }
            HotelBLL.GetInstance().Submit(h);
        }

        private string ConvertXinJi(int xj)
        {
            if (xj <= 2)
            {
                return "2";
            }

            if (xj >= 5)
            {
                return "5";
            }
            return xj.ToString();
        }

        private string SaveImg(string imgUrl, Hotel h)
        {
            WebClientPlus mywebclient = new WebClientPlus();
            FileInfo fi = new FileInfo(GetFileName(imgUrl));
            string newfilename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".jpg";

            string relatepath = "/uploadfile/Hotel/" + h.Guid + "/" + fi.Name;
            string filepath = Page.Server.MapPath("~" + relatepath);
            FileInfo fi1 = new FileInfo(filepath);
            if (!fi1.Directory.Exists)
            {
                fi1.Directory.Create();
            }

            int tryTime = 5;
            while (tryTime > 0)
            {

                try
                {
                    mywebclient.DownloadFile(imgUrl, filepath);
                    tryTime = 0;
                }
                catch (Exception)
                {
                    tryTime--;
                    Thread.Sleep(100);
                    if (tryTime == 0)
                    {
                        throw;
                    }
                }
            }
            return relatepath;
        }

        private string GetFileName(string fullUrl)
        {
            int idx = fullUrl.LastIndexOf('/');
            return fullUrl.Substring(idx);
        }

        public void CopyData(Stream FromStream, Stream ToStream)
        {
            // This routine copies content from one stream to another, regardless
            // of the media represented by the stream.

            // This will track the # bytes read from the FromStream
            int intBytesRead = 0;

            // The maximum size of each read
            const int intSize = 4096;
            byte[] bytes = new byte[intSize + 1];

            // Read the first bit of content, then write and read all the content
            // From the FromStream to the ToStream.
            intBytesRead = FromStream.Read(bytes, 0, intSize);
            while (intBytesRead > 0)
            {
                ToStream.Write(bytes, 0, intBytesRead);
                intBytesRead = FromStream.Read(bytes, 0, intSize);
            }
        }


        private void importRoominfo(Hotel h)
        {
            string getHotelInfo1 = string.Format("http://price.un.zhuna.cn/json.php?hid={0}&tm1={1}&tm2={2}", RefHotelId, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            HttpWebRequest HttpWRequest = (HttpWebRequest)WebRequest.Create(getHotelInfo1);
            HttpWRequest.Method = "GET";
            HttpWRequest.ContentType = "text/xml; charset=UTF-8";

            HttpWebResponse response1 = (HttpWebResponse)HttpWRequest.GetResponse();


            if (response1 != null)
            {

                //Console.WriteLine("Content length is {0}", response.ContentLength);
                //Console.WriteLine("Content type is {0}", response.ContentType);


                MemoryStream msRec = new MemoryStream();

                // Get the stream associated with the response.
                CopyData(response1.GetResponseStream(), msRec);
                if ((msRec != null))
                {
                    string xmlString = Encoding.UTF8.GetString(msRec.GetBuffer());
                    msRec.Close();

                    if (xmlString != string.Empty)
                    {
                        string json = "{'HotelRoomInfos': {\"RoomInfo\":" + xmlString + "}}";
                        XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json);
                        XmlSerializer mySerializer = new XmlSerializer(typeof(HotelRoomInfos.HotelRoomInfos));

                        byte[] bstr = Encoding.UTF8.GetBytes(doc.InnerXml);
                        MemoryStream ms = new MemoryStream(bstr);
                        HotelRoomInfos.HotelRoomInfos iim = (HotelRoomInfos.HotelRoomInfos)mySerializer.Deserialize(ms);

                        foreach (HotelRoomInfos.rooms rm in iim.RoomInfoCollection[0].roomsCollection)
                        {
                            List<Room> rs = RoomBLL.GetInstance().GetRoomByname(rm.title, h.Guid);
                            Room r = new Room();
                            if (rs.Count > 0)
                            {
                                r = rs[0];
                            }
                            r.Guid = StringUtil.getGuid();
                            r.Pguid = h.Guid;
                            r.Roomtitle = rm.title;
                            r.CreateDate = DateTime.Now;
                            r.Descr = rm.notes;
                            r.Price1 = rm.plansCollection[0].totalprice - 10;
                            r.Price2 = rm.plansCollection[0].totalprice;
                            r.Marketprice = rm.plansCollection[0].totalprice + 10;
                            RoomBLL.GetInstance().Submit(r);
                        }
                    }
                }

            }

        }
    }
}
