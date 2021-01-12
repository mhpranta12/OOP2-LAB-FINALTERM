using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2new.Controller;
using System.Windows.Forms;

namespace ProjectOOP2new.View
{
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }

        private void dltcrsBtnClk(object sender, EventArgs e)
        {
            string cid =cidtextBox.Text;

            bool x = CourseController.DeleteCourse(cid);
            if (x)
            {
                MessageBox.Show("Course Deleted !");
            }
            else
                MessageBox.Show("Course Not Deleted");
        }
    }
}
