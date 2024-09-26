using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchEdge
    {

            IWebDriver driver;
            [SetUp]
            public void startbrowser()
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                //Initialize web driver
                driver = new EdgeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }
            [Test]
            public void testcase1()
            {
            Thread.Sleep(4000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys("Admin");

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
                LoginButton.Click();





        }
            [TearDown]
            public void tearDownrowser()
            {
                driver.Close();
            }
    }
}
