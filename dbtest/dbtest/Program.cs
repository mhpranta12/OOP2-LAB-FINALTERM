using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstring = @"Server =DESKTOP-1AATEUK\SQLEXPRESS; Integrated Security=true;Database =aiub_ums";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id :\t Course Name :\t Course Code");
            while(reader.Read())
            {
                int name = reader.GetInt32(0);
                string cid = reader.GetString(1);
                string ccd = reader.GetString(2);

                Console.WriteLine("{0} \t {1} \t {2} ",name,cid,ccd);
            }
        }
    }
}
