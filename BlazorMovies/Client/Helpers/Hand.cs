﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public enum GameStatus
    {
        Victory, Loss, Draw
    }
    public enum OptionRPS
    {
        Rock, Paper, Scissors
    }
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }

            if (LosesAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }

            return GameStatus.Victory;
        }
    }
}
