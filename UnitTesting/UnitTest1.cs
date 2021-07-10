using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LinkedList;
namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        LinkedListOperations list = new LinkedListOperations();


        [TestMethod]
            public void TestSearchMethod()
            {
                
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            int actual = list.InsertMiddle(30, 40);
            int expected = 40;
            Assert.AreEqual(expected, actual);
        }
        }
    }
}
