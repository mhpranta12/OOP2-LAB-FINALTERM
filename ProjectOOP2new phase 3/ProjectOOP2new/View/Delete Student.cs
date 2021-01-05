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
    public partial class Delete_Student : Form
    {
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void dltstndBtnClk(object sender, EventArgs e)
        {

            string name = snametextBox.Text;

            bool x = StudentController.DeleteStudent(name);
            if (x)
            {
                MessageBox.Show("Student Deleted !");
            }
            else
                MessageBox.Show("Student Not Deleted");
        }
    }
}
