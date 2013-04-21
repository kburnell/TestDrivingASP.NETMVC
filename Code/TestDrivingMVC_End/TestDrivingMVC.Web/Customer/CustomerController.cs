using System.Web.Mvc;
using TestDrivingMVC.Common.Interfaces.Service;
using TestDrivingMVC.Service;
using TestDrivingMVC.Service.Interfaces.Service;

namespace TestDrivingMVC.Web.Customer {

    public class CustomerController : Controller {

        //[Voice of James Earl Jones as the Enterprise Architect]
        //Every controller must log it's in action's when in debug mode
        private readonly ILoggingService _logger;
        private readonly ICustomerService _customerService;


        public CustomerController(ILoggingService logger, ICustomerService customerService) {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult Index(int id) {
            _logger.LogInfo(string.Format("Hit Customer/Index/{0}", id));
            return View("Index", _customerService.GetById(id));
        }

        [HttpPost]
        public ActionResult Index(Core.Entities.Customer customer) {
            return RedirectToAction("Step2", "Customer", new { id = customer.Id });
        }

        [HttpGet]
        public ActionResult Step2(int id) {
            return View("Step2", _customerService.GetById(1));
        }

        [HttpGet]
        public ActionResult Create() {
            return View("Create");
        }
    }
}