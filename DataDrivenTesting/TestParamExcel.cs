using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectInjector.Broker;
using NUnitSeleniumC_Training.Utilites;
using OfficeOpenXml.Style;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParamExcel:BaseClass
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginCase(string user, string pass)
        {
            Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(user);

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(pass);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(1000);

            IWebElement ErrorMsg = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));

            string error = ErrorMsg.Text;

            Console.WriteLine(error);

            Assert.AreEqual("Invalid credentials", error);


        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username","password"};
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\raprs\\source\\repos\\NUnitSeleniumC#Training\\LoginTestData.xlsx", "LoginData", columns);
        }
    }
}
