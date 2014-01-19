/*
版权所有：版权所有(C) 2008，中兴通讯
文件编号：BL_CN0000101_UrlUtility.cs
系统编号：Z0003007
系统名称：通用办公系统
设计文档：IOA_CN000_ShareLib 公用组件组件设计模型.cat
完成日期：2009-5-4
作　　者：刘建新
内容摘要：Htmp的URL串参数处理方法类 
*/


using System;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Configuration;
using System.Web.UI;

namespace dx177.FrameWork
{
    /// <summary>      
    /// 内容摘要：Htmp的URL串参数处理方法类 
    /// 编码人员：刘建新
    /// 完成日期：2009-5-4
    /// </summary>
    public static class UrlUtility
    {


        public static string GenerateURL(Page page, string[] paramters)
        {
            string rawUrl = page.Request.RawUrl;
           
            return  GenerateURL(rawUrl, paramters);
        }

        public static string GenerateURL(string rawUrl, string[] paramters)
        {
            foreach (var str in paramters)
            {
                string[] split = str.Split('=');
                if (split.Length == 2)
                {
                    if (!split[0].Equals(ConstantElements.QueryStringNameJQ))
                    {
                        rawUrl = AddOrReplaceParam(rawUrl, split[0], split[1], false);
                    }
                }                
            }

            return rawUrl;
        }

        #region 公有方法
        /// <summary>
        /// 路径加密
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string UrlEncode(string url)
        {
            return System.Web.HttpUtility.UrlEncode(url, Encoding.GetEncoding("utf-8"));
        }
        
        /// <summary>
        /// 增加或替换URL串里的参数queryStrName
        /// </summary>
        /// <param name="sourceURL">原URL串</param>
        /// <param name="nameValueColl">
        /// 参数集合
        ///     请使用 NameValueCollection coll = new NameValueCollection();
        ///            coll.Set("A","A value");方式处理
        /// </param>        
        /// <returns>
        /// 返回更新后的URL串
        /// </returns>
        public static string AddOrReplaceParam(string sourceURL, NameValueCollection nameValueColl)
        {
            for (int i = 0; i < nameValueColl.Count; i++)
            {
                sourceURL = addorRemoveParamFromUrl(sourceURL, nameValueColl.GetKey(i), nameValueColl[nameValueColl.GetKey(i)],true, true);
            }
            return sourceURL;
            //return addorRemoveParamFromUrl(sourceURL, queryStrName, queryStrValue, true);
        }


        /// <summary>
        /// 增加或替换URL串里的参数queryStrName
        /// </summary>
        /// <param name="sourceURL">原URL串</param>
        /// <param name="queryStrName">参数名</param>
        /// <param name="queryStrValue">参数值</param>
        /// <param name="needUrlEncode">如果是true，则默认给queryStrValue，UrlEncode</param>
        /// <returns>
        /// 返回更新后的URL串
        /// </returns>
        public static string AddOrReplaceParam(string sourceURL, string queryStrName, string queryStrValue,bool needUrlEncode)
        {
            return addorRemoveParamFromUrl(sourceURL, queryStrName, queryStrValue, needUrlEncode, true);
        }

        /// <summary>
        /// 从URL串里删除参数queryStrName
        /// </summary>
        /// <param name="sourceURL">原URL串</param>
        /// <param name="queryStrName">参数名</param>
        /// <returns>
        /// 返回更新后的URL串
        /// </returns>
        public static string RemoveParam(string sourceURL, string queryStrName)
        {   
            return addorRemoveParamFromUrl(sourceURL, queryStrName, string.Empty,false, false);
        }


        #endregion

        #region 私有方法
        /// <summary>
        /// 增加或者删除URL中的queryStrName
        /// </summary>
        /// <param name="sourceURL">原URL串</param>
        /// <param name="queryStrName">参数名</param>
        /// <param name="queryStrValue">参数值（请不要UrlEncode）</param>
        /// <param name="needUrlEncode">如果是true，则默认给queryStrValue，UrlEncode</param>
        /// <param name="add">增加：true，删除：false</param>
        /// <returns>返回更新后的URL串</returns>
        private static string addorRemoveParamFromUrl(string sourceURL, string queryStrName, string queryStrValue,bool needUrlEncode, bool add)
        {
            
            if (queryStrName == null || queryStrName.Trim() == string.Empty) return sourceURL;

            string pattern = "[&?]((?<paramName>[^=]*)=(?<paramValue>[^&]*))";
            MatchCollection matchs = Regex.Matches(sourceURL, pattern);//取得匹配

            StringBuilder returnVal = new StringBuilder(Regex.Replace(sourceURL, pattern, string.Empty));//替换所有的匹配 
            StringBuilder strQueryString = new StringBuilder();
            bool flag = false;//是否包括了queryStrName参数
            string tmp = "&{0}={1}";
            //查找
            foreach (Match match in matchs)
            {

                if (match.Groups["paramName"].ToString().ToLower() == queryStrName.ToLower())
                {
                    flag = true;
                    if (add)
                        strQueryString.AppendFormat(tmp, queryStrName,
                            needUrlEncode ? System.Web.HttpUtility.UrlEncode(queryStrValue, Encoding.GetEncoding("utf-8")) : queryStrValue);
                }
                else
                {
                    strQueryString.AppendFormat(tmp, match.Groups["paramName"].ToString(), match.Groups["paramValue"].ToString());
                }

            }
            if (!flag)
            {
                if (add)
                    strQueryString.AppendFormat(tmp, queryStrName,
                        needUrlEncode ? System.Web.HttpUtility.UrlEncode(queryStrValue, Encoding.GetEncoding("utf-8")) : queryStrValue);
            }

            if (!string.IsNullOrEmpty(strQueryString.ToString().Trim('&')))
            {
                returnVal.Append("?").Append(strQueryString.ToString().Trim('&'));
            }
            return returnVal.ToString();
        }
        #endregion


        
    }
}
