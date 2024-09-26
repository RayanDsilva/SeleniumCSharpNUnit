using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class FileDownload
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement Download = driver.FindElement(By.LinkText("Test.pdf"));
            Download.Click();
            Thread.Sleep(1000);

            string text = Download.Text;
            string path = "C:\\Users\\raprs\\Downloads" + text;
            Console.WriteLine(path);
            Assert.That(File.Exists(path));
            Console.WriteLine("Successfully Downloaded");
        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
