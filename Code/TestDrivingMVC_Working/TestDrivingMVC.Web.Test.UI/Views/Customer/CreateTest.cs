using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class CreateTest {

        private const string Url = "http://localhost:11074/Customer/Create";
        private IE _browser;

        [TestInitialize]
        public void TestInitialize() {
            _browser = new IE(Url);
        }
        
    }

}