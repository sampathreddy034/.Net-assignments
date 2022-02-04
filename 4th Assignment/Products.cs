using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
<<<<<<< HEAD
    class Products : IComparable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CompareTo(object obj)
        {
            Products nxtprod = obj as Products;
            if (nxtprod != null)
            {
                return this.Price.CompareTo(nxtprod.Price);
            }
            else
                return 0;
        }

        public override string ToString()
        {

            return $" Product Id : {ProductId} \n Product Name : {ProductName} \n product price :{Price}";

=======
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
           
>>>>>>> 5992c6ccaa5736b64dd449c8fb42bfe1c6722349
        }
    }
    class Data
    {
        public static void Main()
        {
<<<<<<< HEAD
            int k = 1;
            List<Products> prodlist = new List<Products>(){
                new Products(){
                    ProductId=1,ProductName="Mobile",Price= 20000},
            new Products(){
                    ProductId=2,ProductName="Laptop",Price= 80000},
            new Products(){
                    ProductId=3,ProductName="A.C",Price= 10000},
            new Products(){
                    ProductId=4,ProductName="Car",Price= 200000},
            new Products(){
                    ProductId=5,ProductName="Watch",Price= 2000},};
            Console.WriteLine("***********************************************************************");
            prodlist.Sort();
            Console.WriteLine("Products available are");
            foreach (var e in prodlist)
            {

               // Console.WriteLine("Products available are");
                Console.WriteLine($"Product {k} details");
                Console.WriteLine(e.ToString());
                k = k + 1;
=======
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
>>>>>>> 5992c6ccaa5736b64dd449c8fb42bfe1c6722349
            }
        }
    }
}
