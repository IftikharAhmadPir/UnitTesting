using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            StackMethods SM = new StackMethods();
            int res = SM.Addition(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            StackMethods SM = new StackMethods();
            int res = SM.Subtraction(20, 10);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            StackMethods SM = new StackMethods();
            int res = SM.Multiplication(5, 2);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void DivisionTest()
        {
            StackMethods SM = new StackMethods();
            int res = SM.Division(10, 5);
            Assert.AreEqual(res, 2);
        }
    }
}
