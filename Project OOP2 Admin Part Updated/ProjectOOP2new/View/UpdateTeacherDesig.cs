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
    public partial class UpdateTeacherDesig : Form
    {
        public UpdateTeacherDesig()
        {
            InitializeComponent();
        }

        private void utradesigBtnClk(object sender, EventArgs e)
        {
            string udesig = desigcomboBox.Text;
            string name = trsnametextBox.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("Please Enter Name ");

            }
            else if (udesig.Equals(""))
            {
                MessageBox.Show("Please Enter Designation To Update ");

            }
            else
            {
                bool v = TeacherController.UpdateTeacherDesig(name, udesig);
                if (v)
                {
                    MessageBox.Show("Teacher's Designation Updated !");
                }
                else
                {

                }
            }
        }
    }
}
