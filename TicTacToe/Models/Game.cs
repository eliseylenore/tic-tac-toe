using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class Game
    {
        public char[,] Board { get; set; }
        public Player Player { get; set; }

        public char AiMarker { get; set; }
        char PlayerMarker { get; set; }
        bool IsPlayerTurn { get; set; }
        bool IsComputerTurn { get; set; }


        public Game(Player newPlayer)
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