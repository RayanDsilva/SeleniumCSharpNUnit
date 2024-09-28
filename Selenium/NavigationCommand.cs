using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class NavigationCommand
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            //Launch browser by GoToUrl
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            Thread.Sleep(3000);

            driver.Navigate().Back();

            Thread.Sleep(3000);

            driver.Navigate().Forward();

            Thread.Sleep(3000);

            driver.Navigate().Refresh();



        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close(); //closes the current browser session

            //driver.Quit(); // closes all the browser session
        }
    }
}
