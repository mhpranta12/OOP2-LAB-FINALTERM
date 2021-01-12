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
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    public partial class ViewAllStudents : Form
    {
        public ViewAllStudents()
        {
            InitializeComponent();
            ArrayList x = new ArrayList();
            x = StudentController.ShowAllStudentC();
            dataGridViewstudents.DataSource = x;
        }

        private void ShowAllStudent_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
