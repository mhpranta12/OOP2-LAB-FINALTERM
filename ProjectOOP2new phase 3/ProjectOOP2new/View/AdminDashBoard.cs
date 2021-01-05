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
using System.Collections;

namespace ProjectOOP2new.View
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            Teacher s = new Teacher();
            s.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            x.ShowDialog();
        }

        private void stnBtnCLk(object sender, EventArgs e)
        {
            Student x = new Student();
            x.ShowDialog();
        }

        private void coursesBtnClk(object sender, EventArgs e)
        {
            Course x = new Course();
            x.ShowDialog();
        }

        private void searchBtn(object sender, EventArgs e)
        {
        }

        private void searchBtnClk(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void serchBtnClk(object sender, EventArgs e)
        {
            string b = serchtextBox.Text;
            ArrayList f = new ArrayList();

            if (searchoptioncombobox.Text.Equals("Student"))
            {
                f = StudentController.SearchStudent(b);
                new SearchPage(f).Show();
            }
           else if (searchoptioncombobox.Text.Equals("Teacher"))

            {
                f = TeacherController.SearchTeacher(b);
                new SearchPage(f).Show();
            }

            else if (searchoptioncombobox.Text.Equals("Course"))

            {
                f = CourseController.SearchCourse(b);
                new SearchPage(f).Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void noticeBtnClk(object sender, EventArgs e)
        {
            Notice x = new Notice();
            x.ShowDialog();
        }

        private void finalcialsBtnClk(object sender, EventArgs e)
        {
            Financials x = new Financials();
            x.ShowDialog();
        }

        private void showenrlclk(object sender, EventArgs e)
        {
            TeacherEnrollment x = new TeacherEnrollment();
        }
    }
}
