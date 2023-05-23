using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Game:Team
    {
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> refAssistant { get; set; } = new List<Referee>();
        public List<Coach> Coaches { get; set; } = new List<Coach>();

    }
}
