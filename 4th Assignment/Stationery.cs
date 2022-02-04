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
<<<<<<< HEAD
            Dictionary<int,string> ht = new Dictionary<int,string>();
=======
            HashSet<string> ht = new HashSet<string>();
>>>>>>> 5992c6ccaa5736b64dd449c8fb42bfe1c6722349
            Console.WriteLine("Enter the number of items you want to add");
            int items = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter the name of the item {i + 1}");
                var item = Console.ReadLine();
<<<<<<< HEAD
                ht.Add(i+1,item);
            }
            Console.WriteLine("Items are: ");
            Console.WriteLine("\t Sno \t Item name");
            foreach (var e in ht)
            {

                Console.WriteLine("\t" + e.Key +"\t"+e.Value);
=======
                ht.Add(item);
            }
            Console.WriteLine("Items are: ");
            foreach (var e in ht)
            {
                
                Console.WriteLine(e);
>>>>>>> 5992c6ccaa5736b64dd449c8fb42bfe1c6722349
            }
        }
    }
}
