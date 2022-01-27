using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Arrays2
    {
        public static void Main()
        {
            int[] marks= new int[10];
            Console.WriteLine("Enter marks");
            for(int i=0;i<10;i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Total {0}",marks.Sum());
            Console.WriteLine("Average {0}",marks.Average());
            Console.WriteLine("Maximum marks{0}",marks.Max());
            Console.WriteLine("Minimum marks{0}",marks.Min());
            Array.Sort(marks);
            Console.WriteLine("Marks in ascending order");
            foreach (var k in marks)
            {
                Console.WriteLine(k);
            }
            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order ");
            foreach (var k in marks)
            {
                Console.WriteLine(k);
            }
        }
    }
}
