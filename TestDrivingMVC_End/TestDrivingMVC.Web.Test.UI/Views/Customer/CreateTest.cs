using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using WatiN.Core;

namespace TestDrivingMVC.Web.Test.UI.Views.Customer {

    [TestClass]
    public class CreateTest {

        private const string Url = "http://localhost:11074/Customer/Create";
        private IE _browser;

        [TestInitialize]
        public void TestInitialize() {
            _browser = new IE(Url);
        }

        [TestMethod]
        public void FirstNameIsRequired_ValidationMessage_ShouldBeDisplayed_WhenClickingCreate_WithoutFillingIn_FirstName_Field() {
            //Arrange
            _browser.Button("create").Click();
            //Act
            Span result = _browser.Span(Find.By("for", "FirstName"));
            //Assert
            result.InnerHtml.ShouldEqual("First Name is required");
        }

        [TestMethod]
        public void FirstNameIsRequired_ValidationMessage_ShouldNotBeDisplayed_WhenClickingCreate_With_FirstName_Field_FilledIn() {
            //Arrange
            _browser.TextField("FirstName").TypeText("Joe");
            _browser.Button("create").Click();
            //Act
            Span result = _browser.Span(Find.By("for", "FirstName"));
            //Assert
            result.Exists.ShouldBeFalse();
        }


    }

}