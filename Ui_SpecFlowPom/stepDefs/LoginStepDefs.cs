using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebAppTestingExample.helpers;
using WebAppTestingExample.pageObjects;

namespace WebAppTestingExample.stepDefs
{
    [Binding]
    public class LoginStepDefs
    {
        IWebDriver driver;
        BrowserDrivers browserDrivers = new BrowserDrivers();
        LoginPage loginPage = new LoginPage();

        public LoginStepDefs()
        {
            if(driver != null)
            {
                driver.Dispose();
            }
            driver = new ChromeDriver(browserDrivers.GetChromeDriverPath());
        }

        /*
         * 
         * Givens
         * 
         */
        [Given(@"I am on the login page")]
        public void GoToLoginPage()
        {
            loginPage.GoToLoginPage(driver);
        }

        /*
         * 
         * Whens
         * 
         */

        [When(@"I log in using known credentials")]
        public void LoginKnownCredentials()
        {
            // Send keys to username
             

            // Send keys to password

            // Click login

        }

        /*
         * 
         * Then
         * 
         */

    }
}
