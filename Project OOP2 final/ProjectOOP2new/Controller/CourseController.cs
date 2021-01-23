using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2new.Model;
using System.Collections;


namespace ProjectOOP2new.Controller
{
    class CourseController
    {
        public static bool AddCourse(string x, string y, string z)
        {

            bool a = Courses.AddCourseMdl(x, y, z);
            return a;
        }
        public static ArrayList ShowAllCourseC()
        {
            ArrayList x = new ArrayList();
            x = Courses.GetAllCourses();
            return x;

        }
        public static bool DeleteCourse (string x)
        {
          
            bool a = Courses.RemoveCourse(x);
            return a;

        }
        public static ArrayList SearchCourse(string h)
        {
            ArrayList x = new ArrayList();
            x = Courses.FindCourse(h);
            return x;

        }
        public static bool UpdateCourseName(string x, string y)
        {
            bool a =Courses.UpgradeCourseName(x, y);
            return a;
        }
        public static bool UpdateCourseTeacher(string x, string y)
        {
            bool a = Courses.UpgradeCourseTeacher(x, y);
            return a;
        }
    }
}
