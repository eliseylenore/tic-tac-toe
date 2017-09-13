using Xunit;
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
            Player newPlayer = new Player("Elise", 'x');
            Game newGame = new Game(newPlayer);

            char[,] expected = new char[,]
            {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' }
            };
            Assert.Equal(newGame.Board, expected);
        }

        public void EmptyBoardExists()
        {
            Player newPlayer = new Player("Elise", 'x');
            Game newGame = new Game(newPlayer);

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