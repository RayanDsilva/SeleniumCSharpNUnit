using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParaUsingTestcase
    {
        [TestCase("abc.com","asdf")]
        [TestCase("asd.com","zxcv")]
        [TestCase("qwe.com","poiu")]

        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username+ ":" + password);
        }
    }
}
