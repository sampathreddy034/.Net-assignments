using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Evenorodd
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }

    }
}
