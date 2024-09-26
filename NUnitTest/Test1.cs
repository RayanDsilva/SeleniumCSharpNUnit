using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class Test1
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Initialized");
        }
        [Test]
        public void testone()
        {
            Console.WriteLine("This is first test");
        }
        [TearDown] 
        public void tearDown() 
        {
            Console.WriteLine("Terminated");
        }
    }
}
