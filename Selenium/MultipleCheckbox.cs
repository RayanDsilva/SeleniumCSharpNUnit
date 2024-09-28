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
    internal class MultipleCheckbox
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
            IReadOnlyList<IWebElement> checkboxs = driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach (IWebElement c in checkboxs) 
            {
                Console.WriteLine(c.Text);
                c.Click();
                Thread.Sleep(2000);

            }
        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
