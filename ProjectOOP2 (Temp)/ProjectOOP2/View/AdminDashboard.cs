using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP2.View
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void recomndBtn_Click(object sender, EventArgs e)
        {
            RecommandCertificate x = new RecommandCertificate();
            x.ShowDialog();
        }

        private void assnBtnClk(object sender, EventArgs e)
        {
            Student x = new Student();
            x.ShowDialog();
        }

        private void lgoutBtnClk(object sender, EventArgs e)
        {
            LoginForm x = new LoginForm();
            x.ShowDialog();
        }

        private void stnBtnClk(object sender, EventArgs e)
        {
            Student x = new Student();
            x.ShowDialog();
        }

        private void courseBtnClk(object sender, EventArgs e)
        {
            Course x = new Course();
            x.ShowDialog();
        }

        private void teacherBtnClk(object sender, EventArgs e)
        {
            Teacher x = new Teacher();
            x.ShowDialog();
        }
    }
}
