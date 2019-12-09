using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTestingFramework
{
    public class HomePage
    {
        [Obsolete]
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
