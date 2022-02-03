using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Products
    {
        public static int ProductId;
        public static string ProductName;
        public static double Price;
        public Products(int Id, string Name,double price)
        {
            ProductId = Id;
            ProductName = Name;
            Price = price;
        }
        public override string ToString()
        {
           
            return $" Product Id : {ProductId} \n Product Name : {ProductName} \n product price :{Price}";
           
        }
    }
    class Data
    {
        public static void Main()
        {
            int itemno,Id,k=1;
            string name;
            double price;
            List<Products> prodlist = new List<Products>();
            Console.WriteLine("Enter the number of Products");
            itemno=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<itemno;i++)
            {
                Console.WriteLine($"Product {i+1} details");
                Console.WriteLine("Enter the product Id");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the product Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the product Price");
                price = Convert.ToDouble(Console.ReadLine());
                prodlist.Add(new Products(Id, name, price));

            }
           // var t=SortedList(prodlist.OrderBy);
            Console.WriteLine("***********************************************************************");
            foreach (var e in prodlist)
            {
                
                Console.WriteLine("Products available are");
                Console.WriteLine($"Product {k} details");
                Console.WriteLine(e.ToString());
                k =k+ 1;
            }
        }
    }
}
