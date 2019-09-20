using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Creation()
        {
            Stack<int> S = new Stack<int>(3);
            Assert.AreEqual(0, S.Size);
        }
        [TestMethod]
        public void insert()
        {
            Stack<int> S = new Stack<int>(3);
            S.Push(1);
            S.Push(2);
            S.Push(3);
            int value = S.Pop();
            Assert.AreEqual(3, value);
            Assert.AreEqual(2, S.Size);
        }
        [TestMethod]
        public void Too_Much_Push()
        {
            Stack<int> S = new Stack<int>(3);
            S.Push(1);
            S.Push(2);
            S.Push(3);
            Assert.ThrowsException<ExceedSizeException>(()=> S.Push(4));
        }
        [TestMethod]
        public void Too_Much_Pop()
        {
            Stack<int> S = new Stack<int>(3);
            Assert.ThrowsException<ProhibitedException>(() => S.Pop());
        }
    }
}
