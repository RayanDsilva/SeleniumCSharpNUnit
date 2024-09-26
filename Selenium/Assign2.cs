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
    internal class Assign2
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //maximize the window
            driver.Manage().Window.Maximize();
            //Launch browser
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(4000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(2000);

            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@id='login-button']"));
            LoginButton.Click();

            Thread.Sleep(2000);

            IWebElement AddCart = driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
            AddCart.Click();

            Thread.Sleep(2000);

            IWebElement Cart = driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            Cart.Click();

            Thread.Sleep(2000);

            IWebElement CheckOut = driver.FindElement(By.XPath("//button[@id='checkout']"));
            CheckOut.Click();

            Thread.Sleep(2000);

            IWebElement FirstName = driver.FindElement(By.Name("firstName"));
            FirstName.SendKeys("Rayan");

            Thread.Sleep(2000);

            IWebElement LastName = driver.FindElement(By.Name("lastName"));
            LastName.SendKeys("Dsilva");

            Thread.Sleep(2000);

            IWebElement PostalCode = driver.FindElement(By.Name("postalCode"));
            PostalCode.SendKeys("574211");

            Thread.Sleep(2000);

            IWebElement Continue = driver.FindElement(By.XPath("//input[@id='continue']"));
            Continue.Click();

            Thread.Sleep(2000);

            IWebElement Finish = driver.FindElement(By.XPath("//button[@id='finish']"));
            Finish.Click();

            Thread.Sleep(2000);

            IWebElement thankYouSection = driver.FindElement(By.ClassName("complete-header"));
            Console.WriteLine(thankYouSection.Text);
            string ResultedText = thankYouSection.Text;

            Assert.That(ResultedText, Is.EqualTo("Thank you for your order!"));
            Thread.Sleep(2000);
        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
