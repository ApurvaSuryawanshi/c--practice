using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace RunNotepadProject
{
    class RunCalculator
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> sessionCalc;
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app" , "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            sessionCalc = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"),options);
            var btnTwo = sessionCalc.FindElementByName("Two");
            btnTwo.Click();
            sessionCalc.FindElementByName("Plus").Click();
            btnTwo.Click();
            sessionCalc.FindElementByName("Equals").Click();
            var txtResults = sessionCalc.FindElementByAccessibilityId("CalculatorResults");
            
            Console.WriteLine($"Value shown by calculator : {txtResults.Text}");
            if(txtResults.Text.EndsWith("4"))
            {
                Console.WriteLine("The result is correct");
            }
            else
            {
                Console.WriteLine("The result is incorrect");
            }

            txtResults.SendKeys(Keys.Escape);
            txtResults.SendKeys("2");
            txtResults.SendKeys("+");
            txtResults.SendKeys("2");
            txtResults.SendKeys("=");

            Console.WriteLine($"Value shown by calculator: {txtResults.Text}");
            if (txtResults.Text.EndsWith("4"))
            {
                Console.WriteLine("The result is correct");
            }
            else
            {
                Console.WriteLine("The result is incorrect");
            }

            sessionCalc.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }   
    }
}
