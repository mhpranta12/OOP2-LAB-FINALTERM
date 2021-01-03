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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void viewAllTeacherBtnClk(object sender, EventArgs e)
        {
            ViewAllTeachers x = new ViewAllTeachers();
            x.ShowDialog();
        }

        private void addnewteacherbtnClk(object sender, EventArgs e)
        {
            AddTeacherDesign x = new AddTeacherDesign();
            x.ShowDialog();
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
