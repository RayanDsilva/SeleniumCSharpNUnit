using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchChrome
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            
        }
        [Test]
        public void testcase1()
        {
            //Launch chrome browser
            driver.Navigate().GoToUrl("https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/");
        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
