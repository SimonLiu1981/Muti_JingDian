using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using dx177.Model.Bus;
using dx177.Business.Bus;
using System.Web.Script.Serialization;
using dx177.FrameWork;

namespace dx177.WebUI.RemoteHandlers.JqueryUploadify
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class uploadimg : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Expires = -1;

            try
            {

                HttpPostedFile postedFile = context.Request.Files["Filedata"];

                string saveLargePath = "";
                string saveSmallPath = "";
                string tempLargePath = "";
                string tempSmallPath = "";
                tempLargePath = "/uploadfile/img/large/" + DateTime.Now.ToString("yyyyMMdd") + "/";
                tempSmallPath = "/uploadfile/img/small/" + DateTime.Now.ToString("yyyyMMdd") + "/";
                //创建文件夹
                saveLargePath = context.Server.MapPath(tempLargePath);
                if (!Directory.Exists(saveLargePath))
                    Directory.CreateDirectory(saveLargePath);
                saveSmallPath = context.Server.MapPath(tempSmallPath);
                if (!Directory.Exists(saveSmallPath))
                    Directory.CreateDirectory(saveSmallPath);
                //文件扩展名
                FileInfo finfo = new FileInfo(postedFile.FileName);
                string filename = finfo.Name.Replace(finfo.Extension, "");
                string sExtension = finfo.Extension;
                string sNewFileName = DateTime.Now.ToString("hhmmssfff");
                //保存文件
                postedFile.SaveAs(saveLargePath + @"\" + sNewFileName + sExtension);
                DoImage.MakeSPic(200, 200, saveLargePath + @"\" + sNewFileName + sExtension, saveSmallPath + @"\" + sNewFileName + sExtension);

                //图片页面访问路径
                string requestLargePath = tempLargePath + sNewFileName + sExtension;
                string requestSmallPath = tempSmallPath + sNewFileName + sExtension;
                //数据库保存
                Picturelist pic = new Picturelist();
                pic.Bigimgfile = requestLargePath;
                pic.Smallimgfile = requestSmallPath;
                pic.Title = filename;
                pic.Pguid = context.Request["pguid"];
                if (context.Request["seqno"] != null && (context.Request["seqno"] != "0" ||
                    context.Request["seqno"] != ""))
                {
                    pic.CreateDate = DateTime.Now;
                }
                pic = PicturelistBLL.GetInstance().Submit(pic);
                context.Response.Write(CommonUnitl.JavaScriptSerializerString(pic));
                context.Response.StatusCode = 200;
            }
            catch (Exception ex)
            {
                context.Response.Write("Error: " + ex.Message);
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        

    }
}
