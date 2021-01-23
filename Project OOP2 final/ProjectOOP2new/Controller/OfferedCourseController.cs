using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ProjectOOP2new.Model;

namespace ProjectOOP2new.Controller
{
    class OfferedCourseController
    {
        public static bool AddOfferedCourse(string x, string y, string z , string n , string b )
        {

            bool a = OfferedCourses.AddOfrCourseMdl(x, y, z, n,b);
            return a;
        }
        public static ArrayList ShowAllOfferedCourseC()
        {
            ArrayList x = new ArrayList();
            x = OfferedCourses.GetAllCourses();
            return x;

        }
    }
}
