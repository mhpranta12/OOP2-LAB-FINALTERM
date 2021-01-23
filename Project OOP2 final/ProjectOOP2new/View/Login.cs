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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void adminloginBtnClk(object sender, EventArgs e)
        {
            AdminLogin x = new AdminLogin();
            x.ShowDialog();
        }

        private void stdnloginBtnClk(object sender, EventArgs e)
        {
            StudentLogin x = new StudentLogin();
            x.ShowDialog();
        }

        private void trsloginBtnClk(object sender, EventArgs e)
        {
            TeacherLogin x = new TeacherLogin();
            x.ShowDialog();
        }
    }
}
