using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2.Model
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public static bool AddStudentMdl(string name, string sid, string password)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into Student Values ('{0}','{1}','{2}')", name,sid, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static ArrayList GetAllStudents()
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList students = new ArrayList();
            while (reader.Read())
            {
                Student stud = new Student();
                stud.Name = reader.GetString(reader.GetOrdinal("Name"));
                stud.SId = reader.GetString(reader.GetOrdinal("StudentId"));
                stud.Password = reader.GetString(reader.GetOrdinal("Password"));
                students.Add(stud);

            }
            conn.Close();
            return students;
        }
    }
}
