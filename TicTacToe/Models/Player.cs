using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class Player
    {
        public String Name { get; set; }
        public char Marker { get; set; }
        public int PercentWon { get; set; }

        public Player(String name, char marker)
        {
            this.Name = name;
            this.Marker = marker;
        }

    }
}