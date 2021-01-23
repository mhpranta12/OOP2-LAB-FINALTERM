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
    public partial class TeacherLogin : Form
    {
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void trsloginBtnClk(object sender, EventArgs e)
        {
            string id = richTextBox1.Text;
            string pwd = richtextBox2.Text;




            var x = TeacherController.AuthenticateTeacher(id, pwd);
            if (x != null)
            {
                TeacherDashboard m = new TeacherDashboard();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("✘ UserName / Password Error");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
