using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTestingFramework.UIElements
{
    public class TestScenariosPage
    {
        [Obsolete]
        public TestScenariosPage()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div.mh-loop-content.clearfix > header > h3 > a")]
        public IWebElement LoginForm { get; set; }
    }
}
