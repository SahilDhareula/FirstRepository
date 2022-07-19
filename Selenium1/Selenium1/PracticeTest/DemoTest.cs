using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.PracticeTest
{
    [TestFixture]
    public class DemoTest
    {
        int s;

        [SetUp]

        [Test, Order(1)]
        public void AddMethod()
        {
            int x = 10;
            int y = 20;
            s = x + y;
        }
        [Test, Order(2)]
        public void SubMethod()
        {
            int p = s - 10;
            Assert.AreEqual(20, p);
        }
         
    }
}
