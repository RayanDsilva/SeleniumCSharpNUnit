using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class CalciUnitTesting
    {
        Calculator cl =new Calculator();

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);

            int result1= cl.Add(-3, 4);

            //Assertion on NUNIT to compare the expected results with actual results
            Assert.AreEqual(5, result);
            Assert.AreEqual(1, result1);
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
        [Test]
        public void DivTest()
        {
            int result = cl.Div(10, 5);

            int result1 = cl.Div(50, 10);

            //Assertion on NUNIT to compare the expected results with actual results
            Assert.AreEqual(2, result);
            Assert.AreEqual(5, result1);
        }
    }
}
