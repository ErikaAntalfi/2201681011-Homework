using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        public List<FootBallPlayer> FootBallPlayers { get; set; } = new List<FootBallPlayer>();
        public double averageAgeOfThePlayers { get; set; }
    }
}
