﻿using Xunit;
using TicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models.Tests
{
    public class TicTacToeTests
    {
        [Fact()]
        public void TicTacToeTest()
        {
            var game = new Game();

            char[,] expected = new char[,]
            {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' }
            };
            Assert.Equal(game.Board, expected);
        }

        public void EmptyBoardExists()
        {
            var game = new Game();

        }

        //[Fact()]
        //public void playTurnTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}

        //[Fact()]
        //public void isThereAWinnerTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}
    }
}