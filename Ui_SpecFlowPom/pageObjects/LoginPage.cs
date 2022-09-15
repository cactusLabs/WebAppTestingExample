using NUnit.Framework;
using OpenQA.Selenium;
using WebAppTestingExample.configs;
using WebAppTestingExample.helpers;

namespace WebAppTestingExample.pageObjects
{
    internal class LoginPage
    {
        /*
         * 
         * URLs
         *
         */

        string loginPageUrl = "https://gearspace.com/";

        /*
         * 
         * Locators
         *
         */

        string loginButton = "//input[@type='submit' and @class='userbar-btn login-btn'] ";
        string passwordEntry = "//input[@id='navbar_password']";
        string privacyModal = "//*[@role='dialog' and @aria-modal='true']//*[contains(text(), 'We value your privacy')] ";
        string privacyModalAgree = "*//button/span[contains(text(), 'AGREE')]";
        string usernameEntry = "//input[@id='navbar_username']";

        /*
         * 
         * Methods
         *
         */

        internal void GoToLoginPage(IWebDriver driver) 
        {
            driver.Navigate().GoToUrl(loginPageUrl);

            // Handle privacy modal if present 
            if(Selenium.IsElementPresent(driver, By.XPath(privacyModal), 15))
            {
                driver.FindElement(By.XPath(privacyModalAgree)).Click();
            }
        }

        internal void EnterUsername(IWebDriver driver, string username)
        {
            Selenium.FindElement(driver, By.XPath(usernameEntry), 15).SendKeys(username);
        }

        internal void EnterPassword(IWebDriver driver, string password)
        {
            Selenium.FindElement(driver, By.XPath(passwordEntry), 15).SendKeys(password);
        }

        internal void Login(IWebDriver driver)
        {
            Selenium.FindElement(driver, By.XPath(loginButton), 15).Click();
        }

    }
}
