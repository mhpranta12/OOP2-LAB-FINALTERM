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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void loginBtnClk(object sender, EventArgs e)
        {
            string id = richTextBox1.Text;
            string pwd = richtextBox2.Text;
            



            var x = StudentController.AuthenticateStudent(id, pwd);
            if (x!=null)
            {
                string name = StudentController.FindAuthenticatedStudent(id, pwd);
                StudentDashboard m = new StudentDashboard(name);
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("✘ UserName / Password Error");

            }
        }
    }
}
