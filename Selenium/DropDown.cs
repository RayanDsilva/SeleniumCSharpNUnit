using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

        }
        [Test]
        public void testcase1()
        {
            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);

            var select = new SelectElement(DropDown);

            //select by visible text
            select.SelectByText("Option2");
            Thread.Sleep(1000);

            //select by index 
            select.SelectByIndex(1);
            Thread.Sleep(1000);

            //select by attribute value

            select.SelectByValue("option3");


        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
