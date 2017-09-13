using Xunit;
using TicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerTest()
        {
            Player newPlayer = new Player("Elise");
            string expected = "Elise";
            string actual = newPlayer.Name;

            Assert.Equal(expected, actual);
        }
    }
}