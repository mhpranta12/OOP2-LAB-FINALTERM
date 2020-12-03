using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task_Dept.Faculty_
{
    class Faculty
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Faculty(string name , string id)
        {
            Name = name;
            Id = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Teacher's Name  :" + Name);
            Console.WriteLine("Teacher's ID  :" + Id);

        }
    }
}
