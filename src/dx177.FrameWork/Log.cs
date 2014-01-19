using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.IO;

namespace dx177.FrameWork
{
    public  class Log
    {
        public static string WriteError(string ModeID, string ErrMsg)
        {
            try
            {

                StringBuilder sp = new StringBuilder();
                sp.Append("登 录 人：" + HttpContext.Current.User.Identity.Name + "  ");
                sp.Append("登 录 IP：" + HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString() + "  ");
                sp.Append("ModeID：" + ModeID + "\r\n  ");
                sp.Append("ErrMsg：" + ErrMsg);
                sp.Append("地址:" + HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath));
                string sPath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath) + @"\Log";
                //string ff=HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath + System.Configuration.ConfigurationManager.AppSettings["DependencyFilePath"]);
                if (!Directory.Exists(sPath))
                {
                    Directory.CreateDirectory(sPath);
                }
                string filename = sPath + "/" + System.DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                FileStream fileStream = new FileStream(filename, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.Default);
                streamWriter.WriteLine(System.DateTime.Now.ToString() + "---" + sp.ToString() + "\r\n");
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return string.Empty;
        }

        public static void CacheDependencyNotity(string FileName)
        {
            try
            {

                StringBuilder sp = new StringBuilder();
                sp.Append("登 录 人：" + HttpContext.Current.User.Identity.Name + "  ");
                sp.Append("登 录 IP：" + HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString() + "  ");
                string sPath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath) + @"\DependencyFilePath";
                if (!Directory.Exists(sPath))
                {
                    Directory.CreateDirectory(sPath);
                }
                string filename = sPath + "/" + FileName + ".txt";
                FileStream fileStream = new FileStream(filename, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.Default);
                streamWriter.WriteLine(System.DateTime.Now.ToString() + "---" + sp.ToString() + "\r\n");
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
            }
        }
    }
}
