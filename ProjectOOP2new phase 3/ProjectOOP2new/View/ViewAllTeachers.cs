using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    public partial class ViewAllTeachers : Form
    {
        public ViewAllTeachers()
        {
            InitializeComponent();
            ArrayList x = new ArrayList();
            x = TeacherController.ShowAllTeachers();
            dataGridView2.DataSource = x;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
