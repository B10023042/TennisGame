﻿using System;

namespace TennisGame
{
    public class TennisGame
    {
        private readonly IRepository<Game> _repo;

        public TennisGame(IRepository<Game> repo)
        {
            _repo = repo;
        }

        public string ScoreResult(int gameId)
        {
            var game = _repo.GetGame(gameId);
            return game.IsSameScore() ? game.GetSameScoreResult() : game.GameDiffScoreResult();
        }
    }
}