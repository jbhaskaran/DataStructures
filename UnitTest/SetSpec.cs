using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace UnitTest
{
    [TestClass]
    public class SetSpec
    {
        Set set;
        [TestInitialize]
        public void SetUp()
        {
            set = new Set();
        }

        [TestMethod]
        public void testIfSetIsEmpty()
        {
            Assert.IsTrue(set.IsEmpty());
            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void testIfSetHasOneElement()
        {
            Assert.IsTrue(set.IsEmpty());
            Assert.AreEqual(0, set.Size());
            set.Add("0");
            Assert.IsFalse(set.IsEmpty());
            Assert.AreEqual(1, set.Size());
        }

        [TestMethod]
        public void testIfSetContainsDuplicates()
        {
            Assert.IsTrue(set.IsEmpty());
            Assert.AreEqual(0, set.Size());
            Assert.IsFalse(set.Contains("0"));
            set.Add("0");
            Assert.IsFalse(set.IsEmpty());
            Assert.AreEqual(1, set.Size());
            set.Add("0");
            Assert.IsTrue(set.Contains("0"));
            Assert.AreEqual(1, set.Size());

        }

        [TestMethod]
        public void testIfSetHasTwoElements()
        {
            Assert.IsTrue(set.IsEmpty());
            Assert.AreEqual(0, set.Size());
            set.Add("0");
            set.Add("1");
            Assert.IsFalse(set.IsEmpty());
            Assert.AreEqual(2, set.Size());
        }

        [TestMethod]
        public void testSetRemoveElement()
        {
            Assert.IsTrue(set.IsEmpty());
            Assert.AreEqual(0, set.Size());
            set.Add("0");
            set.Add("1");
            set.Add("2");
            set.Add("5");
            set.Add("3");
            Assert.IsFalse(set.IsEmpty());
            Assert.AreEqual(5, set.Size());
            Assert.IsTrue(set.Contains("0"));
            Assert.IsTrue(set.Contains("1"));
            set.Remove("0");
            set.Remove("2");
            Assert.AreEqual(3, set.Size());
            Assert.IsFalse(set.Contains("0"));
        }





    }
}