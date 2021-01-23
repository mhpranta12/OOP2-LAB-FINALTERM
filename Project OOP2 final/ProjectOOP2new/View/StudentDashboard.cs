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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard(string c)
        {
            InitializeComponent();
            unametextBox.Text = c;
            unametextBox.Show();
            uname.Visible = true;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void noticeBtnClk(object sender, EventArgs e)
        {
            ArrayList v = new ArrayList();
            v = NoticeController.ShowAllNotices();

            ViewAllNoticeStudent c = new ViewAllNoticeStudent(v);
            c.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void offeredcourseBtnClk(object sender, EventArgs e)
        {
            ArrayList d = new ArrayList();

            d= OfferedCourseController.ShowAllOfferedCourseC();
            ViewAllOfferedCourse n = new ViewAllOfferedCourse();
            n.ShowDialog();
        }

        private void canvaspaint(object sender, PaintEventArgs e)
        {
            Graphics gobj = CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen bpen = new Pen(b, 7);
            gobj.FillRectangle(b, 50, 60, 800, 5);
        }
    }
}
