using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class ClicknHold
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement Primes = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            Actions actions = new Actions(driver);

            actions.MoveToElement(Primes)
                   .MoveToElement(LatestMovies)
                   .Click()
                   .Perform();

            Thread.Sleep(1000);

            //Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']")).Text);
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
