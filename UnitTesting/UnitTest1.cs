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
                list.InsertLast(70);
                list.InsertLast(30);
                list.InsertLast(56);
                int actualValue = list.Search(30);
                int expectedValue = 30;
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
