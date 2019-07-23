using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Football
{
    class FootballTeam
    {
        int score;
        string name;

        public FootballTeam(string teamname)
        {
            score = 0;
            name = teamname;
        }

        public void ShowScore()
        {
            Console.WriteLine($"{name} has a score of {score}");
        } 

        public void ScoreTouchDown()
        {
            score = score + 6;
        }

        public void ExtraPoint()
        {
            score = score + 1;
        }

        public void FieldGoal()
        {
            score = score + 3;
        }

        public void Safety()
        {
            score = score + 2;
        } 

        public void TwoPointConversion()
        {
            score = score + 2;
        }
   
    }
}
