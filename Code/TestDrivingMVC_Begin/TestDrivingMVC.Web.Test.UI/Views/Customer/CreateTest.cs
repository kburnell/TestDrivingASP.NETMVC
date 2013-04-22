using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestFixture]
    public class CreateTest {

        private const string url = "http://localhost/TestDrivingMVC.Web/Customer/Create";
        private IWebDriver _webDriver;

        [TearDown]
        public void TearDown() {
            try {
                // Stop the web driver
                _webDriver.Quit();
            }
            catch (Exception) {}
        }


    }
}