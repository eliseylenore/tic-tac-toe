using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class TicTacToe
    {
        char[,] board = new char[,]
        {
            {'-', '-', '-' },
            {'-', '-', '-' },
            {'-', '-', '-' }
        };

        char aiMarker;
        char playerMarker;
        bool isPlayerTurn;
        bool isComputerTurn;

        public TicTacToe()
        {
          
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