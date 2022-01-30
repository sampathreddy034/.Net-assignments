using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TicketBooking : ApplicationException
    {
        public TicketBooking(string msg) : base(msg)
        {

        }
    }
    class Passenger
    {
        string Name;
        int age;

        public void TicketBooking(int No_of_Tickets)
        {
            if (No_of_Tickets < 5)
            {
                throw (new TicketBooking("Ticket Booking Successfully"));

            }
            else
                Console.WriteLine("Cannot Book more than 5 tickets");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            int No_of_Tickets;
            Passenger P = new Passenger();
            Console.WriteLine("Enter the number of tickets to be booked");
            No_of_Tickets=Convert.ToInt32(Console.ReadLine());
            //P.age=ConvertToInt32(Console.ReadLine())
            try
            {
                P.TicketBooking(No_of_Tickets);
            }
            catch (TicketBooking ve)
            {
                Console.WriteLine(ve.Message + " " + ve.Source);
            }
            Console.Read();
        }
    }
}
