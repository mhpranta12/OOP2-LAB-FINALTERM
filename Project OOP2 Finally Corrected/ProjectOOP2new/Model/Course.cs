using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP2new.Model
{
    class Course
    {
         private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string coursename;

        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; }
        }
        private string coursecode;

        public string CourseCode
        {
            get { return coursecode; }
            set { coursecode = value; }
        }
        private string courseteacher;

        public string CourseTeacher
        {
            get { return courseteacher; }
            set { courseteacher = value; }
        }


    }
}
