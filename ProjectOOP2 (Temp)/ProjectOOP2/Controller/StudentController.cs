using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2.Model;
using System.Collections;

namespace ProjectOOP2.Controller
{
    class StudentController
    {

        public static bool AddAStudent(string x, string y, string z)
        {

            bool a = Students.AddStudentMdl(x, y, z);
            return a;
        }
        public static ArrayList ShowAllStudent()
        {
            ArrayList x = new ArrayList();
            x = Students.GetAllStudents();
            return x;
            
        }
    }
}
