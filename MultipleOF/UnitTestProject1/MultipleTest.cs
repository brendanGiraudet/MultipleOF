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
    }
}
