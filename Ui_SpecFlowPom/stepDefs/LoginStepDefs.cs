using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebAppTestingExample.configs;
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

        // Configurations should be handled better than this...
        // but for ease of demo, get credentials from a
        // class that has been included in .gitignore
        Config config = new Config();

        public LoginStepDefs()
        {
            if (driver != null)
            {
                driver.Quit();
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
            loginPage.EnterUsername(driver, config.GetUsername());
            loginPage.EnterPassword(driver, config.GetPassword());
            loginPage.ClickLoginButton(driver);
        }

        /*
         * 
         * Then
         * 
         */

        [Then(@"I expect to be logged in as that user")]
        public void ExpectToBeLoggedInAs()
        {
            loginPage.ExpectToBeLoggedInAs(driver, config.GetUsername());
        }

        [AfterScenario]
        public void closeBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
