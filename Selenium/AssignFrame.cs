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
    internal class AssignFrame
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

        }
        [Test]
        public void FrameHandle()
        {
            IWebElement frame1 = driver.FindElement(By.Id("mce_0_ifr"));
            //select frame using the xpath of frame
            driver.SwitchTo().Frame(frame1);
            //select frame using the index
            //driver.SwitchTo().Frame(1);
            //select frame using ID or name
            //driver.SwitchTo().Frame("class-name-or-id-or-name-goes-here");
            IWebElement textArea = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
            textArea.Clear();
            textArea.SendKeys("hello Everyone how are you!!!");
            //go back to the original frame 
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(4000);
        }
        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
