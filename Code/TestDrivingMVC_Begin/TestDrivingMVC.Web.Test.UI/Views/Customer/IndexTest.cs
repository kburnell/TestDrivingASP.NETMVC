using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestFixture]
    public class IndexTest {

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