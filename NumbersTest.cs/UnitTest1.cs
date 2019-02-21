using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex04_Numbers;

namespace NumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(12, Numbers.RectangleArea(3, 4));
        }
        [TestMethod]
        public void TestAreas24()
        {
            Assert.AreEqual(24, Numbers.RectangleArea(12, 2));
        }
        [TestMethod]
        public void TestArea51()
        {
            Assert.AreEqual(51, Numbers.RectangleArea(17, 3));
        }
        */
        [TestMethod]
        public void TestSumOfIntArray()
        {
            int[] ints = { 5, 9, 2, 7, 1 };

            Assert.AreEqual(24, Numbers.Sum(ints));
        }

        [TestMethod]
        public void TestMinOfIntArray()
        {
            int[] ints = { 5, 9, 2, 7, 1 };

            Assert.AreEqual(1, Numbers.Min(ints));
        }

        [TestMethod]
        public void TestMaxOfIntArray()
        {
            int[] ints = { 5, 9, 2, 7, 1 };

            Assert.AreEqual(9, Numbers.Max(ints));
        }

    }
}




