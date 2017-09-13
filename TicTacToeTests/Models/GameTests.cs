using Xunit;
using TicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models.Tests
{
    public class GameTests
    {
        [Fact]
        public void BoardTest()
        {
            Player newPlayer = new Player("Elise", 'x');
            Game newGame = new Game(newPlayer);

            var expected = '-';
            var result = newGame.Board[1, 1];
            Assert.Equal(expected, result);
            Assert.Equal(newPlayer, newGame.Player);
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