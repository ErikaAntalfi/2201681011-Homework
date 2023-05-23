using System;
using System.Linq;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {


            //input Team countGoals players coachName ref ref ref goalMinute goalPlayer
//Team1 2 pl1 pl2 pl3 pl4 pl5 pl6 pl7 pl8 pl9 pl10 pl11 coach1 ref1 ref2 ref3 20 pl4 35 pl18
//Team2 1 pl12 pl13 pl14 pl15 pl16 pl17 pl18 pl19 pl20 pl21 pl22 coach2 ref1 ref2 ref3 5 pl3
  
            Game game1 = new Game();

            string input = Console.ReadLine();

            int goalCounttm1 = 0;
            int goalCounttm2 = 0;

            while(input != "End")
            {
                int index = 1;
                string[] data = input.Split(' ');
                string dataTeam = data[0];

                int countGoals = int.Parse(data[index]);
               

                Team tm1 = new Team();
                Team tm2 = new Team();

                if (dataTeam == "Team1")
                {
                    game1.Teams.Add(tm1);
                    goalCounttm1 = countGoals;

                    for (int i = index ; i < 12; i++)
                    {
                        index++;
                        FootBallPlayer footballPlayer = new FootBallPlayer();
                        footballPlayer.Name = data[index];
                        tm1.FootBallPlayers.Add(footballPlayer);
                    }
                    index++;
                    Coach coachTeam1 = new Coach();
                    coachTeam1.Name = data[index];
                    index++;
                    game1.Coaches.Add(coachTeam1);
                }
                else if(dataTeam == "Team2")
                {
                    game1.Teams.Add(tm2);
                    goalCounttm2 = countGoals;

                    for (int i = index; i < 12; i++)
                    {
                        index++;
                        FootBallPlayer footballPlayer = new FootBallPlayer();
                        footballPlayer.Name = data[index];
                        tm2.FootBallPlayers.Add(footballPlayer);
                    }
                    index++;
                    Coach coachTeam2 = new Coach();
                    coachTeam2.Name = data[index++];
                    
                    game1.Coaches.Add(coachTeam2);
                }

                Referee refereeGame1 = new Referee();
                refereeGame1.Name = data[index++];


                Referee refereeAssistant1 = new Referee();
                refereeAssistant1.Name = data[index++];
                game1.refAssistant.Add(refereeAssistant1);

                Referee refereeAssistant2 = new Referee();
                refereeAssistant2.Name = data[index++];
                game1.refAssistant.Add(refereeAssistant2);

                for (int i = 0; i < countGoals; i++)
                {
                    Goals goals = new Goals(int.Parse(data[index++]), data[index++]);

                    goals.Goal.Add(goals);
                }
                input = Console.ReadLine();
            }


            if(goalCounttm1 > goalCounttm2)
            {
                Console.WriteLine("Team1 wins.");
                Console.WriteLine("Game result {0}:{1}", goalCounttm1, goalCounttm2);
            }else if (goalCounttm2 > goalCounttm1)
            {
                Console.WriteLine("Team2 wins.");
                Console.WriteLine("Game result {0}:{1}", goalCounttm2, goalCounttm1);
            }
            else
            {
                Console.WriteLine("No one wins");
            }

        }
    }
}
