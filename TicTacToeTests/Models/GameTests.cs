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
            Game newGame = new Game();

            var expected = '-';
            var result = newGame.Board[1, 1];
            Assert.Equal(expected, result);
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