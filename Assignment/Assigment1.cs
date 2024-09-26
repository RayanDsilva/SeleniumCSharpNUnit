using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Assignment
{
    internal class Assignment1
    {
        public IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
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

        [Test, Order(1), Category("Registration Link")]
        public void RegisterTest()
        {
            IWebElement Register = driver.FindElement(By.LinkText("Register"));
            Register.Click();

            Thread.Sleep(1000);
        }

        [Test, Order(2), Category("Registration Form")]
        public void RegisterForm()
        {
            IWebElement Register = driver.FindElement(By.LinkText("Register"));
            Register.Click();

            Thread.Sleep(1000);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            FirstName.SendKeys("Rayan");

            Thread.Sleep(1000);

            IWebElement LastName = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            LastName.SendKeys("Dsilva");

            Thread.Sleep(1000);

            IWebElement Address = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Address.SendKeys("Bantwal");

            Thread.Sleep(1000);

            IWebElement City = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            City.SendKeys("Mangaluru");

            Thread.Sleep(1000);

            IWebElement State = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            State.SendKeys("Karnataka");

            Thread.Sleep(1000);

            IWebElement ZipCode = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            ZipCode.SendKeys("574211");

            Thread.Sleep(1000);

            IWebElement Phone = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            Phone.SendKeys("9901662561");

            Thread.Sleep(1000);

            IWebElement SSN = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            SSN.SendKeys("ASD123");

            Thread.Sleep(1000);

            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            UserName.SendKeys("Rayan@123");

            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Password.SendKeys("12345rayan");

            Thread.Sleep(1000);

            IWebElement CnfrmPassword = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            CnfrmPassword.SendKeys("12345rayan");

            Thread.Sleep(1000);

            IWebElement RegisterBtn = driver.FindElement(By.XPath("//input[@value='Register']"));
            RegisterBtn.Click();

            Thread.Sleep(1000);

            driver.Navigate().Back();
            driver.Navigate().Back();
        }
        [Test, Order(3), Category("Login")]
        public void LoginTest()
        {
            IWebElement UserName = driver.FindElement(By.XPath("//input[@name='username']"));
            UserName.SendKeys("Rayan@123");

            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("12345rayan");

            Thread.Sleep(1000);

            IWebElement Login = driver.FindElement(By.XPath("//input[@value='Log In']"));
            Login.Click();

            Thread.Sleep(1000);
        }
    }
}
