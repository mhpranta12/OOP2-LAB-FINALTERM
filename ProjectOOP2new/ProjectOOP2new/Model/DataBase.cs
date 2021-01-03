using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectOOP2new.Model
{
    class DataBase
    {
        public static SqlConnection ConnectDB()
        {
            string connstring = @"Server=DESKTOP-1AATEUK\SQLEXPRESS; Integrated Security = true; Database =Project2";
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }
    }
}
