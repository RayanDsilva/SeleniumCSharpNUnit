using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitSeleniumC_Training.NUnitTest
{
    [SetUpFixture]
    internal class BaseClass
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {
            TestContext.Progress.WriteLine("Opening the DB Connection");
        }
        [OneTimeTearDown]
        public void dbconnectionclose() 
        { 
            TestContext.Progress.WriteLine("Closing the DB Connection"); 
        }
    }
}
