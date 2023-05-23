using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
   public class Goals
    {
        public int Minute;
        public string Player;

        public Goals(int minute, string player)
        {
            Minute = minute;
            Player = player;
        }
        public List<Goals> Goal { get; set; } = new List<Goals>();

    }
}
