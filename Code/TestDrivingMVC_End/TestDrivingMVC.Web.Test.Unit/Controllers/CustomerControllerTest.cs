using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Service.Interfaces.Service;
using TestDrivingMVC.Test.Shared.Fakes.Service;
using TestDrivingMVC.Web.Customer;

namespace TestDrivingMVC.Web.Test.Unit.Controllers {

    [TestClass]
    public class CustomerControllerTest {

        private static ILoggingService _loggingServiceFake;
        private static ICustomerService _customerServiceFake;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            _loggingServiceFake = new LoggingServiceFake();
            _customerServiceFake = new CustomerServiceFake();
        }


        [TestMethod]
        public void Index_ShouldReturn_ViewNamed_Index() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(1);
            //Assert
            result.AssertViewRendered().ForView("Index");
        }

        [TestMethod]
        public void Index_ShouldReturn_ViewWithModelofType_Customer()
        {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ViewResult result = (ViewResult)controller.Index(1);
            //Assert
            Assert.IsInstanceOfType(result.Model, typeof(Core.Entities.Customer));
        }
        

    }
}
