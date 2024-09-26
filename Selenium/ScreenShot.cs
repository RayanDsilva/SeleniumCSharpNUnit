using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using NUnitSeleniumC_Training.Utilites;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class ScreenShot:BaseClass
    {
        [Test]
        public void testcase1()
        {
            Screenshot ss = driver.TakeScreenshot();

            ss.SaveAsFile("C:\\Users\\raprs\\Downloads\\TestFile.jpg");
        }
    }
}
