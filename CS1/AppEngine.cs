using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class AppEngine: UserInterface
    {
        public int ID;
        SqlDataReader dr;
        SqlCommand command;
        static bool flag = true;
        
        static string conn = @"Data Source=APPW48ZLPC0312; Initial Catalog=CaseStudy;integrated security=true";
        SqlConnection con = new SqlConnection(conn);
        SqlDataAdapter adapter=new SqlDataAdapter();
       
        public void ShowEnrollingScreen(int id)
        {
            try
            {

                int ids = id;
                Console.WriteLine("Enter the course id you want to enroll");
                int idc = Convert.ToInt32(Console.ReadLine());
                
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("select StudentName from StudentInfo where StudentID=@Sid");
                command.Parameters.AddWithValue("@Sid", ids);
                command.Connection = con;
                dr = command.ExecuteReader();
                string Sname = null;
                while (dr.Read())
                {
                    Sname = Convert.ToString(dr[0]);
                }
                dr.Close();
                command = new SqlCommand("select CourseName from Course where CourseID=@cid");
                command.Parameters.AddWithValue("@cid", idc);
                command.Connection = con;
                dr = command.ExecuteReader();
                string Cname = null;
                while (dr.Read())
                {
                    Cname = Convert.ToString(dr[0]);
                }
                dr.Close();
                command = new SqlCommand("Insert into Enrollment(StudentId,StudentName,CourseId,CourseName) values(@Sid,@Sname,@Cid,@Cname)");
                command.Parameters.AddWithValue("@Sid", ids);
                command.Parameters.AddWithValue("@Sname", Sname);
                command.Parameters.AddWithValue("@Cid", idc);
                command.Parameters.AddWithValue("@Cname", Cname);
                command.Connection = con;
                command.ExecuteNonQuery();
                dr.Close();
                con.Close();
                Console.WriteLine("Enrollment done Successfully");
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void showFirstScreen()
        {
            flag = true;
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Quit Application");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            while(flag)
            {
                
                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        ShowAdminScreen();
                        break;
                    case 3:
                        Console.WriteLine("Application is Closed");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry... \n Try Again");
                        showFirstScreen();
                        break;
                }
            }
        }

        public void showStudentScreen()
        {
            
            flag = true;
           while(flag)
            {

                Console.WriteLine("\n " + "\n");
                Console.WriteLine("Welcome to Student Screen");
             l3:   Console.WriteLine("New User press 1\nExisting User press 2");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
             l4:         Console.WriteLine("Press 1 to register");
                        int response=Convert.ToInt32(Console.ReadLine());
                        if(response==1)
                        {
                            showStudentRegistrationScreen();
                            goto l2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry... Try again");
                            goto l4;
                        }
                       
                    case 2:
                        goto l2;
                    default:
                        Console.WriteLine("invalid Entry... try again");
                        goto l3;

                }
             l2: Console.WriteLine("Enter your ID");
                ID=Convert.ToInt32(Console.ReadLine()); 
             lo:   Console.WriteLine("Tell us what do you want : \n1. Update Data\n2. To See Enrollments\n3. Show Courses\n4. Enroll to Course\n5. Quit");
                Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\n " + "\n");
                        UpdateStudent(ID);
                        goto lo;
                        
                    case 2:
                        Console.WriteLine("\n " + "\n");
                        MyEnrollments(ID);
                        goto lo;
                    case 3:

                        Console.WriteLine("\n " + "\n");
                        showAllCoursesScreen();
                        goto lo;
                    case 4:
                        Console.WriteLine("\n " + "\n");
                        ShowEnrollingScreen(ID);
                        goto lo;
                        
                    case 5:
                        Console.WriteLine("\n " + "\n");
                        Console.WriteLine("Thank you Visit again");
                        Console.WriteLine("\n");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\n " + "\n");
                        Console.WriteLine("Invalid entry... \n Try Again");
                        Console.WriteLine("\n");
                        goto lo;
                        
                }
                
            }
        }
        public void ShowAdminScreen()
        {
            flag = true;
            while (flag)
            {
                Console.WriteLine("\n ");
                Console.WriteLine("Welcome to Admin Screen");
                Console.WriteLine("Tell us what do you want : \nPress 1 for Students Realted\nPress 2 for Course Realted\nPress 3 for Enrollment Related\nPress 4 to Return back\npress 5 to Quit");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("press 1 to add student\n Press 2 to see Student list\n press 3 to Delete Student \n press 4 to return ");
                        int ch=Convert.ToInt32(Console.ReadLine());
                        switch(ch)
                        {
                            case 1:
                                Console.WriteLine("\n " + "\n");
                                showStudentRegistrationScreen();
                                break;
                            case 2:
                                Console.WriteLine("\n " + "\n");
                                showAllStudentsScreen();
                                break;
                            case 3:
                                Console.WriteLine("\n " + "\n");
                                DeleteStudent();
                                break;
                            case 4:
                                Console.WriteLine("\n " + "\n");
                                ShowAdminScreen();
                                break;
                            default :
                                Console.WriteLine("\n " + "\n");
                                Console.WriteLine("Invalid Entry");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine(" Press 1 to add new Course\n Press 2 to see Course list\n press 3 to Update Course \n press 4 to Delete Course \n  press 5 to return ");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\n " + "\n");
                                introduceNewCourseScreen();
                                break;
                            case 2:
                                Console.WriteLine("\n " + "\n");
                                showAllCoursesScreen();
                                break;
                            case 3:
                                Console.WriteLine("\n " + "\n");
                                UpdateCourse();
                                break;
                            case 4:
                                Console.WriteLine("\n " + "\n");
                                DeleteCourse();
                                break;
                            case 5:
                                Console.WriteLine("\n " + "\n");
                                ShowAdminScreen();
                                break;
                            default:
                                Console.WriteLine("\n " + "\n");
                                Console.WriteLine("Invalid Entry");
                                Console.WriteLine("\n");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Press 1 to see Enrollments\npress 2 to Delete Enrollment \npress 3 to return ");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\n " + "\n");
                                showAllEnrollmentsScreen();
                                break;
                            case 2:
                                Console.WriteLine("\n " + "\n");
                                DeleteEnrollment();
                                break;
                            case 3:
                                Console.WriteLine("\n " + "\n");
                                break;
                            default:
                                Console.WriteLine("\n " + "\n");
                                Console.WriteLine("Invalid Entry");
                                Console.WriteLine("\n");
                                break;
                        }
                        break;
                    case 4:
                        showFirstScreen();
                        break ;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry... \n Try Again");
                        break;
                }

            }
        }

        public void showAllStudentsScreen()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("select * from StudentInfo");
                command.Connection = con;
                dr = command.ExecuteReader();
                Console.WriteLine("ID\tName\tDOB");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2]);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void showStudentRegistrationScreen()
        {
            try
            {
                int SId;
                string Sname;
                DateTime DOB;
                Console.WriteLine("Enter student id");
                SId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student Name");
                Sname = Console.ReadLine();
                Console.WriteLine("Enter student Date of Birth");
                DOB = Convert.ToDateTime(Console.ReadLine());
               

                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("Insert into StudentInfo(StudentID,StudentName,DOB) values(@Sid,@Sname,@DOB)");
                command.Parameters.AddWithValue("@Sid", SId);
                command.Parameters.AddWithValue("@Sname", Sname);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Registration Successful");
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        public void introduceNewCourseScreen()
        {
            try
            {
                int CId;
                string Cname;
                int CDuration;
                int CFees;
                Console.WriteLine("Enter Course Id");
                CId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name");
                Cname = Console.ReadLine();
                Console.WriteLine("Enter Course Duration");
                CDuration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Fees");
                CFees = Convert.ToInt32(Console.ReadLine());
               
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("Insert into Course values(@CId,@Cname,@Duration,@Fees)");
                command.Parameters.AddWithValue("@CId", CId);
                command.Parameters.AddWithValue("@Cname", Cname);
                command.Parameters.AddWithValue("@Duration", CDuration);
                command.Parameters.AddWithValue("@Fees", CFees);
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void showAllCoursesScreen()
        {
            try
            {
               
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("select * from Course");
                command.Connection = con;
                dr = command.ExecuteReader();
                Console.WriteLine("CourseID\tCourseName\tDuration\tFees");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3]);
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void showAllEnrollmentsScreen()
        {
          
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("select * from Enrollment");
                command.Connection = con;
                dr = command.ExecuteReader();
                Console.WriteLine("EnrollmentID\t\tStudentID\t\tStudentName\t\tCourseID\t\tCourseName");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t" + "\t" + "\t" + dr[1] + "\t" + "\t" + "\t" + dr[2] + "\t" + "\t" + "\t" + dr[3] + "\t" + "\t" + "\t" + dr[4]);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteCourse()
        {
            Console.WriteLine("Enter the course ID you would like to delete");
            ID=Convert.ToInt32(Console.ReadLine());
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("Delete from Course where CourseID=@ID");
                command.Parameters.AddWithValue("@ID", ID);
                command.Connection = con;
                command.ExecuteNonQuery();
                Console.WriteLine("Course deleted Successfully");
                Console.WriteLine("\n");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeleteStudent()
        {
            Console.WriteLine("Enter the Student ID you would like to delete");
            ID = Convert.ToInt32(Console.ReadLine());
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("Delete from StudentInfo where StudentId=@ID");
                command.Parameters.AddWithValue("@ID", ID);
                command.Connection = con;
                command.ExecuteNonQuery();
                Console.WriteLine("Student deleted Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeleteEnrollment()
        {
            Console.WriteLine("Enter the Enrollment ID you would like to delete");
            ID = Convert.ToInt32(Console.ReadLine());
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("Delete from Enrollment where EnrollmentId=@ID");
                command.Parameters.AddWithValue("@ID", ID);
                command.Connection = con;
                command.ExecuteNonQuery();
                Console.WriteLine("Enrollment deleted Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void UpdateStudent(int ID)
        {
            Console.WriteLine("Enter what you would like to update");
            Console.WriteLine("1. Name\n2. DOB 3.Return to menu");
            int op=Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    Console.WriteLine("Enter the Updated name");
                    string newname=Console.ReadLine();
                    try
                    {
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        command = new SqlCommand("Update StudentInfo set StudentName=@name where StudentID=@ID");
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@name", newname);
                        command.Connection = con;
                        command.ExecuteNonQuery();
                        Console.WriteLine("Updated Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the Updated name");
                    DateTime newdate =Convert.ToDateTime( Console.ReadLine());
                    try
                    {
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        command = new SqlCommand("Update StudentInfo set DOB=@DOB where StudentID=@ID");
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@DOB", newdate);
                        command.Connection = con;
                        command.ExecuteNonQuery();
                        Console.WriteLine("Updated Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    showStudentScreen();
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
        }
        public void UpdateCourse()
        {
            Console.WriteLine("Enter the Course Id ");
            ID= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter what you would like to update");
            Console.WriteLine("1. Course Name\n2. Duration\n3. Fees 4. Return to menu");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Enter the Updated Course name");
                    string newname = Console.ReadLine();
                    try
                    {
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        command = new SqlCommand("Update Course set CourseName=@name where CourseID=@ID");
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@name", newname);
                        command.Connection = con;
                        command.ExecuteNonQuery();
                        Console.WriteLine("Updated Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the Updated Duration");
                    int newduration = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        command = new SqlCommand("Update Course set CourseDuration=@Duration where CourseID=@ID");
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Duration", newduration);
                        command.Connection = con;
                        command.ExecuteNonQuery();
                        Console.WriteLine("Updated Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the Updated Fees");
                    int newFees = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        command = new SqlCommand("Update Course set CourseFees=@Fees where CourseID=@ID");
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Fees", newFees);
                        command.Connection = con;
                        command.ExecuteNonQuery();
                        Console.WriteLine("Updated Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    showStudentScreen();
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
        }
        public void MyEnrollments(int ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                command = new SqlCommand("select * from Enrollment where StudentId=@ID");
                command.Parameters.AddWithValue("@ID", ID);
                command.Connection = con;
                dr = command.ExecuteReader();
                Console.WriteLine("EnrollmentID\t\tStudentID\t\tStudentName\t\tCourseID\t\tCourseName");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t" + "\t" + "\t" + dr[1] + "\t" + "\t" + "\t" + dr[2] + "\t" + "\t" + "\t" + dr[3] + "\t" + "\t" + "\t" + dr[4]);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
