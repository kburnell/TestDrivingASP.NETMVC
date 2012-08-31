using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class IndexTest {

        private const string Url = "http://localhost:11074/";
        private IE _browser;

        [TestInitialize]
        public void TestInitialize() {
            _browser = new IE(Url);
        }

    }
}