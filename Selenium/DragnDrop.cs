using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DragnDrop
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            //maximize the window
            driver.Manage().Window.Maximize();
            //Launch browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

        }
        [Test]
        public void testcase1()
        {
            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)
                .DragAndDrop(Source, Dest)
                .Perform();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
