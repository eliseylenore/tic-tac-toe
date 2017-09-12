using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class TicTacToe
    {
        public char[,] Board = new char[,]
        {
            {'-', '-', '-' },
            {'-', '-', '-' },
            {'-', '-', '-' }
        };

        char AiMarker;
        char PlayerMarker;
        bool IsPlayerTurn;
        bool IsComputerTurn;

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