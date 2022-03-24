using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace CodeChallenge
{
    internal class Program
    {
        
        public static string conn = @"Data Source=APPW48ZLPC0312; Initial Catalog=CaseStudy;integrated security=true";
        static SqlConnection con = new SqlConnection(conn);
        static void Main(string[] args)
        {
            
            SqlCommand cmd=new SqlCommand();
            try
            {
                con.Open();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            string Ename;
            char Etype;
            int Eid=0,Esal=0;
            cmd = new SqlCommand("select execution_count from sys.dm_exec_procedure_stats qt WHERE qt.object_id = OBJECT_ID('EmpInsert')");
            cmd.Connection = con;
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                Eid = (int)dr[0];
            }
            dr.Close();
            Console.WriteLine("Enter Employee name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            Esal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee type");
            Etype = (char)Console.Read();
            cmd = new SqlCommand("execute dbo.EmpInsert @Eid,@Ename,@Esal,@Etype");
            cmd.Parameters.AddWithValue("@Eid", Eid);
            cmd.Parameters.AddWithValue("@Ename", Ename);
            cmd.Parameters.AddWithValue("@Etype",Etype);
            cmd.Parameters.AddWithValue("@Esal", Esal);
            cmd.Connection=con;
            int c=cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
