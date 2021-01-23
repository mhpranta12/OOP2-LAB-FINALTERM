using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP2new.View
{
    public partial class StudentEnrollment : Form
    {
        int[] n = new int[100];

        public StudentEnrollment(string c)
        {
            InitializeComponent();
            richTextBox1.Text = c;
            richTextBox2.Text = this.n[0].ToString();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addclk(object sender, EventArgs e)
        {
            string x = richTextBox1.Text;
            int c = Int32.Parse(x);
            this.n[0] = this.n[0] + c;

            richTextBox2.Text = this.n[0].ToString();
        }
    }
}
