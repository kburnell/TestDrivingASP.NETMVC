using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TestDrivingMVC.Web.Test.UI.Utility {

    internal static class WebDriver {

        internal static ChromeDriver InitializeChrome() {
            return new ChromeDriver();
        }

        internal static FirefoxDriver InitializeFireFox() {
            return new FirefoxDriver();
        }

        internal static InternetExplorerDriver InitializeInternetExplorer() {
            return new InternetExplorerDriver();
        }
    }
}