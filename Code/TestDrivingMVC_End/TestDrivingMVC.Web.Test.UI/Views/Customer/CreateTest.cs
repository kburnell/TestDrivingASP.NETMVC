using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium;
using TestDrivingMVC.Web.Test.UI.Utility;

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

        [Test]
        public void FirstNameIsRequired_ValidationMessage_ShouldBeDisplayed_WhenClickingCreate_WithoutFillingIn_FirstName_Field_Chrome()
        {
            //Arrange
            _webDriver = WebDriver.InitializeChrome();
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(By.Id("create")).Click();
            //Act
            var result = _webDriver.FindElements(By.TagName("span")).FirstOrDefault(x => x.Text == "First Name is required");
            //Assert
            result.Should().NotBeNull();
            result.Displayed.Should().BeTrue();
        }

        [Test]
        public void FirstNameIsRequired_ValidationMessage_ShouldNotBeDisplayed_WhenClickingCreate_With_FirstName_Field_FilledIn_Chrome()
        {
            //Arrange
            _webDriver = WebDriver.InitializeChrome();
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(By.Id("FirstName")).SendKeys("Hodor! Hodor!");
            _webDriver.FindElement(By.Id("create")).Click();
            //Act
            var result = _webDriver.FindElements(By.TagName("span")).FirstOrDefault(x => x.Text == "First Name is required");
            //Assert
            result.Should().BeNull();
        }
        
    }

}