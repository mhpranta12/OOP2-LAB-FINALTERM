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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void addteacherBtnClk(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string password = passwordtextBox.Text;
            string designation = desigtextBox.Text;
            string age = agetextBox.Text;

            bool x = TeacherController.AddATeacher(name, password, designation, age);
            if (x)
            {
                MessageBox.Show("Added");
            }
            else
                MessageBox.Show("Not Added");
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
