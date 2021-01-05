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
    public partial class VIewAllOfferedCourse : Form
    {
        public VIewAllOfferedCourse()
        {
            InitializeComponent();
            ArrayList x = new ArrayList();
            x = OfferedCourseController.ShowAllOfferedCourseC();
            dataGridView1.DataSource= x;
        }
    }
}
