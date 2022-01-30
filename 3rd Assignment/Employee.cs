using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Emp
    {
        struct EmployeeBirth
        {
            public int Date;
            public int Mon;
            public int Year;
        }
        struct Employee
        {
            public string Emp_Name;
            public EmployeeBirth EB;
        }
        public static void Main()
        {
            //Console.WriteLine("Enter number of Employees");
            //public int a = Convert.ToInt32(Console.ReadLine());
            Employee[] em = new Employee[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter the Name of the Employee ");
                em[i].Emp_Name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter the day of birth of the Employee ");
                em[i].EB.Date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Enter the Month of birth of the Employee ");
                em[i].EB.Mon = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Enter the year of birth of the Employee ");
                em[i].EB.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Details of the {0} employee",i+1);
                Console.WriteLine(" Name of the employee : " + em[i].Emp_Name+ "\n Day of birth of the employee : " + em[i].EB.Date+ "\n Month of birth of the employee :"+em[i].EB.Mon+ "\n Year of birth of the employee :"+em[i].EB.Year);
            }
        }
    }
}
