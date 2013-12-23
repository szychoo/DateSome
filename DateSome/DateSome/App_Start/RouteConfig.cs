using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DateSome
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{userProfileId}",
            //    defaults: new { controller = "Profile", action = "Show", userProfileId = 1 }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{senderId}/{receiverId}",
                defaults: new { controller = "Message", action = "Send", senderId = 1, receiverId = 1}
            );
        }
    }
}
