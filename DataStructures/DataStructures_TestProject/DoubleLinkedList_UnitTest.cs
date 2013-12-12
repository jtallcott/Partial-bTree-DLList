using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTest_TestProject                              
{
    [TestClass]
    public class DoubleLinkedList_UnitTest
    {
        public InterviewTest.DoubleLinkedList<int> list;
        private int actualValue;

        [TestInitialize]
        public void Setup()
        {
            if (list != null)
                Cleanup();
            list = new InterviewTest.DoubleLinkedList<int>();
            actualValue = int.MinValue; //Not default(int)
        }

        [TestCleanup]
        public void Cleanup()
        {
            list = null;
        }

        [TestMethod]
        public void InsertAndRemoveTests()
        {

            list.InstertAtEnd(5);
            list.InstertAtEnd(2);

            actualValue = list.RemoveFirst();
            Assert.AreEqual(5, actualValue);
            
            actualValue = list.RemoveFirst();
            Assert.AreEqual(2, actualValue);

            //Removed past end of list, should not crash
            actualValue = list.RemoveFirst(); 
            Assert.AreEqual(0, actualValue);

            //Inset and Remove one more after list became empty
            list.InstertAtEnd(3);

            actualValue = list.RemoveFirst();
            Assert.AreEqual(3, actualValue);
        }
        
        [TestMethod]
        public void InsertOneRemoveTwo()
        {
            list.InstertAtEnd(5);

            actualValue = list.RemoveFirst();
            Assert.AreEqual(5, actualValue);

            actualValue = list.RemoveFirst(); //Removed past end of list, should not crash
            Assert.AreEqual(default(int), actualValue);
        }

        [TestMethod]
        public void RemoveFromEmptyList()
        {
            actualValue = list.RemoveFirst(); //Removed past end of list, should not crash
            Assert.AreEqual(default(int), actualValue);
        }

        [TestMethod]
        public void Insert100AndRemove101()
        {
            //Add 100 numbers to list
            for (int i = 0; i < 100; i++)
                list.InstertAtEnd(i);

            //Verify all 100 numbers are removed from List in order.
            for (int expectedValue = 0; expectedValue < 100; expectedValue++)
            {
                actualValue = list.RemoveFirst();
                Assert.AreEqual(expectedValue, actualValue);
            }

            //Remove 101st value
            actualValue = list.RemoveFirst();
            Assert.AreEqual(default(int), actualValue); //List should be empty, default(int) == 0.
        }
    }
}
