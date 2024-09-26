using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParaTestcaseSource
    {
        [Test,TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "asdf");
            yield return new TestCaseData("asd.com", "zxcv");
            yield return new TestCaseData("qwe.com", "poiu");
        }
    }
}
