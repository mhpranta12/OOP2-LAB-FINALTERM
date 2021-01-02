using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_new
{
    public class Books
    {

        public int id;

        public int MyId
        {
            get { return id; }
            set { id = value; }
        }
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string edition;

        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }
    }
}
