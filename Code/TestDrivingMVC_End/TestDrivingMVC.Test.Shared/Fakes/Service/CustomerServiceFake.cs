using TestDrivingMVC.Core.Entities;
using TestDrivingMVC.Service.Interfaces.Service;

namespace TestDrivingMVC.Test.Shared.Fakes.Service {

    public class CustomerServiceFake : ICustomerService {

        public Customer GetById(long id) {
            return new Customer();
        }
    }
}