using MvcToHtml.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcToHtml
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/{filename}.html");

            routes.MapRoute("test", "Test/page1.html", new { controller = "d", action = "a" });
            routes.MapRoute(
                 "Default",
                 "{controller}/{action}/{id}",
                 new { controller = "Default1", action = "Index", id = UrlParameter.Optional },
                 new { ttt =new UserExplorer("Chrome")}
            );
           
        }
    }
}