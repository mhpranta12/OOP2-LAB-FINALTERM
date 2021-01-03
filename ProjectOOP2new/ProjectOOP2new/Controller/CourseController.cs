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
    }
}
