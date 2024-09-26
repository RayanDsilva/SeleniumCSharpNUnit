using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilites;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParaForLogin:BaseClass
    {
        [TestCase("Admin", "admin123")]
        [TestCase("Rayan", "asdfg123")]
        [TestCase("Oggy", "Olly")]
        public void testcase1(string user,string pass)
        {
            Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(user);

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(pass);

/*            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
            LoginButton.Click();*/

        }
    }
}
