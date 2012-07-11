using System.Web.Routing;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {

            RouteProvider.ConfigureRoutes(routes);
        }
    }
}