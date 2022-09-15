using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAppTestingExample.helpers
{
    internal static class Selenium
    {
        /*
         * Poll for an element for a defined period of time
         * 
         * @driver = the current web driver
         * @by = element locator
         * @timeout = whole seconds to wait 
         * 
         */
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeout)
        {
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        /*
         * Poll for a period of seconds to determine whether an element is present or not
         * 
         * @driver = the current web driver
         * @by = element locator
         * @timeout = whole seconds to wait 
         * 
         */
        public static bool IsElementPresent(this IWebDriver driver, By by, int timeout)
        {
            try
            {
                if(timeout > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                    wait.Until(drv => drv.FindElement(by));
                }
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
