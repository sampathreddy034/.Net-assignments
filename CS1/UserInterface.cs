using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    interface UserInterface
    {
		void showFirstScreen();
		void showStudentScreen();
		 void ShowAdminScreen();
		 void showAllStudentsScreen();
		 void showStudentRegistrationScreen();
		 void introduceNewCourseScreen();
		 void showAllCoursesScreen();
		void ShowEnrollingScreen(int id);
		void showAllEnrollmentsScreen();
		void UpdateCourse();
		void MyEnrollments(int ID);
		void UpdateStudent(int ID);
		void DeleteEnrollment();
		void DeleteStudent();
		void DeleteCourse();


	}
}
