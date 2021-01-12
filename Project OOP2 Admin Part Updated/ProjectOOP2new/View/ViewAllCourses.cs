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
    public partial class ViewAllCourses : Form
    {
        public ViewAllCourses()
        {
            InitializeComponent();
            ArrayList x = new ArrayList();
            x = CourseController.ShowAllCourseC();
            dataGridViewcourses.DataSource = x;
        }
    }
}
