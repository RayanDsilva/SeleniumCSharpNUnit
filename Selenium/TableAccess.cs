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
    internal class TableAccess
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            //Maximize the window
            driver.Manage().Window.Maximize();
            //Launch browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
        [Test]
        public void test1()
        {
            // xpath of the html web table

            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'table1']"));

            // fetch the all rows of the table

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));

            int rowcount = trrow.Count();

            Console.WriteLine(rowcount);

            // fecth the no of columns

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td")));

            int colcount = tdcol.Count();

            Console.WriteLine(colcount);

            // cell data

            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[2]/td[2]"));

            string text = celldata.Text;

            Console.WriteLine(text);

            Assert.AreEqual("Frank", text);
        }
    }
}
