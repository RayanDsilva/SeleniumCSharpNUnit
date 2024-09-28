using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class FileUpload
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id ='file-upload']"));
            ChooseFile.SendKeys("C:\\Users\\raprs\\Downloads\\1.png");

            IWebElement Upload = driver.FindElement(By.XPath("//input[@id = 'file-submit']"));
            Upload.Click();
            Thread.Sleep(1000);

            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Uploaded!')]"));
            string textmsg = FileUploadMsg.Text;
            string expectedtext = "File Uploaded!";

            Console.WriteLine(textmsg);

            Assert.AreEqual(textmsg, expectedtext);


        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
