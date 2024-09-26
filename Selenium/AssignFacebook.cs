using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class AssignFacebook
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //Maximize the window
            driver.Manage().Window.Maximize();
            //Launch browser
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");

        }
        [Test]
        public void FacebookHandle()
        {
            IWebElement email = driver.FindElement(By.Id("email"));

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("Abc").KeyUp(Keys.Shift).SendKeys("@gmail.").KeyDown(Keys.Shift).SendKeys("com").Perform();

            Thread.Sleep(2000);

        }

        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
