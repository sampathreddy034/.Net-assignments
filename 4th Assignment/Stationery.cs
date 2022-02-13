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
            Dictionary<int,string> ht = new Dictionary<int,string>();
            Console.WriteLine("Enter the number of items you want to add");
            int items = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter the name of the item {i + 1}");
                var item = Console.ReadLine();
                ht.Add(i+1,item);
            }
            Console.WriteLine("Items are: ");
            Console.WriteLine("\t Sno \t Item name");
            foreach (var e in ht)
            {

                Console.WriteLine("\t" + e.Key +"\t"+e.Value);
            }
        }
    }
}
