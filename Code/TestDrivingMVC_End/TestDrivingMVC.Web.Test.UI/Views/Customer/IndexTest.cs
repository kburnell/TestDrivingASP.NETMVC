using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
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

        [TestCleanup]
        public void TestCleanUp() { }

        [TestMethod]
        public void CustomerIndex_ShouldBeDisplayed_AsDefault_View() {
            //Act & Assert
            _browser.Title.ShouldEqual("Customer Index");
        }

        [TestMethod]
        public void CustomerIndex_ShouldContain_DisplayFor_FirstName() {
            //Act
            Label result = _browser.Label("firstName");
            //Assert
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Clicking_Next_ShouldDisplayThe_Step2_Page() {
            //Act
            _browser.Button("next").Click();
            //Assert
            _browser.Title.ShouldEqual("Step 2");
        }

    }
}