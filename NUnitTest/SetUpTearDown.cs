using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class SetUpTearDown
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launching Chrome");
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing of Chrome");
        }
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logged in to App");
        }

        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("Products are added");
        }
        [Test, Order(3)]
        public void AddCart()
        {
            Console.WriteLine("Order confirmed");
        }
    }
}
