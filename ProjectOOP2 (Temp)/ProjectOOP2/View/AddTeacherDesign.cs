using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP2.Controller;
using System.Data.SqlClient;


namespace ProjectOOP2.View
{
    public partial class AddTeacherDesign : Form
    {
        public AddTeacherDesign()
        {
            InitializeComponent();
        }

        private void Lecturer(object sender, EventArgs e)
        {
           
        }

        private void addteacherBtn(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;  
            string desig = desigComboBox.Text;
            string age = ageTextBox.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("Please Enter Name");

            }
           
            else if (age.Equals(""))
            {
                MessageBox.Show("Please Enter Age");

            }
            else
            {
                bool a = TeacherController.AddATeacher(name, password , age );
                if (a)
                {
                    MessageBox.Show("Added");
                }
                else
                    MessageBox.Show("Not Added");
            }
        }
    }
}
