using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using Rhino.Mocks;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Controller.Customer;
using TestDrivingMVC.Test.Shared.Fakes.Service;
using Should;

namespace TestDrivingMVC.Controller.Test.Unit {

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
        public void Index_ShouldReturn_ViewWithModelofType_Customer() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(1);
            //Assert
            //Assert.IsInstanceOfType(((ViewResult) result).Model, typeof (Common.Domain.Customer));
            ((ViewResult) result).Model.ShouldBeType<Common.Domain.Customer>();
        }

        [TestMethod]
        public void Index_ShouldReturn_ViewWithModelofType_Customer_With_Idof_1_WhenPassed_1() {
            //Arrange
            // - Fake (No need to mock logging service)
            ILoggingService loggingServiceFake = new LoggingServiceFake();
            // - Mocks
            MockRepository mockRepo = new MockRepository();
            ICustomerService customerServiceMock = mockRepo.StrictMock<ICustomerService>();
            customerServiceMock.Expect(x => x.GetById(1)).Return(new Common.Domain.Customer {Id = 1}).Repeat.Once();
            CustomerController controller = new CustomerController(loggingServiceFake, customerServiceMock);
            mockRepo.ReplayAll();
            //Act
            Common.Domain.Customer result = (Common.Domain.Customer)((ViewResult)controller.Index(1)).Model;
            //Assert
            mockRepo.VerifyAll();
            result.Id.ShouldEqual(1);
        }

    }
}