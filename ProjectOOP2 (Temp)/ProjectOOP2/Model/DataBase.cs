using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectOOP2.Model
{
    public  class DataBase
    {
        
        public Students Students { get; set; }
        public Courses Courses { get; set; }
        public DataBase ()
        {
            

        }
        public static SqlConnection ConnectDB()
        {
            string connstring = @"Server=DESKTOP-1AATEUK\SQLEXPRESS; Integrated Security = true; Database =project";
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }
    }
}
