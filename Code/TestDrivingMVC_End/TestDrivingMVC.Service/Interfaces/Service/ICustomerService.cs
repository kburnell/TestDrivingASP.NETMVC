
using TestDrivingMVC.Core.Entities;

namespace TestDrivingMVC.Service.Interfaces.Service {

    public interface ICustomerService {

        Customer GetById(long id);

    }

}