using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Celsiustofahrenheit
    {
        public static void Main()
        {
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            float celsius = ((fahrenheit-32)*5)/9;
            Console.WriteLine(celsius);

        }
    }
}
