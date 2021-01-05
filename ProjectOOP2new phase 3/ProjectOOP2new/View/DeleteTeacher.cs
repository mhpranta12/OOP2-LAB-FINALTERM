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
    public partial class Delete_Teacher : Form
    {
        public Delete_Teacher()
        {
            InitializeComponent();
        }

        private void dlttrsBtnClk(object sender, EventArgs e)
        {
            string name = trsnametextBox.Text;
            
            bool x = TeacherController.DeleteATeacher(name);
            if (x)
            {
                MessageBox.Show("Teacher Deleted !");
            }
            else
                MessageBox.Show("Teacher Not Deleted");
        }
    }
}
