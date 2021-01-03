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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addstndBtnClk(object sender, EventArgs e)
        {
            AddStudent c = new AddStudent();
            c.ShowDialog();
        }

        private void viewallstndBtnCLk(object sender, EventArgs e)
        {
            ViewAllStudents x = new ViewAllStudents();
            x.ShowDialog();
        }
    }
}
