using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class Description
    {
        [Test]
        [Description("Testcase verifies the test case 1")]
        public void testone()
        {
            Console.WriteLine("This is first test");
        }
    }
}
