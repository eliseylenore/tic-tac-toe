using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class Game
    {
        public char[,] Board;

        char AiMarker;
        char PlayerMarker;
        bool IsPlayerTurn;
        bool IsComputerTurn;

        public Game()
        {
            this.Board  = new char[,]
            {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' }
            };
        }

        public void playTurn()
        {

        }

        public bool isThereAWinner()
        {
            return false;
        }


    }
}