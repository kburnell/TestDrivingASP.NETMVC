using TestDrivingMVC.Common.Domain;
using TestDrivingMVC.Common.Interfaces.Service;

namespace TestDrivingMVC.Test.Shared.Fakes.Service {

    public class CustomerServiceFake : ICustomerService {

        public Customer GetById(long id) {
            return new Customer();
        }

        public bool IsCustomerRegistered(Customer customer) {
            return true;
        }

        public bool CreateCustomer(Customer customer) {
            return true;
        }

        public bool UpdateCustomer(Customer customer) {
            return true;
        }

        public bool DeleteCustomer(Customer customer) {
            return true;
        }
    }
}