using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Studentsmarks
    {
        public static void Main()
        {
             int[] arr= new int[3];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter marks of {0} student",i);
                Console.WriteLine("enter marks secured in C#");
                arr[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter marks secured in HTML");
                arr[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter marks secured in SQL");
                arr[2] = Convert.ToInt32(Console.ReadLine());
                int avg = (arr[0] + arr[1] + arr[2]) / 3;
                if(avg>50)
                    Console.WriteLine("passed");
                else
                    Console.WriteLine("fail");
            }
        }
    }
}
