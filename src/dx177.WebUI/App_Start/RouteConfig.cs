using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dx177.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
     
            routes.MapRoute(
               name: "coustomer",
               url: "{controller}/{action}/{id}",
               defaults: new {action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "JQRouter",
               url: "jq_{jingqucode}/{controller}/{action}",
               defaults: new { action = "Index" }
           );




        }
    }
}