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
    public partial class Delete_Student : Form
    {
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void dltstndBtnClk(object sender, EventArgs e)
        {

            string sid = richTextBox1.Text;

            bool x = StudentController.DeleteStudent(sid);
            if (x)
            {
                MessageBox.Show("Student Deleted !");
            }
            else
                MessageBox.Show("Student Not Deleted");
        }

        private void paint(object sender, PaintEventArgs e)
        {
            Graphics gobj = CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen bpen = new Pen(b, 7);
            gobj.FillRectangle(b, 40, 65, 800, 5);
        }
    }
}
