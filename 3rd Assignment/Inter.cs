using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Inter
    {
        public static void Main()
        {
            Dayscholar ds = new Dayscholar();
            ds.Show_details("123", "Rai");
            Resident r = new Resident();
            r.Show_details("456", "mani");
        }

    }
    interface IStudent
    {
        //String StudentId="123", Name="Raj";
        void Show_details(String StudentId, String Name);
    }
    class Dayscholar : IStudent
    {


        public void Show_details(string StudentId, string Name)
        {

            Console.WriteLine("Student id : {0} \n Student Name: {1}", StudentId, Name);
        }
        public void hello()
        {

        }
    }
    class Resident : IStudent
    {
        public void Show_details(string StudentId, string Name)
        {

            Console.WriteLine("Student id : {0} \n Student Name: {1}", StudentId, Name);
        }
    }
}
