using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Array1
    {
        public static void  Main()
        {
            int[] arr={ 0, 0, 0, 0,0 };
            int max, min;
            float avg = 0;
            arr[0] = 1;
            Console.WriteLine("enter array elements");
            for(int i=0;i<5;i++)
            {
                arr[i] =Convert.ToInt32( Console.ReadLine());
            }
           // foreach (int k in arr)
           //     sum += k;
           //// avg = sum + arr.Length;
            max =arr.Max();
            min = arr.Min();
            avg =Convert.ToSingle(arr.Average());
            Console.WriteLine("average of the given array is{0}",avg);
            Console.WriteLine("Max value of the array is{0}",max);
            Console.WriteLine("Max value of the array is{0}",min);

        }
    }
}
