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
        public static bool DeleteATeacher(string x)
        {
            bool y = Teachers.RemoveTeacher(x);
            return y;
        }
        public static ArrayList SearchTeacher(string h)
        {
            ArrayList x = new ArrayList();
            x = Teachers.FindTeacher(h);
            return x;

        }
        public static bool UpdateTeacherName(string x , string y)
        {
            bool a = Teachers.UpgradeTeacherName(x,y);
            return a;
        }
        public static bool UpdateTeacherDesig(string x, string y)
        {
            bool a = Teachers.UpgradeTeacherDesig(x, y);
            return a;
        }
       
    }
}
