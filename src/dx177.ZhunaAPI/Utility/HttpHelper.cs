using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace dx177.ZhuNaAPI.Utility
{
    public class HttpHelper
    {
        /// <summary>
        /// 获取http-url数据
        /// </summary>
        /// <param name="url">url</param>
        /// <returns></returns>
        public static string GetHttpUrlData(string url)
        {
            string apiurldata = "";
            bool retry = true;
            try
            {
                while (retry)
                {
                    WebRequest request = WebRequest.Create(url);
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                    apiurldata = reader.ReadToEnd();

                    reader.Close();
                    reader.Dispose();
                    response.Close();
                    if (apiurldata.IndexOf("<script>") == -1)
                    {
                        retry = false;
                    }
                }
 
            }
            catch (Exception ex)
            {
                apiurldata = ex.Message;
            }
            return apiurldata;
        }
    }
}
