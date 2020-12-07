using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPracticeLab8
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void adduser(object sender, EventArgs e)
        {
            Registration x = new Registration();
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
