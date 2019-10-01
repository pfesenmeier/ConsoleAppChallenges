using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Challenge_Repository;

namespace _03_Challenge_Repository_Tests
{
    [TestClass]
    public class Repository_Tests
    {
        
        [TestMethod]
        public void AutoAddDictionaryConstructor()
        {
            Badge.BadgeDictionary.Clear();
            for (int i = 0; i < 100; i++)
            {
                Badge badge = new Badge(i);
                Assert.AreEqual(i, badge.BadgeId);
            }
            Assert.AreEqual(100, Badge.BadgeDictionary.Keys.Count);
        }
        [TestMethod]
        public void AddDoors()
        {
            Badge badge = new Badge(100);
            Badge.BadgeDictionary[badge].Add(Doors.D1);
            Assert.AreEqual(1, badge.AccessibleDoors.Count);
            //Program won't compile if Door doesn't exist
            //Assert.ThrowsException<Exception>(Badge.BadgeDictionary[badge].Add(Doors.D42);
        }
        [TestMethod]
        public void EnumTest()
        {
            Assert.IsInstanceOfType(Doors.C12, typeof(Doors));
        }
    }
}
