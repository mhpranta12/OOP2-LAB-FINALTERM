using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    
    public partial class TeacherEnrollment : Form
    {
        int[] n = new int[100];

        public TeacherEnrollment(string c )
        {
            InitializeComponent();
            richTextBox1.Text = c;
            richTextBox2.Text = this.n[0].ToString();

        }
        public TeacherEnrollment()
        {
            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtnClk(object sender, EventArgs e)
        {
            string x = richTextBox1.Text;
            int c = Int32.Parse(x);
            this.n[0]= this.n[0]+ c;

            richTextBox2.Text = this.n[0].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllEnrollment_Load(object sender, EventArgs e)
        {

        }
    }
}
