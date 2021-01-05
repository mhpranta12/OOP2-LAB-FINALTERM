using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2new.Model;
using System.Collections;


namespace ProjectOOP2new.Controller
{
    class StudentController
    {

        public static bool AddStudent(string x, string y, string z)
        {

            bool a = Students.AddStudentMdl(x, y, z);
            return a;
        }
        public static ArrayList ShowAllStudentC()
        {
            ArrayList x = new ArrayList();
            x = Students.GetAllStudents();
            return x;

        }
        public static bool DeleteStudent(string x)
        {
            bool a = Students.RemoveStudent(x);
            return a;
        }
        public static ArrayList SearchStudent(string h)
        {
            ArrayList x = new ArrayList();
            x = Students.FindStudent(h);
            return x;

        }
        public static bool UpdateStudentC(Student stu)
        {
            bool a = Students.UpgradeStudent(stu);
            return a;
        }
    }
}
