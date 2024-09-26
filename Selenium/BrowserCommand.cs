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
    internal class BrowserCommand
    {

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();

        }
        [Test]
        public void testcase1()
        {
            //Launch browser by GoToUrl
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //get the title of the page
            string title = driver.Title;
            Console.WriteLine(title);

            //get the current url
            string currentUrl=driver.Url;
            Console.WriteLine(currentUrl);

            //fetch the pagesourse of html page
            string pageSource=driver.PageSource;
            Console.WriteLine(pageSource);



        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close(); //closes the current browser session

            //driver.Quit(); // closes all the browser session
        }
    }
}
