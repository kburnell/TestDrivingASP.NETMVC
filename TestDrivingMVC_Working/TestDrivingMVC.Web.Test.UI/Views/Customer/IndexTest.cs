using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class IndexTest {

        private const string Url = "http://localhost:11074/";
        private IE _browser;

        [TestCleanup()]
        public void TestCleanup() {
            _browser.Close();
            _browser.Dispose();
        }

        [TestMethod]
        public void CustomerIndex_ShouldBeDisplayed_AsTheDefault_Page() {
            //Act
            _browser = new IE(Url);
            //Assert
            _browser.Title.ShouldEqual("Customer Index");
        }

        [TestMethod]
        public void Customer_Index_ShouldDisplay_FirstName() {
            //Act
            _browser = new IE(Url);
            //Assert
            _browser.Label("firstName").Exists.ShouldBeTrue();
        }

        [TestMethod]
        public void Clicking_Next_ShouldDisplay_Step2() {
            //Arrange
            _browser = new IE(Url);
            //Act
            _browser.Button("next").Click();
            //Assert
            _browser.Title.ShouldEqual("Step 2");
        }
    }
}