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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addteacherBtn(object sender, EventArgs e)
        {
            string name = crsnametextBox.Text;
            string code = crscodetextBox.Text;
            string teacher = crsteachertextBox.Text;
            bool x = CourseController.AddCourse(name, code, teacher);
            if (x)
            {
                MessageBox.Show("Course Added !");
            }
            else
                MessageBox.Show("Course Not Added");
        }

        private void crsnametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
