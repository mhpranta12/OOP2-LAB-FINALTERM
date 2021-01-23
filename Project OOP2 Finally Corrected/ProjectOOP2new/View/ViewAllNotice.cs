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

namespace ProjectOOP2new.View
{
    public partial class ViewAllNotice : Form
    {
        ArrayList y = new ArrayList();
        public ViewAllNotice(ArrayList x)
        {
            InitializeComponent();
            this.y = x;
            dataGridView.DataSource = y;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void canvaspaint(object sender, PaintEventArgs e)
        {
            Graphics gobj = CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Pen bpen = new Pen(b, 7);
            gobj.FillRectangle(b, 280, 63, 800, 5);
        }
    }
}
