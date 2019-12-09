using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTestingFramework.UIElements
{
    public class UserNameFieldPost
    {
        [Obsolete]
        public UserNameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}
