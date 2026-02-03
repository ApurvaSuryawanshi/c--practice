using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunNotePad
{
    class AutomationWithoutRunningWinAppDriver
    {
        static void Main(string[] args)
        {
            var appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).Build();
            appiumLocalService.Start();
            
            AppiumOptions ao = new AppiumOptions();
            ao.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            WindowsDriver<WindowsElement> session = new WindowsDriver<WindowsElement>(appiumLocalService, ao);

        }
    }
}
