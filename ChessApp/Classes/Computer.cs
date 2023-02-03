using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessApp.Classes
{
    public class Computer
    {
        public int Difficulty { get; set; }
        public Computer(int difficulty)
        {
            Difficulty = difficulty;
        }
    }
}