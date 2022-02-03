using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Cricket
    {
        public static void Pointscalculation(int no_of_matches)
        {
            List<int> scores = new List<int>();
            for (var i =0; i < no_of_matches; i++)
            {
                Console.WriteLine($"Enter the no of runs scored in {i+1} match");
                var a= Convert.ToInt32(Console.ReadLine());
                scores.Add(a);
            }
            Console.WriteLine($"Average of Scores is {scores.Average()} \nSum of the Scores is {scores.Sum()}");
        }
        public static void Main()
        {
            Console.WriteLine("Enter the number of Matches played by the player");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());
            Pointscalculation(no_of_matches);
        }
    }
}