using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class IndexTest {

        [TestMethod]
        public void CustomerIndex_ShouldBeDisplayed_AsThe_DefaultPage() {
            //Arrange
            string url = "http://localhost:11074/";
            //Act
            IE browser = new IE(url);
            //Assert
            browser.Title.ShouldEqual("Customer Index");
            browser.Close();
            browser.Dispose();
        }

        [TestMethod]
        public void CustomerIndex_ShouldContain_DisplayFor_FirstName() {
            //Arange
            string url = "http://localhost:11074/";
            //Act
            IE browser = new IE(url);
            //Assert
            browser.Label("firstName").Exists.ShouldBeTrue();
            browser.Close();
            browser.Dispose();
        }

        [TestMethod]
        public void Clicking_Next_ShouldDisplayThe_Step2Page() {
            //Arange
            string url = "http://localhost:11074/";
            //Act
            IE browser = new IE(url);
            browser.Button("next").Click();
            //Assert
            browser.Title.ShouldEqual("Step 2");
        }

    }
}