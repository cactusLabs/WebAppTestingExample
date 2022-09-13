using System.Configuration;

namespace WebAppTestingExample.helpers
{
    public class Configuration
    {
        public static string GetConfig()
        {
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            Console.WriteLine("Test baseUrl: " + baseUrl);

            return baseUrl;
        }
    }
}