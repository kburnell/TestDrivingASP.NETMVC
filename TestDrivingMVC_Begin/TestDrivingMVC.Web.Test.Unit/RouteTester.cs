using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivingMVC.Web.Test.Unit {

    [TestClass]
    public class RouteTester {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            RouteCollection routes = RouteTable.Routes;
            routes.Clear();
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new {controller = "Customer", action = "Index", id = "1"}, namespaces: new[] {"TestDrivingMVC.Controller"});
        }
    }
}