using GFTTest.Core.Utils;
using GFTTest.infra.data.Entity;
using GFTTest.infra.data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GFTTest.test
{
    [TestClass]
    public class PortifolioTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            List<ITrade> portfolio;
            List<string> tradeCategories;

            Trade trade1 = new Trade { Value = 2000000, ClientSector = "Private" };
            Trade trade2 = new Trade { Value = 400000, ClientSector = "Public" };
            Trade trade3 = new Trade { Value = 500000, ClientSector = "Public" };
            Trade trade4 = new Trade { Value = 3000000, ClientSector = "Public" };

            //act
            portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };
            tradeCategories = new Category(portfolio).GetCategories();

            //assert
            Assert.AreEqual("HIGHRISK", tradeCategories[0]);
            Assert.AreEqual("LOWRISK", tradeCategories[1]);
            Assert.AreEqual("LOWRISK", tradeCategories[2]);
            Assert.AreEqual("MEDIUMRISK", tradeCategories[3]);
        }
    }
}