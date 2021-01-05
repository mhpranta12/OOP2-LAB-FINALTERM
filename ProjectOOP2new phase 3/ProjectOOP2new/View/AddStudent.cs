using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    public partial class AddStudent : Form
    {
        int tc = 0;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addstdnBtn_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string sid = sidtextBox.Text;
            string password = pwdtextBox.Text;
            bool x = StudentController.AddStudent(name, sid, password);
            if (x)
            {
                MessageBox.Show("Added");
                this.tc = this.tc + 1;
                string stc = this.tc.ToString();
                countTextBox.Text = stc;
            }
            else
                MessageBox.Show("Not Added");
        }

        private void baddenrlclk(object sender, EventArgs e)
        {
            string h = countTextBox.Text;
            new StudentEnrollment(h).Show();
        }
    }
}
