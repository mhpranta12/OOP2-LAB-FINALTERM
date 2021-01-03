using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2new.Model
{
    class Teachers
    {
        public static bool AddTeacherMdl(string name, string password, string desig , string age )
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into Teacher Values ('{0}','{1}','{2}','{3}')", name, password, desig ,age);
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
        public static ArrayList GetAllTeachers()
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from Teacher";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList teachers = new ArrayList();
            while (reader.Read())
            {
                Teacher tech = new Teacher();
                tech.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                tech.Name = reader.GetString(reader.GetOrdinal("Name"));
                tech.Password = reader.GetString(reader.GetOrdinal("Password"));
                tech.Desig = reader.GetString(reader.GetOrdinal("Designation"));
                tech.Age = reader.GetString(reader.GetOrdinal("Age"));
                teachers.Add(tech);

            }
            conn.Close();
            return teachers;
        }
    }
}
