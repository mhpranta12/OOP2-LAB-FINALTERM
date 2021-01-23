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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void viewallteachersBtnClk(object sender, EventArgs e)
        {
            ViewAllTeachers x = new ViewAllTeachers();
            x.ShowDialog();
        }

        private void addteacherBtnClk(object sender, EventArgs e)
        {
            AddTeacher x = new AddTeacher();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete_Teacher x = new Delete_Teacher();
            x.ShowDialog();
        }

        private void updateteacherBtnClk(object sender, EventArgs e)
        {
            UpdateTeacher c = new UpdateTeacher();
            c.ShowDialog();
        }

        private void enrldtrsBtnClk(object sender, EventArgs e)
        {
            TeacherEnrollment x = new TeacherEnrollment();
            x.ShowDialog();
         }

        private void canvas_paint(object sender, PaintEventArgs e)
        {
            Graphics gobj = CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen bpen = new Pen(b, 7);
            gobj.FillRectangle(b, 60, 115, 800, 5);
        }
    }
}
