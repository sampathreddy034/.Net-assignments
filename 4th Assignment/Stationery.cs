using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Stationery
    {

        public static void Main()
        {
            HashSet<string> ht = new HashSet<string>();
            Console.WriteLine("Enter the number of items you want to add");
            int items = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter the name of the item {i + 1}");
                var item = Console.ReadLine();
                ht.Add(item);
            }
            Console.WriteLine("Items are: ");
            foreach (var e in ht)
            {
                
                Console.WriteLine(e);
            }
        }
    }
}
