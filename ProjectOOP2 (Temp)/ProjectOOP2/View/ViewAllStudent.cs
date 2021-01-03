using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ProjectOOP2.Controller;

namespace ProjectOOP2.View
{
    public partial class ViewAllStudent : Form
    {
        public ViewAllStudent()
        {
            InitializeComponent();
        }

        private void viewBtnClk(object sender, EventArgs e)
        {
            ArrayList x = new ArrayList();
            x = StudentController.ShowAllStudent();
            dataGridViewStudentList.DataSource = x;
        }
    }
}
