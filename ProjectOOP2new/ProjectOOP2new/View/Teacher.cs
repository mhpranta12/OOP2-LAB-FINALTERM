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

    }
}
