using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class Player
    {
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage ="Name required")]
        public String Name { get; set; }
        public char Marker { get; set; }
        public int PercentWon { get; set; }

        public Player()
        {
        }
        public Player(String name, char marker)
        {
            this.Name = name;
            this.Marker = marker;
        }

    }
}