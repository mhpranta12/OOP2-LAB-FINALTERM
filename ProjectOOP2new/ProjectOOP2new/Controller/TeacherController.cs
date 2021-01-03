using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ProjectOOP2new.Model;
namespace ProjectOOP2new.Controller
{
    class TeacherController
    {
        public static bool AddATeacher (string a, string b, string c , string d)
        {
            bool x = Teachers.AddTeacherMdl(a, b, c, d);
            return x;
        }
        public static ArrayList ShowAllTeachers()
        {
            ArrayList x = new ArrayList();
            x = Teachers.GetAllTeachers();
            return x;
        }
    }
}
