﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using Should;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Controller.Customer;
using TestDrivingMVC.Test.Shared.Fakes.Service;

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
        public void Index_Should_Return_ViewNamed_Index() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(1);
            //Assert
            result.AssertViewRendered().ForView("Index");
        }

        [TestMethod]
        public void Index_ShouldReturn_ViewWithModel_OfType_Customer() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(1);
            //Assert
            //Assert.IsInstanceOfType((((ViewResult) result).Model), typeof (Common.Domain.Customer));
            ((ViewResult) result).Model.ShouldBeType<Common.Domain.Customer>();
        }

        [TestMethod]
        public void Index_Post_ShouldRedirectTo_Step2() {
            //Arrange
            CustomerController controller = new CustomerController(_loggingServiceFake, _customerServiceFake);
            //Act
            ActionResult result = controller.Index(new Common.Domain.Customer {Id = 1});
            //Assert
            result.AssertActionRedirect().ToAction("Step2");
        }
    }

}
