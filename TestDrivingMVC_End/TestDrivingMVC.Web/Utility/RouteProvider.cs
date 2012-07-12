using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestDrivingMVC.Web.Utility {
    
    public static class RouteProvider {
        
        public static RouteCollection ConfigureRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new { controller = "Customer", action = "Index", id = "1" }, namespaces: new[] { "TestDrivingMVC.Controller" });
            return routes;
        }

    }
}