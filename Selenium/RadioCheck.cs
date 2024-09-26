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
    internal class RadioCheck
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

        }
        [Test]
        public void testcase1()
        {
            IReadOnlyList<IWebElement> radios = driver.FindElements(By.XPath("//input[@type='radio']"));

            foreach (IWebElement r in radios)
            {
                Console.WriteLine(r.Text);
                r.Click();
                Thread.Sleep(2000);

            }
        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
