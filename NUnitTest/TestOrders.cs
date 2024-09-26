using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class TestOrders
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Initialized");
        }
        [Test,Order(1)]
        public void login()
        {
            Console.WriteLine("Logged in to App");
        }

        [Test,Order(2)]
        public void products()
        {
            Console.WriteLine("Products are added");
        }
        [Test,Order(3)]
        public void AddCart()
        {
            Console.WriteLine("Order confirmed");
        }
        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("Terminated");
        }
    }
}
