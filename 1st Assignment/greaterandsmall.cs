using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Greaterandsmall
    {
        public static void Main()
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                if (a > c)
                    Console.WriteLine("first number is greatest");
                else
                    Console.WriteLine("third number is greatest");
            else if (b > c)
                    Console.WriteLine("second number is greatest");
                else
                    Console.WriteLine("third number is greatest");
            if (a < b)
                if (a < c)
                    Console.WriteLine("first number is smallest");
                else
                    Console.WriteLine("third number is greatest");
            else if (b < c)
                Console.WriteLine("second number is smallest");
            else
                Console.WriteLine("third number is smallest");
        }
    }
}
