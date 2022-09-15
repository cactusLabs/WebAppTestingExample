using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAppTestingExample.helpers
{
    class BrowserDrivers
    {
        string chromeDriverPath = Environment.CurrentDirectory + "\\..\\..\\..\\drivers\\";

        public string GetChromeDriverPath()
        {
            return chromeDriverPath;
        }
    }
}
