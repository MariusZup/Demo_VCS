using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VCS
{
    public class Class1
    {
        [Test]
        public static void Test1()
        {
            int expectedRemainder = 0;
            int actualRemainder = 4 % 2;

            Assert.AreEqual(expectedRemainder, actualRemainder);
            //Assert.IsTrue(expectedRemainder == actualRemainder);
        }

        [Test]
        public static void Test2()
        {
            int expectedHour = 01;
            int actualHour = DateTime.Now.Hour;

            Assert.AreEqual(expectedHour, actualHour);

        }
    }
}
