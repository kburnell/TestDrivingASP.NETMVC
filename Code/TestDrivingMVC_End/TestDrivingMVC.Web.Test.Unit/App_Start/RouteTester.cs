using System.Web.Routing;
using MvcContrib.TestHelper;
using NUnit.Framework;
using TestDrivingMVC.Web.Customer;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web.Test.Unit.App_Start {

    [TestFixture]
    public class RouteTester {

        [TestFixtureSetUp]
        public static void ClassInitialize() {
            RouteCollection routes = RouteTable.Routes;
            RouteProvider.ConfigureRoutes(routes);
        }

        [Test]
        public void RequestGoingTo_Whack_ShouldMapTo_CustomerIndex() {
            //Arrange
            string url = "~/";
            //Act & Assert
            url.ShouldMapTo<CustomerController>(action => action.Index(1));
        }


        [Test]
        public void RequestTo_Wack_TraceAxd_ShouldBe_Ignored()
        {
            //Arrange
            string url = "~/trace.axd";
            //Act & Assert
            url.ShouldBeIgnored();
        }
    }
}