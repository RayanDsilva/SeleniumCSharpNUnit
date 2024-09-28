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
    internal class Assign1
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
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            IWebElement Gender = driver.FindElement(By.XPath("//input[@id='gender-male']"));
            Gender.Click();

            Thread.Sleep(3000);

            IWebElement FirstName = driver.FindElement(By.Name("FirstName"));
            FirstName.SendKeys("Rayan");

            Thread.Sleep(3000);

            IWebElement LastName = driver.FindElement(By.Name("LastName"));
            LastName.SendKeys("Dsilva");

            Thread.Sleep(3000);

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("rayandsilva5@gmail.com");

            Thread.Sleep(3000);

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("rayan@123");

            Thread.Sleep(3000);

            IWebElement ConfirmPassword = driver.FindElement(By.Name("ConfirmPassword"));
            ConfirmPassword.SendKeys("rayan@123");

            Thread.Sleep(3000);

            IWebElement Register = driver.FindElement(By.XPath("//input[@id='register-button']"));
            Register.Click();

        }
        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }
    }
}
