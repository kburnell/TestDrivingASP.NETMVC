using NUnit.Framework;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Service.Interfaces.Service;
using TestDrivingMVC.Test.Shared.Fakes.Service;

namespace TestDrivingMVC.Web.Test.Unit.Controllers {

    [TestFixture]
    public class CustomerControllerTest {

        private static ILoggingService _loggingServiceFake;
        private static ICustomerService _customerServiceFake;

        [SetUp]
        public static void ClassInitialize(TestContext context) {
            _loggingServiceFake = new LoggingServiceFake();
            _customerServiceFake = new CustomerServiceFake();
        }

    }
}
