using System;
using System.Threading;
using AutomationTestingFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework
{
    public class EntryPoint
        
    {
        IAlert alert;
        [Obsolete]
        public static void Main()
        {
            /* string BaseUrl = "http://testing.todorvachev.com";
             Menu menu = new Menu();
             Driver.driver.Navigate().GoToUrl(BaseUrl);
             menu.Selectors.Click();

             GreenMessage("Selectors tab clicked");

             Thread.Sleep(3000);
             Driver.driver.Navigate().Back();

             NavigateTo.LoginFormThroughTheMenu();
             RedMessage("Login form through Menu");
             Thread.Sleep(3000);

             Driver.driver.Navigate().GoToUrl(BaseUrl);
             NavigateTo.LoginFormThroughThePost();
             GreenMessage("Login form through Post");
             Thread.Sleep(3000); 

            Driver.driver.Navigate().GoToUrl(BaseUrl);
            */


            //Driver.driver.Quit();

        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializerDriver();
        }

        [Test]
        [Obsolete]
        public void ValidLogin()
        {
            
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.successfullLogin, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
