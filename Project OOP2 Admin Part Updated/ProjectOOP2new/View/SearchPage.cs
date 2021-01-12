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
    public partial class SearchPage : Form
    {
        ArrayList b = new ArrayList();
        public SearchPage(ArrayList a)
        {
            InitializeComponent();
            this.b = a;
            dataGridViewSearch.DataSource = b;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
