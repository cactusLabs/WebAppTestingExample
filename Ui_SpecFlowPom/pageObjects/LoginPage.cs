using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebAppTestingExample.helpers;

namespace WebAppTestingExample.pageObjects
{
    internal class LoginPage
    {
        IWebDriver driver;
        BrowserDrivers browserDrivers = new BrowserDrivers();

        /*
         * 
         * URLs
         *
         */

        string loginPageUrl = "https://login.elucidat.com/";

        /*
         * 
         * Locators
         *
         */

        string usernameEntry = "//input[@id='email']";
        string passwordEntry = "//xpath[@class, contains()]";

        /*
         * 
         * Methods
         *
         */

        internal void GoToLoginPage() 
        {
            driver = new ChromeDriver(browserDrivers.GetChromeDriverPath());
            driver.Navigate().GoToUrl(loginPageUrl);
        }

    }
}
