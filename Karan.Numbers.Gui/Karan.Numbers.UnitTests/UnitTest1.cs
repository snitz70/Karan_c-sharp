using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Karan.Numbers.UnitTests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Room Floor = new Room() { CostPerTile = 1.20, Height = 10, Width = 10 };
            Assert.AreEqual(120.00M, Floor.TotalCost);
            Assert.AreEqual(100, Floor.Area);
        }
    }

    [TestClass]
    public class ChangeReturnTest
    {
        [TestMethod]
        public void TestChangeReturnsCorrectAmount()
        {

        }
    }
}
