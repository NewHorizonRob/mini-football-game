using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Football
{
    class Program
    {
        static void Main(string[] args)
        {   
            #next two lines calls the FootballTeam method to create two new instances Clemson and Alabama
            FootballTeam Clemson = new FootballTeam("Clemson");
            FootballTeam Alabama = new FootballTeam("Alabama");
            
            
            # below are the calls to the methods from the program part of the project using the two new instances
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Clemson.ScoreTouchDown();
            Clemson.ExtraPoint();
            Clemson.ScoreTouchDown();
            Clemson.ExtraPoint();
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Clemson.FieldGoal();
            Clemson.ScoreTouchDown();
            Clemson.ExtraPoint();
           // Clemson.ShowScore();
           // Alabama.ShowScore();
            Alabama.FieldGoal();
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Clemson.FieldGoal();
           // Clemson.ShowScore();
           // Alabama.ShowScore();
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Clemson.ScoreTouchDown();
            Alabama.ScoreTouchDown();
            Alabama.ExtraPoint();
            Clemson.ScoreTouchDown();
            Clemson.ExtraPoint();
            Alabama.ShowScore();
            Clemson.ShowScore();





            Console.WriteLine("Pak");
            Console.ReadKey();
            
        }
    }
}
