﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var ret = multiple.SumOfMultiple(3, 5, 10);
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
        [TestMethod]
        public void LargestPrimeFactor()
        {
            var ret = multiple.LargestPrimeFactor(13195);
            var rep = new List<int> { 5, 7, 13, 29 };
            Assert.IsTrue(ret.Except(rep).ToList().Count == 0);
            Assert.IsTrue(rep.Except(ret).ToList().Count == 0);

            ret = multiple.LargestPrimeFactor(600851475143);
            rep = new List<int> { 71, 839, 1471, 6857 };
            Assert.IsTrue(ret.Except(rep).ToList().Count == 0);
            Assert.IsTrue(rep.Except(ret).ToList().Count == 0);
        }
        [TestMethod]
        public void SearchIndexFibonacciNumber()
        {
            var ret = multiple.SearchIndexFibonacciNumber(3);
            Assert.IsTrue(ret == 12);

            //ret = multiple.SearchIndexFibonacciNumber(1000);
           //Assert.IsTrue(ret == 12);
        }
        [TestMethod]
        public void SumSquareDifference()
        {
            var ret = multiple.SumSquareDifference(10);
            Assert.IsTrue(ret == 2640);
        }
        [TestMethod]
        public async Task FibonacciPairWithLimit()
        {
            Assert.ThrowsException<Exception>( () => multiple.FibonacciPairWithLimit(ulong.MaxValue));
         //   Assert.IsTrue(ret == ulong.MaxValue);
        }
    }
}
