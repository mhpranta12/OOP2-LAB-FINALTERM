using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2new.Model
{
    class OfferedCourses
    {
        public static bool AddOfrCourseMdl(string name, string code, string type , string capacity , string count)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into OfferCourse Values ('{0}','{1}','{2}','{3}','{4}')", name, code, type, capacity, count);
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
        public static ArrayList GetAllCourses()
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from OfferCourse";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList courses = new ArrayList();
            while (reader.Read())
            {
                OfferedCourse cou = new OfferedCourse();
                cou.ID = reader.GetInt32(reader.GetOrdinal("Id"));
                cou.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                cou.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                cou.CourseType = reader.GetString(reader.GetOrdinal("CourseType"));
                cou.Capacity = reader.GetString(reader.GetOrdinal("Capaticy"));
                cou.Count = reader.GetString(reader.GetOrdinal("Count"));

                courses.Add(cou);

            }
            conn.Close();
            return courses;
        }
    }
}
