using TechTalk.SpecFlow;
using WebAppTestingExample.pageObjects;

namespace WebAppTestingExample.stepDefs
{
    [Binding]
    public class LoginStepDefs
    {
        LoginPage loginPage = new LoginPage();

        /*
         * 
         * Givens
         * 
         */
        [Given(@"I am on the login page")]
        public void GoToLoginPage()
        {
            loginPage.GoToLoginPage();
        }

        /*
         * 
         * Whens
         * 
         */


        /*
         * 
         * Then
         * 
         */

    }
}
