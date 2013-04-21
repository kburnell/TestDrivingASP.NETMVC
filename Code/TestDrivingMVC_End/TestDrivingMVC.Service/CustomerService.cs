using System;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Core.Entities;
using TestDrivingMVC.Service.Interfaces.Service;

namespace TestDrivingMVC.Service {

    public class CustomerService : ICustomerService {

        readonly ILoggingService _logger;

        public CustomerService(ILoggingService loggingService) {
            _logger = loggingService;
        }

        public Customer GetById(long id) {
            _logger.LogInfo(string.Format("Calling GetById with {0}", id));
            return new Customer {Id = id, FirstName = "Keith", LastName = "Burnell", DateOfBirth = new DateTime(1978, 2, 21)};
        }
    }

}