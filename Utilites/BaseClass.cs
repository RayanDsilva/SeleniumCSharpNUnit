using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using AngleSharp;
using System.Configuration;

namespace NUnitSeleniumC_Training.Utilites
{
    public class BaseClass
    {
        public IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //Launch browser
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            //Maximize the window
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    //Initialize web driver
                    driver = new EdgeDriver();
                    break;

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    //Initialize web driver
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    //Initialize web driver
                    driver = new ChromeDriver();
                    break;
            }
        }

    }
}
