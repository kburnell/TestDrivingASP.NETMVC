using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivingMVC.Common.Interfaces.Service;
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

    }
}
