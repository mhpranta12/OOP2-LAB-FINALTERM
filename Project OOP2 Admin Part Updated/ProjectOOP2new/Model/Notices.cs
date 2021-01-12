using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2new.Model
{
    class Notices
    {
        public static bool AddNoticeMdl(string notice, string date , string subject)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into Notice Values ('{0}','{1}','{2}')", notice, date, subject);
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

        public static ArrayList GetAllNotices()
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from Notice";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList courses = new ArrayList();
            while (reader.Read())
            {
                Notice cou = new Notice();
                cou.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                cou.Notices = reader.GetString(reader.GetOrdinal("Notice"));
                cou.Date = reader.GetString(reader.GetOrdinal("Date"));
                cou.NtcSubject = reader.GetString(reader.GetOrdinal("NoticeSubject"));
                courses.Add(cou);

            }
            conn.Close();
            return courses;
        }
    }
}