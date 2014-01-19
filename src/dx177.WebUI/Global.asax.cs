using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using dx177.FrameWork;
using dx177.WebUI.admin.JingQuMgnt;
using dx177.Model.Bus;
using System.Collections.Generic;
using dx177.Business.Bus;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Optimization;

namespace dx177.WebUI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            //System.Collections.Specialized.NameValueCollection nvc = Request.Headers;
            //string oldUrl = nvc.Get("host").ToLower().Trim();//这里已经得到了进入的域名            
            //if (oldUrl.StartsWith("www") 
            //    || oldUrl.StartsWith("localhost") 
            //    || oldUrl.ToLower() == System.Configuration.ConfigurationManager.AppSettings["DomainUri"].ToLower()
            //    || Request.Url.ToString().ToLower().IndexOf("changeimageinfo.aspx") != -1
            //    || Request.Url.ToString().ToLower().IndexOf("reply.aspx") != -1)
                
            //{
            //    return;
            //}
            //else//这里实现二级域名
            //{
            //    if (listJingqu == null)
            //    {
            //        listJingqu = new List<Jingqus>();
            //        IList il = JingqusBLL.GetInstance().Select();
            //        foreach (Jingqus tmp in il)
            //        {
            //            listJingqu.Add(tmp);
            //        }
            //    }


            //    char[] t = ".".ToCharArray();
            //    string[] temp = oldUrl.Split(t);

            //    string jingqucode = FindJingQuCode(temp[0]);
            //    if (jingqucode == string.Empty)
            //    {
            //        string url = "~/UndefinedJingQu.aspx";
            //        this.Context.RewritePath(url);
            //    }
            //    else
            //    {
                    
            //        System.Text.StringBuilder sb = new System.Text.StringBuilder("/");
            //        sb.Append(Request.RawUrl);                     
            //        string uri = UrlUtility.AddOrReplaceParam(sb.ToString(), "jingqucode", jingqucode, true);
            //        this.Context.RewritePath(uri);
            //    }
            //}

        }

        //string FindJingQuCode(string subDomain)
        //{
        //    if (listJingqu == null || listJingqu.Count == 0)
        //    {
        //        return string.Empty;
        //    }
        //    foreach (Jingqus tmp in listJingqu)
        //    {
        //        if (tmp.Matchdomain.ToLower().Equals(subDomain.ToLower()))
        //        {
        //            return tmp.Jingqucode;
        //        }
        //    }
        //    return string.Empty;
        //}

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}