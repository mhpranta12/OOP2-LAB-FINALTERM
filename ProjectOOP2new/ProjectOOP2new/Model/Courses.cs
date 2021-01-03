﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2new.Model
{
    class Courses
    {
        public static bool AddCourseMdl(string name, string code, string teacher)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into Course Values ('{0}','{1}','{2}')", name, code , teacher);
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
            string query = "Select * from Course";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList courses = new ArrayList();
            while (reader.Read())
            {
                Course cou = new Course();
                cou.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                cou.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                cou.CourseCode= reader.GetString(reader.GetOrdinal("CourseCode"));
                cou.CourseTeacher = reader.GetString(reader.GetOrdinal("CourseTeacher"));
                courses.Add(cou);

            }
            conn.Close();
            return courses;
        }
    }
}
