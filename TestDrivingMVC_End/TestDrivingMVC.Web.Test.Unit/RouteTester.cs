using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using TestDrivingMVC.Controller.Customer;
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


        [TestMethod]
        public void RequestGoingTo_Wack_ShouldMapTo_Customer_Index() {
            //Arrange
            string url = "~/";
            //Act & Assert
            url.ShouldMapTo<CustomerController>(action => action.Index(1));
        }

        [TestMethod]
        public void RequestGoingTo_Wack_Customer_ShouldMapTo_Customer_Index() {
            //Arrange
            string url = "~/customer";
            //Act & Assert
            url.ShouldMapTo<CustomerController>(action => action.Index(1));
        }

        [TestMethod]
        public void RequestTo_Wack_TraceAxd_ShouldBe_Ignored() {
            //Arrange
            string url = "~/trace.axd";
            //Act & Assert
            url.ShouldBeIgnored();
        }
        
    }
}