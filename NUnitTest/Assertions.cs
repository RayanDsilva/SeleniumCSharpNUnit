using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTest
{
    internal class Assertions
    {
        [Test]
        public void assertMethod()
        {
            string actual = "Google";
            string expected = "Gmail";

            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual,Is.Not.EqualTo(expected));
            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);
            Assert.IsEmpty(actual);
            Assert.That(actual, Is.Empty);
            Assert.IsNull(actual);
            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(expected, actual);


            int[] array =new int[] {1,2,3,4,5};

            Assert.NotNull(array);
            Assert.That(array,Is.All.GreaterThan(0));

            Assert.That(array, Is.Empty);

            Assert.That(array,Is.Ordered.Ascending);

            




        }
    }
}
