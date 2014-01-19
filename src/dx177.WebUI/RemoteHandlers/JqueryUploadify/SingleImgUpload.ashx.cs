using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.RemoteHandlers.JqueryUploadify
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class SingleImgUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Expires = -1;

            try
            {
                HttpPostedFile postedFile = context.Request.Files["Filedata"];

                string saveLargePath = "";            
                string tempLargePath = "";
                
                tempLargePath = "/uploadfile/img/single/" + DateTime.Now.ToString("yyyyMMdd") + "/";
                //创建文件夹
                saveLargePath = context.Server.MapPath(tempLargePath);
                if (!Directory.Exists(saveLargePath))
                    Directory.CreateDirectory(saveLargePath);                
                //文件扩展名
                string filename = postedFile.FileName;
                string sExtension = filename.Substring(filename.LastIndexOf('.'));
                string sNewFileName = DateTime.Now.ToString("hhmmssfff");
                string tempPath = context.Server.MapPath( "/uploadfile/img/single/") + DateTime.Now.ToString("yyyyMMddhhmmssfff") + sExtension;
                //保存文件
                postedFile.SaveAs(tempPath);
                DoImage.MakeSPic(200, 200, tempPath, saveLargePath + @"\" + sNewFileName + sExtension);
                File.Delete(tempPath);
                string oldPath = context.Request["oldPicturePath"];
                if (!string.IsNullOrEmpty(oldPath))
                {
                    if (File.Exists(context.Server.MapPath(oldPath)))
                    {
                        File.Delete(context.Server.MapPath(oldPath));
                    }                
                }
                 
                 
                //图片页面访问路径
                string requestLargePath = tempLargePath + sNewFileName + sExtension;                
                //数据库保存
                //Picturelist pic = new Picturelist();
                //pic.Bigimgfile = requestLargePath;
                //pic.Smallimgfile = requestLargePath; 
                //pic.Title = filename;
                //pic.Pguid = context.Request["pguid"];
                //if (context.Request["seqno"] != null && (context.Request["seqno"] != "0" ||
                //    context.Request["seqno"] != ""))
                //{
                //    pic.CreateDate = DateTime.Now;
                //}
                //pic = PicturelistBLL.GetInstance().Submit(pic);
                context.Response.Write(CommonUnitl.JavaScriptSerializerString(new { ImgPath = requestLargePath, ShowImgPath = requestLargePath }));
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
