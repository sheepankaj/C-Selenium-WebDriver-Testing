

using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    public static void Main()
    {
        string urlName = "http://testing.todorvachev.com/selectors/name/";
        string urlID = "http://testing.todorvachev.com/selectors/ID/";
        string urlClassName = "http://testing.todorvachev.com/selectors/class-name/";
        string urlTextInput = "http://testing.todvachev.com/special-elements/text-input-field/";
        string urlRadioButton = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string urlDropDown = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string urlAlert = "http://testing.todvachev.com/special-elements/alert-box/";

        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
        string[] option = { "1", "3", "5" };
        string classname = "testClass";

        driver.Navigate().GoToUrl(urlName);
        driver.Manage().Window.Maximize();

        Thread.Sleep(3000);

        //Name Element
        IWebElement element = driver.FindElement(By.Name("myName"));
        if(element.Displayed)
        {
            GreenMessage("Yes The element is present");
        }
        else
        {
            RedMessage("Nothing found");
        }

        //ID Element
        driver.Navigate().GoToUrl(urlID);
        IWebElement Idelement = driver.FindElement(By.Id("testImage"));

        if(Idelement.Displayed)
        {
            GreenMessage("Found ID element");
        }
        else
        {
            RedMessage("ID element is not found");
        }

        //ClassName Element
        driver.Navigate().GoToUrl(urlClassName);
        IWebElement classElement = driver.FindElement(By.ClassName(classname));
        GreenMessage(classElement.Text);

        //TextInput Element
        driver.Navigate().GoToUrl(urlTextInput);
        IWebElement TextInputElement = driver.FindElement(By.Name("username"));
        TextInputElement.SendKeys("Pankaj text");
        Thread.Sleep(3000);

        GreenMessage(TextInputElement.GetAttribute("value"));
        Thread.Sleep(3000);

        //Radion Button Element
        driver.Navigate().GoToUrl(urlRadioButton);
        for (int i = 0; i < option.Length; i++)
        {
            IWebElement RadioElement = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option[i] + ")"));
            if (RadioElement.GetAttribute("checked") == "true")
            {
                GreenMessage("The " +(i+1)+" radio button is checked");
            }
            else
            {
                RedMessage("The radio button is not checked");
            }
            Thread.Sleep(3000);

        }

        //DropDown Element
        driver.Navigate().GoToUrl(urlDropDown);
        IWebElement elementFromTheDropDownMenu;
        IWebElement DropDownElemnt = driver.FindElement(By.Name("DropDownTest"));
        GreenMessage("The selected value is: " + DropDownElemnt.GetAttribute("value"));
        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
        GreenMessage("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        elementFromTheDropDownMenu.Click();
        RedMessage("The selected value is: " + DropDownElemnt.GetAttribute("value"));
        Thread.Sleep(3000);

        for(int i=1; i<= 4; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
            GreenMessage("The " + i + " options from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        }
        Thread.Sleep(3000);


        //AlertBox Element
        driver.Navigate().GoToUrl(urlAlert);
        IAlert alert;
        alert = driver.SwitchTo().Alert();
        RedMessage(alert.Text);
        alert.Accept();

        IWebElement image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        if(image.Displayed)
        {
            GreenMessage("The alert was successfully accepted and I can see the image");
        }
        else
        {
            RedMessage("The alert was not successfully");
        }
        Thread.Sleep(3000);

        driver.Quit();
     

    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.BackgroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.BackgroundColor = ConsoleColor.White;
    }
}

