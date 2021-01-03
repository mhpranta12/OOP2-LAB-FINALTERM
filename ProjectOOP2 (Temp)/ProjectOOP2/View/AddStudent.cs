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

namespace ProjectOOP2.View
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void addstudentBtnClk(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string id = idtextBox.Text;
            string password = passwordTextBox.Text;
            
            if (name.Equals(""))
            {
                MessageBox.Show("Please Enter Name");

            }
            else if (id.Equals(""))
            {
                MessageBox.Show("Please Select ID");

            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please Enter Password");

            }
            else
            {
                bool a = StudentController.AddAStudent(name, id, password);
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
