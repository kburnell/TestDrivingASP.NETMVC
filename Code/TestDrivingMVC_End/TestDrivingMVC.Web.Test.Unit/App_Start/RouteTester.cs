using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using TestDrivingMVC.Web.Customer;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web.Test.Unit.App_Start {

    [TestClass]
    public class RouteTester {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            RouteCollection routes = RouteTable.Routes;
            RouteProvider.ConfigureRoutes(routes);
        }

        [TestMethod]
        public void RequestGoingTo_Whack_ShouldMapTo_CustomerIndex() {
            //Arrange
            string url = "~/";
            //Act & Assert
            url.ShouldMapTo<CustomerController>(action => action.Index(1));
        }


        [TestMethod]
        public void RequestTo_Wack_TraceAxd_ShouldBe_Ignored()
        {
            //Arrange
            string url = "~/trace.axd";
            //Act & Assert
            url.ShouldBeIgnored();
        }
    }
}