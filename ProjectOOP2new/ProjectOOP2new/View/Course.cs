﻿using System;
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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addcoursesBtnClk(object sender, EventArgs e)
        {
            AddCourse x = new AddCourse();
            x.ShowDialog();
        }

        private void viewallcrsBtnCLk(object sender, EventArgs e)
        {
            ViewAllCourses x = new ViewAllCourses();
            x.ShowDialog();
        }
    }
}
