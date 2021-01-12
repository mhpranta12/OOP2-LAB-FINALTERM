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
    public partial class UpdateTeacherName : Form
    {
        public UpdateTeacherName()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void utrsBtnClk(object sender, EventArgs e)
        {
            string name = richTextBox1.Text;
            string uname = richTextBox2.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("Please Enter Name ");
            }
            else if (uname.Equals(""))
            {
                MessageBox.Show("Please Enter Updated Name to Update ");
            }
            else
            {
                bool m = TeacherController.UpdateTeacherName(name, uname);
                if (m)
                {
                    MessageBox.Show("Name Updated !");
                }
                else
                {

                }
            }
            
            
        }
    }
}
