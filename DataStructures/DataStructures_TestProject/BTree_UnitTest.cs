using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTest_TestProject
{
    [TestClass]
    public class BTree_UnitTest
    {
        [TestMethod]
        public void TestBTree()
        {
            var bTree = new InterviewTest.BTree();

            bTree.Insert(5);
            bTree.Insert(2);
            bTree.Insert(3);
            bTree.Insert(1);
            bTree.Insert(0);
            bTree.Insert(9);
            
            //Expected Structure
            //          5  (root)
            //         / \
            //        2   9
            //       / \
            //      1   3
            //     /
            //    0

            Assert.AreEqual(5, bTree.Value);
            Assert.AreEqual(2, bTree.Left.Value);
            Assert.AreEqual(3, bTree.Left.Right.Value);
            Assert.AreEqual(1, bTree.Left.Left.Value);
            Assert.AreEqual(0, bTree.Left.Left.Left.Value);
            Assert.AreEqual(9, bTree.Right.Value);
        }
    }
}
