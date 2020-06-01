using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TennisGame
{
    [TestClass]
    public class UnitTest1
    {
        private static string _firstPlayerName = "Cloud";
        private static string _secondPlayerName = "Tom";
        private static int _gameId = 1;
        private readonly IRepository<Game> _instance = Substitute.For<IRepository<Game>>();
        private TennisGame _tennisGame;

        [TestInitialize]
        public void Setup()
        {
            _tennisGame = new TennisGame(_instance);
        }

        [TestMethod]
        public void When_0_0()
        {
            GivenGame(_instance, 0, 0);
            Assert.AreEqual("Love All", _tennisGame.ScoreResult(_gameId));
        }

        [TestMethod]
        public void When_1_0()
        {
            GivenGame(_instance, 1, 0);
            Assert.AreEqual("Fifteen Love", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_2_0()
        {
            GivenGame(_instance, 2, 0);
            Assert.AreEqual("Thirty Love", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_3_0()
        {
            GivenGame(_instance, 3, 0);
            Assert.AreEqual("Forty Love", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_0_1()
        {
            GivenGame(_instance, 0, 1);
            Assert.AreEqual("Love Fifteen", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_0_2()
        {
            GivenGame(_instance, 0, 2);
            Assert.AreEqual("Love Thirty", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_0_3()
        {
            GivenGame(_instance, 0, 3);
            Assert.AreEqual("Love Forty", _tennisGame.ScoreResult(_gameId));
        }

        [TestMethod]
        public void When_1_1()
        {
            GivenGame(_instance, 1, 1);
            Assert.AreEqual("Fifteen All", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_2_2()
        {
            GivenGame(_instance, 2, 2);
            Assert.AreEqual("Thirty All", _tennisGame.ScoreResult(_gameId));
        }

        [TestMethod]
        public void When_3_3()
        {
            GivenGame(_instance, 3, 3);
            Assert.AreEqual("Deuce", _tennisGame.ScoreResult(_gameId));
        }

        [TestMethod]
        public void When_4_3()
        {
            GivenGame(_instance, 4, 3);
            Assert.AreEqual("Cloud Adv", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_3_4()
        {
            GivenGame(_instance, 3, 4);
            Assert.AreEqual("Tom Adv", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_4_4()
        {
            GivenGame(_instance, 4, 4);
            Assert.AreEqual("Deuce", _tennisGame.ScoreResult(_gameId));
        }
        [TestMethod]
        public void When_5_3()
        {
            GivenGame(_instance, 5, 3);
            Assert.AreEqual("Cloud Win", _tennisGame.ScoreResult(_gameId));
        }
        private void GivenGame(IRepository<Game> instance, int firstPlayerScore, int secondPlayerScore)
        {
            instance.GetGame(Arg.Any<int>()).Returns(new Game()
            {
                FirstPlayerName = _firstPlayerName,
                SecondPlayerName = _secondPlayerName,
                FirstPlayerScore = firstPlayerScore,
                SecondPlayerScore = secondPlayerScore,
                Id = _gameId
            });
        }
    }
}
