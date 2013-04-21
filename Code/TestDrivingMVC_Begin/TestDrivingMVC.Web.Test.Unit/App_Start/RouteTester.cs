using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web.Test.Unit.App_Start {

    [TestClass]
    public class RouteTester {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            RouteCollection routes = RouteTable.Routes;
            RouteProvider.ConfigureRoutes(routes);
        }

    }
}