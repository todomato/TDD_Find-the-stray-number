using System;
using NUnit.Framework;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestFixture()]
    public class CalculatorTests
    {
        [Test()]
        public void SimpleArray1()
        {
            var array = new int[] { 1, 1, 2 };

            var target = new Calculator();
            var actual = target.Stray(array);

            Assert.AreEqual(2, actual);
        }

        [Test()]
        public void SimpleArray2()
        {
            var array = new int[] { 17, 17, 3, 17, 17, 17, 17 };

            var target = new Calculator();
            var actual = target.Stray(array);

            Assert.AreEqual(3, actual);
        }
      
    }
}
