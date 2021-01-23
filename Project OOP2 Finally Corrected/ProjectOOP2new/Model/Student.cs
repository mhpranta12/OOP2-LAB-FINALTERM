using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP2new.Model
{
    class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sid;

        public string SId
        {
            get { return sid; }
            set { sid = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
