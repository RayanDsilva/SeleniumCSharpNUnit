using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class UnitTestCalci
    {
        public Calculator cl;
        [SetUp]
        public void setup()
        {
            cl = new Calculator();
            Console.WriteLine("Executing the setup");
        }
        [Test]
        public void SubTest()
        {
            int result = cl.Sub(10, 3);

            int result1 = cl.Sub(5, -1);

            //Assertion on NUNIT to compare the expected results with actual results
            Assert.AreEqual(7, result);
            Assert.AreEqual(6, result1);
        }
        [Test]
        public void MulTest()
        {
            int result = cl.Mul(10, 3);

            int result1 = cl.Mul(5, -1);

            //Assertion on NUNIT to compare the expected results with actual results
            Assert.AreEqual(30, result);
            Assert.AreEqual(-5, result1);
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("All test unit test cases are executed");
        }
    }
}
