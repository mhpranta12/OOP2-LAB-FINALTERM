using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP2.Model
{
    class Course
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string  coursename;

        public string  CourseName
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
        private string teacher;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }



    }
}
