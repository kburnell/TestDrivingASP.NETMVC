using System.Web.Routing;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using TestDrivingMVC.Controller.Customer;
using TestDrivingMVC.Web.Utility;
using RouteParameter = System.Web.Http.RouteParameter;

namespace TestDrivingMVC.Web.Test.Unit {

    [TestClass]
    public class RouteTester {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            RouteCollection routes = RouteTable.Routes;
        }

    }
}