using System.Web.Routing;
using NUnit.Framework;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web.Test.Unit.App_Start {

    [TestFixture]
    public class RouteTester {

        [TestFixtureSetUp]
        public static void ClassInitialize() {
            RouteCollection routes = RouteTable.Routes;
            RouteProvider.ConfigureRoutes(routes);
        }

    }
}