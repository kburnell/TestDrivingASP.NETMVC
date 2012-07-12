using System;
using TestDrivingMVC.Common.Domain;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Common.Utility;

namespace TestDrivingMVC.Service {

    public class CustomerService : ICustomerService {

        readonly ILoggingService _logger;

        public CustomerService(ILoggingService logger) {
            _logger = logger;
        }

        public CustomerService() {
            _logger = Resolver.GetConcreteInstanceOf<ILoggingService>();
        }

        public Customer GetById(long id) {
            _logger.LogInfo(string.Format("Calling GetById with {0}", id));
            return new Customer {Id = id, FirstName = "Keith", LastName = "Burnell", DateOfBirth = new DateTime(1978, 2, 21)};
        }

        public bool IsCustomerRegistered(Customer customer) {
            throw new NotImplementedException();
        }

        public bool CreateCustomer(Customer customer) {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer) {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customer) {
            throw new NotImplementedException();
        }
    }

}