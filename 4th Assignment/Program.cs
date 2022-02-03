using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4;
namespace Assignment4
{
    class Program
    {
        const int Totalfare=500;
        static int age;
        static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Concession c = new Concession();
            Console.WriteLine("Customer name :"+name);
            Console.Write("Ticket status: ");
            c.CalculateConcession(age);
            Console.WriteLine("");
        }
    }
}
