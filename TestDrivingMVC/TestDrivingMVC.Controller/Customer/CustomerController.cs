using System.Web.Mvc;
using TestDrivingMVC.Common.Interfaces.Service;

namespace TestDrivingMVC.Controller.Customer {

    public class CustomerController : System.Web.Mvc.Controller {

        private readonly ILoggingService _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILoggingService logger, ICustomerService customerService) {
            _logger = logger;
            _customerService = customerService;
        }

        public ActionResult Index(int id) {
            _logger.LogInfo(string.Format("Hit Customer/Index/{0}", id));
            return View("Index", _customerService.GetById(id));
        }
        
    }
}