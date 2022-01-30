using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Books
    {

        struct Book
        {
            public string Book_Name;
            public string Author;
        }
        public static void Main()
        {
            int j = 2;
            Book[] b = new Book[j];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Information of Book {0} :", i + 1);
                Console.Write("Input name of the book:");
                b[i].Book_Name = Console.ReadLine();
                Console.Write("Input the author :");
                b[i].Author = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Title = " + b[i].Book_Name + ", Author = " + b[i].Author);
            }
        }
    }
}
