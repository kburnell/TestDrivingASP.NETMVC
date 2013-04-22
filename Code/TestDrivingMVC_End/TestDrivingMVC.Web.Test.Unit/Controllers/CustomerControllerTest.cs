using System.Web.Mvc;
using MvcContrib.TestHelper;
using FluentAssertions;
using NUnit.Framework;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Service.Interfaces.Service;
using TestDrivingMVC.Test.Shared.Fakes.Service;
using TestDrivingMVC.Web.Customer;

namespace TestDrivingMVC.Web.Test.Unit.Controllers {

    [TestFixture]
    public class CustomerControllerTest {

        private static ILoggingService _loggingServiceFake;
        private static ICustomerService _customerServiceFake;

        [SetUp]
        public static void ClassInitialize() {
            _loggingServiceFake = new LoggingServiceFake();
            _customerServiceFake = new CustomerServiceFake();
        }


        [Test]
        public void Index_ShouldReturn_ViewNamed_Index() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(1);
            //Assert
            result.AssertViewRendered().ForView("Index");
        }

        [Test]
        public void Index_ShouldReturn_ViewWithModelofType_Customer()
        {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ViewResult result = (ViewResult)controller.Index(1);
            //Assert
            result.Model.Should().BeOfType<Core.Entities.Customer>();
            //Assert.IsInstanceOfType(result.Model, typeof(Core.Entities.Customer));
        }

        [Test]
        public void IndexPost_ShouldRedirectTo_Step2()
        {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(new Core.Entities.Customer { Id = 1 });
            //Assert
            result.AssertActionRedirect().ToAction("Step2");
        }
        

    }
}
