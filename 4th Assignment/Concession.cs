using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Concession
    {
        int totalfare=500,concession;
        public void CalculateConcession(int age)
        {
            if(age<=5)
            {
                Console.WriteLine("Little Champs- Free Ticket");
            }
            else if(age>60)
            {
                concession = (totalfare / 100) * 30;
                totalfare = totalfare - concession;
                Console.WriteLine("Senior Citizen "+totalfare);
            }
            else
            {
                Console.WriteLine("Ticket Booked"+totalfare);
            }
        }
    }
}
