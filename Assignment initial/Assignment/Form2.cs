using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string temp = searchBox.Text;
            if(temp.Equals("a"))
            { }
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from Book";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList books = new ArrayList();
            while (reader.Read())
            {
                Books b = new Books();
                b.id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.name = reader.GetString(reader.GetOrdinal("Name"));
                b.author = reader.GetString(reader.GetOrdinal("Author"));
                b.edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(b);
            }
            dataGridView1.DataSource = books;

            string constring = @"Server =DESKTOP-1AATEUK\SQLEXPRESS; Integrated Security=true;Database =aiub_ums";
            SqlConnection con = new SqlConnection(constring);
            conn.Open();
            string q = "SELECT * FROM Book";
            SqlCommand cm = new SqlCommand(q, con);
            SqlDataReader read = cm.ExecuteReader();
            Console.WriteLine("Id :\t Course Name :\t Course Code");
            while (reader.Read())
            {
                int id = read.GetInt32(0);
                string name = read.GetString(1);
                string author = read.GetString(2);
                string edition = read.GetString(3);
                if (temp.Equals(name))
                {
                    found.Show();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = searchBox.Text;
            if (temp.Equals(2))
            {
                found.Show();
            }
            string constring = @"Server =DESKTOP-1AATEUK\SQLEXPRESS; Integrated Security=true;Database =aiub_ums";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM Book";
            SqlCommand cm = new SqlCommand(q, con);
            SqlDataReader read = cm.ExecuteReader();
            Console.WriteLine("Id :\t Course Name :\t Course Code");
            while (read.Read())
            {
                int id = read.GetInt32(0);
                string name = read.GetString(1);
                string author = read.GetString(2);
                string edition = read.GetString(3);
                if (temp.Equals("{1},name"))
                {
                    found.Show();
                }

            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
