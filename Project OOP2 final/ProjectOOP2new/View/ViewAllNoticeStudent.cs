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
    public partial class ViewAllNoticeStudent : Form
    {
        public ViewAllNoticeStudent(ArrayList x )
        {
            InitializeComponent();
            dataGridView.DataSource = x;
        }
    }
}
