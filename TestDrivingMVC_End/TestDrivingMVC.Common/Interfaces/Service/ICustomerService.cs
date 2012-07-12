using TestDrivingMVC.Common.Domain;

namespace TestDrivingMVC.Common.Interfaces.Service {

    public interface ICustomerService {

        Customer GetById(long id);

        bool IsCustomerRegistered(Customer customer);

        bool CreateCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Customer customer);

    }

}