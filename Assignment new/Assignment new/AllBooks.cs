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
    public partial class AllBooks : Form
    {
        public string c;
        public AllBooks()
        {
            
            InitializeComponent();
            var con = Database.ConnectDB();
            con.Open();
            string query = "SELECT * FROM Book";
            SqlCommand cmd = new SqlCommand(query, con);
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

        private void clickbtn(object sender, EventArgs e)
        {




        }

        public string GetAut(string x)
        {
            return x;

        }
        private void searchButtonClick(object sender, EventArgs e)
        {


            dynamic x = SearchBook(textBox1.Text.ToString());
            if (x.Equals(null))
            {
                MessageBox.Show("Not Found ");

            }
            else
            {
                namel.Show();
                authorl.Show();
                editionl.Show();
                rT1.Show();
                rT2.Show();
                rT3.Show();
                this.c = x.name;
                rT1.Text = x.name;
                rT2.Text = x.author;
                rT3.Text = x.edition;


            }
        }


        public Books SearchBook(string temp)
        {

            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM Book WHERE Name='{0}'", temp);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Books b = new Books();
            while (reader.Read())
            {

                b.id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.name = reader.GetString(reader.GetOrdinal("Name"));
                b.author = reader.GetString(reader.GetOrdinal("Author"));
                b.edition = reader.GetString(reader.GetOrdinal("Edition"));

            }
            conn.Close();
            found.Show();
            return b;

        }

        private void showDetails(object sender, EventArgs e)
        {
            new NewForm(c).Show();
        }
    }
}
