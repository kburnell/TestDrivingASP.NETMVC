using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class IndexTest {

        private const string Url = "http://localhost:11074/";
        private IE _browser;

        [TestCleanup]
        public void TestCleanUp() {
            _browser.Close();
            _browser.Dispose();    
        }

        [TestMethod]
        public void CustomerIndex_ShouldBeDisplayed_AsThe_DefaultPage() {
            //Arrange
            string expectedTitle = "Customer Index";
            //Act
            _browser = new IE(Url);
            //Assert
            _browser.Title.ShouldEqual(expectedTitle);
        }

        [TestMethod]
        public void CustomerIndex_ShouldContain_DisplayFor_FirstName() {
            //Arrange
            _browser = new IE(Url);
            Label result = _browser.Label("firstName");
            //Assert
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Clicking_Next_ShouldDisplayThe_Step2Page() {
            //Arrange
            string expectedTitle = "Step 2";
            _browser = new IE(Url);
            //Act
            _browser.Button("next").Click();
            //Assert
            _browser.Title.ShouldEqual(expectedTitle);
        }

    }
}