using TestDrivingMVC.Common.Domain;

namespace TestDrivingMVC.Common.Interfaces.Service {

    public interface ICustomerService {

        Customer GetById(long id);

    }

}