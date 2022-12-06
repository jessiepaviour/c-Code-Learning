using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public class ship
    {
        public static void distance()
        {
            int speed = 5;
            int velocity = 0;
            while (velocity < 100)
            {
                velocity = speed + velocity;

                Console.WriteLine($"The {this} is {velocity} space units from the point");
            }

            if (velocity >= 100)
            {
                Console.WriteLine("{0} has won");
            }
        }
    }
}
