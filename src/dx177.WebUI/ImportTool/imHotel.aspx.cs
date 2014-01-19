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
using System.Net;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using dx177.WebUI.HotelInfoImport;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dx177.WebUI.ImportTool
{
    public partial class imHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            



            string getHotelInfo = string.Format("http://un.api.zhuna.cn/api/utf-8/hotelinfo.asp?hid={0}", txtHotelId.Text.Trim());
            HttpWebRequest HttpWRequest = (HttpWebRequest)WebRequest.Create(getHotelInfo);
            HttpWRequest.Method = "GET";
            HttpWRequest.ContentType = "text/xml; charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)HttpWRequest.GetResponse();

            string xmlString = string.Empty;


            

            if (response != null)
            {
               
                //Console.WriteLine("Content length is {0}", response.ContentLength);
                //Console.WriteLine("Content type is {0}", response.ContentType);

                MemoryStream msRec = default(MemoryStream);
                msRec = new MemoryStream();

                // Get the stream associated with the response.
                CopyData(response.GetResponseStream(), msRec);
                if ((msRec != null))
                {
                    xmlString = Encoding.UTF8.GetString(msRec.GetBuffer());
                    msRec.Close();
                }

                if (xmlString != string.Empty)
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(HotelInfoImport.hotelinfo));

                    byte[] bstr = Encoding.UTF8.GetBytes(xmlString);
                    MemoryStream ms = new MemoryStream(bstr);
                    hotelinfo iim = (hotelinfo)mySerializer.Deserialize(ms);

                    
                    Hotel h = new Hotel();
                    h.Address = iim.Address.v;
                    h.Descr = iim.Content;
                    h.Name = iim.HotelName;
                    h.Area = "0";
                    h.Hoteltype = "1";
                    h.Biz = iim.jianshu;
                    h.Status = 1;
                    h.Guid = StringUtil.getGuid();
                    h.Jingqucode = txtJingQuCode.Text.Trim();

                    if (HotelBLL.GetInstance().SearchHotel(new dx177.Model.Bus.QueryO.HotelQuery { Name = h.Name }).Rows.Count > 0)
                    {
                        importRoominfo(Hotel.Dt2Objs(HotelBLL.GetInstance().SearchHotel(new dx177.Model.Bus.QueryO.HotelQuery { Name = h.Name }), dx177.Model.BaseModel.ColumnNameEnum.DBName)[0]);
                        return; 
                    }


                    HotelBLL.GetInstance().Submit(h);

                    if (iim.Picture.hpicmin.Trim() != string.Empty)
                    {
                        string[] picts = iim.Picture.hpicmin.Split(',');
                        string[] txts = iim.Picture.hpictxt.Split(',');
                        int idx = 0;
                        foreach (string pic in picts)
                        {
                            if (pic.Trim() == string.Empty)
                                continue;
                            WebClient mywebclient = new WebClient();
                            string url = pic.Replace("160x120_", "");
                            string newfilename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".jpg";
                             
                            try
                            {
                                string relatepath = "/uploadfile/Hotel/" + h.Guid + "/" + newfilename;
                                
                                string filepath = Page.Server.MapPath("~" + relatepath);
                                FileInfo fi = new FileInfo(filepath);
                                if (!fi.Directory.Exists)
                                {
                                    fi.Directory.Create();
                                }

                                mywebclient.DownloadFile(url, filepath);
                                idx++;
                                if (idx == 1)
                                {
                                    h.Logo = relatepath;

                                    HotelBLL.GetInstance().Submit(h);
                                }
                                Picturelist plis = new Picturelist();
                                

                                plis.Pguid = h.Guid;
                                plis.Showidx = idx;
                                string s100path = UploadPicturesBLL.Get100pxPath(relatepath);
                                
                                DoImage.MakeSPic(100, 100, filepath, Page.Server.MapPath("~" + Path.Combine(fi.DirectoryName, s100path)));
                                string s300path = UploadPicturesBLL.Get300pxPath(relatepath);
                                DoImage.MakeSPic(300, 300, filepath, Page.Server.MapPath("~" + Path.Combine(fi.DirectoryName, s300path)));
                                string s600path = UploadPicturesBLL.Get600pxPath(relatepath);
                                DoImage.MakeSPic(600, 600, filepath, Page.Server.MapPath("~" + Path.Combine(fi.DirectoryName, s600path)));
                                plis.Smallimgfile = relatepath;
                                plis.Bigimgfile = relatepath;
                                plis.Title = txts[idx-1];
                                plis.Jingqucode = txtJingQuCode.Text;
                                PicturelistBLL.GetInstance().Submit(plis);
                                //filename = newfilename;  
                            }
                            catch (Exception ex)
                            {
                            }

                        }
                    }

                    importRoominfo(h);

                }


                

                
            }
             
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
            string getHotelInfo1 = string.Format("http://price.un.zhuna.cn/json.php?hid={0}&tm1=2011-03-22&tm2=2011-03-23", txtHotelId.Text.Trim());
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
                            r.Price1 = rm.plansCollection[0].totalprice-10;
                            r.Price2 = rm.plansCollection[0].totalprice;
                            r.Marketprice = rm.plansCollection[0].totalprice + 10;
                            RoomBLL.GetInstance().Submit(r);
                        }
                    }
                }

            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        } // CopyData
    }
}
