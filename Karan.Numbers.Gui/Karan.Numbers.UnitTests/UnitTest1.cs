using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            decimal Cost = 2.26M;
            decimal MoneyTendered = 5M;

            Assert.AreEqual(2.74M, Change.Due(Cost, MoneyTendered));
        }

        [TestMethod]
        public void TestRuturnCorrectMonies()
        {
            Dictionary<string, int> Result = Change.DueMonies(5.74M);

            Assert.AreEqual(Result["FiveDollar"], 1);
            Assert.AreEqual(Result["Quarter"], 2);
            Assert.AreEqual(Result["Dime"], 2);
            Assert.AreEqual(Result["Penny"], 4);
        }
    }
}
