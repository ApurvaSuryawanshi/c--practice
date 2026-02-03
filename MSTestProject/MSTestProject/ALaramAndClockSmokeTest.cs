using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;

using System;
using System.Diagnostics;

namespace MSTestProject
{
    [TestClass]
    public class ALaramAndClockSmokeTest
    {

        public static WindowsDriver<WindowsElement> sessionAlarms;
        [ClassInitialize]

        public static void PrepareForTestingAlarms(TestContext testContext)
        {
            try
            {
                Debug.WriteLine("Hello ClassInitialize");

                var options = new AppiumOptions();
                options.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");

                sessionAlarms = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"),
                    options


                );
                Debug.WriteLine("Session Created Successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR in ClassInitialize: " + ex.Message);
            }

            sessionAlarms.Manage().Window.Maximize();
        }

        [ClassCleanup]
        public static void CleanupForTestingAlarms()
        {
            Debug.WriteLine("Hello ClassCleanup");
            if (sessionAlarms != null)
            {
                sessionAlarms.Quit();
            }
        }

        [TestInitialize]
        public void BeforeAtTest()
        {
            Debug.WriteLine("Before a test, calling TestInitialize");

        }

        [TestCleanup]

        public void AfterAtTest()
        {
            Debug.WriteLine("After a test , calling TestCleanup");
        }

        [TestMethod]
        public void JustAnotherTest(){
            Debug.WriteLine("Hello another test.");
            }

        [TestMethod]
        public void TestMethod1()
        {
            //WindowsDriver<WindowsElement> sessionAlarms;
            //var options = new AppiumOptions();
            //options.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");

            //var session = new WindowsDriver<WindowsElement>(
            //    new Uri("http://127.0.0.1:4723"),
            //    options
            //);
            sessionAlarms.Manage().Window.Maximize();
            Assert.AreEqual("Clock", sessionAlarms.Title,false,$"Actual title doesn't match expected title: {sessionAlarms.Title}");
        }

        [TestMethod]
        public void VerifyNewClockCanBeAdded()
        {

            //sessionAlarms.Manage().Window.Maximize();
            //var alarmTab = sessionAlarms.FindElementByName("Alarm");
            //alarmTab.Click();
            //System.Threading.Thread.Sleep(1000);

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "Root");

        }
    }
}
