using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Str
    {
        public static void Main()
        {
            Book books = new Book();
            Console.WriteLine("Enter Book id");
            books.Id = Console.ReadLine();
            Console.WriteLine("Enter Book Name");
            books.Book_Name=Console.ReadLine();
            books.Display();
        }
    }
    public struct Book
    {
        private string Book_Id;
        public string Book_Name;
        public String Id
        {
            get { return Book_Id; }
            set { Book_Id = value; }
        }
        public void Display()
        {
            Console.WriteLine("Book id : " + Book_Id+"  Book Name : "+Book_Name);
        } 
    }
}
