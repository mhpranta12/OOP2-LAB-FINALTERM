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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
