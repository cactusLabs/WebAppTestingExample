using NUnit.Framework;
using OpenQA.Selenium;
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

        string loginPageUrl = "https://gearspace.com/board";

        /*
         * 
         * Locators
         *
         */

        string gBulletinMsg = "//*[contains(text(), 'You have entered an invalid username or password.')]";
        string joinNow = "//*[contains(text(), 'not registered yet? ')]";
        string loginButton = "//input[@type='submit' and @class='userbar-btn login-btn'] ";
        string passwordEntry = "//input[@id='navbar_password']";
        string privacyModal = "//*[@role='dialog' and @aria-modal='true']//*[contains(text(), 'We value your privacy')] ";
        string privacyModalAgree = "*//button/span[contains(text(), 'AGREE')]";
        string usernameEntry = "//input[@id='navbar_username']";
        string welcome = "//*[contains(text(), 'welcome,')]";
        string welcomeUsername = "//*[@class='username']";

        /*
         * 
         * Methods
         *
         */

        internal void GoToLoginPage(IWebDriver driver) 
        {
            driver.Navigate().GoToUrl(loginPageUrl);

            // Handle privacy modal if present 
            if(Selenium.IsElementPresent(driver, By.XPath(privacyModal), 5))
            {
                driver.FindElement(By.XPath(privacyModalAgree)).Click();
            }
        }

        internal void EnterUsername(IWebDriver driver, string username)
        {
            Selenium.FindElement(driver, By.XPath(usernameEntry), 5).SendKeys(username);
        }

        internal void EnterPassword(IWebDriver driver, string password)
        {
            Selenium.FindElement(driver, By.XPath(passwordEntry), 5).SendKeys(password);
        }

        internal void ClickLoginButton(IWebDriver driver)
        {
            Selenium.FindElement(driver, By.XPath(loginButton), 5).Click();
        }

        internal void ExpectToBeLoggedInAs(IWebDriver driver, string username)
        {
            string thisUsernameLocator = welcomeUsername + "/*[contains(text(), '" + username + "')]";
            
            Assert.That(Selenium.IsElementPresent(driver, By.XPath(welcome), 5), Is.True);
            Assert.That(Selenium.IsElementPresent(driver, By.XPath(thisUsernameLocator), 15), Is.True);
        }

        internal void ExpectToNotBeLoggedIn(IWebDriver driver)
        {
            Assert.That(Selenium.IsElementPresent(driver, By.XPath(welcome), 5), Is.False);
            Assert.That(Selenium.IsElementPresent(driver, By.XPath(joinNow), 5), Is.True);
            Assert.That(Selenium.IsElementPresent(driver, By.XPath(gBulletinMsg), 5), Is.True);
        }
    }
}
