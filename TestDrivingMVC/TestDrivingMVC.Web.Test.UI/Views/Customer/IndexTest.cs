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

    }
}