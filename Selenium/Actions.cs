using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp.Dom;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class ActionsExample
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {

            IWebElement TodaysDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            IWebElement BestSeller = driver.FindElement(By.XPath("//a[@href='/gp/bestsellers/?ref_=nav_cs_bestsellers']"));
            Actions actions = new Actions(driver);

            // Perform double click on the element
/*            actions.DoubleClick(TodaysDeal).Perform();
            Thread.Sleep(1000);*/

            //Context Click
            actions.ContextClick(BestSeller).Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
