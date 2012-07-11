using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web.Test.Unit {

    [TestClass]
    public class RouteTester {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            RouteCollection routes = RouteTable.Routes;
            routes.Clear();
            RouteProvider.ConfigureRoutes(routes);
        }

    }
}