using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP2new.View
{
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void utrsdesigBtnClk(object sender, EventArgs e)
        {
            UpdateTeacherDesig x = new UpdateTeacherDesig();
            x.ShowDialog();
        }

        private void utrsnameBtnClk(object sender, EventArgs e)
        {
            UpdateTeacherName x = new UpdateTeacherName();
            x.ShowDialog();
        }
    }
}
