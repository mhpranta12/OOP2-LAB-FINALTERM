using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2.Model;
using System.Collections;

namespace ProjectOOP2.Controller
{
    class TeacherController
    {
        public static bool AddATeacher(string x , string y, string z)
        {
            
            bool a = Teacherss.AddTeacherMdl(x, y, z);
            return a;
        }
        public static void ShowAllTeacher()
        {
            
        }
    }
}
