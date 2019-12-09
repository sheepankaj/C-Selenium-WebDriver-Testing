using System;
using AutomationTestingFramework.UIElements;

namespace AutomationTestingFramework
{
    public static class Actions
    {
        public static void InitializerDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.urlBase);
        }
            
        [Obsolete]
        public static void FillLoginForm(string username, string passwprd, string repeatpassword)
        {
            LoginScenarioPost isPost = new LoginScenarioPost();

            isPost.UsernameField.SendKeys(username);
            isPost.PasswordField.SendKeys(passwprd);
            isPost.RepeatPasswordField.SendKeys(repeatpassword);
            isPost.LoginButton.Click();
        }
    }
}
