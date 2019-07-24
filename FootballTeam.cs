using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Football
{
    class FootballTeam
    {
        int score; #creates the int variable score 
        string name; # creates the string variable name 

        public FootballTeam(string teamname) #method FootballTeam with a string as a parameter
        {
            score = 0;   #assigns the score variable to zero
            name = teamname; # assigns the name to teamname 
        }

        public void ShowScore() #method used for showing the score 
        {
            Console.WriteLine($"{name} has a score of {score}"); #writes the score of the game to the console w/ formatted string
        } 

        public void ScoreTouchDown() #method for adding six to the team scoring a touchdown
        {
            score = score + 6; #adds six to the total score
        }

        public void ExtraPoint() #method for adding one to the team scoring a field goal
        {
            score = score + 1; #adds one to the total score
        }

        public void FieldGoal() #method for adding three to the team scoring a field goal
        {
            score = score + 3; #adds three to the total score
        }

        public void Safety() #method for adding two to the team scoring a safety
        {
            score = score + 2; #adds two to the total score
        } 

        public void TwoPointConversion() #method for adding two to the team scoring a two point conversion 
        {
            score = score + 2; #adds two to the total score
        }
   
    }
}
