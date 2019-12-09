using System;
using AutomationTestingFramework.UIElements;

namespace AutomationTestingFramework
{
    public static class NavigateTo
    {
        [Obsolete]
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();
            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }

        [Obsolete]
        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UserNameFieldPost ufPost = new UserNameFieldPost();

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            ufPost.LoginFormLink.Click();
            
        }
    }
}
