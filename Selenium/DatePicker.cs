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
    internal class DatePicker
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

            driver.Navigate().GoToUrl("https://www.makemytrip.com");

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(4000);

            IWebElement CloseButton = driver.FindElement(By.XPath("//span[@class='commonModal__close']"));
            CloseButton.Click();

            Thread.Sleep(2000);

            IWebElement dateSelector = driver.FindElement(By.XPath("//span[normalize-space()='Departure']"));
            dateSelector.Click();
            Thread.Sleep(2000);

            IWebElement date26 = driver.FindElement(By.XPath("(//p[contains(text(),'26')])[1]"));
            Console.WriteLine(date26.Text);
            string date = date26.Text;
            date26.Click();
            Assert.That(date, Is.EqualTo("26"));
            Thread.Sleep(2000);

            IWebElement fareSelection = driver.FindElement(By.XPath("(//div[normalize-space()='Student'])[1]"));

            fareSelection.Click();
            Thread.Sleep(2000);

            IWebElement searchButton = driver.FindElement(By.XPath("(//a[normalize-space()='Search'])[1]"));
            searchButton.Click();
            Thread.Sleep(4000);

        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
