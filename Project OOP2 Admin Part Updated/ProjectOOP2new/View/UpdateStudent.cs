using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP2new.Model;
using ProjectOOP2new.Controller;


namespace ProjectOOP2new.View
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidtextBox_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void upstuBtnClk(object sender, EventArgs e)
        {
            string sid = sidtextBox.Text;
            string uname = unametextBox.Text;
            string usid = sidtextBox.Text;

            Model.Student stu = new Model.Student();
            stu.SId = sid;
            stu.Name = uname;

            bool x = StudentController.UpdateStudentC(stu);
            if (x)
            {
                MessageBox.Show("Student Updated !");
            }
            else
                MessageBox.Show("Student Not Updated");



        }

        private void usidtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
