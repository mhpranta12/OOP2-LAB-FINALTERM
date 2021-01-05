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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
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
            string name = trsnametextBox.Text;
            string uname = utrsnametextBox.Text;
            string udesig = desigcomboBox.Text;
            bool flag= false;
            if (uname.Equals(""))
            {

            }
            else
            {
                bool m = TeacherController.UpdateTeacherName(name, uname);
                if (m)
                {
                    flag = true;
                }
                else
                    flag = false;

            }
            if (udesig.Equals(""))
            {

            }
            else
            {
               
                bool v = TeacherController.UpdateTeacherDesig(name, udesig);
                if (v)
                {
                    flag = true;
                }
                else
                    flag = false;
            }
            if (flag)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
                flag = false;
        }
    }
}
