using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MultipleTest
    {
        public MultipleOF.Multiple multiple { get; set; } = new MultipleOF.Multiple();

        [TestMethod]
        public void SumOfMultiple()
        {
            var ret = multiple.SumOfMultiple(3,5,10);
            Assert.IsTrue(ret == 23);
        }

        [TestMethod]
        public void Fibonacci()
        {
            var ret = multiple.FibonacciWithLimit(10);
            Assert.IsTrue(ret == 8);

            ret = multiple.FibonacciWithLimit(25);
            Assert.IsTrue(ret == 21);

            ret = multiple.FibonacciWithLimit(60);
            Assert.IsTrue(ret == 55);
        }
    }
}
