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

namespace Assignment_new
{
    public partial class NewForm : Form
    {
        public string j;
        public string TheValue
        {
            get { return j; }
            set { j = value; }
        }

        public NewForm(string x )
        {
            
            InitializeComponent();
            richTextBox1.Text = x;

            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM Book WHERE Name='{0}'", x);
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
            conn.Close();
            dataGridView1.DataSource = books;
           
        }
    }
}
