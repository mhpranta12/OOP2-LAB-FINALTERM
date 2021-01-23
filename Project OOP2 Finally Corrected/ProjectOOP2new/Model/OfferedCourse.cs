using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP2new.Model
{
    class OfferedCourse
    {
        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
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
        private string coursetype;

        public string CourseType
        {
            get { return coursetype; }
            set { coursetype = value; }
        }
        private string capacity;

        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private string count;

        public string Count
        {
            get { return count; }
            set { count = value; }
        }

    }
}
