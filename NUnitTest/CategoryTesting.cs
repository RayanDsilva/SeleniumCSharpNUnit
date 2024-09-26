using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logged in to App");
        }

        [Test, Ignore("Defect")]
        public void products()
        {
            Console.WriteLine("Products are added");
        }
        [Test, Category("Regression")]
        public void AddCart()
        {
            Console.WriteLine("Order confirmed");
        }
    }
}
