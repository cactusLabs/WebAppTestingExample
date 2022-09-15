using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAppTestingExample.helpers
{
    internal static class Selenium
    {
        //public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        //{
        //    if (timeoutInSeconds > 0)
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        //        return wait.Until(drv => drv.FindElement(by));
        //    }
        //    return driver.FindElement(by);
        //}

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
                // driver.FindElement(by);
                // return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
