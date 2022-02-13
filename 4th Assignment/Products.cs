using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
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

        }
    }
    class Data
    {
        public static void Main()
        {
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
            }
        }
    }
}
