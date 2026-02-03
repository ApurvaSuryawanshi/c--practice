using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace TestAutomationTVOnYouTube
{
    [TestClass]
    public class UnitTest1
    {
       
         
            [TestMethod]
            public void LaunchPhotosUWP()
            {
                var appOptions = new AppiumOptions();
                appOptions.AddAdditionalCapability(
                    "app",
                    "Microsoft.Windows.Photos_8wekyb3d8bbwe!App"
                );
                // appOptions.AddAdditionalCapability("appArguments" , "/e");

                var driver = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"),
                    appOptions
                );

                var window = driver.FindElementByXPath("//Window");
                window.SendKeys(Keys.Alt + Keys.Space + "x");
                driver.Manage().Window.Maximize();
                Console.WriteLine($"App title: {driver.Title}");
            }
        }

    }

