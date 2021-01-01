using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            dataGridView.DataSource = books;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
