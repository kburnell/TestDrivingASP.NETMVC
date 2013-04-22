using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using TestDrivingMVC.Web.Test.UI.Utility;

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

        [Test]
        public void CustomerIndex_ShouldBeDisplayed_AsDefault_View_Chrome()
        {
            //Arrange
            _webDriver = WebDriver.InitializeChrome();
            //Act
            _webDriver.Navigate().GoToUrl("http://localhost/TestDrivingMVC.Web/");
            //Assert
            _webDriver.Title.Should().Be("Customer Index");
        }

        [Test]
        public void CustomerIndex_ShouldBeDisplayed_AsDefault_View_FireFox()
        {
            //Arrange
            _webDriver = WebDriver.InitializeFireFox();
            //Act
            _webDriver.Navigate().GoToUrl("http://localhost/TestDrivingMVC.Web/");
            //Assert
            _webDriver.Title.Should().Be("Customer Index");
        }

        [Test]
        public void CustomerIndex_ShouldBeDisplayed_AsDefault_View_IE()
        {
            //Arrange
            _webDriver = WebDriver.InitializeInternetExplorer();
            //Act
            _webDriver.Navigate().GoToUrl("http://localhost/TestDrivingMVC.Web/");
            //Assert
            _webDriver.Title.Should().Be("Customer Index");
        }

        [Test]
        public void Page_Chrome_ShouldContain_DisplayFor_FirstName()
        {
            //Arrange
            _webDriver = WebDriver.InitializeChrome();
            _webDriver.Navigate().GoToUrl("http://localhost/TestDrivingMVC.Web/Customer/Index/1");
            //Act
            IWebElement result = _webDriver.FindElements(By.TagName("label")).FirstOrDefault(x => x.Text == "First Name");
            //Assert
            result.Should().NotBeNull();
        }

        [Test]
        public void Clicking_Next_ShouldDisplayThe_Step2_Page_Chrome()
        {
            //Arrange
            _webDriver = WebDriver.InitializeChrome();
            _webDriver.Navigate().GoToUrl("http://localhost/TestDrivingMVC.Web/Customer/Index/1");
            //Act
            _webDriver.FindElement(By.Id("next")).Click();
            //Assert
            _webDriver.Title.Should().Be("Step 2");
        }

    }
}