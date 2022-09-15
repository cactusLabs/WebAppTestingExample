using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebAppTestingExample.helpers;

namespace WebAppTestingExample.pageObjects
{
    internal class LoginPage
    {
        Configuration configuration = new Configuration();

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

        internal void EnterUsername()
        {

        }

    }
}
