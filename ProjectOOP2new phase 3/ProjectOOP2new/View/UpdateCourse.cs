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
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void ucrsBtnClk(object sender, EventArgs e)
        {
            string code = crscdtextBox.Text;
            string uname = ucrsnametextBox.Text;
            string ucrstrs = ucrstrstextBox.Text;
            bool flag = false;
            if (uname.Equals("") && ucrstrs.Equals(""))
            {
                MessageBox.Show("Please Enter Someting to update");
            }
            else if (uname.Equals(""))
            {
                
                
                bool m = CourseController.UpdateCourseTeacher(ucrstrs, code);
                flag = true;
            }
            else if (ucrstrs.Equals(""))
            {
                bool n = CourseController.UpdateCourseName(uname, code);
                flag = true;
            }
            
            
            if (flag)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
                flag = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
