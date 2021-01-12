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
    public partial class OfferedCourseForm : Form
    {
        public OfferedCourseForm()
        {
            InitializeComponent();
        }

        private void viewallcrsBtn_Click(object sender, EventArgs e)
        {
            VIewAllOfferedCourse x = new VIewAllOfferedCourse();
            x.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addofrdcourseclk(object sender, EventArgs e)
        {
            string sname = name.Text;
            string scode = code.Text;
            string stype = type.Text;
            string scapacity = capacity.Text;
            string scount = count.Text;

            bool x = OfferedCourseController.AddOfferedCourse(sname, scode, stype, scapacity, scount);
            if (x)
            {
                MessageBox.Show("Course Added !");
            }
            else
                MessageBox.Show("Course Not Added");
        }
    }
}
