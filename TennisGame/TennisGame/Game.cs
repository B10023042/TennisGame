using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class Game
    {

        public int SecondPlayerScore { get; set; }
        public int FirstPlayerScore { get; set; }
        public int Id { get; set; }
        public string FirstPlayerName { get; set; }
        public string SecondPlayerName { get; set; }

        public bool IsSameScore()
        {
            return FirstPlayerScore == SecondPlayerScore;
        }
        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            [0] = "Love",
            [1] = "Fifteen",
            [2] = "Thirty",
            [3] = "Forty",
        };
        public string GetAdvPlayer()
        {
            var advPlayer = FirstPlayerScore > SecondPlayerScore
                ? FirstPlayerName
                : SecondPlayerName;
            return advPlayer;
        }

        public bool IsDeuce()
        {
            return FirstPlayerScore == SecondPlayerScore && FirstPlayerScore > 2;
        }

        public string GetSameScoreResult()
        {
            return IsDeuce() ? "Deuce" : $"{_scoreLookup[FirstPlayerScore]} All";
        }

        public string GameDiffScoreResult()
        {
            if (IsGamePoint())
            {
                return IsAdv() ? $"{GetAdvPlayer()} Adv" : $"{GetAdvPlayer()} Win";
            }
            return GetScoreFromLookup();
        }

        private bool IsGamePoint()
        {
            return FirstPlayerScore > 3 || SecondPlayerScore > 3;
        }

        private string GetScoreFromLookup()
        {
            return $"{_scoreLookup[FirstPlayerScore]} {_scoreLookup[SecondPlayerScore]}";
        }

        private bool IsAdv()
        {
            return Math.Abs(FirstPlayerScore - SecondPlayerScore) == 1;
        }
    }
}