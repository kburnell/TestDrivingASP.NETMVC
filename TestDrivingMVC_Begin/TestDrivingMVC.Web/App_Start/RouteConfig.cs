﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {
            //Out of the box
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = "1" },
                namespaces: new[] { "TestDrivingMVC.Controller" });
            //RouteProvider.ConfigureRoutes(routes);
        }
    }
}