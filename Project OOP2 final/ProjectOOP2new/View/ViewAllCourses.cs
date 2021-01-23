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
using System.IO;


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
        

        private void canvaspaint(object sender, PaintEventArgs e)
        {
            Graphics gobj = CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen bpen = new Pen(b, 7);
            gobj.FillRectangle(b, 100, 123, 800, 5);
        }
    }
}
