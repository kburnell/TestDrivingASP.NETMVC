using System.Web.Mvc;
using System.Web.Routing;

namespace TestDrivingMVC.Web.Utility {

    public static class RouteProvider {

        public static RouteCollection ConfigureRoutes(RouteCollection routes) {
            routes.Clear();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", 
                defaults: new {controller = "Customer", action = "Index", id = "1"});
            return routes;
        }
    }
}