using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TennisGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var instance = Substitute.For<IRepository<Game>>();

            var tennisGame = new TennisGame(instance);
            var scoreResult = tennisGame.ScoreResult(1);
            Assert.AreEqual("", scoreResult);
        }
    }
}
